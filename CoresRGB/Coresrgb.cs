using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoresRGB
{
    public partial class Coresrgb : Form
    {
        public Coresrgb()
        {
            InitializeComponent();
        }

        public void MesclarCores() 
        {
            labelPainel.BackColor = Color.FromArgb(
                hScrollBarRed.Value,
                hScrollBarGreen.Value,
                hScrollBarBlue.Value
                );
        }

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            labelNumRed.Text = hScrollBarRed.Value.ToString();
            MesclarCores();
        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            labelNumGreen.Text = hScrollBarGreen.Value.ToString();
            MesclarCores();
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            labelNumBlue.Text = hScrollBarBlue.Value.ToString();
            MesclarCores();
        }
    }
}
