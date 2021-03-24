using System.Windows.Forms;

namespace Draw_Point
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ToolBoxRadioButton = new System.Windows.Forms.RadioButton();
            this.CrtajTackeRadioButton = new System.Windows.Forms.RadioButton();
            this.ToolBox = new System.Windows.Forms.GroupBox();
            this.CrtajTrougaoButton = new System.Windows.Forms.Button();
            this.CrtajPravuButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.PictureBox.Location = new System.Drawing.Point(-1, 75);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(962, 568);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ToolBoxRadioButton);
            this.groupBox1.Controls.Add(this.CrtajTackeRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ToolBoxRadioButton
            // 
            this.ToolBoxRadioButton.AutoSize = true;
            this.ToolBoxRadioButton.Location = new System.Drawing.Point(10, 42);
            this.ToolBoxRadioButton.Name = "ToolBoxRadioButton";
            this.ToolBoxRadioButton.Size = new System.Drawing.Size(86, 17);
            this.ToolBoxRadioButton.TabIndex = 1;
            this.ToolBoxRadioButton.TabStop = true;
            this.ToolBoxRadioButton.Text = "Use ToolBox";
            this.ToolBoxRadioButton.UseVisualStyleBackColor = true;
            this.ToolBoxRadioButton.CheckedChanged += new System.EventHandler(this.radToolBoxUse_CheckedChanged);
            // 
            // CrtajTackeRadioButton
            // 
            this.CrtajTackeRadioButton.AutoSize = true;
            this.CrtajTackeRadioButton.Location = new System.Drawing.Point(10, 19);
            this.CrtajTackeRadioButton.Name = "CrtajTackeRadioButton";
            this.CrtajTackeRadioButton.Size = new System.Drawing.Size(82, 17);
            this.CrtajTackeRadioButton.TabIndex = 0;
            this.CrtajTackeRadioButton.TabStop = true;
            this.CrtajTackeRadioButton.Text = "Draw Points";
            this.CrtajTackeRadioButton.UseVisualStyleBackColor = true;
            this.CrtajTackeRadioButton.CheckedChanged += new System.EventHandler(this.radDrawPoints_CheckedChanged);
            // 
            // ToolBox
            // 
            this.ToolBox.Controls.Add(this.CrtajTrougaoButton);
            this.ToolBox.Controls.Add(this.CrtajPravuButton);
            this.ToolBox.Location = new System.Drawing.Point(127, 0);
            this.ToolBox.Name = "ToolBox";
            this.ToolBox.Size = new System.Drawing.Size(109, 69);
            this.ToolBox.TabIndex = 3;
            this.ToolBox.TabStop = false;
            this.ToolBox.Text = "ToolBox";
            // 
            // CrtajTrougaoButton
            // 
            this.CrtajTrougaoButton.Location = new System.Drawing.Point(9, 40);
            this.CrtajTrougaoButton.Name = "CrtajTrougaoButton";
            this.CrtajTrougaoButton.Size = new System.Drawing.Size(97, 20);
            this.CrtajTrougaoButton.TabIndex = 1;
            this.CrtajTrougaoButton.Text = "Draw Rectangle";
            this.CrtajTrougaoButton.UseVisualStyleBackColor = true;
            // 
            // CrtajPravuButton
            // 
            this.CrtajPravuButton.Location = new System.Drawing.Point(24, 16);
            this.CrtajPravuButton.Name = "CrtajPravuButton";
            this.CrtajPravuButton.Size = new System.Drawing.Size(63, 20);
            this.CrtajPravuButton.TabIndex = 0;
            this.CrtajPravuButton.Text = "Draw Line";
            this.CrtajPravuButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(404, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 69);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(958, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ToolBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ToolBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private GroupBox groupBox1;
        private RadioButton ToolBoxRadioButton;
        private RadioButton CrtajTackeRadioButton;
        private GroupBox ToolBox;
        private Button CrtajTrougaoButton;
        private Button CrtajPravuButton;
        private GroupBox groupBox2;
    }
}

