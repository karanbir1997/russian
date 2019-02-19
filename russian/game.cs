using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace russian
{
    public partial class game : Form
    {
        main main_objet = new main();
        public game()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Load_Click(object sender, EventArgs e)
        {   //this code enables and disables the buttons
            btnspin.Enabled = true;
            btnload.Enabled = false;
            pictureBox2.Visible = true;
            main_objet.loaded = 1;//this code changes the vale of load to 1
            pictureBox2.Image = Image.FromFile(@"C:\Users\karanbir singh\Desktop\russian\load.gif");//this code shows gif
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\karanbir singh\Desktop\russian\load.wav");//this code play sound
            
            
        }

        private void buttonshoot_Click(object sender, EventArgs e)
        {
            {
                pictureBox2.Visible = true;
                pictureBox2.Image = Image.FromFile(@"C:\Users\karanbir singh\Desktop\russian\shoot.gif");//this code is for gif
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\karanbir singh\Desktop\russian\shoot.wav");//this code is for the sound
                player.Play();

                do
                {
                    if (main_objet.shooter == 0 && main_objet.loaded == main_objet.Spinner)//this code runs if shooter=0 and loaded=spinner
                    {
                        MessageBox.Show("winner score = 100");//this code shows message box
                        main_objet.shooter = 3;
                        btnshoot.Enabled = false;
                        btnspin.Enabled = false;
                        btnload.Enabled = false;
                    }
                    else if (main_objet.shooter == 1 && main_objet.loaded == main_objet.Spinner)
                    {
                        MessageBox.Show("winner score = 100");
                        main_objet.shooter = 3;
                        main_objet.restart = main_objet.restart - 1;
                        btnshoot.Enabled = false;
                        btnspin.Enabled = false;
                        btnload.Enabled = false;
                    }
                    else if (main_objet.shooter == 2)
                    {
                        MessageBox.Show("looser");
                        main_objet.shooter = 3;
                        main_objet.restart = main_objet.restart - 1;


                    }
                    else
                    {
                        main_objet.shooter++;
                        main_objet.Spinner = main_objet.spinner(main_objet.Spinner);

                    }
                }
                while (main_objet.shooter <= 2);// this is a do while loop it runs until the value of shooter is <=2

                if (main_objet.restart == 0)
                {
                    btnload.Enabled = false;
                    btnshoot.Enabled = false;
                    btnspin.Enabled = false;
                    main_objet.restart = 2;
                }
                if (main_objet.restart != 0)

                {
                    
                    main_objet.loaded = 0;
                    main_objet.Spinner = 0;
                    main_objet.shooter = 0;
                    main_objet.restart = 2;
                    btnload.Enabled = false;
                    btnspin.Enabled = false;
                }

            }
        }

        private void btnspin_Click(object sender, EventArgs e)
        {
            btnspin.Enabled = false;
            btnshoot.Enabled = true;
            pictureBox2.Visible = true;
            pictureBox2.Image = Image.FromFile(@"C:\Users\karanbir singh\Desktop\russian\spin.gif");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\karanbir singh\Desktop\russian\spin.wav");
            main_objet.Spinner = main_objet.spiner();

            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            (new game()).Show();//this code reset the form
            this.Close();
        }

        private void game_Load(object sender, EventArgs e)
        {
            btnspin.Enabled = false;
            btnshoot.Enabled = false;

        }
    }

}

