using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Assignment1
{
    public partial class Form1 : Form
    {

        Lift lft = new Lift();
        Database db = new Database();
        private Boolean CheckD, CheckF;

        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.Layout;

            SecondBtn.Image = Properties.Resources.Arrow_btn_Down_OFF;
            FirstBtn.Image = Properties.Resources.Arrow_btn_Up_OFF;
            FloorOneBtn.Image = Properties.Resources.Button_1_Off;
            FloorTwoBtn.Image = Properties.Resources.Button_2_Off;
            LogBtn.Image = Properties.Resources.LogBtn;

            SecondPosition.Image = Properties.Resources._1st_Floor;
            SecondMovement.Image = Properties.Resources.Blank;
            SecondDoor.Image = Properties.Resources.DoorClosed;

            FirstPosition.Image = Properties.Resources._1st_Floor;
            FirstMovement.Image = Properties.Resources.Blank;
            FirstDoor.Image = Properties.Resources.DoorClosed;

            LiftPosition.Image = Properties.Resources._1st_Floor;
            LiftMovement.Image = Properties.Resources.Blank;
            LiftDoor.Image = Properties.Resources.DoorClosed;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void FirstBtn_Click(object sender, EventArgs e)
        {
            CheckF = lft.CheckFloor("1");

            if (CheckF == true)
            {
                await Task.Delay(1000);
                OpenDoorFirst();
                OpenLiftDoor();
            }

            else
            {
                CheckD = lft.CheckDoor();

                if (CheckD == true)
                {
                    await Task.Delay(1000);
                    GoDown();
                    await Task.Delay(1500);
                    ToFirstFloor();
                    await Task.Delay(1500);
                    Stop();
                    await Task.Delay(1000);
                    OpenDoorFirst();
                    OpenLiftDoor();
                }

                else
                {
                    await Task.Delay(1000);
                    CloseDoorSecond();
                    CloseLiftDoor();
                    await Task.Delay(1000);
                    GoDown();
                    await Task.Delay(1500);
                    ToFirstFloor();
                    await Task.Delay(1500);
                    Stop();
                    await Task.Delay(1000);
                    OpenDoorFirst();
                    OpenLiftDoor();
                }
            }
        }

        private async void SecondBtn_Click(object sender, EventArgs e)
        {
            CheckF = lft.CheckFloor("2");

            if (CheckF == true)
            {
                await Task.Delay(1000);
                OpenDoorSecond();
                OpenLiftDoor();
            }

            else
            {
                CheckD = lft.CheckDoor();

                if (CheckD == true)
                {
                    await Task.Delay(1000);
                    GoUp();
                    await Task.Delay(1500);
                    ToSecondFloor();
                    await Task.Delay(1500);
                    Stop();
                    await Task.Delay(1000);
                    OpenDoorSecond();
                    OpenLiftDoor();
                }

                else
                {
                    await Task.Delay(1000);
                    CloseDoorFirst();
                    CloseLiftDoor();
                    await Task.Delay(1000);
                    GoUp();
                    await Task.Delay(1500);
                    ToSecondFloor();
                    await Task.Delay(1500);
                    Stop();
                    await Task.Delay(1000);
                    OpenDoorSecond();
                    OpenLiftDoor();
                }
            }
        }

        private async void FloorOneBtn_Click(object sender, EventArgs e)
        {
            CheckF = lft.CheckFloor("1");

            if (CheckF == false)
            {
                await Task.Delay(1000);
                CloseDoorSecond();
                CloseLiftDoor();
                await Task.Delay(1000);
                GoDown();
                await Task.Delay(1500);
                ToFirstFloor();
                await Task.Delay(1500);
                Stop();
                await Task.Delay(1000);
                OpenDoorFirst();
                OpenLiftDoor();
            }

            else
            {
                //You're already in the first floor 
            }
        }

        private async void FloorTwoBtn_Click(object sender, EventArgs e)
        {
            CheckF = lft.CheckFloor("2");

            if (CheckF == false)
            {
                await Task.Delay(1000);
                CloseDoorFirst();
                CloseLiftDoor();
                await Task.Delay(1000);
                GoUp();
                await Task.Delay(1500);
                ToSecondFloor();
                await Task.Delay(1500);
                Stop();
                await Task.Delay(1000);
                OpenDoorSecond();
                OpenLiftDoor();
            }

            else
            {
                //You're already in the first floor 
            }
        }

        

        private void GoDown()
        {
            lft.ChangeMovement();
            this.FirstMovement.Image = Properties.Resources.Arrow_down;
            this.SecondMovement.Image = Properties.Resources.Arrow_down;
            this.LiftMovement.Image = Properties.Resources.Arrow_down;
            db.Log("The Lift started moving down.");
        }

        private void GoUp()
        {
            lft.ChangeMovement();
            this.FirstMovement.Image = Properties.Resources.Arrow_up;
            this.SecondMovement.Image = Properties.Resources.Arrow_up;
            this.LiftMovement.Image = Properties.Resources.Arrow_up;
            db.Log("The Lift started moving up.");
        }

        private void Stop()
        {
            lft.ChangeMovement();
            this.FirstMovement.Image = Properties.Resources.Blank;
            this.SecondMovement.Image = Properties.Resources.Blank;
            this.LiftMovement.Image = Properties.Resources.Blank;
            db.Log("The Lift Stoped.");
        }

        private void ToFirstFloor()
        {
            lft.ChangeFloor();
            this.FirstPosition.Image = Properties.Resources._1st_Floor;
            this.SecondPosition.Image = Properties.Resources._1st_Floor;
            this.LiftPosition.Image = Properties.Resources._1st_Floor;
            db.Log("The Lift arrived at the first floor.");
        }

        private void ToSecondFloor()
        {
            lft.ChangeFloor();
            this.FirstPosition.Image = Properties.Resources._2nd_Floor;
            this.SecondPosition.Image = Properties.Resources._2nd_Floor;
            this.LiftPosition.Image = Properties.Resources._2nd_Floor;
            db.Log("The Lift arrived at the second floor.");
        }

        private void OpenDoorSecond()
        {
            this.SecondDoor.Image = Properties.Resources.DoorOpen;
            db.Log("The door on the second floor is open.");
        }

        private void CloseDoorSecond()
        {
            this.SecondDoor.Image = Properties.Resources.DoorClosed;
            db.Log("The door on the second floor is closed.");
        }

        private void OpenDoorFirst()
        {
            this.FirstDoor.Image = Properties.Resources.DoorOpen;
            db.Log("The door on the first floor is open.");
        }

        private void CloseDoorFirst()
        {
            this.FirstDoor.Image = Properties.Resources.DoorClosed;
            db.Log("The door on the first floor is closed.");
        }

        private void CloseLiftDoor()
        {
            lft.ChangeDoor();
            this.LiftDoor.Image = Properties.Resources.DoorClosed;
            db.Log("The lift door is closed.");
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            Form2 log = new Form2();
            log.ShowDialog();
        }

        private void OpenLiftDoor()
        {
            lft.ChangeDoor();
            this.LiftDoor.Image = Properties.Resources.DoorOpen;
            db.Log("The lift door is open.");
        }
    }
}
