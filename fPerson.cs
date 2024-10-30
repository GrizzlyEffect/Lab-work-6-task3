using Laba_6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_6
{
    public partial class fPerson : Form
    {
        public PersonBase ThePerson;

        public fPerson(PersonBase t)
        {
            ThePerson = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ThePerson.FirstName = tbFirstName.Text.Trim();
            ThePerson.LastName = tbLastName.Text.Trim();
            ThePerson.Gender = tbGender.Text.Trim();
            ThePerson.Age = int.Parse(tbAge.Text.Trim());
            ThePerson.Weight = double.Parse(tbWeight.Text.Trim());
            ThePerson.Height = double.Parse(tbHeight.Text.Trim());
            ThePerson.HasAuto = chbHasAuto.Checked;
            ThePerson.HasBike = chbHasBike.Checked;
            ThePerson.BMI = ThePerson.CalculateBMI();
            DialogResult = DialogResult.OK;
        }

    private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fPerson_Load(object sender, EventArgs e)
        {
            if (ThePerson != null)
            {
                tbFirstName.Text = ThePerson.FirstName;
                tbLastName.Text = ThePerson.LastName;
                tbGender.Text = ThePerson.Gender;
                tbAge.Text = ThePerson.Age.ToString();
                tbHeight.Text = ThePerson.Height.ToString("0.00");
                tbWeight.Text = ThePerson.Weight.ToString("0.00");
                chbHasAuto.Checked = ThePerson.HasAuto;
                ThePerson.BMI = ThePerson.CalculateBMI();
            }
        }
    }
}
