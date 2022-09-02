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

namespace KursBD.Forms
{
    public partial class GamePage : Form
    {
        private Game game;

        public GamePage()
        {
            InitializeComponent();
            
        }

        public void Init(Game game)
        {
            this.game = game;
           
            DescriptionText.Text = game.Description;
            GameNameLabel.Text = game.Name;
            GameNameLabel1.Text = game.Name;
            string gamePrice = game.Price.ToString(); 
            Pricelabel.Text = gamePrice;
            DataRe.Text = game.YearOfRelease;

            if (game.ImageURL != null) 
            { 
                 var projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent;
                 var path = Path.Combine(projectPath.FullName,"Image", game.ImageURL);
                 ImageGame.Image = Image.FromFile(path);
            }

            db db = new db();
            var context = new Context(db);
            var SR = context.GetSystemRequirements(game.Id);
            if (SR != null) 
            {
                SystemReqOC.Text = SR.OC;
                SystemReqCPU.Text = SR.CPU;
                SystemReqGPU.Text = SR.GPU;
                SystemReqRAM.Text = SR.RAM;
                SystemReqDirectX.Text = SR.DirectX;
                SystemReqDiskSpace.Text = SR.DiskSpace;
            }
            var Dev = context.GetDevelopers(game.IdDevelopers);
            DeveloperLabel.Text = Dev.NameDeveloper;

            var Pub = context.GetPublishers(game.IdPublishers);
            PublisherLabel.Text = Pub.NamePublisher;
             
            var Tag = context.GetTags(game.Id);
            Tag1Label.Text = Tag?.Tag1;
            //Tag2Label.Text = Tag.Tag2;

            


        }

        private void HIdeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
            
        }

        private void BuyingButton_Click(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        private void mainPanelGamePageForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
           
        private void mainPanelGamePageForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    
        
        
        

    }
}
