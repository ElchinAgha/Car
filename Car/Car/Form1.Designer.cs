namespace Car
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnDrive = new System.Windows.Forms.Button();
            this.BggCurrentFuel = new Bunifu.Framework.UI.BunifuGauge();
            this.TxtYol = new System.Windows.Forms.TextBox();
            this.TmrDrive = new System.Windows.Forms.Timer(this.components);
            this.BtnBrake = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.bunifuSwitch1 = new Bunifu.Framework.UI.BunifuSwitch();
            this.bunifuSwitch2 = new Bunifu.Framework.UI.BunifuSwitch();
            this.PcbStation = new System.Windows.Forms.PictureBox();
            this.BtnCar = new System.Windows.Forms.PictureBox();
            this.PnlStation = new System.Windows.Forms.Panel();
            this.BtnExitStation = new System.Windows.Forms.Button();
            this.BtnAddFullFuel = new System.Windows.Forms.Button();
            this.BtnAddFuel = new System.Windows.Forms.Button();
            this.LblAddedFuel = new System.Windows.Forms.Label();
            this.TxtAddedFuel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblGbKm = new System.Windows.Forms.Label();
            this.LblLocKm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnLocalKm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PcbStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCar)).BeginInit();
            this.PnlStation.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDrive
            // 
            this.BtnDrive.Location = new System.Drawing.Point(360, 12);
            this.BtnDrive.Name = "BtnDrive";
            this.BtnDrive.Size = new System.Drawing.Size(67, 25);
            this.BtnDrive.TabIndex = 0;
            this.BtnDrive.Text = "Drive";
            this.BtnDrive.UseVisualStyleBackColor = true;
            this.BtnDrive.Click += new System.EventHandler(this.BtnDrive_Click);
            // 
            // BggCurrentFuel
            // 
            this.BggCurrentFuel.BackColor = System.Drawing.Color.Transparent;
            this.BggCurrentFuel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BggCurrentFuel.BackgroundImage")));
            this.BggCurrentFuel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BggCurrentFuel.Location = new System.Drawing.Point(0, 0);
            this.BggCurrentFuel.Margin = new System.Windows.Forms.Padding(6);
            this.BggCurrentFuel.Name = "BggCurrentFuel";
            this.BggCurrentFuel.ProgressBgColor = System.Drawing.Color.Gray;
            this.BggCurrentFuel.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.BggCurrentFuel.ProgressColor2 = System.Drawing.Color.Tomato;
            this.BggCurrentFuel.Size = new System.Drawing.Size(174, 117);
            this.BggCurrentFuel.Suffix = "";
            this.BggCurrentFuel.TabIndex = 2;
            this.BggCurrentFuel.Thickness = 30;
            this.BggCurrentFuel.Value = 25;
            // 
            // TxtYol
            // 
            this.TxtYol.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYol.Location = new System.Drawing.Point(203, 12);
            this.TxtYol.Name = "TxtYol";
            this.TxtYol.Size = new System.Drawing.Size(151, 25);
            this.TxtYol.TabIndex = 4;
            this.TxtYol.Text = "Getmek istediyiniz mesafe";
            this.TxtYol.TextChanged += new System.EventHandler(this.TxtYol_TextChanged);
            this.TxtYol.Enter += new System.EventHandler(this.TxtYol_Enter);
            this.TxtYol.Leave += new System.EventHandler(this.TxtYol_Leave);
            // 
            // TmrDrive
            // 
            this.TmrDrive.Interval = 1;
            this.TmrDrive.Tick += new System.EventHandler(this.TmrDrive_Tick);
            // 
            // BtnBrake
            // 
            this.BtnBrake.Location = new System.Drawing.Point(433, 12);
            this.BtnBrake.Name = "BtnBrake";
            this.BtnBrake.Size = new System.Drawing.Size(67, 25);
            this.BtnBrake.TabIndex = 6;
            this.BtnBrake.Text = "Brake";
            this.BtnBrake.UseVisualStyleBackColor = true;
            this.BtnBrake.Click += new System.EventHandler(this.BtnBrake_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(506, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(67, 25);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "Turn back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // bunifuSwitch1
            // 
            this.bunifuSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch1.BorderRadius = 0;
            this.bunifuSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Location = new System.Drawing.Point(-15, -15);
            this.bunifuSwitch1.Name = "bunifuSwitch1";
            this.bunifuSwitch1.Oncolor = System.Drawing.Color.SeaGreen;
            this.bunifuSwitch1.Onoffcolor = System.Drawing.Color.DarkGray;
            this.bunifuSwitch1.Size = new System.Drawing.Size(51, 19);
            this.bunifuSwitch1.TabIndex = 8;
            this.bunifuSwitch1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Value = true;
            // 
            // bunifuSwitch2
            // 
            this.bunifuSwitch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch2.BorderRadius = 0;
            this.bunifuSwitch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch2.Location = new System.Drawing.Point(-15, -15);
            this.bunifuSwitch2.Name = "bunifuSwitch2";
            this.bunifuSwitch2.Oncolor = System.Drawing.Color.SeaGreen;
            this.bunifuSwitch2.Onoffcolor = System.Drawing.Color.DarkGray;
            this.bunifuSwitch2.Size = new System.Drawing.Size(51, 19);
            this.bunifuSwitch2.TabIndex = 9;
            this.bunifuSwitch2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch2.Value = true;
            // 
            // PcbStation
            // 
            this.PcbStation.BackColor = System.Drawing.Color.Transparent;
            this.PcbStation.Image = ((System.Drawing.Image)(resources.GetObject("PcbStation.Image")));
            this.PcbStation.Location = new System.Drawing.Point(298, 177);
            this.PcbStation.Name = "PcbStation";
            this.PcbStation.Size = new System.Drawing.Size(168, 126);
            this.PcbStation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbStation.TabIndex = 10;
            this.PcbStation.TabStop = false;
            // 
            // BtnCar
            // 
            this.BtnCar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCar.Image")));
            this.BtnCar.Location = new System.Drawing.Point(719, 302);
            this.BtnCar.Name = "BtnCar";
            this.BtnCar.Size = new System.Drawing.Size(176, 115);
            this.BtnCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnCar.TabIndex = 11;
            this.BtnCar.TabStop = false;
            // 
            // PnlStation
            // 
            this.PnlStation.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PnlStation.Controls.Add(this.BtnExitStation);
            this.PnlStation.Controls.Add(this.BtnAddFullFuel);
            this.PnlStation.Controls.Add(this.BtnAddFuel);
            this.PnlStation.Controls.Add(this.LblAddedFuel);
            this.PnlStation.Controls.Add(this.TxtAddedFuel);
            this.PnlStation.Location = new System.Drawing.Point(0, 116);
            this.PnlStation.Name = "PnlStation";
            this.PnlStation.Size = new System.Drawing.Size(174, 326);
            this.PnlStation.TabIndex = 12;
            this.PnlStation.Visible = false;
            // 
            // BtnExitStation
            // 
            this.BtnExitStation.Location = new System.Drawing.Point(33, 195);
            this.BtnExitStation.Name = "BtnExitStation";
            this.BtnExitStation.Size = new System.Drawing.Size(100, 31);
            this.BtnExitStation.TabIndex = 4;
            this.BtnExitStation.Text = "Cix";
            this.BtnExitStation.UseVisualStyleBackColor = true;
            this.BtnExitStation.Click += new System.EventHandler(this.BtnExitStation_Click);
            // 
            // BtnAddFullFuel
            // 
            this.BtnAddFullFuel.Location = new System.Drawing.Point(33, 142);
            this.BtnAddFullFuel.Name = "BtnAddFullFuel";
            this.BtnAddFullFuel.Size = new System.Drawing.Size(100, 32);
            this.BtnAddFullFuel.TabIndex = 3;
            this.BtnAddFullFuel.Text = "Tam doldur";
            this.BtnAddFullFuel.UseVisualStyleBackColor = true;
            this.BtnAddFullFuel.Click += new System.EventHandler(this.BtnAddFullFuel_Click);
            // 
            // BtnAddFuel
            // 
            this.BtnAddFuel.Location = new System.Drawing.Point(33, 93);
            this.BtnAddFuel.Name = "BtnAddFuel";
            this.BtnAddFuel.Size = new System.Drawing.Size(100, 33);
            this.BtnAddFuel.TabIndex = 2;
            this.BtnAddFuel.Text = "Doldur";
            this.BtnAddFuel.UseVisualStyleBackColor = true;
            this.BtnAddFuel.Click += new System.EventHandler(this.BtnAddFuel_Click);
            // 
            // LblAddedFuel
            // 
            this.LblAddedFuel.AutoSize = true;
            this.LblAddedFuel.Location = new System.Drawing.Point(30, 35);
            this.LblAddedFuel.Name = "LblAddedFuel";
            this.LblAddedFuel.Size = new System.Drawing.Size(39, 13);
            this.LblAddedFuel.TabIndex = 1;
            this.LblAddedFuel.Text = "Benzin";
            // 
            // TxtAddedFuel
            // 
            this.TxtAddedFuel.Location = new System.Drawing.Point(33, 51);
            this.TxtAddedFuel.Name = "TxtAddedFuel";
            this.TxtAddedFuel.Size = new System.Drawing.Size(100, 20);
            this.TxtAddedFuel.TabIndex = 0;
            this.TxtAddedFuel.TextChanged += new System.EventHandler(this.TxtAddedFuel_TextChanged);
            this.TxtAddedFuel.Leave += new System.EventHandler(this.TxtAddedFuel_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "LocalKm";
            // 
            // LblGbKm
            // 
            this.LblGbKm.AutoSize = true;
            this.LblGbKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGbKm.Location = new System.Drawing.Point(280, 80);
            this.LblGbKm.Name = "LblGbKm";
            this.LblGbKm.Size = new System.Drawing.Size(16, 18);
            this.LblGbKm.TabIndex = 14;
            this.LblGbKm.Text = "0";
            this.LblGbKm.Click += new System.EventHandler(this.LblGbKm_Click);
            // 
            // LblLocKm
            // 
            this.LblLocKm.AutoSize = true;
            this.LblLocKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocKm.Location = new System.Drawing.Point(280, 53);
            this.LblLocKm.Name = "LblLocKm";
            this.LblLocKm.Size = new System.Drawing.Size(16, 18);
            this.LblLocKm.TabIndex = 15;
            this.LblLocKm.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "GloablKm";
            // 
            // BtnLocalKm
            // 
            this.BtnLocalKm.Location = new System.Drawing.Point(319, 53);
            this.BtnLocalKm.Name = "BtnLocalKm";
            this.BtnLocalKm.Size = new System.Drawing.Size(75, 23);
            this.BtnLocalKm.TabIndex = 17;
            this.BtnLocalKm.Text = "Reset";
            this.BtnLocalKm.UseVisualStyleBackColor = true;
            this.BtnLocalKm.Click += new System.EventHandler(this.BtnLocalKm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 458);
            this.Controls.Add(this.BtnCar);
            this.Controls.Add(this.BtnLocalKm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblLocKm);
            this.Controls.Add(this.LblGbKm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlStation);
            this.Controls.Add(this.PcbStation);
            this.Controls.Add(this.bunifuSwitch2);
            this.Controls.Add(this.bunifuSwitch1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnBrake);
            this.Controls.Add(this.TxtYol);
            this.Controls.Add(this.BggCurrentFuel);
            this.Controls.Add(this.BtnDrive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PcbStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCar)).EndInit();
            this.PnlStation.ResumeLayout(false);
            this.PnlStation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDrive;
        private Bunifu.Framework.UI.BunifuGauge BggCurrentFuel;
        private System.Windows.Forms.TextBox TxtYol;
        private System.Windows.Forms.Timer TmrDrive;
        private System.Windows.Forms.Button BtnBrake;
        private System.Windows.Forms.Button BtnBack;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch1;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch2;
        private System.Windows.Forms.PictureBox PcbStation;
        private System.Windows.Forms.PictureBox BtnCar;
        private System.Windows.Forms.Panel PnlStation;
        private System.Windows.Forms.Button BtnExitStation;
        private System.Windows.Forms.Button BtnAddFullFuel;
        private System.Windows.Forms.Button BtnAddFuel;
        private System.Windows.Forms.Label LblAddedFuel;
        private System.Windows.Forms.TextBox TxtAddedFuel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblGbKm;
        private System.Windows.Forms.Label LblLocKm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnLocalKm;
    }
}

