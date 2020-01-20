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
    public partial class FishNotes : Form
    {
        public Form _newNote;


        public FishNotes()
        {
            InitializeComponent();
        }

        private void MoreFish_Click(object sender, EventArgs e)
        {

        }

        private void AddNote_Click(object sender, EventArgs e)
        {
            //instantiate a new note pop-up
            FishyNote _newNote = new FishyNote();

            //shows the pop-up
            if (_newNote != null)
            {
                _newNote.Show();
            }
            
        }
    }
}
