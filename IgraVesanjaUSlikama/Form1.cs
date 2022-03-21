using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgraVesanjaUSlikama
{
    public partial class IgraVesala : Form
    {
        string word;
        string[] solution;
        char guess;
        string stringSolution;
        int badguess;
        int goodguess;

        public IgraVesala()
        {
            InitializeComponent();
            word = "igrajigru";
            solution = new string[word.Length];
            MakeSolutionStrg();
        }
        public void MakeSolutionStrg()
        {
            string temp = "";
            for (int i = 0; i < word.Length; i++)
            {
                solution[i] = "_" + " ";
                stringSolution = temp + solution[i];
                temp = stringSolution;
            }
            label2.Text = stringSolution;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          
            bool found = false;
            guess = textBoxSlovo.Text[0];
            string temp = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].CompareTo(guess) == 0)
                {
                    solution[i] = guess.ToString();
                    goodguess++;
                    if (goodguess == word.Length)
                    {
                        label3.Text = "YOU WIN!!";
                    }
                    found = true;
                }
                stringSolution = temp + solution[i];
                temp = stringSolution;
            }
            if (found == false)
            {
                badguess++;
                if (badguess == 1)
                {
                    Graphics g = panel1.CreateGraphics();
                    Bitmap bitmap1 = new Bitmap(Properties.Resources.Glava);
                    g.DrawImage(bitmap1, 473, 120, 330, 99);                  
                }
                if (badguess == 2)
                {
                    Graphics g = panel1.CreateGraphics();
                    Bitmap bitmap2 = new Bitmap(Properties.Resources.Tijelo);
                    g.DrawImage(bitmap2, 475, 195, 297, 234);
                }
                if (badguess == 3)
                {
                    Graphics g = panel1.CreateGraphics();
                    Bitmap bitmap3 = new Bitmap(Properties.Resources.NogaLEva);
                    g.DrawImage(bitmap3, 448, 355, 307, 192);
                }
                if (badguess == 4)
                {
                    Graphics g = panel1.CreateGraphics();
                    Bitmap bitmap4 = new Bitmap(Properties.Resources.NogaDesna);
                    g.DrawImage(bitmap4, 627, 348, 127, 195);
                }
                if (badguess == 5)
                {
                    Graphics g = panel1.CreateGraphics();
                    Bitmap bitmap5 = new Bitmap(Properties.Resources.RukaLeva);
                    g.DrawImage(bitmap5, 390, 225, 227, 122);
                }
                if (badguess == 6)
                {
                    Graphics g= panel1.CreateGraphics();
                    Bitmap bitmap6 = new Bitmap(Properties.Resources.RukaDesna);
                    g.DrawImage(bitmap6, 628, 226, 180, 122);
                    label3.Text = "GAME OVER!";
                    button1.Visible = false;
                }
                }          
            label2.Text = stringSolution;
        }

        private void IgraVesala_Load(object sender, EventArgs e)
        {

        }
    }
    }
