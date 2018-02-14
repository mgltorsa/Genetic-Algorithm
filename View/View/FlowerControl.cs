using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FlowerControl : UserControl
    {
        public FlowerControl()
        {
            InitializeComponent();
        }

        private void FlowerControl_Paint(object sender, PaintEventArgs e)
        {
            if (main != null)
            {
                //Paint a floor
                e.Graphics.FillRectangle(Brushes.DarkGreen, 0, 550, 800, 50);

                //paint flowers
                PaintFLowers(sender, e);
            }

        }

        private void PaintFLowers(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < main.CountTotalFlowers(); i++)
            {
                Flower flower = main.GetFlower(i);
                SelectStemColor(flower, e);
                PaintFlower(flower, e);
                main.AddGeneration();
            }
        }

        private void PaintFlower(Flower flower, PaintEventArgs e)
        {
            Color cFlower = new Color();
            if (flower.GetColor() == 0)
            {
                cFlower = Color.Red;
            }
            else if (flower.GetColor() == 1)
            {
                cFlower = Color.Blue;
            }
            else if (flower.GetColor() == 2)
            {
                cFlower = Color.Yellow;
            }

            e.Graphics.FillEllipse(new SolidBrush(cFlower),
                flower.WindowPosition + flower.GetStemWidth() / 2 - flower.GetStemSize() / 2,
                550 - flower.GetHeight() - flower.GetStemSize() / 2,
                flower.GetStemSize(), flower.GetStemSize());

            //paint a center of flower
            e.Graphics.FillEllipse(Brushes.DarkOrange,
            flower.WindowPosition + flower.GetStemWidth() / 2 - flower.GetSizeCenter() / 2,
            550 - flower.GetHeight() - flower.GetSizeCenter() / 2,
            flower.GetSizeCenter(), flower.GetSizeCenter());

        }

        private void SelectStemColor(Flower flower, PaintEventArgs e)
        {
            if (flower.GetStemColor() == 0)
            {
                e.Graphics.FillRectangle(Brushes.DarkGreen, flower.WindowPosition,
                    550 - flower.GetHeight(), flower.GetStemWidth(), flower.GetHeight());

            }
            else if (flower.GetStemColor() == 1)
            {
                e.Graphics.FillRectangle(Brushes.Green,
                    flower.WindowPosition, 550 - flower.GetHeight(), flower.GetStemWidth(), flower.GetHeight());

            }
            else if (flower.GetStemColor() == 2)
            {
                e.Graphics.FillRectangle(Brushes.LightGreen,
                    flower.WindowPosition, 550 - flower.GetHeight(), flower.GetStemWidth(), flower.GetHeight());
            }

        }

        public void SetMain(Main main)
        {
            this.main = main;
        }

        public void CalculateAdaptation()
        {
            int height = 0, color, size;
            color = size = height;

            double AHeight = 0.0, AColor, ASize;
            AColor = ASize = AHeight;

            int selectedOption = main.GetSelectedHeight();

        }


    }
}
