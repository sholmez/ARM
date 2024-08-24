using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace kurs
{
    static class Utils
    {
        static public string ConnectionString = null;

        static public void Connect(string ConnectionString)
        {
            SqlConnection connection = null;
            Utils.ConnectionString = ConnectionString;
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect connection string", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        static public object GetFieldValueFromSql(string selectQuery, string fieldName)
        {
            object fieldValue = null;

            try
            {
                using SqlConnection connection = new SqlConnection(ConnectionString);
                using SqlCommand command = new SqlCommand(selectQuery, connection);

                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    fieldValue = reader[fieldName];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return fieldValue;
        }

        static public void ExportToExcel(DataGridView dataGridView)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Створення нового пакету Excel
            ExcelPackage excelPackage = new ExcelPackage();

            // Створення нового листа
            ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets.Add("Worksheet1");

            // Запис даних з DataGridView в Excel
            for (int i = 1; i <= dataGridView.Columns.Count; i++)
            {
                excelWorksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
            }

            for (int i = 1; i <= dataGridView.Rows.Count; i++)
            {
                for (int j = 1; j <= dataGridView.Columns.Count; j++)
                {
                    object value = dataGridView.Rows[i - 1].Cells[j - 1].Value;
                    if (value != null)
                    {
                        excelWorksheet.Cells[i + 1, j].Value = value.ToString();
                    }
                }
            }

            // Форматування стилю для заголовків стовпців
            using (ExcelRange range = excelWorksheet.Cells[1, 1, 1, dataGridView.Columns.Count])
            {
                range.Style.Font.Bold = true;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            }

            // Авто ширина стовпців
            excelWorksheet.Cells.AutoFitColumns();

            // Збереження Excel-файлу
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                excelPackage.SaveAs(excelFile);
                MessageBox.Show("Дані успішно збережені у файлі Excel.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static public int GetIdFromTable(string tableName, string idField, Dictionary<string, string> fieldsAndValues)
        {
            string selectQuery = $"SELECT {idField} FROM {tableName} WHERE ";
            foreach (var field in fieldsAndValues)
            {
                selectQuery += $"{field.Key} = '{field.Value}' AND ";
            }
            selectQuery = selectQuery.Remove(selectQuery.Length - 5); // видаляємо " AND " з кінця запиту
            using SqlConnection sqlCon = new SqlConnection(ConnectionString);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(selectQuery, sqlCon);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            sqlCon.Close();
            return id;
        }

        static public void FillComboBoxFromSql(ComboBox comboBox, string selectQuery, string displayMember, string valueMember, string promptText = "")
        {
            try
            {
                // Виконуємо запит на отримання даних з бази даних
                using SqlConnection connection = new SqlConnection(ConnectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                connection.Close();

                // Додаємо пункт вибору за замовчуванням, якщо потрібно
                if (!string.IsNullOrEmpty(promptText))
                {
                    DataRow row = dataTable.NewRow();
                    row[displayMember] = promptText;
                    dataTable.Rows.InsertAt(row, 0);
                }

                // Налаштовуємо комбобокс
                comboBox.DataSource = dataTable;
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = valueMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public int GetLastInsertedId(string tableName)
        {
            int lastInsertedId = -1;

            try
            {
                using SqlConnection connection = new SqlConnection(ConnectionString);
                string sql = $"SELECT IDENT_CURRENT('{tableName}')";
                using SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                lastInsertedId = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lastInsertedId;
        }

        static public string GenerateSelectQuery(
            string tableName,
            object fieldsList = null,
            Dictionary<string, object> conditionArray = null,
            object joinTables = null,
            Dictionary<string, string> joinConditions = null
        )
        {
            if (fieldsList is null)
                fieldsList = "*";
            // Підготовка SQL-запиту
            string fields = fieldsList is List<string> ? string.Join(",", (List<string>)fieldsList) : (string)fieldsList;
            string sql = $"SELECT {fields} FROM {tableName}";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (conditionArray != null && conditionArray.Count > 0)
            {
                string whereClause = string.Join(" AND ", conditionArray.Select(c => $"{c.Key} = @{c.Key}"));
                sql += $" WHERE {whereClause}";
                parameters.AddRange(conditionArray.Select(c => new SqlParameter($"@{c.Key}", c.Value)));
            }

            List<string> tablesToJoin = new List<string>();

            if (joinTables != null)
            {
                if (joinTables is string)
                {
                    tablesToJoin.Add((string)joinTables);
                }
                else if (joinTables is List<string>)
                {
                    tablesToJoin.AddRange((List<string>)joinTables);
                }
            }

            if (tablesToJoin.Count > 0 && joinConditions != null && joinConditions.Count > 0)
            {
                foreach (string joinTable in tablesToJoin)
                {
                    if (joinConditions.ContainsKey(joinTable))
                    {
                        sql += $" JOIN {joinTable} ON {joinConditions[joinTable]}";
                    }
                }
            }

            return sql;
        }

        #region CRUD Function
        static public void Select(
                DataGridView dataGridView,
                string tableName,
                object fieldsList = null,
                Dictionary<string, object> conditionArray = null,
                object joinTables = null,
                Dictionary<string, string> joinConditions = null
            )
        {
            if (fieldsList is null)
                fieldsList = "*";
            // Підготовка SQL-запиту
            string fields = fieldsList is List<string> ? string.Join(",", (List<string>)fieldsList) : (string)fieldsList;
            string sql = $"SELECT {fields} FROM {tableName}";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (conditionArray != null && conditionArray.Count > 0)
            {
                string whereClause = string.Join(" AND ", conditionArray.Select(c => $"{c.Key} = @{c.Key}"));
                sql += $" WHERE {whereClause}";
                parameters.AddRange(conditionArray.Select(c => new SqlParameter($"@{c.Key}", c.Value)));
            }

            List<string> tablesToJoin = new List<string>();

            if (joinTables != null)
            {
                if (joinTables is string)
                {
                    tablesToJoin.Add((string)joinTables);
                }
                else if (joinTables is List<string>)
                {
                    tablesToJoin.AddRange((List<string>)joinTables);
                }
            }

            if (tablesToJoin.Count > 0 && joinConditions != null && joinConditions.Count > 0)
            {
                foreach (string joinTable in tablesToJoin)
                {
                    if (joinConditions.ContainsKey(joinTable))
                    {
                        sql += $" JOIN {joinTable} ON {joinConditions[joinTable]}";
                    }
                }
            }

            // Виконання запиту та отримання результатів
            using SqlConnection connection = new SqlConnection(ConnectionString);
            using SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddRange(parameters.ToArray());

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Заповнення DataGridView даними
            dataGridView.DataSource = table;
        }

        static public void Insert(
            string tableName,
            Dictionary<string, object> data
        )
        {
            // Підготовка SQL-запиту
            string fields = string.Join(",", data.Keys);
            string values = string.Join(",", data.Keys.Select(k => $"@{k}"));
            string sql = $"INSERT INTO {tableName} ({fields}) VALUES ({values})";

            List<SqlParameter> parameters = data.Select(d => new SqlParameter($"@{d.Key}", d.Value)).ToList();

            // Виконання запиту на додавання запису
            using SqlConnection connection = new SqlConnection(ConnectionString);
            using SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddRange(parameters.ToArray());

            connection.Open();
            command.ExecuteNonQuery();
        }

        static public void Delete(
            string tableName,
            Dictionary<string, object> conditionArray
        )
        {
            // Підготовка SQL-запиту
            string sql = $"DELETE FROM {tableName}";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (conditionArray != null && conditionArray.Count > 0)
            {
                string whereClause = string.Join(" AND ", conditionArray.Select(c => $"{c.Key} = @{c.Key}"));
                sql += $" WHERE {whereClause}";
                parameters.AddRange(conditionArray.Select(c => new SqlParameter($"@{c.Key}", c.Value)));
            }

            // Виконання запиту на видалення
            using SqlConnection connection = new SqlConnection(ConnectionString);
            using SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddRange(parameters.ToArray());
            connection.Open();
            command.ExecuteNonQuery();
        }

        static public void Update(
            string tableName,
            Dictionary<string, object> setArray,
            Dictionary<string, object> conditionArray)
        {
            string setClause = string.Join(", ", setArray.Select(c => $"{c.Key} = @{c.Key}"));
            string whereClause = "";
            if (conditionArray != null && conditionArray.Count > 0)
                whereClause = "WHERE " + string.Join(" AND ", conditionArray.Select(c => $"{c.Key} = @{c.Key}"));

            string sql = $"UPDATE {tableName} SET {setClause} {whereClause}";

            using SqlConnection connection = new SqlConnection(ConnectionString);
            using SqlCommand command = new SqlCommand(sql, connection);
            // Додавання параметрів
            if (setArray != null && setArray.Count > 0)
                command.Parameters.AddRange(setArray.Select(c => new SqlParameter($"@{c.Key}", c.Value)).ToArray());

            if (conditionArray != null && conditionArray.Count > 0)
                command.Parameters.AddRange(conditionArray.Select(c => new SqlParameter($"@{c.Key}", c.Value)).ToArray());

            connection.Open();
            command.ExecuteNonQuery();
        }
        #endregion
    }
}
