namespace AbcGymManagement.Forms
{
    partial class Trainer
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
            pictureBox18 = new PictureBox();
            lblTrainer = new Label();
            lblName = new Label();
            lbl = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            SuspendLayout();
            // 
            // pictureBox18
            // 
            pictureBox18.Image = Properties.Resources.Untitled_1;
            pictureBox18.Location = new Point(33, 65);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(788, 174);
            pictureBox18.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox18.TabIndex = 7;
            pictureBox18.TabStop = false;
            // 
            // lblTrainer
            // 
            lblTrainer.AutoSize = true;
            lblTrainer.BackColor = Color.FromArgb(64, 64, 64);
            lblTrainer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTrainer.ForeColor = SystemColors.ButtonHighlight;
            lblTrainer.Location = new Point(359, 134);
            lblTrainer.Name = "lblTrainer";
            lblTrainer.Size = new Size(94, 32);
            lblTrainer.TabIndex = 8;
            lblTrainer.Text = "Trainer";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(308, 270);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 24);
            lblName.TabIndex = 9;
            lblName.Text = "Name";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(308, 341);
            lbl.Name = "lbl";
            lbl.Size = new Size(62, 24);
            lbl.TabIndex = 9;
            lbl.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(962, 270);
            label2.Name = "label2";
            label2.Size = new Size(62, 24);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(962, 341);
            label3.Name = "label3";
            label3.Size = new Size(62, 24);
            label3.TabIndex = 9;
            label3.Text = "Name";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(419, 332);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(402, 33);
            comboBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(419, 270);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 31);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1073, 263);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(403, 31);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1073, 332);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(403, 31);
            textBox3.TabIndex = 11;
            // 
            // Trainer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 710);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(lbl);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(lblTrainer);
            Controls.Add(pictureBox18);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Trainer";
            Text = "Trainer";
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox18;
        private Label lblTrainer;
        private Label lblName;
        private Label lbl;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}