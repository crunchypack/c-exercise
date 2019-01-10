using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BounceNew
{
    public partial class DifficultySelector : Form
    {
        public DifficultySelector()
        {
            InitializeComponent();
        }

        private void diffButton_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
        public bool Difficulty
        {
            get
            {
                // Om easy är markerad skicka sant, annars skicka falsk
                if (easyDiff.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
