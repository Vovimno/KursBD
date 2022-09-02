using KursBD.Class;
using MySqlConnector;
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

namespace KursBD.Forms
{
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();

            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void LoginCancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;                                                       
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = LoginField.Text;
            string loginPassword = PasswordField.Text;

            db db = new db();
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"Users\" where \"Login\" = @Login", db.GetConnection());
            command.Parameters.Add("@Login", NpgsqlTypes.NpgsqlDbType.Varchar).Value = LoginField.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show(); 
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        
    }
}
