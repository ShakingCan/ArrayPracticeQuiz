namespace ArrayPracticeQuiz
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
            this.cmnamebox = new System.Windows.Forms.ListBox();
            this.alphabetsbox = new System.Windows.Forms.ListBox();
            this.Determinebutton = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.cmnameboxmanual = new System.Windows.Forms.ListBox();
            this.alphabetsboxmanual = new System.Windows.Forms.ListBox();
            this.manualcmbtn = new System.Windows.Forms.Button();
            this.manualalphabtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmnamebox
            // 
            this.cmnamebox.FormattingEnabled = true;
            this.cmnamebox.Location = new System.Drawing.Point(34, 95);
            this.cmnamebox.Name = "cmnamebox";
            this.cmnamebox.Size = new System.Drawing.Size(120, 95);
            this.cmnamebox.TabIndex = 0;
            // 
            // alphabetsbox
            // 
            this.alphabetsbox.FormattingEnabled = true;
            this.alphabetsbox.Location = new System.Drawing.Point(34, 196);
            this.alphabetsbox.Name = "alphabetsbox";
            this.alphabetsbox.Size = new System.Drawing.Size(120, 95);
            this.alphabetsbox.TabIndex = 1;
            // 
            // Determinebutton
            // 
            this.Determinebutton.Location = new System.Drawing.Point(57, 66);
            this.Determinebutton.Name = "Determinebutton";
            this.Determinebutton.Size = new System.Drawing.Size(75, 23);
            this.Determinebutton.TabIndex = 3;
            this.Determinebutton.Text = "Determine";
            this.Determinebutton.UseVisualStyleBackColor = true;
            this.Determinebutton.Click += new System.EventHandler(this.Determinebutton_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(45, 40);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(100, 20);
            this.message.TabIndex = 4;
            this.message.Text = "Any message";
            // 
            // cmnameboxmanual
            // 
            this.cmnameboxmanual.FormattingEnabled = true;
            this.cmnameboxmanual.Location = new System.Drawing.Point(207, 95);
            this.cmnameboxmanual.Name = "cmnameboxmanual";
            this.cmnameboxmanual.Size = new System.Drawing.Size(120, 95);
            this.cmnameboxmanual.TabIndex = 5;
            this.cmnameboxmanual.SelectedIndexChanged += new System.EventHandler(this.cmnameboxmanual_SelectedIndexChanged);
            // 
            // alphabetsboxmanual
            // 
            this.alphabetsboxmanual.FormattingEnabled = true;
            this.alphabetsboxmanual.Location = new System.Drawing.Point(207, 196);
            this.alphabetsboxmanual.Name = "alphabetsboxmanual";
            this.alphabetsboxmanual.Size = new System.Drawing.Size(120, 95);
            this.alphabetsboxmanual.TabIndex = 6;
            // 
            // manualcmbtn
            // 
            this.manualcmbtn.Location = new System.Drawing.Point(358, 134);
            this.manualcmbtn.Name = "manualcmbtn";
            this.manualcmbtn.Size = new System.Drawing.Size(75, 23);
            this.manualcmbtn.TabIndex = 7;
            this.manualcmbtn.Text = "show name";
            this.manualcmbtn.UseVisualStyleBackColor = true;
            this.manualcmbtn.Click += new System.EventHandler(this.manualcmbtn_Click);
            // 
            // manualalphabtn
            // 
            this.manualalphabtn.Location = new System.Drawing.Point(358, 235);
            this.manualalphabtn.Name = "manualalphabtn";
            this.manualalphabtn.Size = new System.Drawing.Size(75, 23);
            this.manualalphabtn.TabIndex = 8;
            this.manualalphabtn.Text = "show content";
            this.manualalphabtn.UseVisualStyleBackColor = true;
            this.manualalphabtn.Click += new System.EventHandler(this.manualalphabtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.manualalphabtn);
            this.Controls.Add(this.manualcmbtn);
            this.Controls.Add(this.alphabetsboxmanual);
            this.Controls.Add(this.cmnameboxmanual);
            this.Controls.Add(this.message);
            this.Controls.Add(this.Determinebutton);
            this.Controls.Add(this.alphabetsbox);
            this.Controls.Add(this.cmnamebox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cmnamebox;
        private System.Windows.Forms.ListBox alphabetsbox;
        private System.Windows.Forms.Button Determinebutton;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.ListBox cmnameboxmanual;
        private System.Windows.Forms.ListBox alphabetsboxmanual;
        private System.Windows.Forms.Button manualcmbtn;
        private System.Windows.Forms.Button manualalphabtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

