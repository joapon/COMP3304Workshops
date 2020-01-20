using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sticky_Notes_Clone
{

    public partial class FishyNote : Form
    {
        int height = 50;
        int width = 395;

        int _expandHeight = 400;
        int _expandWidth = 400;

        bool _expand = true;

        public FishyNote()
        {
            InitializeComponent();
        }

        private void FishyNote_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            Inser_Text_Box.Text = "";
        }


        //closenote pop-up
        private void Close_Enter_Note_Box_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //expand and shrink note box
        private void Expand_Colapse_Note_Click(object sender, EventArgs e)
        {
            if(_expand)
            {
                this.Size = new System.Drawing.Size(width, height);
                _expand = false;
            }
            else
            {
                this.Size = new System.Drawing.Size(_expandWidth, _expandHeight);
                _expand = true;
            }



        }
    }
}
