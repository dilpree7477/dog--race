using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dog_race_assignment
{
    public partial class Form1 : Form
    {

        int sukh = 100,tarsem=100,ranjit=100;
        RaceResult instance_Race = new RaceResult();

        public Form1()
        {
            InitializeComponent();
            //disable the button so thus no one can start the race 
            betRace.Enabled = false;

        }

        private void betRace_Click(object sender, EventArgs e)
        {
            runner.Enabled = true;

        }

        private void runner_Tick(object sender, EventArgs e)
        {
            DogNo1.Left += instance_Race.jump();
            int winnerDog = instance_Race.winner(DogNo1, 1, runner);
            if (winnerDog==1) {
                runner.Enabled = false;
                if (DetailsSukh.Text.Contains("Amount")) {
                    String[] data= DetailsSukh.Text.Split(' ');
                    //DetailsSukh.Text = "Sukh selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    int amount = Convert.ToInt32(data[6]);
                    int dog = Convert.ToInt32(data[3]);
                    sukh = instance_Race.Budget(dog,amount,sukh,winnerDog);
                    DetailsSukh.Text = "Sukh has " + sukh + " Dollar Cash";
                }

                if (DetailsTarsem.Text.Contains("Amount"))
                {
                    String[] data = DetailsTarsem.Text.Split(' ');
                    //DetailsSukh.Text = "Sukh selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    int amount = Convert.ToInt32(data[6]);
                    int dog = Convert.ToInt32(data[3]);
                    tarsem = instance_Race.Budget(dog, amount, tarsem, winnerDog);
                    DetailsTarsem.Text = "Tarsem has " + tarsem + " Dollar Cash";
                }

                if (DetailsRanjit.Text.Contains("Amount"))
                {
                    String[] data = DetailsRanjit.Text.Split(' ');
                    //DetailsSukh.Text = "Sukh selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    int amount = Convert.ToInt32(data[6]);
                    int dog = Convert.ToInt32(data[3]);
                    ranjit = instance_Race.Budget(dog, amount, ranjit, winnerDog);
                    DetailsRanjit.Text = "Ranjit has " + ranjit + " Dollar Cash";
                }

                Restart();




            }

            DogNo2.Left += instance_Race.jump();
            winnerDog = instance_Race.winner(DogNo2, 2, runner);
            if (winnerDog ==2)
            {
                runner.Enabled = false;
                if (DetailsSukh.Text.Contains("Amount"))
                {
                    String[] data = DetailsSukh.Text.Split(' ');
                    //DetailsSukh.Text = "Sukh selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    int amount = Convert.ToInt32(data[6]);
                    int dog = Convert.ToInt32(data[3]);
                    sukh = instance_Race.Budget(dog, amount, sukh, winnerDog);
                    DetailsSukh.Text = "Sukh has " + sukh + " Dollar Cash";
                }

                if (DetailsTarsem.Text.Contains("Amount"))
                {
                    String[] data = DetailsTarsem.Text.Split(' ');
                    //DetailsSukh.Text = "Sukh selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    int amount = Convert.ToInt32(data[6]);
                    int dog = Convert.ToInt32(data[3]);
                    tarsem = instance_Race.Budget(dog, amount, tarsem, winnerDog);
                    DetailsTarsem.Text = "Tarsem has " + tarsem + " Dollar Cash";
                }

                if (DetailsRanjit.Text.Contains("Amount"))
                {
                    String[] data = DetailsRanjit.Text.Split(' ');
                    //DetailsSukh.Text = "Sukh selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    int amount = Convert.ToInt32(data[6]);
                    int dog = Convert.ToInt32(data[3]);
                    ranjit = instance_Race.Budget(dog, amount, ranjit, winnerDog);
                    DetailsRanjit.Text = "Ranjit has " + ranjit + " Dollar Cash";
                }

                Restart();

            }

            DogNo3.Left += instance_Race.jump();
             winnerDog = instance_Race.winner(DogNo3, 3, runner);
            if (winnerDog==3)
            {
                runner.Enabled = false;
                if (DetailsSukh.Text.Contains("Amount"))
                {
                    String[] data = DetailsSukh.Text.Split(' ');
                    //DetailsSukh.Text = "Sukh selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    int amount = Convert.ToInt32(data[6]);
                    int dog = Convert.ToInt32(data[3]);
                    sukh = instance_Race.Budget(dog, amount, sukh, winnerDog);
                    DetailsSukh.Text = "Sukh has " + sukh + " Dollar Cash";
                }

                if (DetailsTarsem.Text.Contains("Amount"))
                {
                    String[] data = DetailsTarsem.Text.Split(' ');
                    //DetailsSukh.Text = "Sukh selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    int amount = Convert.ToInt32(data[6]);
                    int dog = Convert.ToInt32(data[3]);
                    tarsem = instance_Race.Budget(dog, amount, tarsem, winnerDog);
                    DetailsTarsem.Text = "Tarsem has " + tarsem + " Dollar Cash";
                }

                if (DetailsRanjit.Text.Contains("Amount"))
                {
                    String[] data = DetailsRanjit.Text.Split(' ');
                    //DetailsSukh.Text = "Sukh selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    int amount = Convert.ToInt32(data[6]);
                    int dog = Convert.ToInt32(data[3]);
                    ranjit = instance_Race.Budget(dog, amount, ranjit, winnerDog);
                    DetailsRanjit.Text = "Ranjit has " + ranjit + " Dollar Cash";
                }

                Restart();

            }





            DogNo4.Left += instance_Race.jump();
             winnerDog = instance_Race.winner(DogNo4, 4, runner);
            if (winnerDog==4)
            {
                runner.Enabled = false;
                if (DetailsSukh.Text.Contains("Amount"))
                {
                    String[] data = DetailsSukh.Text.Split(' ');
                    //DetailsSukh.Text = "Sukh selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    int amount = Convert.ToInt32(data[6]);
                    int dog = Convert.ToInt32(data[3]);
                    sukh = instance_Race.Budget(dog, amount, sukh, winnerDog);
                    DetailsSukh.Text = "Sukh has " + sukh + " Dollar Cash";
                }

                if (DetailsTarsem.Text.Contains("Amount"))
                {
                    String[] data = DetailsTarsem.Text.Split(' ');
                    //DetailsSukh.Text = "Sukh selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    int amount = Convert.ToInt32(data[6]);
                    int dog = Convert.ToInt32(data[3]);
                    tarsem = instance_Race.Budget(dog, amount, tarsem, winnerDog);
                    DetailsTarsem.Text = "Tarsem has " + tarsem + " Dollar Cash";
                }

                if (DetailsRanjit.Text.Contains("Amount"))
                {
                    String[] data = DetailsRanjit.Text.Split(' ');
                    //DetailsSukh.Text = "Sukh selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    int amount = Convert.ToInt32(data[6]);
                    int dog = Convert.ToInt32(data[3]);
                    ranjit = instance_Race.Budget(dog, amount, ranjit, winnerDog);
                    DetailsRanjit.Text = "Ranjit has " + ranjit + " Dollar Cash";
                }

                Restart();


            }


        }


        public void Restart() {
            ComboAmount.Text = "";
            ComboPlayer.Text = "";
            ComboDog.Text = "";
            betRace.Enabled = false;
            DogNo1.Left = 261;
            DogNo2.Left = 261;
            DogNo3.Left = 261;
            DogNo4.Left = 261;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            //first select the dog 
            if (ComboPlayer.Text.Equals(""))
            {
                MessageBox.Show("If we want to play then we must select the player ");
            }
            
                // after selecting the player we must select the dog 
           else if (ComboDog.Text.Equals(""))
           {
                    MessageBox.Show("You must have to select  the dog ");
           }
            else if (ComboAmount.Text.Equals("")) {

                MessageBox.Show("You must select the bet amount ");
            }

            if (ComboPlayer.Text.Equals("") && ComboDog.Text.Equals("") && ComboAmount.Text.Equals("")) {
                MessageBox.Show("you must follow the rules to play the game ");        
            }

            if (!ComboPlayer.Text.Equals("") && !ComboDog.Text.Equals("") && !ComboAmount.Text.Equals("")) {
                //we must set the figure 
                if (ComboPlayer.SelectedIndex == 0 && Convert.ToInt32(ComboAmount.Text) <= sukh)
                {
                    DetailsSukh.Text = "Sukh selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    betRace.Enabled = true;
                }
                else if (ComboPlayer.SelectedIndex == 1 && Convert.ToInt32(ComboAmount.Text) <= tarsem)
                {
                    DetailsTarsem.Text = "Tarsem selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    betRace.Enabled = true;
                }
                else if (ComboPlayer.SelectedIndex == 2 && Convert.ToInt32(ComboAmount.Text) <= ranjit)
                {
                    DetailsRanjit.Text = "Ranjit selected Dog " + ComboDog.SelectedItem.ToString() + " and Amount " + ComboAmount.SelectedItem.ToString();
                    betRace.Enabled = true;
                }
                else {
                    MessageBox.Show("Bet Amount must be less than or eqaul to budget ");
                }
            }

        }
    }
}
