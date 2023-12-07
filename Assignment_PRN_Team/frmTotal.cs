using DataAccess.Repository;
using System;
using System.Windows.Forms;
using Sunny.UI;

namespace BlogWinApp
{
    public partial class frmTotal : Form
    {
        IPostRepository repo = new PostRepository();
        public frmTotal()
        {
            InitializeComponent();
        }
        private void LoadLB()
        {
            waitingLbl.Text = repo.GetWaitingPosts().Count.ToString();
            approveLbl.Text = repo.GetApprovedPosts().Count.ToString();
            totalLbl.Text = repo.GetAllPosts().Count.ToString();

            UIPieOption option = new UIPieOption();

            option.Title = new UITitle();
            option.Title.Text = "";
            option.Title.SubText = "";

            var series = new UIPieSeries();

            series.Name = $"Total: {repo.GetAllPosts().Count}";
            series.Center = new UICenter(50, 55);
            series.Radius = 70;

            series.AddData("Waiting post:", repo.GetWaitingPosts().Count);
            series.AddData("Approved post:", repo.GetApprovedPosts().Count);


            option.Series.Add(series);

            // Assuming pieChart is the name of your UIPieChart control
            pieChart.SetOption(option);
            pieChart.Refresh();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadLB();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}