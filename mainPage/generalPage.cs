using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainPage
{
    enum RowState 
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted,
    }

    public partial class generalPage : Form
    {
        public static string RoleName { get; set; }
        public static string UserName { get; set; }
        

        DataBase data = new DataBase();
        int selectedRow = 0;

        public generalPage()
        {
            InitializeComponent();
        }

        private void generalPage_Load_1(object sender, EventArgs e)
        {
            CreateColumns();
            RoleVisible();
            RefreshDataGridView(dataGridView);
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            OpenProductAddPage();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnProductDraft_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView);
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            RefreshDataGridView(dataGridView);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void btnProductOrder_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (tbxId.Text != "" && tbxName.Text != "" && tbxPrice.Text != "" && tbxCategory.Text != "" && tbxBrand.Text != "") 
                {
                    Order();
                }
                else
                {
                    MessageBox.Show("Выберите Товар!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWatchOrders_Click(object sender, EventArgs e)
        {
            Form watcher = new orderPage();
            watcher.Show();
        }

        ///<summary>
        ///Метод проверки роли пользователя
        /// </summary>
        private void RoleVisible() 
        {
            try 
            {            
                lblRole.Text += "" + UserName;
                if (RoleName == "Администратор") 
                {
                    btnProductAdd.Visible = true;
                    btnProductDelete.Visible = true;
                    btnProductDraft.Visible = true;
                    btnProductSave.Visible = true;
                    btnWatchOrders.Visible = true;
                }
                else if (RoleName == "Пользователь") 
                {
                    btnProductAdd.Visible = false;
                    btnProductDelete.Visible = false;
                    btnProductDraft.Visible = false;
                    btnProductSave.Visible = false;
                    btnWatchOrders.Visible = true;
                }
            }
            catch (Exception ev) 
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///<summary>
        ///Метод создания колонок в таблице
        /// </summary>
        private void CreateColumns() 
        {
            dataGridView.Columns.Add("id_product", "id");
            dataGridView.Columns.Add("name", "Название");
            dataGridView.Columns.Add("brand", "Бренд");
            dataGridView.Columns.Add("price", "Цена");
            dataGridView.Columns.Add("category", "Категория");
            dataGridView.Columns.Add("IsNew", String.Empty);
        }

        ///<summary>
        ///Метод по строкового чтения из БД
        /// </summary>
        private void ReadSingleRows(DataGridView dgw, IDataRecord record) 
        {
            try 
            { 
                dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4), RowState.ModifiedNew);            
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///<summary>
        ///Метод обновления данных из БД в таблицу
        /// </summary>
        private void RefreshDataGridView(DataGridView dgw)
        {
            try 
            { 
                dgw.Rows.Clear();
                string queryString = "select * from Products";
                SqlCommand command = new SqlCommand(queryString, data.getConnection());
                data.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRows(dgw, reader);
                }
                reader.Close();
            }
            catch (Exception ev) 
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///<summary>
        ///Метод проверки события клика по ячейкам
        /// </summary>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///<summary>
        ///Метод открытия формы добавления товара
        /// </summary>
        private void OpenProductAddPage()
        {
            Form productAdd = new productAdd();
            productAdd.Show();
        }

        ///<summary>
        ///Метод поиска в БД
        /// </summary>
        private void Search(DataGridView dgw)
        {
            try 
            { 
                dgw.Rows.Clear();
                string searchQuery = $"select * from Products where concat (id_product, name, brand, price, category) like '%" + tbxSearch.Text + "%'";
        
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
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///<summary>
        ///Метод удаления данных и присвоения статуса
        /// </summary>
        private void DeleteRow() 
        {
            try 
            {            
                int index = dataGridView.CurrentCell.RowIndex;

                dataGridView.Rows[index].Visible = false;
            
                if (dataGridView.Rows[index].Cells[0].Value.ToString() != string.Empty)
                {
                    dataGridView.Rows[index].Cells[5].Value = RowState.Deleted;
                    return;
                }

                dataGridView.Rows[index].Cells[5].Value = RowState.Deleted;
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///<summary>
        ///Метод обновления по заданному статусу
        /// </summary>
        private void UpdateData()
        {
            try
            {
                data.openConnection();

                for (int index = 0; index < dataGridView.Rows.Count; index++) 
                {
                    var rowState = (RowState)dataGridView.Rows[index].Cells[5].Value;

                    if (rowState == RowState.Existed) 
                    {
                        continue;
                    }

                    if (rowState == RowState.Deleted)
                    {
                        var id = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                        var deleteQuery = $"delete from Products where id_product = {id}";
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

                        var changeQuery = $"update Products set name = '{name}', brand = '{brand}', price = '{price}', category = '{category}' where id_product = '{id}'";
                        var command = new SqlCommand(changeQuery, data.getConnection());
                        command.ExecuteNonQuery();
                    }
                }
                data.closeConnection();
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        ///<summary>
        ///Метод изменения данных в таблице
        /// </summary>
        private void Change()
        {
            try 
            {
                var selectedRowIndex = dataGridView.CurrentCell.RowIndex;
                var id = tbxId.Text;
                var name = tbxName.Text;
                var brand = tbxBrand.Text;
                var category = tbxCategory.Text;
                int price;

                if (dataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty) 
                {
                    if (int.TryParse(tbxPrice.Text, out price)) 
                    {
                        dataGridView.Rows[selectedRowIndex].SetValues(id, name, brand, price, category);
                        dataGridView.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                    }
                    else
                    {
                        MessageBox.Show("Проверьте корректность данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        }

        ///<summary>
        ///Метод заказа товара
        /// </summary>
        private void Order() 
        {
            try 
            {
                var name = tbxName.Text;
                var brand = tbxBrand.Text;
                var price = tbxPrice.Text;
                var category = tbxCategory.Text;
                var login = UserName;
                var orderQuery = $"insert into Orders (name, brand, price, category, login) values ('{name}', '{brand}', '{price}', '{category}', '{login}')";
                var command = new SqlCommand(orderQuery, data.getConnection());

                data.openConnection();
                command.ExecuteNonQuery();
                data.closeConnection();
                MessageBox.Show($"Вы заказали {name}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
