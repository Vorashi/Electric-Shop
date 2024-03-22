using Guna.UI2.WinForms;
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
    public partial class registrationPage : Form
    {
        DataBase data = new DataBase();
        public registrationPage()
        {
            InitializeComponent();
            tbxPasswordRegister.UseSystemPasswordChar = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void lkLblEnter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenAutorizationPage();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (tbxLoginRegister.Text != "" && tbxPasswordRegister.Text != "")
                {
                    OpenGeneralPage();
                }
                else
                {
                    tbxLoginRegister.BorderColor = Color.Red;
                    tbxLoginRegister.PlaceholderForeColor = Color.Red;
                    tbxPasswordRegister.BorderColor = Color.Red;
                    tbxPasswordRegister.PlaceholderForeColor = Color.Red;
                    MessageBox.Show("Заполните поля ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ev) 
            {
                MessageBox.Show(ev.Message,"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxVisibleState_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxVisibleState.Checked)
                {
                    tbxPasswordRegister.UseSystemPasswordChar = false;
                    lblVisiblePassword.Text = "Скрыть пароль";
                }
                else
                {
                    tbxPasswordRegister.UseSystemPasswordChar = true;
                    lblVisiblePassword.Text = "Показать пароль";
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
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
        /// Метод открытия формы с авторизацией
        /// </summary>
        private void OpenAutorizationPage()
        {
            try
            {
                Form autorez = new authorizationPage();
                autorez.Show();
                this.Close();
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
        {
            try
            {
                string role = "Пользователь";
                string login = tbxLoginRegister.Text;
                string password = tbxPasswordRegister.Text;
                var registerQuery = $"insert into Users (password, login, role) values ('{password}', '{login}', '{role}')";
                var command = new SqlCommand(registerQuery, data.getConnection());
                data.openConnection();
                command.ExecuteNonQuery();
                data.closeConnection();
                MessageBox.Show("Вы успешно зарегистрированы!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form generalForm = new generalPage();
                generalForm.Show();
                Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Метод очищения полей формы
        /// </summary>
        private void Clear() 
        {
            try
            { 
                tbxLoginRegister.Text = "";
                tbxPasswordRegister.Text = "";
            }
            catch (Exception ev) 
            {
                MessageBox.Show(ev.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}