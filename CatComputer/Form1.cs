using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatComputer
{
    public partial class Form1 : Form
    {
        CatComputer computer = new CatComputer();

        public Form1()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            computer.Run();
            // hook up data to the panel
            this.graphCoin.ShowData("Coin",computer.coinHistory);
            this.graphLevel.ShowData("Level",computer.levelHistory);
            this.graphCats.ShowData("Cats", computer.catsHistory);
            this.graphRooms.ShowData("Rooms", computer.roomsHistory);
            this.graphHardware.ShowData("Hardware", computer.hardwareHistory);
            this.graphXP.ShowData("XP", computer.xpHistory);
            trackBarTime.Value = 0;
            trackBarTime.Maximum = computer.numSessions;

            for (int i = 0; i < computer.events.Count; i++)
                listBoxEvents.Items.Add(computer.events[i]);
        }

        private void trackBarTime_Scroll(object sender, EventArgs e)
        {
            SetTime(trackBarTime.Value);
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = listBoxEvents.SelectedItem.ToString();
            string[] parts = s.Split(':');
            if (parts.Length > 0)
                SetTime(int.Parse(parts[0]));
        }

        void SetTime(int time)
        {
            this.graphCoin.SetCurrentTime(time);
            this.graphLevel.SetCurrentTime(time);
            this.graphCats.SetCurrentTime(time);
            this.graphRooms.SetCurrentTime(time);
            this.graphHardware.SetCurrentTime(time);
            this.graphXP.SetCurrentTime(time);
            trackBarTime.Value = time;
            labelTime.Text = "" + time + "/" + trackBarTime.Maximum;
        }
    }
}
