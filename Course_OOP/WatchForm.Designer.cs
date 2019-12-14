namespace Course_OOP
{
    partial class TicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MackbetButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExitLabel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.MackbetButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 630);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MackbetButton
            // 
            this.MackbetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MackbetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MackbetButton.Image = ((System.Drawing.Image)(resources.GetObject("MackbetButton.Image")));
            this.MackbetButton.Location = new System.Drawing.Point(12, 183);
            this.MackbetButton.Name = "MackbetButton";
            this.MackbetButton.Size = new System.Drawing.Size(270, 339);
            this.MackbetButton.TabIndex = 0;
            this.MackbetButton.UseVisualStyleBackColor = true;
            this.MackbetButton.Click += new System.EventHandler(this.MackbetButton_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Посмотреть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitLabel.Location = new System.Drawing.Point(1316, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(37, 43);
            this.ExitLabel.TabIndex = 2;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(567, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "Спектакли";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 630);
            this.Controls.Add(this.panel1);
            this.Name = "TicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MackbetButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label label1;
    }
}