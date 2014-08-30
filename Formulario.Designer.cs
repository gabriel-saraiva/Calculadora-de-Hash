namespace Calculadora_de_Hash
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.BCsha1 = new System.Windows.Forms.Button();
            this.BAsha1 = new System.Windows.Forms.Button();
            this.TextBoxSHA1 = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.LinkLabelSITE = new System.Windows.Forms.LinkLabel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.OPENfileDIALOG = new System.Windows.Forms.OpenFileDialog();
            this.GroupBox2.SuspendLayout();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BCsha1
            // 
            this.BCsha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCsha1.Location = new System.Drawing.Point(8, 64);
            this.BCsha1.Margin = new System.Windows.Forms.Padding(4);
            this.BCsha1.Name = "BCsha1";
            this.BCsha1.Size = new System.Drawing.Size(215, 34);
            this.BCsha1.TabIndex = 0;
            this.BCsha1.Text = "Calcular";
            this.BCsha1.UseVisualStyleBackColor = true;
            this.BCsha1.Click += new System.EventHandler(this.BCsha1_Click);
            // 
            // BAsha1
            // 
            this.BAsha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAsha1.Location = new System.Drawing.Point(160, 26);
            this.BAsha1.Margin = new System.Windows.Forms.Padding(4);
            this.BAsha1.Name = "BAsha1";
            this.BAsha1.Size = new System.Drawing.Size(62, 30);
            this.BAsha1.TabIndex = 2;
            this.BAsha1.Text = "Abrir";
            this.BAsha1.UseVisualStyleBackColor = true;
            this.BAsha1.Click += new System.EventHandler(this.BAsha1_Click);
            // 
            // TextBoxSHA1
            // 
            this.TextBoxSHA1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSHA1.Location = new System.Drawing.Point(8, 26);
            this.TextBoxSHA1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSHA1.Name = "TextBoxSHA1";
            this.TextBoxSHA1.Size = new System.Drawing.Size(146, 30);
            this.TextBoxSHA1.TabIndex = 1;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.TextBoxSHA1);
            this.GroupBox2.Controls.Add(this.BAsha1);
            this.GroupBox2.Controls.Add(this.BCsha1);
            this.GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(11, 12);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(231, 108);
            this.GroupBox2.TabIndex = 15;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "SHA1 Calculator";
            // 
            // LinkLabelSITE
            // 
            this.LinkLabelSITE.AutoSize = true;
            this.LinkLabelSITE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelSITE.LinkColor = System.Drawing.Color.Aqua;
            this.LinkLabelSITE.Location = new System.Drawing.Point(305, 32);
            this.LinkLabelSITE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabelSITE.Name = "LinkLabelSITE";
            this.LinkLabelSITE.Size = new System.Drawing.Size(243, 29);
            this.LinkLabelSITE.TabIndex = 0;
            this.LinkLabelSITE.TabStop = true;
            this.LinkLabelSITE.Text = "gldss-creative.com.br";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Location = new System.Drawing.Point(298, 9);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(254, 18);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Copyright © GLDSS-CREATIVE 2013";
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Panel.Controls.Add(this.Label1);
            this.Panel.Controls.Add(this.LinkLabelSITE);
            this.Panel.Location = new System.Drawing.Point(11, 360);
            this.Panel.Margin = new System.Windows.Forms.Padding(4);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(848, 71);
            this.Panel.TabIndex = 14;
            // 
            // OPENfileDIALOG
            // 
            this.OPENfileDIALOG.FileName = "DIALG";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 438);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.GroupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 399);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Hash";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BCsha1;
        internal System.Windows.Forms.Button BAsha1;
        internal System.Windows.Forms.TextBox TextBoxSHA1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.LinkLabel LinkLabelSITE;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.OpenFileDialog OPENfileDIALOG;

    }
}

