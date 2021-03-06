﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Reflection;

namespace RUSSIAN_ROULETTE
{
    public partial class Form1 : Form
    {
        public object PictureBoxMain1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            //coding for sound//
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(RUSSIAN_ROULETTE.Properties.Resources.machine);
            snd.Play();
            //coding for Load button//
            btn_Load.Enabled = false; // Disabling Load button //
            btn_Spin.Enabled = true; // enable the spin button //
            btn_Shoot.Enabled = false; // disable the shoot button //
            btn_Shootaway.Enabled = false;//disable the shootaway button //
            //coding for image//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("RUSSIAN_ROULETTE.Resources.spinpic.jpg");
            Bitmap bmp = new Bitmap(mystream);

            //var bmp = new Bitmap(RUSSIAN_ROULETTE.properties.Resources.spinpic);
            pictureBox1.Image = bmp;
            // Image.FromFile(RUSSIAN_ROULETTE.Resources.spinpic);

        }

        private void Btn_Spin_Click(object sender, EventArgs e)
        {
            //coding for sound//
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(RUSSIAN_ROULETTE.Properties.Resources.spin);
            snd.Play();
            //Coding for Spin button//
            btn_Load.Enabled = false;// disable the load button //
            btn_Spin.Enabled = false;// disable the spin button //
            btn_Shoot.Enabled = true;// enabled the shoot button //
            btn_Shootaway.Enabled = true;// enabled the shootaway //

            //coding for image//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("RUSSIAN_ROULETTE.Resources.gun.jpg");
            Bitmap bmp = new Bitmap(mystream);

            //var bmp = new Bitmap(RUSSIAN_ROULETTE.properties.Resources.gun);
            pictureBox1.Image = bmp;
            // Image.FromFile(RUSSIAN_ROULETTE.Resources.gun);
         
        }

        private void Btn_Shoot_Click(object sender, EventArgs e)

        { //coding for sound//
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(RUSSIAN_ROULETTE.Properties.Resources.shootawaysound);
            snd.Play();

            //coding for Shoot button////
            btn_Load.Enabled = false;// disabled the load button //
            btn_Spin.Enabled = false;// disabled the spin button //
            btn_Shoot.Enabled = true;// enabled the shoot button //
            btn_Shootaway.Enabled = true;//enabled the shootaway button //
            //coding for image//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("RUSSIAN_ROULETTE.Resources.shoot.jpg");
            Bitmap bmp = new Bitmap(mystream);

            //var bmp = new Bitmap(RUSSIAN_ROULETTE.properties.Resources.shoot);
            pictureBox1.Image = bmp;
            MessageBox.Show("you lose the game try next time");
            // Image.FromFile(RUSSIAN_ROULETTE.Resources.shoot);
        }

        private void Btn_Shootaway_Click(object sender, EventArgs e)
        {
            //coding for sound//
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(RUSSIAN_ROULETTE.Properties.Resources.shoot);
            snd.Play();
            //Coding for Shootaway button// 
            btn_Load.Enabled = false;// disabled the load button//
            btn_Spin.Enabled = false;// disabled the spin button//
            btn_Shoot.Enabled = true;// enabled the shoot button//
            btn_Shootaway.Enabled = true;// enabled the shootaway button//


            //coding for image//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("RUSSIAN_ROULETTE.Resources.shootaway.jpg");
            Bitmap bmp = new Bitmap(mystream);

            //var bmp = new Bitmap(RUSSIAN_ROULETTE.properties.Resources.shootaway);
            pictureBox1.Image = bmp;
            MessageBox.Show("you won the game and got 100 points");
            // Image.FromFile(RUSSIAN_ROULETTE.Resources.shootaway);
        }
        
        // coding for Playagain //
        private void Btn_playagain_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            btn_Load.Enabled = true;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = false;
            btn_Shootaway.Enabled = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
             
        }
    }
}
