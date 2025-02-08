namespace Opdracht3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtWoonplaats = new System.Windows.Forms.TextBox();
            this.btnWoonplaats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxOverzicht = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtWoonplaats);
            this.groupBox2.Controls.Add(this.btnWoonplaats);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(151, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(519, 169);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recepten";
            // 
            // txtWoonplaats
            // 
            this.txtWoonplaats.Location = new System.Drawing.Point(199, 23);
            this.txtWoonplaats.Margin = new System.Windows.Forms.Padding(4);
            this.txtWoonplaats.Name = "txtWoonplaats";
            this.txtWoonplaats.Size = new System.Drawing.Size(132, 22);
            this.txtWoonplaats.TabIndex = 3;
            // 
            // btnWoonplaats
            // 
            this.btnWoonplaats.Location = new System.Drawing.Point(199, 55);
            this.btnWoonplaats.Margin = new System.Windows.Forms.Padding(4);
            this.btnWoonplaats.Name = "btnWoonplaats";
            this.btnWoonplaats.Size = new System.Drawing.Size(133, 28);
            this.btnWoonplaats.TabIndex = 2;
            this.btnWoonplaats.Text = "Klik hier";
            this.btnWoonplaats.UseVisualStyleBackColor = true;
            this.btnWoonplaats.Click += new System.EventHandler(this.btnWoonplaats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef ID aan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxOverzicht);
            this.groupBox1.Location = new System.Drawing.Point(26, 190);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(851, 439);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overzicht Recepten";
            // 
            // lbxOverzicht
            // 
            this.lbxOverzicht.FormattingEnabled = true;
            this.lbxOverzicht.ItemHeight = 16;
            this.lbxOverzicht.Location = new System.Drawing.Point(103, 44);
            this.lbxOverzicht.Margin = new System.Windows.Forms.Padding(4);
            this.lbxOverzicht.Name = "lbxOverzicht";
            this.lbxOverzicht.Size = new System.Drawing.Size(651, 372);
            this.lbxOverzicht.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 684);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtWoonplaats;
        private System.Windows.Forms.Button btnWoonplaats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxOverzicht;
    }
}

