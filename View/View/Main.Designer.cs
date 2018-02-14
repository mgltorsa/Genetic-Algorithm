using Model;
using System.Windows.Forms;
using View;


namespace View
{

    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.optionControl = new View.OptionControl();
            this.lbGeneration = new System.Windows.Forms.Label();
            this.flowerControl = new View.FlowerControl();
            this.SuspendLayout();
            // 
            // optionControl
            // 
            this.optionControl.Location = new System.Drawing.Point(12, 2);
            this.optionControl.Name = "optionControl";
            this.optionControl.Size = new System.Drawing.Size(655, 126);
            this.optionControl.TabIndex = 1;
            // 
            // lbGeneration
            // 
            this.lbGeneration.AutoSize = true;
            this.lbGeneration.Location = new System.Drawing.Point(12, 131);
            this.lbGeneration.Name = "lbGeneration";
            this.lbGeneration.Size = new System.Drawing.Size(74, 13);
            this.lbGeneration.TabIndex = 2;
            this.lbGeneration.Text = "Generación: 0";
            // 
            // flowerControl
            // 
            this.flowerControl.Location = new System.Drawing.Point(12, 157);
            this.flowerControl.Name = "flowerControl";
            this.flowerControl.Size = new System.Drawing.Size(723, 572);
            this.flowerControl.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 741);
            this.Controls.Add(this.flowerControl);
            this.Controls.Add(this.lbGeneration);
            this.Controls.Add(this.optionControl);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OptionControl optionControl;
        private Label lbGeneration;
        private Garden garden;
        private int generation;
        private FlowerControl flowerControl;
    }
}

