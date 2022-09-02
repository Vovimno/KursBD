using KursBD.Class;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursBD
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            RegisterField.Text = "Введите логин";
            PasswordRegisterField.Text = "Введите пароль";
            PasswordConfirmField.Text = "Повторите паро";

        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if ((RegisterField.Text == "Введите логин") ||
                (PasswordRegisterField.Text == "Введите пароль") ||
                (PasswordConfirmField.Text == "Повторный пароль"))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (PasswordRegisterField.Text != PasswordConfirmField.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            if (isUserExist())
            {
                return;
            }
            db DB = new db();

            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO public.\"Users\" (\"Login\", \"Password\") VALUES(@Login, @Password) returning \"id\";", DB.GetConnection());
            command.Parameters.Add("@Login", NpgsqlTypes.NpgsqlDbType.Varchar).Value = RegisterField.Text;
            command.Parameters.Add("@Password", NpgsqlTypes.NpgsqlDbType.Varchar).Value = PasswordRegisterField.Text;
            

            DB.OpenConection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан");
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан");
            }
            DB.CloseConection();
        }

        public Boolean isUserExist()
        {
            db DB = new db();
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"Users\" where \"Login\" = @Login", DB.GetConnection());
            command.Parameters.Add("@Login", NpgsqlTypes.NpgsqlDbType.Varchar).Value = RegisterField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой Логин уже существует");
                return true;
            }
            else
            {
                return false;
            }

        }






















        private void LoginCancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void mainPanelRegister_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void mainPanelRegister_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginCancelbutton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterField_Enter(object sender, EventArgs e)
        {
            if (RegisterField.Text == "Введите логин")
            RegisterField.Text = "";
        }

        private void RegisterField_Leave(object sender, EventArgs e)
        {
            if (RegisterField.Text == "")
                RegisterField.Text = "Введите логин";
        }

        private void PasswordRegisterField_Enter(object sender, EventArgs e)
        {
            if (PasswordRegisterField.Text == "Введите пароль")
                PasswordRegisterField.Text = "";
        }

        private void PasswordRegisterField_Leave(object sender, EventArgs e)
        {
            if (PasswordRegisterField.Text == "")
                PasswordRegisterField.Text = "Введите пароль";
        }

        private void PasswordConfirmField_Enter(object sender, EventArgs e)
        {
            if (PasswordConfirmField.Text == "Повторите паро")
                PasswordConfirmField.Text = "";

        }

        private void PasswordConfirmField_Leave(object sender, EventArgs e)
        {
            if (PasswordConfirmField.Text == "")
                PasswordConfirmField.Text = "Повторите паро";
        }

        
    }
}
