using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double average = 0;
            average += Convert.ToDouble(EngCon.Text);
            average += Convert.ToDouble(MatCon.Text);
            average += Convert.ToDouble(SciCon.Text);
            average += Convert.ToDouble(FilCon.Text);
            average += Convert.ToDouble(HisCon.Text);
            average /= 5;

            label8.Text = (average > 75 ? "The student passed." : "The student failed.") + "\nThe general average of " + NameCon.Text + " is " + average + "." ;
            if (average > 75)
            {
                label8.Text = "The student passed.\nThe general average of " + NameCon.Text + " is " + average + ".";
            }

            else 
            {
                label8.Text = "The student failed.\nThe general average of " + NameCon.Text + " is " + average + ".";
            }
        }
    }
}
