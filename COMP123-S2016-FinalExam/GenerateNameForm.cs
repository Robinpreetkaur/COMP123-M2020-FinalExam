using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class GenerateNameForm : Form
    {

        private Random random;
      

        public GenerateNameForm()
        {
            InitializeComponent();
        } 

        private void GenerateNames()
        {
            random = new Random();
            int fname = random.Next(0, 30);
            int lname = random.Next(0, 30);
            FirstNameListBox.SelectedIndex = fname;
            LastNameListBox.SelectedIndex = lname;
            FirstNameTextBox.Text = FirstNameListBox.GetItemText(FirstNameListBox.SelectedItem);
            LastNameTextBox.Text = LastNameListBox.GetItemText(LastNameListBox.SelectedItem);
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }


       private void GenerateButton_Click(object sender , EventArgs e)
        {
            GenerateNames();
            Program.character.fname = FirstNameTextBox.Text;
            Program.character.lname = LastNameTextBox.Text;

        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
            this.Hide();
            

        }

        private void NameListGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
