using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addTrainButton_Click(object sender, EventArgs e)
        {
            AddLineandStation addLineandStation = new AddLineandStation();
            addLineandStation.Show();
        }

        private void addDistanceButton_Click(object sender, EventArgs e)
        {
            AddDistance addDistance = new AddDistance();
            addDistance.Show();
        }

        private void linkButton_Click(object sender, EventArgs e)
        {
            LinkTrainStationtoaLine link = new LinkTrainStationtoaLine();
            link.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ShortestRoute shortestRoute = new ShortestRoute();
            shortestRoute.Show();
        }
    }
}
