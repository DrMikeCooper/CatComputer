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
        }
    }
}
