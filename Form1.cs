using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presidential
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = birthdayPicker.Value;
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - selectedDate.Year;

            // Check if the birthday has occurred already this year
            if (selectedDate.AddYears(age) > currentDate)
            {
                age--;
            }

            int.TryParse(yearsLivedinUStextbox.Text, out int yearsLived);

            bool correctAge = age >= 35;
            bool livedInUS = yearsLived >= 14;

            if (!USbornCheckbox.Checked || !correctAge
                || !livedInUS || disqualifiedCheckbox.Checked
                || rebelCheckbox.Checked || alreadyServedCheckbox.Checked)
            {
                MessageBox.Show("You are not eligible to serve as President.");
            }
            else
            {
                MessageBox.Show("You are eligible to serve as President.");
            }
        }



    }
}