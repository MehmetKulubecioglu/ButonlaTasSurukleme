using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        private int sayac = 0;
        private int anatassatır = 0;
        private int anatassutun = 0;
        private int satır = 0;
        private int sutun = 0;
        private int toplamsatır = 0;
        private int toplamsutun = 0;
        private int tas1 = 0;
        private int tas2 = 0;
        private int tas3 = 0;
        private int tas4 = 0;
        private int tas5 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button88.Text = "X";
                sayac++;
                anatassatır = 8;
                anatassutun = 8;
            }



           else if (sayac < 6 && sayac > 0)
           {
                satır = 8;
                sutun = 8;
                if (anatassatır > satır)
                        toplamsatır = anatassatır - satır;
           else if (satır > anatassatır)
                        toplamsatır = satır - anatassatır;
              else
                        toplamsatır = 0;


                if (anatassutun > sutun)
                     toplamsutun = anatassutun - sutun;
               else if (sutun > anatassutun)
                     toplamsutun = sutun - anatassutun;
               else
                     toplamsutun = 0;


                    if (sayac == 1)
                    {
                        tas1 = toplamsatır + toplamsutun;
                        button88.Text = tas1.ToString();
                    }
                    else if (sayac==2)
                    {
                        tas2 = toplamsatır + toplamsutun;
                        button88.Text = tas2.ToString();
                    }
                    else if (sayac == 3)
                    {
                         tas3 = toplamsatır + toplamsutun;
                         button88.Text = tas3.ToString();
                    }
                    else if (sayac == 4)
                    {
                        tas4 = toplamsatır + toplamsutun;
                        button88.Text = tas4.ToString();
                    }
                    else if (sayac == 5)
                    {
                        tas5 = toplamsatır + toplamsutun;
                        button88.Text = tas5.ToString();
                    }

                sayac++;
           }

            if (sayac == 6 && button88.Text != "X")
            {
                if (button87.Text != "" && button87.Text!="X")
                {
                    int a = Convert.ToInt32(button87.Text);
                    a--;
                    if(a==0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button88.Text = a.ToString();
                    button87.Text = "";
                }
                else if (button78.Text != "" && button78.Text != "X")
                {
                    int a = Convert.ToInt32(button78.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button88.Text = a.ToString();
                    button78.Text = "";
                }

            }
            else if (sayac == 6 && button88.Text == "X")
            {
                if (button87.Text != "")
                {
                    button87.Text = "";
                }
                else if (button78.Text != "")
                {
                    button78.Text = "";
                }

            }




        }

        private void button87_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button87.Text = "X";
                sayac++;
                anatassatır = 8;
                anatassutun = 7;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 8;
                sutun = 7;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button87.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button87.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button87.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button87.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button87.Text = tas5.ToString();
                }

                sayac++;
            }


            if (sayac == 6 && button87.Text!="X")
            {
                if(button88.Text!= "" && button88.Text != "X")
                {
                    int a= Convert.ToInt32(button88.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button87.Text = a.ToString();
                    button88.Text = "";
                }
                else if (button86.Text != "" && button86.Text != "X")
                {
                    int a = Convert.ToInt32(button86.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button87.Text = a.ToString();
                    button86.Text = "";
                }
                else if(button77.Text != "" && button77.Text != "X")
                {
                    int a = Convert.ToInt32(button77.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button87.Text = a.ToString();
                    button77.Text = "";
                }
            }
            else if(sayac==6 && button87.Text=="X")
            {
                if (button88.Text != "")
                {
                    button88.Text = "";
                }
                else if (button86.Text != "")
                {
                    button86.Text = "";
                }
                else if (button77.Text != "")
                {
                    button77.Text = "";
                }
            }

        }

        private void button86_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button86.Text = "X";
                sayac++;
                anatassatır = 8;
                anatassutun = 6;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 8;
                sutun = 6;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button86.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button86.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button86.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button86.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button86.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button86.Text != "X")
            {
                if (button87.Text != "" && button87.Text!="X")
                {
                    int a = Convert.ToInt32(button87.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button86.Text = a.ToString();
                    button87.Text = "";
                }
                else if (button76.Text != "" && button76.Text != "X")
                {
                    int a = Convert.ToInt32(button76.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button86.Text = a.ToString();
                    button76.Text = "";
                }
                else if (button85.Text != "" && button85.Text != "X")
                {
                    int a = Convert.ToInt32(button85.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button86.Text = a.ToString();
                    button85.Text = "";
                }
            }
            else if (sayac == 6 && button86.Text == "X")
            {
                if (button87.Text != "")
                {
                    button87.Text = "";
                }
                else if (button76.Text != "")
                {
                    button76.Text = "";
                }
                else if (button85.Text != "")
                {
                    button85.Text = "";
                }
            }

        }

        private void button85_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button85.Text = "X";
                sayac++;
                anatassatır = 8;
                anatassutun = 5;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 8;
                sutun = 5;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button85.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button85.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button85.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button85.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button85.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button85.Text != "X")
            {
                if (button86.Text != "" && button86.Text != "X")
                {
                    int a = Convert.ToInt32(button86.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button85.Text = a.ToString();
                    button86.Text = "";
                }
                else if (button84.Text != "" && button84.Text != "X")
                {
                    int a = Convert.ToInt32(button84.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button85.Text = a.ToString();
                    button84.Text = "";
                }
                else if (button75.Text != "" && button75.Text != "X")
                {
                    int a = Convert.ToInt32(button75.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button85.Text = a.ToString();
                    button75.Text = "";
                }

            }
            else if (sayac == 6 && button85.Text == "X")
            {
                if (button86.Text != "")
                {
                    button86.Text = "";
                }
                else if (button84.Text != "")
                {
                    button84.Text = "";
                }
                else if (button75.Text != "")
                {
                    button75.Text = "";
                }

            }

        }

        private void button84_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button84.Text = "X";
                sayac++;
                anatassatır = 8;
                anatassutun = 4;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 8;
                sutun = 4;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button84.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button84.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button84.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button84.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button84.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button84.Text != "X")
            {
                if (button85.Text != "" && button85.Text != "X")
                {
                    int a = Convert.ToInt32(button85.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button84.Text = a.ToString();
                    button85.Text = "";
                }
                else if (button83.Text != "" && button83.Text != "X")
                {
                    int a = Convert.ToInt32(button83.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button84.Text = a.ToString();
                    button83.Text = "";
                }
                else if (button74.Text != "" && button74.Text != "X")
                {
                    int a = Convert.ToInt32(button74.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button84.Text = a.ToString();
                    button74.Text = "";
                }

            }
            else if (sayac == 6 && button84.Text == "X")
            {
                if (button85.Text != "")
                {
                    button85.Text = "";
                }
                else if (button83.Text != "")
                {
                    button83.Text = "";
                }
                else if (button74.Text != "")
                {
                    button74.Text = "";
                }

            }


        }

        private void button83_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button83.Text = "X";
                sayac++;
                anatassatır = 8;
                anatassutun = 3;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 8;
                sutun = 3;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button83.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button83.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button83.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button83.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button83.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button83.Text != "X")
            {
                if (button84.Text != "" && button84.Text != "X")
                {
                    int a = Convert.ToInt32(button84.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button83.Text = a.ToString();
                    button84.Text = "";
                }
                else if (button82.Text != "" && button82.Text != "X")
                {
                    int a = Convert.ToInt32(button82.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button83.Text = a.ToString();
                    button82.Text = "";
                }
                else if (button73.Text != "" && button73.Text != "X")
                {
                    int a = Convert.ToInt32(button73.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button83.Text = a.ToString();
                    button73.Text = "";
                }

            }
            else if (sayac == 6 && button83.Text == "X")
            {
                if (button84.Text != "")
                {
                    button84.Text = "";
                }
                else if (button82.Text != "")
                {
                    button82.Text = "";
                }
                else if (button73.Text != "")
                {
                    button73.Text = "";
                }

            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button82.Text = "X";
                sayac++;
                anatassatır = 8;
                anatassutun = 2;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 8;
                sutun = 2;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button82.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button82.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button82.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button82.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button82.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button82.Text != "X")
            {
                if (button83.Text != "" && button83.Text != "X")
                {
                    int a = Convert.ToInt32(button83.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button82.Text = a.ToString();
                    button83.Text = "";
                }
                else if (button81.Text != "" && button81.Text != "X")
                {
                    int a = Convert.ToInt32(button81.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button82.Text = a.ToString();
                    button81.Text = "";
                }
                else if (button72.Text != "" && button72.Text != "X")
                {
                    int a = Convert.ToInt32(button72.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button82.Text = a.ToString();
                    button72.Text = "";
                }

            }
            else if (sayac == 6 && button82.Text == "X")
            {
                if (button83.Text != "")
                {
                    button83.Text = "";
                }
                else if (button81.Text != "")
                {
                    button81.Text = "";
                }
                else if (button72.Text != "")
                {
                    button72.Text = "";
                }

            }

        }

        private void button81_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button81.Text = "X";
                sayac++;
                anatassatır = 8;
                anatassutun = 1;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 8;
                sutun = 1;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button81.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button81.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button81.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button81.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button81.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button81.Text != "X")
            {
                if (button82.Text != "" && button82.Text != "X")
                {
                    int a = Convert.ToInt32(button82.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button81.Text = a.ToString();
                    button82.Text = "";
                }

                else if (button71.Text != "" && button71.Text != "X")
                {
                    int a = Convert.ToInt32(button71.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button81.Text = a.ToString();
                    button71.Text = "";
                }

            }
            else if (sayac == 6 && button81.Text == "X")
            {
                if (button82.Text != "")
                {
                    button82.Text = "";
                }

                else if (button71.Text != "")
                {
                    button71.Text = "";
                }

            }

        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button78.Text = "X";
                sayac++;
                anatassatır = 7;
                anatassutun = 8;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 7;
                sutun = 8;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button78.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button78.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button78.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button78.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button78.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button78.Text != "X")
            {
                if (button88.Text != "" && button88.Text != "X")
                {
                    int a = Convert.ToInt32(button88.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button78.Text = a.ToString();
                    button88.Text = "";
                }
                else if (button77.Text != "" && button77.Text != "X")
                {
                    int a = Convert.ToInt32(button77.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button78.Text = a.ToString();
                    button77.Text = "";
                }
                else if (button68.Text != "" && button68.Text != "X")
                {
                    int a = Convert.ToInt32(button68.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button78.Text = a.ToString();
                    button68.Text = "";
                }

            }
            else if (sayac == 6 && button78.Text == "X")
            {
                if (button88.Text != "")
                {
                    button88.Text = "";
                }
                else if (button77.Text != "")
                {
                    button77.Text = "";
                }
                else if (button68.Text != "")
                {
                    button68.Text = "";
                }

            }

        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button77.Text = "X";
                sayac++;
                anatassatır = 7;
                anatassutun = 7;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 7;
                sutun = 7;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button77.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button77.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button77.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button77.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button77.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button77.Text != "X")
            {
                if (button87.Text != "" && button87.Text != "X")
                {
                    int a = Convert.ToInt32(button87.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button77.Text = a.ToString();
                    button87.Text = "";
                }
                else if (button76.Text != "" && button76.Text != "X")
                {
                    int a = Convert.ToInt32(button76.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button77.Text = a.ToString();
                    button76.Text = "";
                }

                else if (button67.Text != "" && button67.Text != "X")
                {
                    int a = Convert.ToInt32(button67.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button77.Text = a.ToString();
                    button67.Text = "";
                }
                else if (button87.Text != "" && button87.Text != "X")
                {
                    int a = Convert.ToInt32(button87.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button77.Text = a.ToString();
                    button87.Text = "";
                }

            }
            else if (sayac == 6 && button77.Text == "X")
            {
                if (button87.Text != "")
                {
                    button87.Text = "";
                }
                else if (button76.Text != "")
                {
                    button76.Text = "";
                }
                else if (button67.Text != "")
                {
                    button67.Text = "";
                }
                else if (button87.Text != "")
                {
                    button87.Text = "";
                }

            }

        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button76.Text = "X";
                sayac++;
                anatassatır = 7;
                anatassutun = 6;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 7;
                sutun = 6;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button76.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button76.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button76.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button76.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button76.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button76.Text != "X")
            {
                if (button77.Text != "" && button77.Text != "X")
                {
                    int a = Convert.ToInt32(button77.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button76.Text = a.ToString();
                    button77.Text = "";
                }
                else if (button75.Text != "" && button75.Text != "X")
                {
                    int a = Convert.ToInt32(button75.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button76.Text = a.ToString();
                    button75.Text = "";
                }

                else if (button66.Text != "" && button66.Text != "X")
                {
                    int a = Convert.ToInt32(button66.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button76.Text = a.ToString();
                    button66.Text = "";
                }
                else if (button86.Text != "" && button86.Text != "X")
                {
                    int a = Convert.ToInt32(button86.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button76.Text = a.ToString();
                    button86.Text = "";
                }

            }
            else if (sayac == 6 && button76.Text == "X")
            {
                if (button77.Text != "")
                {
                    button77.Text = "";
                }
                else if (button75.Text != "")
                {
                    button75.Text = "";
                }
                else if (button66.Text != "")
                {
                    button66.Text = "";
                }
                else if (button86.Text != "")
                {
                    button86.Text = "";
                }

            }

        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button75.Text = "X";
                sayac++;
                anatassatır = 7;
                anatassutun = 5;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 7;
                sutun = 5;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button75.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button75.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button75.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button75.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button75.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button75.Text != "X")
            {
                if (button76.Text != "" && button76.Text != "X")
                {
                    int a = Convert.ToInt32(button76.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button75.Text = a.ToString();
                    button76.Text = "";
                }
                else if (button74.Text != "" && button74.Text != "X")
                {
                    int a = Convert.ToInt32(button74.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button75.Text = a.ToString();
                    button74.Text = "";
                }

                else if (button65.Text != "" && button65.Text != "X")
                {
                    int a = Convert.ToInt32(button65.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button75.Text = a.ToString();
                    button65.Text = "";
                }
                else if (button85.Text != "" && button85.Text != "X")
                {
                    int a = Convert.ToInt32(button85.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button75.Text = a.ToString();
                    button85.Text = "";
                }

            }
            else if (sayac == 6 && button75.Text == "X")
            {
                if (button76.Text != "")
                {
                    button76.Text = "";
                }
                else if (button74.Text != "")
                {
                    button74.Text = "";
                }
                else if (button65.Text != "")
                {
                    button65.Text = "";
                }
                else if (button85.Text != "")
                {
                    button85.Text = "";
                }

            }

        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button74.Text = "X";
                sayac++;
                anatassatır = 7;
                anatassutun = 4;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 7;
                sutun = 4;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button74.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button74.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button74.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button74.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button74.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button74.Text != "X")
            {
                if (button75.Text != "" && button75.Text != "X")
                {
                    int a = Convert.ToInt32(button75.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button74.Text = a.ToString();
                    button75.Text = "";
                }
                else if (button73.Text != "" && button73.Text != "X")
                {
                    int a = Convert.ToInt32(button73.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button74.Text = a.ToString();
                    button73.Text = "";
                }

                else if (button64.Text != "" && button64.Text != "X")
                {
                    int a = Convert.ToInt32(button64.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button74.Text = a.ToString();
                    button64.Text = "";
                }
                else if (button84.Text != "" && button84.Text != "X")
                {
                    int a = Convert.ToInt32(button84.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button74.Text = a.ToString();
                    button84.Text = "";
                }

            }
            else if (sayac == 6 && button74.Text == "X")
            {
                if (button75.Text != "")
                {
                    button75.Text = "";
                }
                else if (button73.Text != "")
                {
                    button73.Text = "";
                }
                else if (button64.Text != "")
                {
                    button64.Text = "";
                }
                else if (button84.Text != "")
                {
                    button84.Text = "";
                }

            }

        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button73.Text = "X";
                sayac++;
                anatassatır = 7;
                anatassutun = 3;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 7;
                sutun = 3;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button73.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button73.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button73.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button73.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button73.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button73.Text != "X")
            {
                if (button74.Text != "" && button74.Text != "X")
                {
                    int a = Convert.ToInt32(button74.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button73.Text = a.ToString();
                    button74.Text = "";
                }
                else if (button72.Text != "" && button72.Text != "X")
                {
                    int a = Convert.ToInt32(button72.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button73.Text = a.ToString();
                    button72.Text = "";
                }

                else if (button63.Text != "" && button63.Text != "X")
                {
                    int a = Convert.ToInt32(button63.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button73.Text = a.ToString();
                    button63.Text = "";
                }
                else if (button83.Text != "" && button83.Text != "X")
                {
                    int a = Convert.ToInt32(button83.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button73.Text = a.ToString();
                    button83.Text = "";
                }

            }
            else if (sayac == 6 && button73.Text == "X")
            {
                if (button74.Text != "")
                {
                    button74.Text = "";
                }
                else if (button72.Text != "")
                {
                    button72.Text = "";
                }
                else if (button63.Text != "")
                {
                    button63.Text = "";
                }
                else if (button83.Text != "")
                {
                    button83.Text = "";
                }

            }


        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button72.Text = "X";
                sayac++;
                anatassatır = 7;
                anatassutun = 2;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 7;
                sutun = 2;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button72.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button72.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button72.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button72.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button72.Text = tas5.ToString();
                }

                sayac++;
            }


            if (sayac == 6 && button72.Text != "X")
            {
                if (button73.Text != "" && button73.Text != "X")
                {
                    int a = Convert.ToInt32(button73.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button72.Text = a.ToString();
                    button73.Text = "";
                }
                else if (button71.Text != "" && button71.Text != "X")
                {
                    int a = Convert.ToInt32(button71.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button72.Text = a.ToString();
                    button71.Text = "";
                }

                else if (button62.Text != "" && button62.Text != "X")
                {
                    int a = Convert.ToInt32(button62.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button72.Text = a.ToString();
                    button62.Text = "";
                }
                else if (button82.Text != "" && button82.Text != "X")
                {
                    int a = Convert.ToInt32(button82.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button72.Text = a.ToString();
                    button82.Text = "";
                }

            }
            else if (sayac == 6 && button72.Text == "X")
            {
                if (button73.Text != "")
                {
                    button73.Text = "";
                }
                else if (button71.Text != "")
                {
                    button71.Text = "";
                }
                else if (button62.Text != "")
                {
                    button62.Text = "";
                }
                else if (button82.Text != "")
                {
                    button82.Text = "";
                }

            }

        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button71.Text = "X";
                sayac++;
                anatassatır = 7;
                anatassutun = 1;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 7;
                sutun = 1;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button71.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button71.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button71.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button71.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button71.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button71.Text != "X")
            {

                if (button72.Text != "" && button72.Text != "X")
                {
                    int a = Convert.ToInt32(button72.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button71.Text = a.ToString();
                    button72.Text = "";
                }

                else if (button61.Text != "" && button61.Text != "X")
                {
                    int a = Convert.ToInt32(button61.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button71.Text = a.ToString();
                    button61.Text = "";
                }
                else if (button81.Text != "" && button81.Text != "X")
                {
                    int a = Convert.ToInt32(button81.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button71.Text = a.ToString();
                    button81.Text = "";
                }

            }
            else if (sayac == 6 && button71.Text == "X")
            {

                if (button72.Text != "")
                {
                    button72.Text = "";
                }
                else if (button61.Text != "")
                {
                    button61.Text = "";
                }
                else if (button81.Text != "")
                {
                    button81.Text = "";
                }

            }

        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button68.Text = "X";
                sayac++;
                anatassatır = 6;
                anatassutun = 8;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 6;
                sutun = 8;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button68.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button68.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button68.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button68.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button68.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button68.Text != "X")
            {
                if (button67.Text != "" && button67.Text != "X")
                {
                    int a = Convert.ToInt32(button67.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button68.Text = a.ToString();
                    button67.Text = "";
                }


                else if (button58.Text != "" && button58.Text != "X")
                {
                    int a = Convert.ToInt32(button58.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button68.Text = a.ToString();
                    button58.Text = "";
                }
                else if (button78.Text != "" && button78.Text != "X")
                {
                    int a = Convert.ToInt32(button78.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button68.Text = a.ToString();
                    button78.Text = "";
                }

            }
            else if (sayac == 6 && button68.Text == "X")
            {
                if (button67.Text != "")
                {
                    button67.Text = "";
                }

                else if (button58.Text != "")
                {
                    button58.Text = "";
                }
                else if (button78.Text != "")
                {
                    button78.Text = "";
                }

            }

        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button67.Text = "X";
                sayac++;
                anatassatır = 6;
                anatassutun = 7;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 6;
                sutun = 7;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button67.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button67.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button67.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button67.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button67.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button67.Text != "X")
            {
                if (button68.Text != "" && button68.Text != "X")
                {
                    int a = Convert.ToInt32(button68.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button67.Text = a.ToString();
                    button68.Text = "";
                }
                else if (button66.Text != "" && button66.Text != "X")
                {
                    int a = Convert.ToInt32(button66.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button67.Text = a.ToString();
                    button66.Text = "";
                }

                else if (button57.Text != "" && button57.Text != "X")
                {
                    int a = Convert.ToInt32(button57.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button67.Text = a.ToString();
                    button57.Text = "";
                }
                else if (button77.Text != "" && button77.Text != "X")
                {
                    int a = Convert.ToInt32(button77.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button67.Text = a.ToString();
                    button77.Text = "";
                }

            }
            else if (sayac == 6 && button67.Text == "X")
            {
                if (button68.Text != "")
                {
                    button68.Text = "";
                }
                else if (button66.Text != "")
                {
                    button66.Text = "";
                }
                else if (button57.Text != "")
                {
                    button57.Text = "";
                }
                else if (button77.Text != "")
                {
                    button77.Text = "";
                }

            }

        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button66.Text = "X";
                sayac++;
                anatassatır = 6;
                anatassutun = 6;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 6;
                sutun = 6;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button66.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button66.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button66.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button66.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button66.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button66.Text != "X")
            {
                if (button67.Text != "" && button67.Text != "X")
                {
                    int a = Convert.ToInt32(button67.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button66.Text = a.ToString();
                    button67.Text = "";
                }
                else if (button65.Text != "" && button65.Text != "X")
                {
                    int a = Convert.ToInt32(button65.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button66.Text = a.ToString();
                    button65.Text = "";
                }

                else if (button56.Text != "" && button56.Text != "X")
                {
                    int a = Convert.ToInt32(button56.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button66.Text = a.ToString();
                    button56.Text = "";
                }
                else if (button76.Text != "" && button76.Text != "X")
                {
                    int a = Convert.ToInt32(button76.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button66.Text = a.ToString();
                    button76.Text = "";
                }

            }
            else if (sayac == 6 && button66.Text == "X")
            {
                if (button67.Text != "")
                {
                    button67.Text = "";
                }
                else if (button65.Text != "")
                {
                    button65.Text = "";
                }
                else if (button56.Text != "")
                {
                    button56.Text = "";
                }
                else if (button76.Text != "")
                {
                    button76.Text = "";
                }

            }

        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button65.Text = "X";
                sayac++;
                anatassatır = 6;
                anatassutun = 5;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 6;
                sutun = 5;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button65.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button65.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button65.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button65.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button65.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button65.Text != "X")
            {
                if (button66.Text != "" && button66.Text != "X")
                {
                    int a = Convert.ToInt32(button66.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button65.Text = a.ToString();
                    button66.Text = "";
                }
                else if (button64.Text != "" && button64.Text != "X")
                {
                    int a = Convert.ToInt32(button64.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button65.Text = a.ToString();
                    button64.Text = "";
                }

                else if (button55.Text != "" && button55.Text != "X")
                {
                    int a = Convert.ToInt32(button55.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button65.Text = a.ToString();
                    button55.Text = "";
                }
                else if (button75.Text != "" && button75.Text != "X")
                {
                    int a = Convert.ToInt32(button75.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button65.Text = a.ToString();
                    button75.Text = "";
                }

            }
            else if (sayac == 6 && button65.Text == "X")
            {
                if (button64.Text != "")
                {
                    button64.Text = "";
                }
                else if (button66.Text != "")
                {
                    button66.Text = "";
                }
                else if (button55.Text != "")
                {
                    button55.Text = "";
                }
                else if (button75.Text != "")
                {
                    button75.Text = "";
                }

            }

        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button64.Text = "X";
                sayac++;
                anatassatır = 6;
                anatassutun = 4;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 6;
                sutun = 4;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button64.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button64.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button64.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button64.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button64.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button64.Text != "X")
            {
                if (button65.Text != "" && button65.Text != "X")
                {
                    int a = Convert.ToInt32(button65.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button64.Text = a.ToString();
                    button65.Text = "";
                }
                else if (button63.Text != "" && button63.Text != "X")
                {
                    int a = Convert.ToInt32(button63.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button64.Text = a.ToString();
                    button63.Text = "";
                }

                else if (button54.Text != "" && button54.Text != "X")
                {
                    int a = Convert.ToInt32(button54.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button64.Text = a.ToString();
                    button54.Text = "";
                }
                else if (button74.Text != "" && button74.Text != "X")
                {
                    int a = Convert.ToInt32(button74.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button64.Text = a.ToString();
                    button74.Text = "";
                }

            }
            else if (sayac == 6 && button64.Text == "X")
            {
                if (button65.Text != "")
                {
                    button65.Text = "";
                }
                else if (button63.Text != "")
                {
                    button63.Text = "";
                }
                else if (button54.Text != "")
                {
                    button54.Text = "";
                }
                else if (button74.Text != "")
                {
                    button74.Text = "";
                }

            }

        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button63.Text = "X";
                sayac++;
                anatassatır = 6;
                anatassutun = 3;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 6;
                sutun = 3;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button63.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button63.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button63.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button63.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button63.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button63.Text != "X")
            {
                if (button64.Text != "" && button64.Text != "X")
                {
                    int a = Convert.ToInt32(button64.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button63.Text = a.ToString();
                    button64.Text = "";
                }
                else if (button62.Text != "" && button62.Text != "X")
                {
                    int a = Convert.ToInt32(button62.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button63.Text = a.ToString();
                    button62.Text = "";
                }

                else if (button53.Text != "" && button53.Text != "X")
                {
                    int a = Convert.ToInt32(button53.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button63.Text = a.ToString();
                    button53.Text = "";
                }
                else if (button73.Text != "" && button73.Text != "X")
                {
                    int a = Convert.ToInt32(button73.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button63.Text = a.ToString();
                    button73.Text = "";
                }

            }
            else if (sayac == 6 && button63.Text == "X")
            {
                if (button64.Text != "")
                {
                    button64.Text = "";
                }
                else if (button62.Text != "")
                {
                    button62.Text = "";
                }
                else if (button53.Text != "")
                {
                    button53.Text = "";
                }
                else if (button73.Text != "")
                {
                    button73.Text = "";
                }

            }

        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button62.Text = "X";
                sayac++;
                anatassatır = 6;
                anatassutun = 2;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 6;
                sutun = 2;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button62.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button62.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button62.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button62.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button62.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button62.Text != "X")
            {
                if (button63.Text != "" && button63.Text != "X")
                {
                    int a = Convert.ToInt32(button63.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button62.Text = a.ToString();
                    button63.Text = "";
                }
                else if (button61.Text != "" && button61.Text != "X")
                {
                    int a = Convert.ToInt32(button61.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button62.Text = a.ToString();
                    button61.Text = "";
                }

                else if (button52.Text != "" && button52.Text != "X")
                {
                    int a = Convert.ToInt32(button52.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button62.Text = a.ToString();
                    button52.Text = "";
                }
                else if (button72.Text != "" && button72.Text != "X")
                {
                    int a = Convert.ToInt32(button72.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button62.Text = a.ToString();
                    button72.Text = "";
                }

            }
            else if (sayac == 6 && button62.Text == "X")
            {
                if (button63.Text != "")
                {
                    button63.Text = "";
                }
                else if (button61.Text != "")
                {
                    button61.Text = "";
                }
                else if (button52.Text != "")
                {
                    button52.Text = "";
                }
                else if (button72.Text != "")
                {
                    button72.Text = "";
                }

            }

        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button61.Text = "X";
                sayac++;
                anatassatır = 6;
                anatassutun = 1;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 6;
                sutun = 1;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button61.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button61.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button61.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button61.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button61.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button61.Text != "X")
            {
                if (button62.Text != "" && button62.Text != "X")
                {
                    int a = Convert.ToInt32(button62.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button61.Text = a.ToString();
                    button62.Text = "";
                }


                else if (button51.Text != "" && button51.Text != "X")
                {
                    int a = Convert.ToInt32(button51.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button61.Text = a.ToString();
                    button51.Text = "";
                }
                else if (button71.Text != "" && button71.Text != "X")
                {
                    int a = Convert.ToInt32(button71.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button61.Text = a.ToString();
                    button71.Text = "";
                }

            }
            else if (sayac == 6 && button61.Text == "X")
            {
                if (button62.Text != "")
                {
                    button62.Text = "";
                }

                else if (button51.Text != "")
                {
                    button51.Text = "";
                }
                else if (button71.Text != "")
                {
                    button71.Text = "";
                }

            }

        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button58.Text = "X";
                sayac++;
                anatassatır = 5;
                anatassutun = 8;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 5;
                sutun = 8;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button58.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button58.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button58.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button58.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button58.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button58.Text != "X")
            {
                if (button57.Text != "" && button57.Text != "X")
                {
                    int a = Convert.ToInt32(button57.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button58.Text = a.ToString();
                    button57.Text = "";
                }


                else if (button48.Text != "" && button48.Text != "X")
                {
                    int a = Convert.ToInt32(button48.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button58.Text = a.ToString();
                    button48.Text = "";
                }
                else if (button68.Text != "" && button68.Text != "X")
                {
                    int a = Convert.ToInt32(button68.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button58.Text = a.ToString();
                    button68.Text = "";
                }

            }
            else if (sayac == 6 && button58.Text == "X")
            {
                if (button57.Text != "")
                {
                    button57.Text = "";
                }

                else if (button48.Text != "")
                {
                    button48.Text = "";
                }
                else if (button68.Text != "")
                {
                    button68.Text = "";
                }

            }

        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button57.Text = "X";
                sayac++;
                anatassatır = 5;
                anatassutun = 7;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 5;
                sutun = 7;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button57.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button57.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button57.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button57.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button57.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button57.Text != "X")
            {
                if (button58.Text != "" && button58.Text != "X")
                {
                    int a = Convert.ToInt32(button58.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button57.Text = a.ToString();
                    button58.Text = "";
                }
                else if (button56.Text != "" && button56.Text != "X")
                {
                    int a = Convert.ToInt32(button56.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button57.Text = a.ToString();
                    button56.Text = "";
                }

                else if (button47.Text != "" && button47.Text != "X")
                {
                    int a = Convert.ToInt32(button47.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button57.Text = a.ToString();
                    button47.Text = "";
                }
                else if (button67.Text != "" && button67.Text != "X")
                {
                    int a = Convert.ToInt32(button67.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button57.Text = a.ToString();
                    button67.Text = "";
                }

            }
            else if (sayac == 6 && button57.Text == "X")
            {
                if (button58.Text != "")
                {
                    button58.Text = "";
                }
                else if (button56.Text != "")
                {
                    button56.Text = "";
                }
                else if (button47.Text != "")
                {
                    button47.Text = "";
                }
                else if (button67.Text != "")
                {
                    button67.Text = "";
                }

            }

        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button56.Text = "X";
                sayac++;
                anatassatır = 5;
                anatassutun = 6;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 5;
                sutun = 6;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button56.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button56.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button56.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button56.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button56.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button56.Text != "X")
            {
                if (button57.Text != "" && button57.Text != "X")
                {
                    int a = Convert.ToInt32(button57.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button56.Text = a.ToString();
                    button57.Text = "";
                }
                else if (button55.Text != "" && button55.Text != "X")
                {
                    int a = Convert.ToInt32(button55.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button56.Text = a.ToString();
                    button55.Text = "";
                }

                else if (button46.Text != "" && button46.Text != "X")
                {
                    int a = Convert.ToInt32(button46.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button56.Text = a.ToString();
                    button46.Text = "";
                }
                else if (button66.Text != "" && button66.Text != "X")
                {
                    int a = Convert.ToInt32(button66.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button56.Text = a.ToString();
                    button66.Text = "";
                }

            }
            else if (sayac == 6 && button56.Text == "X")
            {
                if (button57.Text != "")
                {
                    button57.Text = "";
                }
                else if (button55.Text != "")
                {
                    button55.Text = "";
                }
                else if (button46.Text != "")
                {
                    button46.Text = "";
                }
                else if (button66.Text != "")
                {
                    button66.Text = "";
                }

            }

        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button55.Text = "X";
                sayac++;
                anatassatır = 5;
                anatassutun = 5;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 5;
                sutun = 5;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button55.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button55.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button55.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button55.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button55.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button55.Text != "X")
            {
                if (button56.Text != "" && button56.Text != "X")
                {
                    int a = Convert.ToInt32(button56.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button55.Text = a.ToString();
                    button56.Text = "";
                }
                else if (button54.Text != "" && button54.Text != "X")
                {
                    int a = Convert.ToInt32(button54.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button55.Text = a.ToString();
                    button54.Text = "";
                }

                else if (button45.Text != "" && button45.Text != "X")
                {
                    int a = Convert.ToInt32(button45.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button55.Text = a.ToString();
                    button45.Text = "";
                }
                else if (button65.Text != "" && button65.Text != "X")
                {
                    int a = Convert.ToInt32(button65.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button55.Text = a.ToString();
                    button65.Text = "";
                }

            }
            else if (sayac == 6 && button55.Text == "X")
            {
                if (button56.Text != "")
                {
                    button56.Text = "";
                }
                else if (button54.Text != "")
                {
                    button54.Text = "";
                }
                else if (button45.Text != "")
                {
                    button45.Text = "";
                }
                else if (button65.Text != "")
                {
                    button65.Text = "";
                }

            }

        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button54.Text = "X";
                sayac++;
                anatassatır = 5;
                anatassutun = 4;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 5;
                sutun = 4;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button54.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button54.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button54.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button54.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button54.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button54.Text != "X")
            {
                if (button55.Text != "" && button55.Text != "X")
                {
                    int a = Convert.ToInt32(button55.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button54.Text = a.ToString();
                    button55.Text = "";
                }
                else if (button53.Text != "" && button53.Text != "X")
                {
                    int a = Convert.ToInt32(button53.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button54.Text = a.ToString();
                    button53.Text = "";
                }

                else if (button44.Text != "" && button44.Text != "X")
                {
                    int a = Convert.ToInt32(button44.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button54.Text = a.ToString();
                    button44.Text = "";
                }
                else if (button64.Text != "" && button64.Text != "X")
                {
                    int a = Convert.ToInt32(button64.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button54.Text = a.ToString();
                    button64.Text = "";
                }

            }
            else if (sayac == 6 && button54.Text == "X")
            {
                if (button53.Text != "")
                {
                    button53.Text = "";
                }
                else if (button55.Text != "")
                {
                    button55.Text = "";
                }
                else if (button44.Text != "")
                {
                    button44.Text = "";
                }
                else if (button64.Text != "")
                {
                    button64.Text = "";
                }

            }

        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button53.Text = "X";
                sayac++;
                anatassatır = 5;
                anatassutun = 3;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 5;
                sutun = 3;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button53.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button53.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button53.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button53.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button53.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button53.Text != "X")
            {
                if (button54.Text != "" && button54.Text != "X")
                {
                    int a = Convert.ToInt32(button54.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button53.Text = a.ToString();
                    button54.Text = "";
                }
                else if (button52.Text != "" && button52.Text != "X")
                {
                    int a = Convert.ToInt32(button52.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button53.Text = a.ToString();
                    button52.Text = "";
                }

                else if (button43.Text != "" && button43.Text != "X")
                {
                    int a = Convert.ToInt32(button43.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button53.Text = a.ToString();
                    button43.Text = "";
                }
                else if (button63.Text != "" && button63.Text != "X")
                {
                    int a = Convert.ToInt32(button63.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button53.Text = a.ToString();
                    button63.Text = "";
                }

            }
            else if (sayac == 6 && button53.Text == "X")
            {
                if (button54.Text != "")
                {
                    button54.Text = "";
                }
                else if (button52.Text != "")
                {
                    button52.Text = "";
                }
                else if (button43.Text != "")
                {
                    button43.Text = "";
                }
                else if (button63.Text != "")
                {
                    button63.Text = "";
                }

            }

        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button52.Text = "X";
                sayac++;
                anatassatır = 5;
                anatassutun = 2;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 5;
                sutun = 2;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button52.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button52.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button52.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button52.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button52.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button52.Text != "X")
            {
                if (button53.Text != "" && button53.Text != "X")
                {
                    int a = Convert.ToInt32(button53.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button52.Text = a.ToString();
                    button53.Text = "";
                }
                else if (button51.Text != "" && button51.Text != "X")
                {
                    int a = Convert.ToInt32(button51.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button52.Text = a.ToString();
                    button51.Text = "";
                }

                else if (button42.Text != "" && button42.Text != "X")
                {
                    int a = Convert.ToInt32(button42.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button52.Text = a.ToString();
                    button42.Text = "";
                }
                else if (button62.Text != "" && button62.Text != "X")
                {
                    int a = Convert.ToInt32(button62.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button52.Text = a.ToString();
                    button62.Text = "";
                }

            }
            else if (sayac == 6 && button52.Text == "X")
            {
                if (button53.Text != "")
                {
                    button53.Text = "";
                }
                else if (button51.Text != "")
                {
                    button51.Text = "";
                }
                else if (button42.Text != "")
                {
                    button42.Text = "";
                }
                else if (button62.Text != "")
                {
                    button62.Text = "";
                }

            }

        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button51.Text = "X";
                sayac++;
                anatassatır = 5;
                anatassutun = 1;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 5;
                sutun = 1;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button51.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button51.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button51.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button51.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button51.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button51.Text != "X")
            {
                if (button52.Text != "" && button52.Text != "X")
                {
                    int a = Convert.ToInt32(button52.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button51.Text = a.ToString();
                    button52.Text = "";
                }


                else if (button41.Text != "" && button41.Text != "X")
                {
                    int a = Convert.ToInt32(button41.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button51.Text = a.ToString();
                    button41.Text = "";
                }
                else if (button61.Text != "" && button61.Text != "X")
                {
                    int a = Convert.ToInt32(button61.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button51.Text = a.ToString();
                    button61.Text = "";
                }

            }
            else if (sayac == 6 && button51.Text == "X")
            {
                if (button52.Text != "")
                {
                    button52.Text = "";
                }

                else if (button41.Text != "")
                {
                    button41.Text = "";
                }
                else if (button61.Text != "")
                {
                    button61.Text = "";
                }

            }

        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button48.Text = "X";
                sayac++;
                anatassatır = 4;
                anatassutun = 8;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 4;
                sutun = 8;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button48.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button48.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button48.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button48.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button48.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button48.Text != "X")
            {
                if (button47.Text != "" && button47.Text != "X")
                {
                    int a = Convert.ToInt32(button47.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button48.Text = a.ToString();
                    button47.Text = "";
                }


                else if (button38.Text != "" && button38.Text != "X")
                {
                    int a = Convert.ToInt32(button38.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button48.Text = a.ToString();
                    button38.Text = "";
                }
                else if (button58.Text != "" && button58.Text != "X")
                {
                    int a = Convert.ToInt32(button58.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button48.Text = a.ToString();
                    button58.Text = "";
                }

            }
            else if (sayac == 6 && button48.Text == "X")
            {
                if (button47.Text != "")
                {
                    button47.Text = "";
                }

                else if (button38.Text != "")
                {
                    button38.Text = "";
                }
                else if (button58.Text != "")
                {
                    button58.Text = "";
                }

            }


        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button47.Text = "X";
                sayac++;
                anatassatır = 4;
                anatassutun = 7;
            }




            else if (sayac < 6 && sayac > 0)
            {
                satır = 4;
                sutun = 7;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button47.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button47.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button47.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button47.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button47.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button47.Text != "X")
            {
                if (button48.Text != "" && button48.Text != "X")
                {
                    int a = Convert.ToInt32(button48.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button47.Text = a.ToString();
                    button48.Text = "";
                }
                else if (button46.Text != "" && button46.Text != "X")
                {
                    int a = Convert.ToInt32(button46.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button47.Text = a.ToString();
                    button46.Text = "";
                }

                else if (button37.Text != "" && button37.Text != "X")
                {
                    int a = Convert.ToInt32(button37.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button47.Text = a.ToString();
                    button37.Text = "";
                }
                else if (button57.Text != "" && button57.Text != "X")
                {
                    int a = Convert.ToInt32(button57.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button47.Text = a.ToString();
                    button57.Text = "";
                }

            }
            else if (sayac == 6 && button47.Text == "X")
            {
                if (button48.Text != "")
                {
                    button48.Text = "";
                }
                else if (button46.Text != "")
                {
                    button46.Text = "";
                }
                else if (button37.Text != "")
                {
                    button37.Text = "";
                }
                else if (button57.Text != "")
                {
                    button57.Text = "";
                }

            }

        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button46.Text = "X";
                sayac++;
                anatassatır = 4;
                anatassutun = 6;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 4;
                sutun = 6;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button46.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button46.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button46.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button46.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button46.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button46.Text != "X")
            {
                if (button47.Text != "" && button47.Text != "X")
                {
                    int a = Convert.ToInt32(button47.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button46.Text = a.ToString();
                    button47.Text = "";
                }
                else if (button45.Text != "" && button45.Text != "X")
                {
                    int a = Convert.ToInt32(button45.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button46.Text = a.ToString();
                    button45.Text = "";
                }

                else if (button36.Text != "" && button36.Text != "X")
                {
                    int a = Convert.ToInt32(button36.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button46.Text = a.ToString();
                    button36.Text = "";
                }
                else if (button56.Text != "" && button56.Text != "X")
                {
                    int a = Convert.ToInt32(button56.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button46.Text = a.ToString();
                    button56.Text = "";
                }

            }
            else if (sayac == 6 && button46.Text == "X")
            {
                if (button47.Text != "")
                {
                    button47.Text = "";
                }
                else if (button45.Text != "")
                {
                    button45.Text = "";
                }
                else if (button36.Text != "")
                {
                    button36.Text = "";
                }
                else if (button56.Text != "")
                {
                    button56.Text = "";
                }

            }

        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button45.Text = "X";
                sayac++;
                anatassatır = 4;
                anatassutun = 5;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 4;
                sutun = 5;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button45.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button45.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button45.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button45.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button45.Text = tas5.ToString();
                }

                sayac++;
            }


            if (sayac == 6 && button45.Text != "X")
            {
                if (button46.Text != "" && button46.Text != "X")
                {
                    int a = Convert.ToInt32(button46.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button45.Text = a.ToString();
                    button46.Text = "";
                }
                else if (button44.Text != "" && button44.Text != "X")
                {
                    int a = Convert.ToInt32(button44.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button45.Text = a.ToString();
                    button44.Text = "";
                }

                else if (button35.Text != "" && button35.Text != "X")
                {
                    int a = Convert.ToInt32(button35.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button45.Text = a.ToString();
                    button35.Text = "";
                }
                else if (button55.Text != "" && button55.Text != "X")
                {
                    int a = Convert.ToInt32(button55.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button45.Text = a.ToString();
                    button55.Text = "";
                }

            }
            else if (sayac == 6 && button45.Text == "X")
            {
                if (button46.Text != "")
                {
                    button46.Text = "";
                }
                else if (button44.Text != "")
                {
                    button44.Text = "";
                }
                else if (button35.Text != "")
                {
                    button35.Text = "";
                }
                else if (button55.Text != "")
                {
                    button55.Text = "";
                }

            }

        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button44.Text = "X";
                sayac++;
                anatassatır = 4;
                anatassutun = 4;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 4;
                sutun = 4;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button44.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button44.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button44.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button44.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button44.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button44.Text != "X")
            {
                if (button45.Text != "" && button45.Text != "X")
                {
                    int a = Convert.ToInt32(button45.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button44.Text = a.ToString();
                    button45.Text = "";
                }
                else if (button43.Text != "" && button43.Text != "X")
                {
                    int a = Convert.ToInt32(button43.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button44.Text = a.ToString();
                    button43.Text = "";
                }

                else if (button34.Text != "" && button34.Text != "X")
                {
                    int a = Convert.ToInt32(button34.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button44.Text = a.ToString();
                    button34.Text = "";
                }
                else if (button54.Text != "" && button54.Text != "X")
                {
                    int a = Convert.ToInt32(button54.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button44.Text = a.ToString();
                    button54.Text = "";
                }

            }
            else if (sayac == 6 && button44.Text == "X")
            {
                if (button45.Text != "")
                {
                    button45.Text = "";
                }
                else if (button43.Text != "")
                {
                    button43.Text = "";
                }
                else if (button34.Text != "")
                {
                    button34.Text = "";
                }
                else if (button54.Text != "")
                {
                    button54.Text = "";
                }

            }

        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button43.Text = "X";
                sayac++;
                anatassatır = 4;
                anatassutun = 3;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 4;
                sutun = 3;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button43.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button43.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button43.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button43.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button43.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button43.Text != "X")
            {
                if (button44.Text != "" && button44.Text != "X")
                {
                    int a = Convert.ToInt32(button44.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button43.Text = a.ToString();
                    button44.Text = "";
                }
                else if (button42.Text != "" && button42.Text != "X")
                {
                    int a = Convert.ToInt32(button42.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button43.Text = a.ToString();
                    button42.Text = "";
                }

                else if (button33.Text != "" && button33.Text != "X")
                {
                    int a = Convert.ToInt32(button33.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button43.Text = a.ToString();
                    button33.Text = "";
                }
                else if (button53.Text != "" && button53.Text != "X")
                {
                    int a = Convert.ToInt32(button53.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button43.Text = a.ToString();
                    button53.Text = "";
                }

            }
            else if (sayac == 6 && button43.Text == "X")
            {
                if (button44.Text != "")
                {
                    button44.Text = "";
                }
                else if (button42.Text != "")
                {
                    button42.Text = "";
                }
                else if (button33.Text != "")
                {
                    button33.Text = "";
                }
                else if (button53.Text != "")
                {
                    button53.Text = "";
                }

            }

        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button42.Text = "X";
                sayac++;
                anatassatır = 4;
                anatassutun = 2;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 4;
                sutun = 2;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button42.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button42.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button42.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button42.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button42.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button42.Text != "X")
            {
                if (button43.Text != "" && button43.Text != "X")
                {
                    int a = Convert.ToInt32(button43.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button42.Text = a.ToString();
                    button43.Text = "";
                }
                else if (button41.Text != "" && button41.Text != "X")
                {
                    int a = Convert.ToInt32(button41.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button42.Text = a.ToString();
                    button41.Text = "";
                }

                else if (button32.Text != "" && button32.Text != "X")
                {
                    int a = Convert.ToInt32(button32.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button42.Text = a.ToString();
                    button32.Text = "";
                }
                else if (button52.Text != "" && button52.Text != "X")
                {
                    int a = Convert.ToInt32(button52.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button42.Text = a.ToString();
                    button52.Text = "";
                }

            }
            else if (sayac == 6 && button42.Text == "X")
            {
                if (button43.Text != "")
                {
                    button43.Text = "";
                }
                else if (button41.Text != "")
                {
                    button41.Text = "";
                }
                else if (button32.Text != "")
                {
                    button32.Text = "";
                }
                else if (button52.Text != "")
                {
                    button52.Text = "";
                }

            }

        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button41.Text = "X";
                sayac++;
                anatassatır = 4;
                anatassutun = 1;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 4;
                sutun = 1;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button41.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button41.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button41.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button41.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button41.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button41.Text != "X")
            {
                if (button42.Text != "" && button42.Text != "X")
                {
                    int a = Convert.ToInt32(button42.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button41.Text = a.ToString();
                    button42.Text = "";
                }


                else if (button31.Text != "" && button31.Text != "X")
                {
                    int a = Convert.ToInt32(button31.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button41.Text = a.ToString();
                    button31.Text = "";
                }
                else if (button51.Text != "" && button51.Text != "X")
                {
                    int a = Convert.ToInt32(button51.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button41.Text = a.ToString();
                    button51.Text = "";
                }

            }
            else if (sayac == 6 && button41.Text == "X")
            {
                if (button42.Text != "")
                {
                    button42.Text = "";
                }

                else if (button31.Text != "")
                {
                    button31.Text = "";
                }
                else if (button51.Text != "")
                {
                    button51.Text = "";
                }

            }

        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button38.Text = "X";
                sayac++;
                anatassatır = 3;
                anatassutun = 8;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 3;
                sutun = 8;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button38.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button38.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button38.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button38.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button38.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button38.Text != "X")
            {
                if (button37.Text != "" && button37.Text != "X")
                {
                    int a = Convert.ToInt32(button37.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button38.Text = a.ToString();
                    button37.Text = "";
                }


                else if (button28.Text != "" && button28.Text != "X")
                {
                    int a = Convert.ToInt32(button28.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button38.Text = a.ToString();
                    button28.Text = "";
                }
                else if (button48.Text != "" && button48.Text != "X")
                {
                    int a = Convert.ToInt32(button48.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button38.Text = a.ToString();
                    button48.Text = "";
                }

            }
            else if (sayac == 6 && button38.Text == "X")
            {
                if (button37.Text != "")
                {
                    button37.Text = "";
                }

                else if (button28.Text != "")
                {
                    button28.Text = "";
                }
                else if (button48.Text != "")
                {
                    button48.Text = "";
                }

            }

        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button37.Text = "X";
                sayac++;
                anatassatır = 3;
                anatassutun = 7;
            }

            else if (sayac < 6 && sayac > 0)
            {
                satır = 3;
                sutun = 7;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button37.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button37.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button37.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button37.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button37.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button37.Text != "X")
            {
                if (button38.Text != "" && button38.Text != "X")
                {
                    int a = Convert.ToInt32(button38.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button37.Text = a.ToString();
                    button38.Text = "";
                }
                else if (button36.Text != "" && button36.Text != "X")
                {
                    int a = Convert.ToInt32(button36.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button37.Text = a.ToString();
                    button36.Text = "";
                }

                else if (button27.Text != "" && button27.Text != "X")
                {
                    int a = Convert.ToInt32(button27.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button37.Text = a.ToString();
                    button27.Text = "";
                }
                else if (button47.Text != "" && button47.Text != "X")
                {
                    int a = Convert.ToInt32(button47.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button37.Text = a.ToString();
                    button47.Text = "";
                }

            }
            else if (sayac == 6 && button37.Text == "X")
            {
                if (button38.Text != "")
                {
                    button38.Text = "";
                }
                else if (button36.Text != "")
                {
                    button36.Text = "";
                }
                else if (button27.Text != "")
                {
                    button27.Text = "";
                }
                else if (button47.Text != "")
                {
                    button47.Text = "";
                }

            }

        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button36.Text = "X";
                sayac++;
                anatassatır = 3;
                anatassutun = 6;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 3;
                sutun = 6;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button36.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button36.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button36.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button36.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button36.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button36.Text != "X")
            {
                if (button37.Text != "" && button37.Text != "X")
                {
                    int a = Convert.ToInt32(button37.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button36.Text = a.ToString();
                    button37.Text = "";
                }
                else if (button35.Text != "" && button35.Text != "X")
                {
                    int a = Convert.ToInt32(button35.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button36.Text = a.ToString();
                    button35.Text = "";
                }

                else if (button26.Text != "" && button26.Text != "X")
                {
                    int a = Convert.ToInt32(button26.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button36.Text = a.ToString();
                    button26.Text = "";
                }
                else if (button46.Text != "" && button46.Text != "X")
                {
                    int a = Convert.ToInt32(button46.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button36.Text = a.ToString();
                    button46.Text = "";
                }

            }
            else if (sayac == 6 && button36.Text == "X")
            {
                if (button37.Text != "")
                {
                    button37.Text = "";
                }
                else if (button35.Text != "")
                {
                    button35.Text = "";
                }
                else if (button26.Text != "")
                {
                    button26.Text = "";
                }
                else if (button46.Text != "")
                {
                    button46.Text = "";
                }

            }

        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button35.Text = "X";
                sayac++;
                anatassatır = 3;
                anatassutun = 5;
            }

            else if (sayac < 6 && sayac > 0)
            {
                satır = 3;
                sutun = 5;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button35.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button35.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button35.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button35.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button35.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button35.Text != "X")
            {
                if (button36.Text != "" && button36.Text != "X")
                {
                    int a = Convert.ToInt32(button36.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button35.Text = a.ToString();
                    button36.Text = "";
                }
                else if (button34.Text != "" && button34.Text != "X")
                {
                    int a = Convert.ToInt32(button34.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button35.Text = a.ToString();
                    button34.Text = "";
                }

                else if (button25.Text != "" && button25.Text != "X")
                {
                    int a = Convert.ToInt32(button25.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button35.Text = a.ToString();
                    button25.Text = "";
                }
                else if (button45.Text != "" && button45.Text != "X")
                {
                    int a = Convert.ToInt32(button45.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button35.Text = a.ToString();
                    button45.Text = "";
                }

            }
            else if (sayac == 6 && button35.Text == "X")
            {
                if (button36.Text != "")
                {
                    button36.Text = "";
                }
                else if (button34.Text != "")
                {
                    button34.Text = "";
                }
                else if (button25.Text != "")
                {
                    button25.Text = "";
                }
                else if (button45.Text != "")
                {
                    button45.Text = "";
                }

            }

        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button34.Text = "X";
                sayac++;
                anatassatır = 3;
                anatassutun = 4;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 3;
                sutun = 4;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button34.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button34.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button34.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button34.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button34.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button34.Text != "X")
            {
                if (button35.Text != "" && button35.Text != "X")
                {
                    int a = Convert.ToInt32(button35.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button34.Text = a.ToString();
                    button35.Text = "";
                }
                else if (button33.Text != "" && button33.Text != "X")
                {
                    int a = Convert.ToInt32(button33.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button34.Text = a.ToString();
                    button33.Text = "";
                }

                else if (button24.Text != "" && button24.Text != "X")
                {
                    int a = Convert.ToInt32(button24.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button34.Text = a.ToString();
                    button24.Text = "";
                }
                else if (button44.Text != "" && button44.Text != "X")
                {
                    int a = Convert.ToInt32(button44.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button34.Text = a.ToString();
                    button44.Text = "";
                }

            }
            else if (sayac == 6 && button34.Text == "X")
            {
                if (button35.Text != "")
                {
                    button35.Text = "";
                }
                else if (button33.Text != "")
                {
                    button33.Text = "";
                }
                else if (button24.Text != "")
                {
                    button24.Text = "";
                }
                else if (button44.Text != "")
                {
                    button44.Text = "";
                }

            }

        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button33.Text = "X";
                sayac++;
                anatassatır = 3;
                anatassutun = 3;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 3;
                sutun = 3;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button33.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button33.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button33.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button33.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button33.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button33.Text != "X")
            {
                if (button34.Text != "" && button34.Text != "X")
                {
                    int a = Convert.ToInt32(button34.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button33.Text = a.ToString();
                    button34.Text = "";
                }
                else if (button32.Text != "" && button32.Text != "X")
                {
                    int a = Convert.ToInt32(button32.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button33.Text = a.ToString();
                    button32.Text = "";
                }

                else if (button23.Text != "" && button23.Text != "X")
                {
                    int a = Convert.ToInt32(button23.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button33.Text = a.ToString();
                    button23.Text = "";
                }
                else if (button43.Text != "" && button43.Text != "X")
                {
                    int a = Convert.ToInt32(button43.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button33.Text = a.ToString();
                    button43.Text = "";
                }

            }
            else if (sayac == 6 && button33.Text == "X")
            {
                if (button34.Text != "")
                {
                    button34.Text = "";
                }
                else if (button32.Text != "")
                {
                    button32.Text = "";
                }
                else if (button23.Text != "")
                {
                    button23.Text = "";
                }
                else if (button43.Text != "")
                {
                    button43.Text = "";
                }

            }

        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button32.Text = "X";
                sayac++;
                anatassatır = 3;
                anatassutun = 2;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 3;
                sutun = 2;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button32.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button32.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button32.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button32.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button32.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button32.Text != "X")
            {
                if (button33.Text != "" && button33.Text != "X")
                {
                    int a = Convert.ToInt32(button33.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button32.Text = a.ToString();
                    button33.Text = "";
                }
                else if (button31.Text != "" && button31.Text != "X")
                {
                    int a = Convert.ToInt32(button31.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button32.Text = a.ToString();
                    button31.Text = "";
                }

                else if (button22.Text != "" && button22.Text != "X")
                {
                    int a = Convert.ToInt32(button22.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button32.Text = a.ToString();
                    button22.Text = "";
                }
                else if (button42.Text != "" && button42.Text != "X")
                {
                    int a = Convert.ToInt32(button42.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button32.Text = a.ToString();
                    button42.Text = "";
                }

            }
            else if (sayac == 6 && button32.Text == "X")
            {
                if (button33.Text != "")
                {
                    button33.Text = "";
                }
                else if (button31.Text != "")
                {
                    button31.Text = "";
                }
                else if (button22.Text != "")
                {
                    button22.Text = "";
                }
                else if (button42.Text != "")
                {
                    button42.Text = "";
                }

            }

        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button31.Text = "X";
                sayac++;
                anatassatır = 3;
                anatassutun = 1;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 3;
                sutun = 1;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button31.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button31.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button31.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button31.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button31.Text = tas5.ToString();
                }

                sayac++;
            }


            if (sayac == 6 && button31.Text != "X")
            {
                if (button32.Text != "" && button32.Text != "X")
                {
                    int a = Convert.ToInt32(button32.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button31.Text = a.ToString();
                    button32.Text = "";
                }


                else if (button21.Text != "" && button21.Text != "X")
                {
                    int a = Convert.ToInt32(button21.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button31.Text = a.ToString();
                    button21.Text = "";
                }
                else if (button41.Text != "" && button41.Text != "X")
                {
                    int a = Convert.ToInt32(button41.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button31.Text = a.ToString();
                    button41.Text = "";
                }

            }
            else if (sayac == 6 && button31.Text == "X")
            {
                if (button32.Text != "")
                {
                    button32.Text = "";
                }

                else if (button21.Text != "")
                {
                    button21.Text = "";
                }
                else if (button41.Text != "")
                {
                    button41.Text = "";
                }

            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button28.Text = "X";
                sayac++;
                anatassatır = 2;
                anatassutun = 8;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 2;
                sutun = 8;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button28.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button28.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button28.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button28.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button28.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button28.Text != "X")
            {
                if (button27.Text != "" && button27.Text != "X")
                {
                    int a = Convert.ToInt32(button27.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button28.Text = a.ToString();
                    button27.Text = "";
                }


                else if (button18.Text != "" && button18.Text != "X")
                {
                    int a = Convert.ToInt32(button18.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button28.Text = a.ToString();
                    button18.Text = "";
                }
                else if (button38.Text != "" && button38.Text != "X")
                {
                    int a = Convert.ToInt32(button38.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button28.Text = a.ToString();
                    button38.Text = "";
                }

            }
            else if (sayac == 6 && button28.Text == "X")
            {
                if (button27.Text != "")
                {
                    button27.Text = "";
                }

                else if (button18.Text != "")
                {
                    button18.Text = "";
                }
                else if (button38.Text != "")
                {
                    button38.Text = "";
                }

            }

        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button27.Text = "X";
                sayac++;
                anatassatır = 2;
                anatassutun = 7;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 2;
                sutun = 7;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button27.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button27.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button27.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button27.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button27.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button27.Text != "X")
            {
                if (button28.Text != "" && button28.Text != "X")
                {
                    int a = Convert.ToInt32(button28.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button27.Text = a.ToString();
                    button28.Text = "";
                }
                else if (button26.Text != "" && button26.Text != "X")
                {
                    int a = Convert.ToInt32(button26.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button27.Text = a.ToString();
                    button26.Text = "";
                }

                else if (button17.Text != "" && button17.Text != "X")
                {
                    int a = Convert.ToInt32(button17.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button27.Text = a.ToString();
                    button17.Text = "";
                }
                else if (button37.Text != "" && button37.Text != "X")
                {
                    int a = Convert.ToInt32(button37.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button27.Text = a.ToString();
                    button37.Text = "";
                }

            }
            else if (sayac == 6 && button27.Text == "X")
            {
                if (button28.Text != "")
                {
                    button28.Text = "";
                }
                else if (button26.Text != "")
                {
                    button26.Text = "";
                }
                else if (button17.Text != "")
                {
                    button17.Text = "";
                }
                else if (button37.Text != "")
                {
                    button37.Text = "";
                }

            }

        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button26.Text = "X";
                sayac++;
                anatassatır = 2;
                anatassutun = 6;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 2;
                sutun = 6;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button26.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button26.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button26.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button26.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button26.Text = tas5.ToString();
                }

                sayac++;
            }


            if (sayac == 6 && button26.Text != "X")
            {
                if (button27.Text != "" && button27.Text != "X")
                {
                    int a = Convert.ToInt32(button27.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button26.Text = a.ToString();
                    button27.Text = "";
                }
                else if (button25.Text != "" && button25.Text != "X")
                {
                    int a = Convert.ToInt32(button25.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button26.Text = a.ToString();
                    button25.Text = "";
                }

                else if (button16.Text != "" && button16.Text != "X")
                {
                    int a = Convert.ToInt32(button16.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button26.Text = a.ToString();
                    button16.Text = "";
                }
                else if (button36.Text != "" && button36.Text != "X")
                {
                    int a = Convert.ToInt32(button36.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button26.Text = a.ToString();
                    button36.Text = "";
                }

            }
            else if (sayac == 6 && button26.Text == "X")
            {
                if (button27.Text != "")
                {
                    button27.Text = "";
                }
                else if (button25.Text != "")
                {
                    button25.Text = "";
                }
                else if (button16.Text != "")
                {
                    button16.Text = "";
                }
                else if (button36.Text != "")
                {
                    button36.Text = "";
                }

            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button25.Text = "X";
                sayac++;
                anatassatır = 2;
                anatassutun = 5;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 2;
                sutun = 5;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button25.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button25.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button25.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button25.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button25.Text = tas5.ToString();
                }

                sayac++;
            }


            if (sayac == 6 && button25.Text != "X")
            {
                if (button26.Text != "" && button26.Text != "X")
                {
                    int a = Convert.ToInt32(button26.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button25.Text = a.ToString();
                    button26.Text = "";
                }
                else if (button24.Text != "" && button24.Text != "X")
                {
                    int a = Convert.ToInt32(button24.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button25.Text = a.ToString();
                    button24.Text = "";
                }

                else if (button15.Text != "" && button15.Text != "X")
                {
                    int a = Convert.ToInt32(button15.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button25.Text = a.ToString();
                    button15.Text = "";
                }
                else if (button35.Text != "" && button35.Text != "X")
                {
                    int a = Convert.ToInt32(button35.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button25.Text = a.ToString();
                    button35.Text = "";
                }

            }
            else if (sayac == 6 && button25.Text == "X")
            {
                if (button26.Text != "")
                {
                    button26.Text = "";
                }
                else if (button24.Text != "")
                {
                    button24.Text = "";
                }
                else if (button15.Text != "")
                {
                    button15.Text = "";
                }
                else if (button35.Text != "")
                {
                    button35.Text = "";
                }

            }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button24.Text = "X";
                sayac++;
                anatassatır = 2;
                anatassutun = 4;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 2;
                sutun = 4;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button24.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button24.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button24.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button24.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button24.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button24.Text != "X")
            {
                if (button25.Text != "" && button25.Text != "X")
                {
                    int a = Convert.ToInt32(button25.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button24.Text = a.ToString();
                    button25.Text = "";
                }
                else if (button23.Text != "" && button23.Text != "X")
                {
                    int a = Convert.ToInt32(button23.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button24.Text = a.ToString();
                    button23.Text = "";
                }

                else if (button14.Text != "" && button14.Text != "X")
                {
                    int a = Convert.ToInt32(button14.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button24.Text = a.ToString();
                    button14.Text = "";
                }
                else if (button34.Text != "" && button34.Text != "X")
                {
                    int a = Convert.ToInt32(button34.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button24.Text = a.ToString();
                    button34.Text = "";
                }

            }
            else if (sayac == 6 && button24.Text == "X")
            {
                if (button25.Text != "")
                {
                    button25.Text = "";
                }
                else if (button23.Text != "")
                {
                    button23.Text = "";
                }
                else if (button14.Text != "")
                {
                    button14.Text = "";
                }
                else if (button34.Text != "")
                {
                    button34.Text = "";
                }

            }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button23.Text = "X";
                sayac++;
                anatassatır = 2;
                anatassutun = 3;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 2;
                sutun = 3;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button23.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button23.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button23.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button23.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button23.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button23.Text != "X")
            {
                if (button24.Text != "" && button24.Text != "X")
                {
                    int a = Convert.ToInt32(button24.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button23.Text = a.ToString();
                    button24.Text = "";
                }
                else if (button22.Text != "" && button22.Text != "X")
                {
                    int a = Convert.ToInt32(button22.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button23.Text = a.ToString();
                    button22.Text = "";
                }

                else if (button13.Text != "" && button13.Text != "X")
                {
                    int a = Convert.ToInt32(button13.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button23.Text = a.ToString();
                    button13.Text = "";
                }
                else if (button33.Text != "" && button33.Text != "X")
                {
                    int a = Convert.ToInt32(button33.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button23.Text = a.ToString();
                    button33.Text = "";
                }

            }
            else if (sayac == 6 && button23.Text == "X")
            {
                if (button24.Text != "")
                {
                    button24.Text = "";
                }
                else if (button22.Text != "")
                {
                    button22.Text = "";
                }
                else if (button13.Text != "")
                {
                    button13.Text = "";
                }
                else if (button33.Text != "")
                {
                    button33.Text = "";
                }

            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button22.Text = "X";
                sayac++;
                anatassatır = 2;
                anatassutun = 2;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 2;
                sutun = 2;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button22.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button22.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button22.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button22.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button22.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button22.Text != "X")
            {
                if (button23.Text != "" && button23.Text != "X")
                {
                    int a = Convert.ToInt32(button23.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button22.Text = a.ToString();
                    button23.Text = "";
                }
                else if (button21.Text != "" && button21.Text != "X")
                {
                    int a = Convert.ToInt32(button21.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button22.Text = a.ToString();
                    button21.Text = "";
                }

                else if (button12.Text != "" && button12.Text != "X")
                {
                    int a = Convert.ToInt32(button12.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button22.Text = a.ToString();
                    button12.Text = "";
                }
                else if (button32.Text != "" && button32.Text != "X")
                {
                    int a = Convert.ToInt32(button32.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button22.Text = a.ToString();
                    button32.Text = "";
                }

            }
            else if (sayac == 6 && button22.Text == "X")
            {
                if (button23.Text != "")
                {
                    button23.Text = "";
                }
                else if (button21.Text != "")
                {
                    button21.Text = "";
                }
                else if (button12.Text != "")
                {
                    button12.Text = "";
                }
                else if (button32.Text != "")
                {
                    button32.Text = "";
                }

            }


        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button21.Text = "X";
                sayac++;
                anatassatır = 2;
                anatassutun = 1;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 2;
                sutun = 1;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button21.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button21.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button21.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button21.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button21.Text = tas5.ToString();
                }

                sayac++;
            }


            if (sayac == 6 && button21.Text != "X")
            {
                if (button22.Text != "" && button22.Text != "X")
                {
                    int a = Convert.ToInt32(button22.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button21.Text = a.ToString();
                    button22.Text = "";
                }


                else if (button11.Text != "" && button11.Text != "X")
                {
                    int a = Convert.ToInt32(button11.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button21.Text = a.ToString();
                    button11.Text = "";
                }
                else if (button31.Text != "" && button31.Text != "X")
                {
                    int a = Convert.ToInt32(button31.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button21.Text = a.ToString();
                    button31.Text = "";
                }

            }
            else if (sayac == 6 && button21.Text == "X")
            {
                if (button22.Text != "")
                {
                    button22.Text = "";
                }

                else if (button11.Text != "")
                {
                    button11.Text = "";
                }
                else if (button31.Text != "")
                {
                    button31.Text = "";
                }

            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button18.Text = "X";
                sayac++;
                anatassatır = 1;
                anatassutun = 8;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 1;
                sutun = 8;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button18.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button18.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button18.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button18.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button18.Text = tas5.ToString();
                }

                sayac++;
            }


            if (sayac == 6 && button18.Text != "X")
            {
                if (button17.Text != "" && button17.Text != "X")
                {
                    int a = Convert.ToInt32(button17.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button18.Text = a.ToString();
                    button17.Text = "";
                }

                else if (button28.Text != "" && button28.Text != "X")
                {
                    int a = Convert.ToInt32(button28.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button18.Text = a.ToString();
                    button28.Text = "";
                }

            }
            else if (sayac == 6 && button18.Text == "X")
            {
                if (button17.Text != "")
                {
                    button17.Text = "";
                }


                else if (button28.Text != "")
                {
                    button28.Text = "";
                }

            }




        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button17.Text = "X";
                sayac++;
                anatassatır = 1;
                anatassutun = 7;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 1;
                sutun = 7;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button17.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button17.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button17.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button17.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button17.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button17.Text != "X")
            {
                if (button18.Text != "" && button18.Text != "X")
                {
                    int a = Convert.ToInt32(button18.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button17.Text = a.ToString();
                    button18.Text = "";
                }
                else if (button16.Text != "" && button16.Text != "X")
                {
                    int a = Convert.ToInt32(button16.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button17.Text = a.ToString();
                    button16.Text = "";
                }
                else if (button27.Text != "" && button27.Text != "X")
                {
                    int a = Convert.ToInt32(button27.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button17.Text = a.ToString();
                    button27.Text = "";
                }

            }
            else if (sayac == 6 && button17.Text == "X")
            {
                if (button18.Text != "")
                {
                    button18.Text = "";
                }
                else if (button16.Text != "")
                {
                    button16.Text = "";
                }

                else if (button27.Text != "")
                {
                    button27.Text = "";
                }

            }


        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button16.Text = "X";
                sayac++;
                anatassatır = 1;
                anatassutun = 6;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 1;
                sutun = 6;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button16.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button16.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button16.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button16.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button16.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button16.Text != "X")
            {
                if (button17.Text != "" && button17.Text != "X")
                {
                    int a = Convert.ToInt32(button17.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button16.Text = a.ToString();
                    button17.Text = "";
                }
                else if (button15.Text != "" && button15.Text != "X")
                {
                    int a = Convert.ToInt32(button15.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button16.Text = a.ToString();
                    button15.Text = "";
                }
                else if (button26.Text != "" && button26.Text != "X")
                {
                    int a = Convert.ToInt32(button26.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button16.Text = a.ToString();
                    button26.Text = "";
                }

            }
            else if (sayac == 6 && button16.Text == "X")
            {
                if (button17.Text != "")
                {
                    button17.Text = "";
                }
                else if (button15.Text != "")
                {
                    button15.Text = "";
                }

                else if (button26.Text != "")
                {
                    button26.Text = "";
                }

            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button15.Text = "X";
                sayac++;
                anatassatır = 1;
                anatassutun = 5;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 1;
                sutun = 5;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button15.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button15.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button15.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button15.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button15.Text = tas5.ToString();
                }

                sayac++;
            }


            if (sayac == 6 && button15.Text != "X")
            {
                if (button16.Text != "" && button16.Text != "X")
                {
                    int a = Convert.ToInt32(button16.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button15.Text = a.ToString();
                    button16.Text = "";
                }
                else if (button14.Text != "" && button14.Text != "X")
                {
                    int a = Convert.ToInt32(button14.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button15.Text = a.ToString();
                    button14.Text = "";
                }
                else if (button25.Text != "" && button25.Text != "X")
                {
                    int a = Convert.ToInt32(button25.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button15.Text = a.ToString();
                    button25.Text = "";
                }

            }
            else if (sayac == 6 && button15.Text == "X")
            {
                if (button16.Text != "")
                {
                    button16.Text = "";
                }
                else if (button14.Text != "")
                {
                    button14.Text = "";
                }

                else if (button25.Text != "")
                {
                    button25.Text = "";
                }

            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button14.Text = "X";
                sayac++;
                anatassatır = 1;
                anatassutun = 4;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 1;
                sutun = 4;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button14.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button14.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button14.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button14.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button14.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button14.Text != "X")
            {
                if (button15.Text != "" && button15.Text != "X")
                {
                    int a = Convert.ToInt32(button15.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button14.Text = a.ToString();
                    button15.Text = "";
                }
                else if (button13.Text != "" && button13.Text != "X")
                {
                    int a = Convert.ToInt32(button13.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button14.Text = a.ToString();
                    button13.Text = "";
                }
                else if (button24.Text != "" && button24.Text != "X")
                {
                    int a = Convert.ToInt32(button24.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button14.Text = a.ToString();
                    button24.Text = "";
                }

            }
            else if (sayac == 6 && button14.Text == "X")
            {
                if (button15.Text != "")
                {
                    button15.Text = "";
                }
                else if (button13.Text != "")
                {
                    button13.Text = "";
                }

                else if (button24.Text != "")
                {
                    button24.Text = "";
                }

            }


        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button13.Text = "X";
                sayac++;
                anatassatır = 1;
                anatassutun = 3;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 1;
                sutun = 3;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button13.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button13.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button13.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button13.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button13.Text = tas5.ToString();
                }

                sayac++;
            }


            if (sayac == 6 && button13.Text != "X")
            {
                if (button14.Text != "" && button14.Text != "X")
                {
                    int a = Convert.ToInt32(button14.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button13.Text = a.ToString();
                    button14.Text = "";
                }
                else if (button12.Text != "" && button12.Text != "X")
                {
                    int a = Convert.ToInt32(button12.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button13.Text = a.ToString();
                    button12.Text = "";
                }
                else if (button23.Text != "" && button23.Text != "X")
                {
                    int a = Convert.ToInt32(button23.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button13.Text = a.ToString();
                    button23.Text = "";
                }

            }
            else if (sayac == 6 && button13.Text == "X")
            {
                if (button14.Text != "")
                {
                    button14.Text = "";
                }
                else if (button12.Text != "")
                {
                    button12.Text = "";
                }

                else if (button23.Text != "")
                {
                    button23.Text = "";
                }

            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button12.Text = "X";
                sayac++;
                anatassatır = 1;
                anatassutun = 2;
            }


            else if (sayac < 6 && sayac > 0)
            {
                satır = 1;
                sutun = 2;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button12.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button12.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button12.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button12.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button12.Text = tas5.ToString();
                }

                sayac++;
            }



            if (sayac == 6 && button12.Text != "X")
            {
                if (button13.Text != "" && button13.Text != "X")
                {
                    int a = Convert.ToInt32(button13.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button12.Text = a.ToString();
                    button13.Text = "";
                }
                else if (button11.Text != "" && button11.Text != "X")
                {
                    int a = Convert.ToInt32(button11.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button12.Text = a.ToString();
                    button11.Text = "";
                }
                else if (button22.Text != "" && button22.Text != "X")
                {
                    int a = Convert.ToInt32(button22.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button12.Text = a.ToString();
                    button22.Text = "";
                }

            }
            else if (sayac == 6 && button12.Text == "X")
            {
                if (button13.Text != "")
                {
                    button13.Text = "";
                }
                else if (button11.Text != "")
                {
                    button11.Text = "";
                }

                else if (button22.Text != "")
                {
                    button22.Text = "";
                }

            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                button11.Text = "X";
                sayac++;
                anatassatır = 1;
                anatassutun = 1;
            }



            else if (sayac < 6 && sayac > 0)
            {
                satır = 1;
                sutun = 1;
                if (anatassatır > satır)
                    toplamsatır = anatassatır - satır;
                else if (satır > anatassatır)
                    toplamsatır = satır - anatassatır;
                else
                    toplamsatır = 0;


                if (anatassutun > sutun)
                    toplamsutun = anatassutun - sutun;
                else if (sutun > anatassutun)
                    toplamsutun = sutun - anatassutun;
                else
                    toplamsutun = 0;


                if (sayac == 1)
                {
                    tas1 = toplamsatır + toplamsutun;
                    button11.Text = tas1.ToString();
                }
                else if (sayac == 2)
                {
                    tas2 = toplamsatır + toplamsutun;
                    button11.Text = tas2.ToString();
                }
                else if (sayac == 3)
                {
                    tas3 = toplamsatır + toplamsutun;
                    button11.Text = tas3.ToString();
                }
                else if (sayac == 4)
                {
                    tas4 = toplamsatır + toplamsutun;
                    button11.Text = tas4.ToString();
                }
                else if (sayac == 5)
                {
                    tas5 = toplamsatır + toplamsutun;
                    button11.Text = tas5.ToString();
                }

                sayac++;
            }

            if (sayac == 6 && button11.Text != "X")
            {
                if (button12.Text != "" && button12.Text != "X")
                {
                    int a = Convert.ToInt32(button12.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button11.Text = a.ToString();
                    button12.Text = "";
                }

                else if (button21.Text != "" && button21.Text != "X")
                {
                    int a = Convert.ToInt32(button21.Text);
                    a--;
                    if (a == 0)
                    {
                        MessageBox.Show("Kaybettin");
                        Application.Exit();
                    }
                    button11.Text = a.ToString();
                    button21.Text = "";
                }

            }
            else if (sayac == 6 && button11.Text == "X")
            {
                if (button12.Text != "")
                {
                    button12.Text = "";
                }
 

                else if (button21.Text != "")
                {
                    button21.Text = "";
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
