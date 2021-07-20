
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
            this.shapesGroupBox = new System.Windows.Forms.GroupBox();
            this.rhombusRadioButton = new System.Windows.Forms.RadioButton();
            this.ellipseRadioButton = new System.Windows.Forms.RadioButton();
            this.quadrangleRadioButton = new System.Windows.Forms.RadioButton();
            this.triangleRadioButton = new System.Windows.Forms.RadioButton();
            this.toolsGroupBox = new System.Windows.Forms.GroupBox();
            this.moveButton = new System.Windows.Forms.RadioButton();
            this.drawButton = new System.Windows.Forms.RadioButton();
            this.selectButton = new System.Windows.Forms.RadioButton();
            this.modePanel.SuspendLayout();
            this.shapesGroupBox.SuspendLayout();
            this.toolsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // modePanel
            // 
            this.modePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modePanel.Controls.Add(this.shapesGroupBox);
            this.modePanel.Controls.Add(this.toolsGroupBox);
            this.modePanel.Location = new System.Drawing.Point(746, 1);
            this.modePanel.Name = "modePanel";
            this.modePanel.Size = new System.Drawing.Size(60, 510);
            this.modePanel.TabIndex = 0;
            // 
            // shapesGroupBox
            // 
            this.shapesGroupBox.Controls.Add(this.rhombusRadioButton);
            this.shapesGroupBox.Controls.Add(this.ellipseRadioButton);
            this.shapesGroupBox.Controls.Add(this.quadrangleRadioButton);
            this.shapesGroupBox.Controls.Add(this.triangleRadioButton);
            this.shapesGroupBox.Location = new System.Drawing.Point(3, 158);
            this.shapesGroupBox.Name = "shapesGroupBox";
            this.shapesGroupBox.Size = new System.Drawing.Size(54, 182);
            this.shapesGroupBox.TabIndex = 1;
            this.shapesGroupBox.TabStop = false;
            this.shapesGroupBox.Text = "Shape";
            this.shapesGroupBox.Visible = false;
            // 
            // rhombusRadioButton
            // 
            this.rhombusRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.rhombusRadioButton.Image = global::Geometry.Properties.Resources.rhombus;
            this.rhombusRadioButton.Location = new System.Drawing.Point(12, 135);
            this.rhombusRadioButton.Name = "rhombusRadioButton";
            this.rhombusRadioButton.Size = new System.Drawing.Size(32, 32);
            this.rhombusRadioButton.TabIndex = 6;
            this.rhombusRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rhombusRadioButton.UseVisualStyleBackColor = true;
            this.rhombusRadioButton.CheckedChanged += new System.EventHandler(this.RhombusRadioButton_CheckedChanged);
            // 
            // ellipseRadioButton
            // 
            this.ellipseRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ellipseRadioButton.Image = global::Geometry.Properties.Resources.ellipse;
            this.ellipseRadioButton.Location = new System.Drawing.Point(12, 97);
            this.ellipseRadioButton.Name = "ellipseRadioButton";
            this.ellipseRadioButton.Size = new System.Drawing.Size(32, 32);
            this.ellipseRadioButton.TabIndex = 5;
            this.ellipseRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ellipseRadioButton.UseVisualStyleBackColor = true;
            this.ellipseRadioButton.CheckedChanged += new System.EventHandler(this.EllipseRadioButton_CheckedChanged);
            // 
            // quadrangleRadioButton
            // 
            this.quadrangleRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.quadrangleRadioButton.Image = global::Geometry.Properties.Resources.qudrangle;
            this.quadrangleRadioButton.Location = new System.Drawing.Point(12, 21);
            this.quadrangleRadioButton.Name = "quadrangleRadioButton";
            this.quadrangleRadioButton.Size = new System.Drawing.Size(32, 32);
            this.quadrangleRadioButton.TabIndex = 3;
            this.quadrangleRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.quadrangleRadioButton.UseVisualStyleBackColor = true;
            this.quadrangleRadioButton.CheckedChanged += new System.EventHandler(this.QuadrangleRadioButton_CheckedChanged);
            // 
            // triangleRadioButton
            // 
            this.triangleRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.triangleRadioButton.Image = global::Geometry.Properties.Resources.triangle;
            this.triangleRadioButton.Location = new System.Drawing.Point(12, 59);
            this.triangleRadioButton.Name = "triangleRadioButton";
            this.triangleRadioButton.Size = new System.Drawing.Size(32, 32);
            this.triangleRadioButton.TabIndex = 4;
            this.triangleRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.triangleRadioButton.UseVisualStyleBackColor = true;
            this.triangleRadioButton.CheckedChanged += new System.EventHandler(this.TriangleRadioButton_CheckedChanged);
            // 
            // toolsGroupBox
            // 
            this.toolsGroupBox.Controls.Add(this.moveButton);
            this.toolsGroupBox.Controls.Add(this.drawButton);
            this.toolsGroupBox.Controls.Add(this.selectButton);
            this.toolsGroupBox.Location = new System.Drawing.Point(3, 4);
            this.toolsGroupBox.Name = "toolsGroupBox";
            this.toolsGroupBox.Size = new System.Drawing.Size(54, 139);
            this.toolsGroupBox.TabIndex = 0;
            this.toolsGroupBox.TabStop = false;
            this.toolsGroupBox.Text = "Tool";
            // 
            // moveButton
            // 
            this.moveButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.moveButton.Image = global::Geometry.Properties.Resources.move16;
            this.moveButton.Location = new System.Drawing.Point(12, 98);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(32, 32);
            this.moveButton.TabIndex = 2;
            this.moveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.CheckedChanged += new System.EventHandler(this.MoveButton_CheckedChanged);
            // 
            // drawButton
            // 
            this.drawButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.drawButton.Image = global::Geometry.Properties.Resources.draw16;
            this.drawButton.Location = new System.Drawing.Point(12, 60);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(32, 32);
            this.drawButton.TabIndex = 1;
            this.drawButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.CheckedChanged += new System.EventHandler(this.DrawButton_CheckedChanged);
            // 
            // selectButton
            // 
            this.selectButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectButton.Image = global::Geometry.Properties.Resources.select16;
            this.selectButton.Location = new System.Drawing.Point(12, 22);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(32, 32);
            this.selectButton.TabIndex = 0;
            this.selectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.CheckedChanged += new System.EventHandler(this.SelectButton_CheckedChanged);
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 512);
            this.Controls.Add(this.modePanel);
            this.Name = "DrawingForm";
            this.Text = "Shape editor";
            this.modePanel.ResumeLayout(false);
            this.shapesGroupBox.ResumeLayout(false);
            this.toolsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel modePanel;
        private RadioButton selectButton;
        private RadioButton moveButton;
        private RadioButton drawButton;
        private GroupBox shapesGroupBox;
        private RadioButton rhombusRadioButton;
        private RadioButton ellipseRadioButton;
        private RadioButton quadrangleRadioButton;
        private RadioButton triangleRadioButton;
        private GroupBox toolsGroupBox;
    }
}

