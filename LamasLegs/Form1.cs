using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LamasLegs
{
    public partial class Form1 : Form
    {
        Lama lucinda;
        Lama lloyd;
       
        public Form1()
        {
            InitializeComponent();
            lucinda = new Lama() { Name = "Lucinda", LegSize = 33 };
            lloyd = new Lama() { Name = "Lloyd", LegSize = 45 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lama reverse;
            reverse = lucinda;
            lucinda = lloyd;
            lloyd = reverse;
            MessageBox.Show("Obiekty zamienione");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Lama lloyd = new Lama() { Name = "Lloyd", LegSize = 40 };
            Lama lucinda = new Lama() { Name = "Lucinda", LegSize = 33 };
            
            lloyd.TellMe("Cześć", lloyd);
            //lloyd = lucinda;
            //lloyd.LegSize = 4321;
            lucinda.SpeakTo(lloyd, "Witaj");
            //lloyd.WhoAmI();
        }
    }
}
