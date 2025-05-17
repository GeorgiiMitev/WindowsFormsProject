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
using System.Threading;

namespace SocialNetwork
{
    public partial class socialPageForm : Form
    {
        // променлива в която ще запазим прехвърленото име
        string username;
        public socialPageForm(string username)
        {
            InitializeComponent();
            this.username = username;
            userName.Text = this.username;
            DateTime dateToday = DateTime.Now;
            joinDateLabel.Text = dateToday.ToString("dd/MM/yyyy HH:mm") + " | " + userName.Text + " " + "has successfully created an account.";
        }





        private void socialPageForm_Load(object sender, EventArgs e)
        {
            wallTextBox.Text = "Write something...";
            wallTextBox.ForeColor = Color.Gray;
            wallTextBox.Enabled = false;
            this.ActiveControl = null;
            wallTextBox.Enabled = true;

            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;



            // Добавяме всички отделни линии текст(имената) в масив, след което го въртим
            // за да проверим дали съдържа името на потребителя, и ако е така просто го премахваме.
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
        int labelY = 0;
        private void wallTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
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

                DateTime dateToday = DateTime.Now;
                Label message = new Label();
                message.Text = dateToday.ToString("dd/MM/yyyy HH:mm") + " | " + $"{username} changed their profile picture";
                message.AutoSize = true;
                message.Font = new Font("Microsoft Sans Serif", 9);
                message.Location = new Point(0, labelY);
                newPostsPanel.Controls.Add(message);
                labelY += message.Height + 8;
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

                DateTime dateToday = DateTime.Now;
                Label message = new Label();
                message.Text = dateToday.ToString("dd/MM/yyyy HH:mm") + " | " + $"{username} changed their background.";
                message.AutoSize = true;
                message.Font = new Font("Microsoft Sans Serif", 9);
                message.Location = new Point(0, labelY);
                newPostsPanel.Controls.Add(message);
                labelY += message.Height + 8;
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
                yPosition += photo.Height + 10;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(textBoxSearch.Text == "Search for friends..." || textBoxSearch.Text == "")
            {
                return;
            }
            if (!listBoxFriends.Items.Contains(textBoxSearch.Text))
            {
                friendError.Visible = false;
                listBoxFriends.Items.Add(textBoxSearch.Text);
            }
            else
            {
                friendError.Visible = true;
                friendError.Text = $"{textBoxSearch.Text} is a friend.";
               
            }

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
