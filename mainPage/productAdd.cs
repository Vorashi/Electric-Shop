using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainPage
{
    public partial class productAdd : Form
    {
        DataBase data = new DataBase();
        public productAdd()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            { 
                if (tbxProductBrand.Text != "" && tbxProductCategory.Text != "" && tbxProductName.Text != "" && tbxProductPrice.Text != "")
                {
                    CreateProduct();
                }
                else
                {
                    MessageBox.Show("Заполните поля ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ev) 
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///<summary>
        ///Метод создания нового продукта
        /// </summary>
        private void CreateProduct()
        {
            try 
            {
                var name = tbxProductName.Text;
                var brand = tbxProductBrand.Text;
                var category = tbxProductCategory.Text;
                int price;

                if (int.TryParse(tbxProductPrice.Text, out price))
                {
                    var addQuery = $"insert into Products (name, brand, price, category) values ('{name}', '{brand}', '{price}', '{category}')";
                    var command = new SqlCommand(addQuery, data.getConnection());
                    data.openConnection();
                    command.ExecuteNonQuery();
                    MessageBox.Show($"Товар {name} добавлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Введите корректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                data.closeConnection();
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
