using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace WindowsFormsAppNumberInWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            //txtInput.Text = txtInput.Text.InsertComma();
            //txtInput.SelectionStart = txtInput.Text.Length;
        }

        private void btnDisplayHorofi_Click(object sender, EventArgs e)
        {
            var TmpInputNoComma = txtInput.Text;
            double TmpDblInput;
            double.TryParse(TmpInputNoComma, out TmpDblInput);
            var TmpOutput = TmpDblInput.ConvertAmount();

            MessageBox.Show(TmpOutput);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
