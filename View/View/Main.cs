using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class Main : Form
    {
        public Main()
        {
            garden = new Garden();
            InitializeComponent();
            flowerControl.SetMain(this);
            
        }

        public Flower GetFlower(int index)
        {
           return garden.GetFlowerByIndex(index);
        }

        internal void AddGeneration()
        {
            lbGeneration.Text = "Generatión: " + generation.ToString();
        }

        public int CountTotalFlowers()
        {
           return garden.CountFLowers();
        }
    }
}
