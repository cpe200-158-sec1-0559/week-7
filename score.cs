using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class score : Form, View
    {
        Model model;
        public score(Model model)
        {
            this.model = model;
            this.model.AttachObserver(this);
            InitializeComponent();
        }

        private void score_Load(object sender, EventArgs e)
        {

        }


        public void Notify(Model m)
        {
            label2.Text = Convert.ToString(((TwoZeroFourEightModel)m).getlblScore());
        }


        private void UpdateTile(Label l, int i)
        {
            if (i != 0)
            {
                l.Text = Convert.ToString(i);
            }
            else
            {
                l.Text = "";
            }
            label2.BackColor = Color.Yellow;
        }
        private void UpdateBoard(int[,] board, int lblscore)
        {
            UpdateTile(label2, lblscore);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
