using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Diagnostics;

namespace Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtYol_TextChanged(object sender, EventArgs e)
        {

        }

        private void Car_Click(object sender, EventArgs e)
        {

        }
        double NextLocation;
        bool BtnDriveClicked = false;
        bool BtnBrakeClicked = false;
        bool BtnBackClicked = false;
        double km;
        int i = 0;
        double UncoveredDistance;
        double CoveredDistance;
        double NewGlbKm = 0;
        int MyAddedFuel = 0;
        double NewLclKm = 0;
        double FuelCapacity = 100;
        double FuelUsage = 5;
        double CurrentFuel = 100;
        bool turn = false;


        //===================================================================================
        //Form load section
        //===================================================================================

        private void Form1_Load(object sender, EventArgs e)
        {
            BggCurrentFuel.Value = Convert.ToInt32(CurrentFuel);
            BtnCar.Location = new Point(this.Width - 10-BtnCar.Width, BtnCar.Location.Y);
        
    }


        //===================================================================================
        //BTN-DRIVE CLICK
        //===================================================================================

        private void BtnDrive_Click(object sender, EventArgs e)
        {
            UncoveredDistance = BtnCar.Location.X;
            
            if ((this.CurrentFuel * (100 / this.FuelUsage)) >= km)
            {
                if (UncoveredDistance >= km)
                {
                    NextLocation = UncoveredDistance - km;
                    //MessageBox.Show(NextLocation.ToString());
                    TmrDrive.Enabled = true;
                    BtnBackClicked = false;
                    BtnDriveClicked = true;
                    if (turn)
                    {
                        BtnCar.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                        turn = false;
                    }

                }
                else
                {
                    MessageBox.Show("Getmek istediyiniz mesafe xeriteden kenardadir!");
                }
               /* CurrentFuel -= km * (FuelUsage / 10)*/;
               
                //UncoveredDistance = BtnCar.Location.X - km;
                //BggCurrentFuel.Value = Convert.ToInt32(CurrentFuel);
            }
            else
            {
                MessageBox.Show("Benzininiz kifayet deyil!");
            }
            
             
        }

        //===================================================================================
        //TMR-DRIVE TICK
        //===================================================================================

        private void TmrDrive_Tick(object sender, EventArgs e)
        {
            if (BtnCar.Location.X == PcbStation.Location.X)
            {
                if (i < 1)
                {
                    TmrDrive.Stop();
                    i++;
                    DialogResult dialogResult = MessageBox.Show("Benzin doldurmaq isteyirsiniz?", "Benzin doldurma stansiyasi", MessageBoxButtons.YesNo);
                    i = 1; 

                    if (dialogResult == DialogResult.Yes)
                    {
                        PnlStation.Visible = true;
                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        TmrDrive.Start();
                        
                    }
                    i--;
                }
                
                    


            }
            UncoveredDistance = BtnCar.Location.X;
            CoveredDistance = this.Width - (BtnCar.Location.X+BtnCar.Width);
            if (BtnDriveClicked)
            {
                if (UncoveredDistance!=NextLocation)
                {
                    BtnCar.Location = new Point(BtnCar.Location.X - 1, BtnCar.Location.Y);
                    CurrentFuel -= FuelUsage / 100;
                    BggCurrentFuel.Value = Convert.ToInt32(CurrentFuel);
                    NewGlbKm += 1;
                    NewLclKm += 1;
                    LblLocKm.Text = NewLclKm.ToString();
                    LblGbKm.Text = NewGlbKm.ToString();
                    //CoveredDistance = NewGlbKm;
                }
               
               
            }
            if (BtnBackClicked)
            {

                if (CoveredDistance!=NextLocation)
                {
                    BtnCar.Location = new Point(BtnCar.Location.X+1, BtnCar.Location.Y);
                    CurrentFuel -= FuelUsage / 100;
                    BggCurrentFuel.Value = Convert.ToInt32(CurrentFuel);
                    NewGlbKm += 1;
                    NewLclKm += 1;
                    LblLocKm.Text = NewLclKm.ToString();
                    LblGbKm.Text = NewGlbKm.ToString();
                }
            }

        }

        //===================================================================================
        //TXT-FOCUS ENTER TICK
        //===================================================================================

        private void TxtYol_Enter(object sender, EventArgs e)
        {
            TxtYol.Text = string.Empty;
        }



        //===================================================================================
        //BTN-BRAKE TICK
        //===================================================================================

        private void BtnBrake_Click(object sender, EventArgs e)
        {
            TmrDrive.Enabled = false;
            BtnBrakeClicked = false;
            BtnDriveClicked = false;
        }



        //===================================================================================
        //TURNBACK-BTN CLICK
        //===================================================================================

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //km = Convert.ToDouble(TxtYol.Text);

            if (CurrentFuel * (100 / FuelUsage) > CoveredDistance )
            {
                if (CoveredDistance >= km)
                {
                    NextLocation = CoveredDistance - km;
                    TmrDrive.Start();
                    BtnBackClicked = true;
                    BtnDriveClicked = false;
                    if (!turn)
                    {
                        BtnCar.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                        turn = true;

                    }
                }
                else
                {
                    MessageBox.Show("Getmek istediyiniz yer xeriteden kenardadir!");
                }
               
            }
            else
            {
                MessageBox.Show("Kifayet qeder benzininiz yoxdur!");
            }
           
        }


        //===================================================================================
        //FORM1 RESIZE
        //===================================================================================

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (TmrDrive.Enabled == false)
            {
                BtnCar.Location = new Point(this.Width - 10 - BtnCar.Width, BtnCar.Location.Y);
            }

        }


        //===================================================================================
        //TXT-YOL LEAVE
        //===================================================================================

        private void TxtYol_Leave(object sender, EventArgs e)
        {
             km=0;
            while((!Double.TryParse(TxtYol.Text,out km)) && (!string.IsNullOrEmpty(TxtYol.Text)) )
            {
                MessageBox.Show("Mesafeni duzgun daxil edin!");
                break;
            }
        }


        //===================================================================================
        //ADDFUEL-BTN CLICK
        //===================================================================================

        private void BtnAddFuel_Click(object sender, EventArgs e)
        {
            if (CurrentFuel < FuelCapacity)
            {
                while (!Int32.TryParse(TxtAddedFuel.Text, out MyAddedFuel))
                {
                    MessageBox.Show("Benzin miqdarini dogru daxil edin!");
                    TxtAddedFuel.Text = string.Empty;
                    return;
                }
                if ((CurrentFuel + MyAddedFuel) > FuelCapacity)
                {
                    MessageBox.Show("Bakda max " + (FuelCapacity - CurrentFuel).ToString("#.##") + " litr yer var");
                    TxtAddedFuel.Text = string.Empty;
                }
                else
                {
                    CurrentFuel += MyAddedFuel;
                    BggCurrentFuel.Value = Convert.ToInt32(CurrentFuel);
                }
            }
            else
            {
                MessageBox.Show("Bakda yer yoxdur!");
            }
           

          
        }

        private void TxtAddedFuel_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAddedFuel_Leave(object sender, EventArgs e)
        {
        }

        private void BtnAddFullFuel_Click(object sender, EventArgs e)
        {
            CurrentFuel = FuelCapacity;
            BggCurrentFuel.Value= Convert.ToInt32(CurrentFuel);
        }

        private void BtnExitStation_Click(object sender, EventArgs e)
        {
            PnlStation.Visible = false;
            TmrDrive.Start();
        }

        private void BtnLocalKm_Click(object sender, EventArgs e)
        {
            NewLclKm = 0;
            LblLocKm.Text = 0.ToString();
        }

        private void LblGbKm_Click(object sender, EventArgs e)
        {

        }
    }
}
