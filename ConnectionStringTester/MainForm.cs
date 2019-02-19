using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace ConnectionStringTester
{
    public partial class MainForm : Form
    {
        private readonly Hashtable _hDataProviders = new Hashtable();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewResults.DataSource = bindingSourceResults;
            
            var dt = GetProviderFactoryClasses();
            foreach (var key in _hDataProviders.Keys)
            {
                comboBoxProvider.Items.Add(key);
            }

            Console.WriteLine(dt.ToString());
        }

        private DataTable GetProviderFactoryClasses()
        {
            // Retrieve the installed providers and factories.
            var table = DbProviderFactories.GetFactoryClasses();

            // Display each row and column value.
            foreach (DataRow row in table.Rows)
            {
                if (table.Columns.Count != 4) continue;
                var dp = new VTDataProvider(row[table.Columns[0]].ToString(),
                    row[table.Columns[1]].ToString(),
                    row[table.Columns[2]].ToString(),
                    row[table.Columns[3]].ToString());
                _hDataProviders.Add(dp.invariant, dp);
            }

            return table;
        }

        private void RunQuery(string providerName, string connectionString, string sqlQuery)
        {
            try
            {
                // Create the DbProviderFactory and DbConnection.
                var factory =
                    DbProviderFactories.GetFactory(providerName);

                var connection = factory.CreateConnection();
                if (connection == null) return;
                connection.ConnectionString = connectionString;

                using (connection)
                {
                    // Define the query.
                    //string queryString =
                    //    "SELECT CategoryName FROM Categories";

                    // Create the DbCommand.
                    var command = factory.CreateCommand();
                    if (command != null)
                    {
                        command.CommandText = sqlQuery;
                        command.Connection = connection;

                        // Create the DbDataAdapter.
                        var adapter = factory.CreateDataAdapter();
                        if (adapter != null)
                        {
                            adapter.SelectCommand = command;

                            // Fill the DataTable.
                            var table = new DataTable();
                            adapter.Fill(table);

                            bindingSourceResults.DataSource = table;
                        }
                    }

                    dataGridViewResults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonRunQuery_Click(object sender, EventArgs e)
        {
            RunQuery(comboBoxProvider.SelectedItem as string, textBoxConnectionString.Text, textBoxSQLQuery.Text);
        }


        private void buttonCheckConnection_Click(object sender, EventArgs e)
        {
            CheckConnection(comboBoxProvider.SelectedItem as string, textBoxConnectionString.Text);
        }

        private static void CheckConnection(string providerName, string connectionString)
        {
            try
            {
                // Create the DbProviderFactory and DbConnection.
                var factory =
                    DbProviderFactories.GetFactory(providerName);

                var connection = factory.CreateConnection();
                if (connection == null) return;
                connection.ConnectionString = connectionString;

                connection.Open();
                MessageBox.Show($"Connection state: {connection.State}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
