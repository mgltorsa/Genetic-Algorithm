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

        private void BtGeneration_Click(object sender, EventArgs e)
        {
            if(sender == btGeneration)
            {
                NextGeneration();
            }
            else
            {
                throw new MethodAccessException("The sender isn't the source expected: " + sender.ToString());
            }
        }

        private void NextGeneration()
        {
            CalculateAdaptation();

            SelectParents();

            MergeGen();




            flowerControl.Refresh();
        }

        private void SelectParents()
        {
           
            

        }

        private void MergeGen()
        {
            throw new NotImplementedException(); 
        }

        private void CalculateAdaptation()
        {
            flowerControl.CalculateAdaptation();
        }

        public int GetSelectedHeight()
        {
            int selectedHeight = optionControl.GetSelectedHeight();
            if (selectedHeight == -1)
            {
                selectedHeight = 0;
            }
            return selectedHeight;
            
        }
    }
}
