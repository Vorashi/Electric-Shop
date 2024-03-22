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

namespace mainPage
{
    public partial class authorizationPage : Form
    {
        DataBase data = new DataBase();
        public authorizationPage()
        {
            InitializeComponent();
            tbxPasswordAutoriz.UseSystemPasswordChar = true;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            CloseForms();
        }

        private void lklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenRegistrationPage();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cbxVisibleState_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxVisibleState.Checked)
                {
                    tbxPasswordAutoriz.UseSystemPasswordChar = false;
                    lblVisiblePassword.Text = "Скрыть пароль";
                }
                else
                {
                    tbxPasswordAutoriz.UseSystemPasswordChar = true;
                    lblVisiblePassword.Text = "Показать пароль";
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            { 
                if (tbxLoginAutoriz.Text != "" && tbxPasswordAutoriz.Text != "")
                {
                    OpenGeneralPage();
                }
                else
                {
                    tbxLoginAutoriz.BorderColor = Color.Red;
                    tbxLoginAutoriz.PlaceholderForeColor = Color.Red;
                    tbxPasswordAutoriz.BorderColor = Color.Red;
                    tbxPasswordAutoriz.PlaceholderForeColor = Color.Red;
                    MessageBox.Show("Заполните поля ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Метод закрытия формы
        /// </summary>
        private void CloseForms()
        {
            try 
            { 
                Close();
                Application.Exit();
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Метод открытия формы регистрации
        /// </summary>
        private void OpenRegistrationPage()
        {
            try
            {
                Hide();
                Form reg = new registrationPage();
                reg.Visible = true;
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Метод открытия формы с товарами
        /// </summary>
        private void OpenGeneralPage()
        {   try 
            { 
                var login = tbxLoginAutoriz.Text;
                var password = tbxPasswordAutoriz.Text;
                string autorizQuery = $"select login, password, role from Users where login = '{login}' and password = '{password}'";
                var command = new SqlCommand(autorizQuery, data.getConnection());
                data.openConnection();
                var reader = command.ExecuteReader();

                if (reader.Read()) { 
                    string role = reader["role"].ToString();
                    string name = reader["login"].ToString();
                    generalPage.RoleName = role;
                    generalPage.UserName = name;
                    data.closeConnection();
                    Form generalForm = new generalPage();
                    generalForm.Show();
                    Hide();
                }
                else
                {
                    data.closeConnection();
                    MessageBox.Show("Неверный логин или пароль. Пожалуйста, попробуйте снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Метод очистки полей формы
        /// </summary>
        private void Clear()
        {
            try 
            {
                tbxLoginAutoriz.Text = "";
                tbxPasswordAutoriz.Text = "";
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
