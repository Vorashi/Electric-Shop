using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Linq;

namespace mainPage
{
    public partial class orderPage : Form
    {
        DataBase data = new DataBase();
        int selectedRow = 0;

        public orderPage()
        {
            InitializeComponent();
        }

        private void orderProduct_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGridView(dataGridView);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView);
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            RefreshDataGridView(dataGridView);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void btnOrderDraft_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void btnOrderSave_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnProductWatch_Click(object sender, EventArgs e)
        {
            WatchProduct();
        }

        ///<summary>
        ///Метод создания колонок в таблице
        /// </summary>
        private void CreateColumns()
        {
            dataGridView.Columns.Add("id_order", "id");
            dataGridView.Columns.Add("name", "Название");
            dataGridView.Columns.Add("brand", "Бренд");
            dataGridView.Columns.Add("price", "Цена");
            dataGridView.Columns.Add("category", "Категория");
            dataGridView.Columns.Add("login", "Пользователь");
            dataGridView.Columns.Add("IsNew", String.Empty);
        }

        ///<summary>
        ///Метод по строкового чтения из БД
        /// </summary>
        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4), record.GetString(5), RowState.ModifiedNew);
        }

        ///<summary>
        ///Метод обновления данных из БД в таблицу
        /// </summary>
        private void RefreshDataGridView(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = "select * from Orders";
            SqlCommand command = new SqlCommand(queryString, data.getConnection());
            data.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }

        ///<summary>
        ///Метод поиска в БД
        /// </summary>
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchQuery = $"select * from Orders where concat (id_order, name, brand, price, category, login) like '%" + tbxSearch.Text + "%'";

            SqlCommand command = new SqlCommand(searchQuery, data.getConnection());
            data.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }

            reader.Close();
            data.closeConnection();
        }

        ///<summary>
        ///Метод удаления данных и присвоения статуса
        /// </summary>
        private void DeleteRow()
        {
            int index = dataGridView.CurrentCell.RowIndex;

            dataGridView.Rows[index].Visible = false;

            if (dataGridView.Rows[index].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }

            dataGridView.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        ///<summary>
        ///Метод проверки события клика по ячейкам
        /// </summary>
        private void dataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[selectedRow];
                tbxId.Text = row.Cells[0].Value.ToString();
                tbxName.Text = row.Cells[1].Value.ToString();
                tbxBrand.Text = row.Cells[2].Value.ToString();
                tbxPrice.Text = row.Cells[3].Value.ToString();
                tbxCategory.Text = row.Cells[4].Value.ToString();
                tbxLogin.Text = row.Cells[5].Value.ToString();
            }
        }

        ///<summary>
        ///Метод измениения данных в таблице
        /// </summary>
        private void Change()
        {
            var selectedRowIndex = dataGridView.CurrentCell.RowIndex;
            var id = tbxId.Text;
            var name = tbxName.Text;
            var brand = tbxBrand.Text;
            var category = tbxCategory.Text;
            var login = tbxLogin.Text;
            int price;

            if (dataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(tbxPrice.Text, out price))
                {
                    dataGridView.Rows[selectedRowIndex].SetValues(id, name, brand, price, category, login);
                    dataGridView.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Проверьте корректность данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        ///<summary>
        ///Метод обновления по заданному статусу
        /// </summary>
        private void UpdateData()
        {
            data.openConnection();

            for (int index = 0; index < dataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Orders where id_order = {id}";
                    var command = new SqlCommand(deleteQuery, data.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView.Rows[index].Cells[1].Value.ToString();
                    var brand = dataGridView.Rows[index].Cells[2].Value.ToString();
                    var price = dataGridView.Rows[index].Cells[3].Value.ToString();
                    var category = dataGridView.Rows[index].Cells[4].Value.ToString();
                    var login = dataGridView.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"update Orders set name = '{name}', brand = '{brand}', price = '{price}', category = '{category}', login = '{login}' where id_order = '{id}'";
                    var command = new SqlCommand(changeQuery, data.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            data.closeConnection();
        }

        ///<summary>
        ///Метод очищения полей
        /// </summary>
        private void Clear()
        {
            tbxBrand.Text = "";
            tbxCategory.Text = "";
            tbxId.Text = "";
            tbxName.Text = "";
            tbxPrice.Text = "";
            tbxSearch.Text = "";
            tbxLogin.Text = "";
        }

        ///<summary>
        ///Метод открытия формы с товарами
        /// </summary>
        private void WatchProduct()
        {
            Form product = new generalPage();
            product.Show();
            Close();
        }
    }
}
