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


            this.playCoinNumber.Value        = computer.data.activeCoin         ;
            this.playXPNumber.Value          = computer.data.activeXP           ;
            this.passiveCoinNumber.Value     = computer.data.passiveCoin        ;
            this.passiveXPNumber.Value       = computer.data.passiveXP          ;
            this.wanderCoinNumber.Value      = computer.data.wanderCoin         ;
            this.wanderCoinPct.Value         = computer.data.pctWanderCoin      ;
            this.wanderHardwareNumber.Value  = computer.data.wanderHardware     ;
            this.wanderHardwarePct.Value     = computer.data.pctWanderHardware  ;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            computer.data.activeCoin            = (int)this.playCoinNumber.Value;
            computer.data.activeXP              = (int)this.playXPNumber.Value;
            computer.data.passiveCoin           = (int)this.passiveCoinNumber.Value;
            computer.data.passiveXP             = (int)this.passiveXPNumber.Value;
            computer.data.wanderCoin            = (int)this.wanderCoinNumber.Value;
            computer.data.pctWanderCoin         = (int)this.wanderCoinPct.Value;
            computer.data.wanderHardware        = (int)this.wanderHardwareNumber.Value;
            computer.data.pctWanderHardware     = (int)this.wanderHardwarePct.Value;

            computer.Run();
            // hook up data to the panel
            this.graphCoin.ShowData("Coin",computer.coinHistory, computer.coinNeedHistory);
            this.graphLevel.ShowData("Level",computer.levelHistory);
            this.graphCats.ShowData("Cats", computer.catsHistory);
            this.graphRooms.ShowData("Rooms", computer.roomsHistory, computer.roomsHistory2);
            this.graphHardware.ShowData("Hardware", computer.hardwareHistory, computer.hardwareNeedHistory);
            this.graphXP.ShowData("XP", computer.xpHistory);
            trackBarTime.Value = 0;
            trackBarTime.Maximum = computer.numSessions;

            listBoxEvents.Items.Clear();
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
