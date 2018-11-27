namespace APA_Reference_App
{
    partial class MainScreen
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outbox = new System.Windows.Forms.RichTextBox();
            this.copybutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 118);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(280, 63);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(86, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "GET DATA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outbox
            // 
            this.outbox.BackColor = System.Drawing.Color.White;
            this.outbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outbox.Location = new System.Drawing.Point(301, 13);
            this.outbox.Margin = new System.Windows.Forms.Padding(4);
            this.outbox.Name = "outbox";
            this.outbox.ReadOnly = true;
            this.outbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outbox.Size = new System.Drawing.Size(447, 436);
            this.outbox.TabIndex = 3;
            this.outbox.Text = "";
            // 
            // copybutton
            // 
            this.copybutton.BackColor = System.Drawing.SystemColors.Desktop;
            this.copybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copybutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.copybutton.Location = new System.Drawing.Point(86, 264);
            this.copybutton.Margin = new System.Windows.Forms.Padding(4);
            this.copybutton.Name = "copybutton";
            this.copybutton.Size = new System.Drawing.Size(145, 48);
            this.copybutton.TabIndex = 4;
            this.copybutton.Text = "COPY ";
            this.copybutton.UseVisualStyleBackColor = false;
            this.copybutton.Click += new System.EventHandler(this.copybutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.SystemColors.Desktop;
            this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearbutton.Location = new System.Drawing.Point(86, 320);
            this.clearbutton.Margin = new System.Windows.Forms.Padding(4);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(145, 48);
            this.clearbutton.TabIndex = 5;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(761, 462);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.copybutton);
            this.Controls.Add(this.outbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "APA Reference App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        protected System.Windows.Forms.RichTextBox outbox;
        private System.Windows.Forms.Button copybutton;
        private System.Windows.Forms.Button clearbutton;
    }
}

