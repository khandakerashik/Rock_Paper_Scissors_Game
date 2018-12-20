using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper_scissors_game
{
    public partial class Form1 : Form
    {
        int wins = 1;
        int losses = 1;
        int count = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Player",150);
            listView1.Columns.Add("Computer", 150);
            listView1.Columns.Add("Winner", 150);          
        }

        //public void addlistview(string player, string Computer, string Winner)       //{
            
        //    string[] row = { player, Computer, Winner };

        //    ListViewItem item = new ListViewItem(row);
        //    listView1.Items.Add(item);
        //}

        private void addplayer(string player)
        {
            //string[] row = { computer };
            ListViewItem item = new ListViewItem(player);
            //item.SubItems.Add(player);
            listView1.Items.Add(item);
        }

        private void addcomputer(string computer)
        {
            //string[] row = { computer };
            ListViewItem item = new ListViewItem(computer);
            //item.SubItems.Add(computer);
            listView1.Items.Add(item);
        }

        private void addwinner(string winner)
        {
            // string[] row = { winner };
            ListViewItem item = new ListViewItem(winner);
            //item.SubItems.Add(winner);
            listView1.Items.Add(item);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string player = listView1.SelectedItems[0].SubItems[0].Text;
            //string computer = listView1.SelectedItems[0].SubItems[1].Text;
            //string winner = listView1.SelectedItems[0].SubItems[2].Text;

            //textBox3.Text = player;
            //textBox4.Text = computer;
            //textBox5.Text = winner;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            //playground(1);
            Random rnd = new Random();
            int enemyselection = rnd.Next(3) + 1;
            //label9.Text = enemyselection.ToString();
            addplayer("Rock");

            if (enemyselection == 1)
            {
                pictureBox4.Visible = true;
                label10.Text = "Match draw";
                addcomputer("Rock");
                addwinner("Draw");
            }
            else if (enemyselection == 2)
            {
                pictureBox5.Visible = true;
                label10.Text = "Computer Win";
                textBox2.Text = losses++.ToString();
                addcomputer("Paper");
                addwinner("Looser");
            }
            else if (enemyselection == 3)
            {
                pictureBox6.Visible = true;
                label10.Text = "Player Win";
                textBox1.Text = wins++.ToString();
                addcomputer("Scissors");
                addwinner("Winner");
            }
            if(count>=5)
            {
                if (wins > losses)
                {
                    MessageBox.Show("Congratulations", "WIN", MessageBoxButtons.OK);
                    this.Close();
                }
                else if (losses > wins)
                {
                    MessageBox.Show("Bad Luck", "LOOSER", MessageBoxButtons.OK);
                    this.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            
            Random rnd = new Random();
            int enemyselection = rnd.Next(3) + 1;
            //label9.Text = enemyselection.ToString();
            addplayer("Paper");

            if (enemyselection == 1)
            {
                pictureBox5.Visible = true;
                label10.Text = "Match draw";
                addcomputer("Paper");
                addwinner("Draw");
            }
            else if (enemyselection == 2)
            {
                pictureBox4.Visible = true;
                label10.Text = "Player Win";
                textBox1.Text= wins++.ToString();
                addcomputer("Rock");
                addwinner("Winner");
            }
            else if (enemyselection == 3)
            {
                pictureBox6.Visible = true;
                label10.Text = "Computer Win";
                textBox2.Text = losses++.ToString();
                addcomputer("Scissors");
                addwinner("Looser");
            }
            if (count >= 5)
            {
                if (wins > losses)
                {
                    MessageBox.Show("Congratulations", "WIN", MessageBoxButtons.OK);
                    this.Close();
                }
                else if (losses > wins)
                {
                    MessageBox.Show("Bad Luck", "LOOSER", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count++;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            
            Random rnd = new Random();
            int enemyselection = rnd.Next(3) + 1;
            //label9.Text = enemyselection.ToString();
            addplayer("Scissors");

            if (enemyselection == 1)
            {
                pictureBox6.Visible = true;
                label10.Text = "Match draw";
                addcomputer("Scissors");
                addwinner("Draw");
            }
            else if (enemyselection == 2)
            {
                pictureBox4.Visible = true;
                label10.Text = "Computer Win";
                textBox2.Text = losses++.ToString();
                addcomputer("Rock");
                addwinner("Losser");
            }
            else if (enemyselection == 3)
            {
                pictureBox5 .Visible = true;
                label10.Text = "Player Win";
                textBox1.Text = wins++.ToString();
                addcomputer("Paper");
                addwinner("Winner");

            }
            if (count >= 5)
            {
                if (wins > losses)
                {
                    MessageBox.Show("Congratulations", "WIN", MessageBoxButtons.OK);
                    this.Close();
                }
                else if (losses > wins)
                {
                    MessageBox.Show("Bad Luck", "LOOSER", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
