using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAVA_FINALTERM_ACTIVITY3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            budtxt.Clear();
            costtxt.Clear();
            lvltxt.Clear();
            Importtxt.Clear();
            risktxt.Clear();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            double budtxt = GetBudget();
            double costtxt = GetEstimatedCost();
            int lvltxt = GetUrgencyLevel();
            int importtxt = GetImportanceLevel();
            int risktxt = GetRiskLevel();

           
        }
            private double GetBudget()
            =>double.TryParse(budtxt.Text.Trim(), out double b) ? b : 0;

        private double GetEstimatedCost()
       => double.TryParse(costtxt.Text.Trim(), out double c) ? c : 0;

        private int GetUrgencyLevel()
      => int.TryParse(lvltxt.Text.Trim(), out int u) ? u : 0;

        private int GetImportanceLevel()
     => int.TryParse(lvltxt.Text.Trim(), out int i) ? i : 0;

        private int GetRiskLevel()
        => int.TryParse(risktxt.Text.Trim(), out int r) ? r : 0;

       
        



    }
}

