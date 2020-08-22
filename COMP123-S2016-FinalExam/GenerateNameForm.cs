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
            var FirstName = random.Next(FirstNameListBox.Items.Count);
            var LastName = random.Next(LastNameListBox.Items.Count);
            FirstNameListBox.SelectedIndex = FirstName;
            LastNameListBox.SelectedIndex = LastName;
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
            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;

        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            
            // Instantiate an object for the form type
            // you are going to next
            AbilityGeneratorForm AbilityGeneratorForm = new AbilityGeneratorForm();

           
            //  point this form to the parent Form 
            // property in the next form
           AbilityGeneratorForm.previousForm = this;

            // Show the next form
            AbilityGeneratorForm.Show();

            // hide the current form
            this.Hide();


        }

        private void NameListGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
