using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankLibrary;

namespace BankLibrary
{
    public partial class BankUIForm : Form
    {
        protected int TextBoxCount = 4;

        // enumartion constants specify TextBox indices
        public enum TextBoxIndices
        {
            ACCOUNT,
            FIRST,
            LAST,
            BALANCE
        }// end enum

        public BankUIForm()
        {
            InitializeComponent();
        }
    }
}
