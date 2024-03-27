using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfHearts
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Form1 f1 = new Form1();

            playerName1.Text = f1.player1.Name;
            playerName2.Text = f1.player1.Name;
            playerName3.Text = f1.player1.Name;
            playerName4.Text = f1.player1.Name;


        }

     
    }
}
