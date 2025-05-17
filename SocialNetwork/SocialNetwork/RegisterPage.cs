using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetwork
{
    public partial class registerPage : Form
    {
        public registerPage()
        {
            InitializeComponent();
        }

        private void registerPage_Load(object sender, EventArgs e)
        {
            validationError.Visible = false;
        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            validationError.Visible = true;

            //Name validation
            if (fullName.Text == "")
            {
                validationError.Text = "Enter a name!";
                return;
            }



            //Email Validation
            if (email.Text == "")
            {
                validationError.Text = "Enter an email!";
                return;
            }
            if (!email.Text.Contains("@") || !email.Text.Contains("."))
            {
                validationError.Text = "Enter a valid email!";
                return;
            }
            if (email.Text.IndexOf(".") < email.Text.IndexOf("@"))
            {
                validationError.Text = "Enter a valid email!";
                return;
            }
            if (email.Text.Contains(".."))
            {
                validationError.Text = "Enter a valid email!";
                return;
            }
            if (email.Text.Contains("@@"))
            {
                validationError.Text = "Enter a valid email!";
                return;
            }
            if (email.Text.StartsWith("@") || email.Text.EndsWith("@"))
            {
                validationError.Text = "Enter a valid email!";
                return;
            }
            if (email.Text.StartsWith(".") || email.Text.EndsWith("."))
            {
                validationError.Text = "Enter a valid email!";
                return;
            }



            //Passwords Validation
            if (password.Text == "")
            {
                validationError.Text = "Enter a password!";
                return;
            }
            if (confirmPassword.Text == "")
            {
                validationError.Text = "Confirm your password!";
                return;
            }
            if (confirmPassword.Text != password.Text)
            {
                validationError.Text = "Passwords must match!";
                return;
            }

            string filePath = @"..\..\..\users.txt";
            File.AppendAllText(filePath, fullName.Text + "\n");

            // Запазване на името в променлива, която прехвърляме към социалната мрежа
            string username = fullName.Text;

            //Създаваме си формата за социална мрежа и подаваме 1 параметър за username
            socialPageForm socialPage = new socialPageForm(username);

            // Затваряне на формата за регистрация и отваряне на социалната мрежа
            this.Hide();
            socialPage.Show();


        }


    }
}
