
using System.Windows.Forms;

namespace Geometry
{
    partial class DrawingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modePanel = new System.Windows.Forms.Panel();
            this.moveButton = new System.Windows.Forms.RadioButton();
            this.drawButton = new System.Windows.Forms.RadioButton();
            this.selectButton = new System.Windows.Forms.RadioButton();
            this.modePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // modePanel
            // 
            this.modePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modePanel.Controls.Add(this.moveButton);
            this.modePanel.Controls.Add(this.drawButton);
            this.modePanel.Controls.Add(this.selectButton);
            this.modePanel.Location = new System.Drawing.Point(852, 1);
            this.modePanel.Name = "modePanel";
            this.modePanel.Size = new System.Drawing.Size(28, 533);
            this.modePanel.TabIndex = 0;
            // 
            // moveButton
            // 
            this.moveButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.moveButton.AutoSize = true;
            this.moveButton.Image = global::Geometry.Properties.Resources.move16;
            this.moveButton.Location = new System.Drawing.Point(3, 59);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(22, 22);
            this.moveButton.TabIndex = 2;
            this.moveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.CheckedChanged += new System.EventHandler(this.moveButton_CheckedChanged);
            // 
            // drawButton
            // 
            this.drawButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.drawButton.AutoSize = true;
            this.drawButton.Image = global::Geometry.Properties.Resources.draw16;
            this.drawButton.Location = new System.Drawing.Point(3, 31);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(22, 22);
            this.drawButton.TabIndex = 1;
            this.drawButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.CheckedChanged += new System.EventHandler(this.drawButton_CheckedChanged);
            // 
            // selectButton
            // 
            this.selectButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectButton.AutoSize = true;
            this.selectButton.Image = global::Geometry.Properties.Resources.select16;
            this.selectButton.Location = new System.Drawing.Point(3, 3);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(22, 22);
            this.selectButton.TabIndex = 0;
            this.selectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.CheckedChanged += new System.EventHandler(this.selectButton_CheckedChanged);
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 535);
            this.Controls.Add(this.modePanel);
            this.Name = "DrawingForm";
            this.Text = "Shape editor";
            this.modePanel.ResumeLayout(false);
            this.modePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel modePanel;
        private RadioButton selectButton;
        private RadioButton moveButton;
        private RadioButton drawButton;
    }
}

