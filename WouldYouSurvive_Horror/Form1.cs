using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WouldYouSurvive_Horror
{
    public partial class WouldYouSurviveInteractive : Form
    {
        
        

        // Start
        public WouldYouSurviveInteractive()
        {
            InitializeComponent();
            lblSQ.Text = "Welcome foolish mortal! Let us see if you will survive. Are you ready to begin?";
            
        }

        // Death and Survival message methods
        private void Death()
        {
            lblSQ.Text = "Dead As A Doornail. Too bad, you did not survive.";
            button1.Visible = true;
            btnNo.Visible = false; btnYes.Visible = false;
        }
        private void BarelySurvived()
        {
            lblSQ.Text = "Well... You made it. Barely. We will get you next time!";
            button1.Visible = true;
            btnNo.Visible = false; btnYes.Visible = false;
        }
        private void SurvivedInjured()
        {
            lblSQ.Text = "You may be injured, but you survived. Don't worry, the emotional trauma will heal in time. Maybe not as quick as your leg, but still.";
            button1.Visible = true;
            btnNo.Visible = false; btnYes.Visible = false;
        }
        private void Survived()
        {
            lblSQ.Text = "Congratulations! You have survived! You have what it takes to survive a Horrror situation.";
            button1.Visible = true;
            btnNo.Visible = false; btnYes.Visible = false;
        }

       

        // If the user answers yes.
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (lblSQ.Text == "Welcome foolish mortal! Let us see if you will survive. Are you ready to begin?")
            {
                lblSQ.Text = "It is Halloween night, you and some friends decided to break into the old plantation house on Elm Street to tell scary stories in the dark. You and your friends gather in the old, run down sitting room. The only light in the room is coming from the moon shining through the busted window. Looking around, you notice an old fireplace. Your friends state they want to sit in the dark, but you want to start a fire. Do you sit in the dark?";
            }

           else if (lblSQ.Text == "It is Halloween night, you and some friends decided to break into the old plantation house on Elm Street to tell scary stories in the dark. You and your friends gather in the old, run down sitting room. The only light in the room is coming from the moon shining through the busted window. Looking around, you notice an old fireplace. Your friends state they want to sit in the dark, but you want to start a fire. Do you sit in the dark?")
            {
                Death();
            }

            else if (lblSQ.Text == "With the fire lit, you all gather in the center of the aging and rotting room. Forming a circle, you sit. You decide to tell the first story. You are just setting the mood of your story when you hear a knock from behind you. You pause. You shake it off, and continue. All of a sudden there is a loud crashing sound. You jump. Your friends want you to investigate. Do you investigate alone?")
            {
                Death();
            }

            else if (lblSQ.Text == "You and your friends head towards where the sound came from. You all are not entirely sure where it came from, so you and two others go off to the left, while the other three go to the right. You hear a scratching noise from behind a door. You open the door to find a set of stairs, and another door to your left. Do you go upstairs?")
            {
                lblSQ.Text = "You and one other friend slowly make your way upstairs. Your one friend took the door to the left. At the top of the stairs, you look around, noticing old furniture covered with sheets. You move further into the room. Looking around you see something tall towards the back corner covered with a sheet. It looks tall and wide enough to be human. Do you investigate the figure?";
            }

            else if (lblSQ.Text == "You and one other friend slowly make your way upstairs. Your one friend took the door to the left. At the top of the stairs, you look around, noticing old furniture covered with sheets. You move further into the room. Looking around you see something tall towards the back corner covered with a sheet. It looks tall and wide enough to be human. Do you investigate the figure?")
            {
                lblSQ.Text = "You move closer to the figure. You reach out to touch the sheet, but you hesitate. Did you just see it move? Your heart starts to pound. Do you remove the sheet?";
            }

            else if (lblSQ.Text == "You move closer to the figure. You reach out to touch the sheet, but you hesitate. Did you just see it move? Your heart starts to pound. Do you remove the sheet?")
            {
                Death();
            }

            else if (lblSQ.Text == "Your heart is pounding, you start to get nauseous. You and you friend decide to get out of this room as quick as possible. You turn to run. Running down the stairs you here a scream. You run faster. You run outside leaving everyone else inside. Do you continue running?")
            {
                Survived();
            }
        }

        // If the user answers no.
        private void btnNo_Click(object sender, EventArgs e)
        {
            if (lblSQ.Text == "Welcome foolish mortal! Let us see if you will survive. Are you ready to begin?")
            {
                Death();
            }

            else if (lblSQ.Text == "It is Halloween night, you and some friends decided to break into the old plantation house on Elm Street to tell scary stories in the dark. You and your friends gather in the old, run down sitting room. The only light in the room is coming from the moon shining through the busted window. Looking around, you notice an old fireplace. Your friends state they want to sit in the dark, but you want to start a fire. Do you sit in the dark?")
            {
                lblSQ.Text = "With the fire lit, you all gather in the center of the aging and rotting room. Forming a circle, you sit. You decide to tell the first story. You are just setting the mood of your story when you hear a knock from behind you. You pause. You shake it off, and continue. All of a sudden there is a loud crashing sound. You jump. Your friends want you to investigate. Do you investigate alone?";
            }

            else if (lblSQ.Text == "With the fire lit, you all gather in the center of the aging and rotting room. Forming a circle, you sit. You decide to tell the first story. You are just setting the mood of your story when you hear a knock from behind you. You pause. You shake it off, and continue. All of a sudden there is a loud crashing sound. You jump. Your friends want you to investigate. Do you investigate alone?")
            {
                lblSQ.Text = "You and your friends head towards where the sound came from. You all are not entirely sure where it came from, so you and two others go off to the left, while the other three go to the right. You hear a scratching noise from behind a door. You open the door to find a set of stairs, and another door to your left. Do you go upstairs?";
            }

            else if (lblSQ.Text == "You and your friends head towards where the sound came from. You all are not entirely sure where it came from, so you and two others go off to the left, while the other three go to the right. You hear a scratching noise from behind a door. You open the door to find a set of stairs, and another door to your left. Do you go upstairs?")
            {
                BarelySurvived();
            }

            else if (lblSQ.Text == "You and one other friend slowly make your way upstairs. Your one friend took the door to the left. At the top of the stairs, you look around, noticing old furniture covered with sheets. You move further into the room. Looking around you see something tall towards the back corner covered with a sheet. It looks tall and wide enough to be human. Do you investigate the figure?")
            {
                lblSQ.Text = "Your heart is pounding, you start to get nauseous. You and you friend decide to get out of this room as quick as possible. You turn to run. Running down the stairs you here a scream. You run faster. You run outside leaving everyone else inside. Do you continue running?";
            }

            else if (lblSQ.Text == "You move closer to the figure. You reach out to touch the sheet, but you hesitate. Did you just see it move? Your heart starts to pound. Do you remove the sheet?")
            {
                BarelySurvived();
            }

            else if (lblSQ.Text == "Your heart is pounding, you start to get nauseous. You and you friend decide to get out of this room as quick as possible. You turn to run. Running down the stairs you here a scream. You run faster. You run outside leaving everyone else inside. Do you continue running?")
            {
                SurvivedInjured();
            }
        }

        // Restart button
        private void button1_Click(object sender, EventArgs e)
        {
            lblSQ.Text = "Welcome foolish mortal! Let us see if you will survive. Are you ready to begin?";
            button1.Visible = false;
            btnNo.Visible = true; btnYes.Visible = true;
        }
    }
}
