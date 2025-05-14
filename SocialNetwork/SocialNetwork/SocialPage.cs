using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;
using System.IO;

namespace SocialNetwork
{
    public partial class socialPageForm : Form
    {

        private string username;
        public socialPageForm(string username, DateTime dateToday)
        {
            InitializeComponent();
            this.username = username;
            userName.Text = username;
            joinDateLabel.Text = dateToday.ToString("dd/MM/yyyy HH:mm") + " | " + userName.Text + " " + "has successfully created an account.";
        }

        

        int labelY = 0;

        private void socialPageForm_Load(object sender, EventArgs e)
        {
            wallTextBox.Text = "Write something...";
            wallTextBox.ForeColor = Color.Gray;
            wallTextBox.Enabled = false;
            this.ActiveControl = null; // or labelTitle.Focus();
            wallTextBox.Enabled = true;
            joinDateLabel.Focus();

            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;




            string filePath = @"..\..\..\users.txt";
            string[] friends = File.ReadAllLines(filePath);
            foreach (var friend in friends)
            {
                listBoxFriends.Items.Add(friend);
                if (friends.Contains(username))
                {
                    listBoxFriends.Items.Remove(username);
                }
            }
            

        }

        private void wallTextBox_Enter(object sender, EventArgs e)
        {
            if (wallTextBox.Text == "Write something...")
            {
                wallTextBox.Text = "";
                wallTextBox.ForeColor = Color.Black;
            }
        }

        private void wallTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(wallTextBox.Text))
            {
                wallTextBox.Text = "Write something...";
                wallTextBox.ForeColor = Color.Gray;
            }
        }

        private void wallTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DateTime dateToday = DateTime.Now;
                Label message = new Label();
                message.Text = dateToday.ToString("dd/MM/yyyy HH:mm") + " | " + $"{username} wrote:" + " " + wallTextBox.Text;
                message.AutoSize = true;
                message.Font = new Font("Microsoft Sans Serif", 9);
                message.Location = new Point(0, labelY);

                newPostsPanel.Controls.Add(message);
                labelY += message.Height + 8;

                wallTextBox.Clear();
            }
        }

        private void buttonChangePFP_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string imagePath = openFileDialog.FileName;


                pictureBoxPFP.Image = new Bitmap(imagePath);
            }
        }
        private void buttonChangeBackground_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBoxBackgroundIMG.Image = new Bitmap(imagePath);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonWall_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
        }

        private void buttonPhotos_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel5.Visible = false;
        }
        private void buttonFriends_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel5.Visible = false;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = true;
        }

        int yPosition = 10;
        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                PictureBox photo = new PictureBox();
                photo.Image = Image.FromFile(imagePath);
                photo.SizeMode = PictureBoxSizeMode.StretchImage;
                photo.Width = 200;
                photo.Height = 200;
                photo.Location = new Point(0, yPosition);
                photoGalleryPanel.Controls.Add(photo);
                yPosition += photo.Height + 25;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxFriends.Items.Add(textBoxSearch.Text);
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search for friends...")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Search for friends...";
                textBoxSearch.ForeColor = Color.Gray;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            ActiveForm.Dispose();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            registerPage registerPage = new registerPage();
            this.Hide();
            registerPage.Show();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBoxFriends.Items.Add(textBoxSearch.Text);
                textBoxSearch.Text = string.Empty;
            }
        }
    }
}
