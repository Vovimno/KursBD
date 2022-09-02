using KursBD.Class;
using KursBD.Forms;
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
    public partial class MainForm : Form
    {
        private DataTable table;

        public MainForm()
        {
            InitializeComponent();
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewColumn
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                Name = "NameColumn",
                HeaderText = "Name of game",
                DataPropertyName = "Name"
            });
            dataGridView1.Columns.Add(new DataGridViewColumn
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                Name = "DateColumn",
                HeaderText = "Date of game",
                DataPropertyName = "YearOfRelease"
            });
            dataGridView1.Columns.Add(new DataGridViewColumn
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                Name = "PriceColumn",
                HeaderText = "Price of game",
                DataPropertyName = "Price"
            });
                     
            db db = new db();
            var context = new Context(db);
            var games = context.GetAllGames();
            dataGridView1.DataSource = games;

        }
        private void label3_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            db db = new db();
            /*DataTable*/ table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand("SELECT \"Name\", \"YearOfRelease\", \"Price\", \"id\" FROM \"Games\" ", db.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        Point lastPoint;
        private void mainPanelMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }
        private void mainPanelMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HIdeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // берем грид
            var grid = (DataGridView)sender;
            // из грида забираем игру по номеру строки
            var item = (Game)grid.Rows[e.RowIndex].DataBoundItem;
            // создаем новую форму для отображения
            var form = new GamePage();
            // инициализируем созданную форму своими данными
            form.Init(item);
            // показываем
            form.Show();
            this.Hide();
        }

       
    }
}
