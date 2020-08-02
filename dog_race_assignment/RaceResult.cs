using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dog_race_assignment
{
    public class RaceResult
    {
        //this class is used to pass the details and find the winner or looser of the game
        Random run = new Random();
        
        public int jump() {
            return run.Next(1, 59);
        }
        //find the winner and stop the game 
        public int winner(PictureBox pb, int dog,Timer tm) {
            if (pb.Left > 840)
            {
                tm.Enabled = false;
                MessageBox.Show("Dog " + dog + "is winner ");
                return dog;
            }
            else {
                return 0;
            }
        }
        //set the account balance of the player 
        public int Budget(int dog,int amount,int budget,int winnerdog) {
            if (dog == winnerdog)
            {
                budget += amount;
            }
            else
            {
                budget -= amount;

            }
            return budget;
        }

    }
}
