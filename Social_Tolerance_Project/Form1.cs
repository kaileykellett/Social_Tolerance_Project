using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Tolerance_Project
{
    public partial class Form1 : Form
    {
        public enum PeopleTypes { blank = 0, blue = 1, red = 2, green = 3, gold = 4, purple = 5 }
        Random r = new Random();

        //x size of control panel off to the side
        public int controlSize = 230;

        //the dimension of each "grid box"
        public int gridSize = 5;
        //grid dimensions, accessible to the user
        public int n = 160; //grid size
        //"types" of people in the world
        public int p = 2;

        //tolerance level (in decimal percentage)
        public double t = .5;
        public bool happy = true;
        //percent of population unoccupied (between 5 and 30%)
        public int u = 30;

        //used to speed up how many cells are moved in a timer tick
        public int time = 100000;

        //population ratios
        public int blueWeight = 1;
        public int redWeight = 1;
        public int greenWeight = 1;
        public int goldWeight = 1;
        public int purpleWeight = 1;

        //public int[] populationWeights = new int[6] { 0, 1, 3, 1, 1, 1 };
        public PeopleTypes[,] population;
        public bool[,] requiresMove;

        //change this, make an array of brushes
        public Brush type1 = new SolidBrush(Color.CadetBlue);
        public Brush type2 = new SolidBrush(Color.OrangeRed);
        public Brush type3 = new SolidBrush(Color.MediumSeaGreen);
        public Brush type4 = new SolidBrush(Color.Gold);
        public Brush type5 = new SolidBrush(Color.Indigo);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            population = new PeopleTypes[n, n];
            requiresMove = new bool[n, n];

            int[] populationWeights = new int[6] { 0, blueWeight, redWeight, greenWeight, goldWeight, purpleWeight };
            int totalWeights = 0;
            for (int k = 1; k <= p; k++)
                totalWeights += populationWeights[k];

            if (p == 2)
            {
                UDpurpleWeight.Enabled = false;
                UDgreenWeight.Enabled = false;
                UDyellowWeight.Enabled = false;
            }

            else if (p == 3)
            {
                UDgreenWeight.Enabled = true;
                UDyellowWeight.Enabled = false;
                UDpurpleWeight.Enabled = false;
            }

            else if (p == 4)
            {
                UDgreenWeight.Enabled = true;
                UDyellowWeight.Enabled = true;
                UDpurpleWeight.Enabled = false;
            }

            else if (p == 5)
            {
                UDgreenWeight.Enabled = true;
                UDyellowWeight.Enabled = true;
                UDpurpleWeight.Enabled = true;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //generate a value between 1 and 100
                    int temp = r.Next(1, 100);

                    //if it's less than unoccupied, leave it blank
                    if (temp < u)
                        population[i, j] = PeopleTypes.blank;

                    //it's more than percent unoccupied! so figure out which people are in it
                    else
                    {
                        double t = r.Next() * 1.0 * totalWeights / int.MaxValue;
                        int currentWeights = 0;

                        for (int k = 1; k <= p; k++)
                        {
                            currentWeights += populationWeights[k];
                            if (t < currentWeights)
                            {
                                population[i, j] = (PeopleTypes)k;
                                break;
                            }
                        }
                    }

                }
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random r = new Random();
            Graphics gr = e.Graphics;

            gr.TranslateTransform(0, menuStrip1.Height);
            ClientSize = new Size((n * gridSize) + controlSize, n * gridSize + menuStrip1.Height);

            Rectangle control = new Rectangle(0, 0, controlSize, ClientSize.Height);
            Rectangle picture = new Rectangle(controlSize, 0, ClientSize.Width - controlSize, ClientSize.Height);

            gr.DrawRectangle(Pens.Black, control);
            gr.DrawRectangle(Pens.Black, picture);

            //make rectangles for the grid
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Rectangle rect = new Rectangle(i * gridSize + controlSize, j * gridSize, gridSize, gridSize);

                    if (population[i, j] == PeopleTypes.blank)
                        gr.FillRectangle(Brushes.White, rect);

                    else if (population[i, j] == PeopleTypes.blue)
                        gr.FillRectangle(type1, rect);

                    else if (population[i, j] == PeopleTypes.red)
                        gr.FillRectangle(type2, rect);

                    else if (population[i, j] == PeopleTypes.green)
                        gr.FillRectangle(type3, rect);

                    else if (population[i, j] == PeopleTypes.gold)
                        gr.FillRectangle(type4, rect);

                    else if (population[i, j] == PeopleTypes.purple)
                        gr.FillRectangle(type5, rect);

                    gr.DrawRectangle(Pens.Black, rect);
                }
            }

        }

        private void DetermineHappinessRandom()
        {
            int i = r.Next(n);
            int j = r.Next(n);

            //cell is not blank
            if (population[i, j] != PeopleTypes.blank)
            {
                int neighbors = 0;
                int sameNeighbors = 0;
                //similarity level (only to be displayed, t is control)
                double s = 1;
                //look left and right
                for (int x = i - 1; x <= i + 1; x++)
                {
                    for (int y = j - 1; y <= j + 1; y++)
                    {
                        //if the cell is the same, skip it
                        if (i == x && j == y)
                            continue;
                        int xx = (x + n) % n;
                        int yy = (y + n) % n;

                        //if the cell isn't blank
                        if (population[xx, yy] != PeopleTypes.blank)
                        {
                            //only count a neighbour if the cell isn't blank
                            neighbors++;

                            //mod by the number of cells for a "wrap-around" board, check if they're the same
                            if (population[xx, yy] == population[i, j])
                                sameNeighbors++;
                        }

                    }
                }
                //calculate the "similarity" level (how many of their neighbors are the same)
                s = sameNeighbors * 1.0 / neighbors;

                //compare similarity to tolerance
                if (s < t)
                    Move(i, j);
            }

        }

        public void Move(int i, int j)
        {
            // find an empty location
            int x = 0, y = 0;
            do
            {
                x = r.Next(0, n);
                y = r.Next(0, n);
            } while (population[x, y] != 0);

            population[x, y] = population[i, j];
            population[i, j] = 0;
        }

        private void sliderpeopleTypes_Scroll(object sender, EventArgs e)
        {
            //types of people is changed
            p = sliderpeopleTypes.Value;
            Form1_Load(sender, e);
            this.Invalidate();
        }

        private void trackBarXGrid_Scroll(object sender, EventArgs e)
        {
            //grid size is changed
            n = trackBarXGrid.Value;
            Form1_Load(sender, e);
            lblGridX.Text = "Grid Size - " + n + " x " + n;
            this.Invalidate();
        }

        private void trackBarTolerance_Scroll(object sender, EventArgs e)
        {
            t = trackBarTolerance.Value * 1.0 / 100;
            lblToleranceValue.Text = "(" + (100 - (t * 100)).ToString() + "%)";
            //Form1_Load(sender, e);
            this.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < time; i++)
            DetermineHappinessRandom();

            this.Invalidate();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1_Tick(sender, e);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            this.Invalidate();
        }

        private void trackBarUnoccupiedPercent_Scroll(object sender, EventArgs e)
        {
            u = trackBarUnoccupiedPercent.Value;
            lblPercentUnoccupied.Text = "Percent Unoccupied (" + u + "%)";
            Form1_Load(sender, e);
            this.Invalidate();
        }

        private void UDredWeight_ValueChanged(object sender, EventArgs e)
        {
            redWeight = (int)UDredWeight.Value;
            Form1_Load(sender, e);
            this.Invalidate();
        }

        private void UDblueWeight_ValueChanged(object sender, EventArgs e)
        {
            blueWeight = (int)UDblueWeight.Value;
            Form1_Load(sender, e);
            this.Invalidate();
        }

        private void UDgreenWeight_ValueChanged(object sender, EventArgs e)
        {
            greenWeight = (int)UDgreenWeight.Value;
            Form1_Load(sender, e);
            this.Invalidate();
        }

        private void UDyellowWeight_ValueChanged(object sender, EventArgs e)
        {
            goldWeight = (int)UDyellowWeight.Value;
            Form1_Load(sender, e);
            this.Invalidate();
        }

        private void UDpurpleWeight_ValueChanged(object sender, EventArgs e)
        {
            purpleWeight = (int)UDpurpleWeight.Value;
            Form1_Load(sender, e);
            this.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
                this.Dispose();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutBox1 = new AboutBox1();
            AboutBox1.ShowDialog();
        }


        private void trackBarTimer_Scroll(object sender, EventArgs e)
        {
            time = trackBarTimer.Value;
        }
    }
}
