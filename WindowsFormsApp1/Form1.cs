using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void res_TextChanged(object sender, EventArgs e)
        {
        
            res.Clear();
            var first_no = int.Parse(fn.Text);
            var second_no = int.Parse(sn.Text);
            var result = 0;
            string choise = ec.Text;
            if (choise.Equals("+"))
            {
                result = first_no + second_no;
            }
            else if (choise.Equals("-"))
            {
                result = first_no - second_no;
            }
            else if (choise.Equals("*"))
            {
                result = first_no * second_no;
            }
            else if (choise.Equals("/"))
            {
                result = first_no / second_no;
            }
            res.AppendText(result.ToString());
            fn.Clear();
            sn.Clear();
           return;
            
            
        }

        private void fn_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}
