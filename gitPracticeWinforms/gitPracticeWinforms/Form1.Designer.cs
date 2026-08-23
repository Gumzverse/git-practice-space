namespace gitPracticeWinforms
{
    partial class Form1
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
            label1 = new Label();
            panel1 = new Panel();
            btnStandard = new Button();
            btnMetric = new Button();
            label2 = new Label();
            label3 = new Label();
            txtHeightFtCm = new TextBox();
            txtWeight = new TextBox();
            lblHeighInches = new Label();
            lblHeightFtCm = new Label();
            label7 = new Label();
            lblWeight = new Label();
            txtHeightInches = new TextBox();
            btnCalculate = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(217, 32);
            label1.TabIndex = 0;
            label1.Text = "BMI Calculator";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 67);
            panel1.TabIndex = 1;
            // 
            // btnStandard
            // 
            btnStandard.Location = new Point(110, 91);
            btnStandard.Name = "btnStandard";
            btnStandard.Size = new Size(94, 29);
            btnStandard.TabIndex = 2;
            btnStandard.Text = "Standard";
            btnStandard.UseVisualStyleBackColor = true;
            btnStandard.Click += btnStandard_Click;
            // 
            // btnMetric
            // 
            btnMetric.Location = new Point(225, 91);
            btnMetric.Name = "btnMetric";
            btnMetric.Size = new Size(94, 29);
            btnMetric.TabIndex = 3;
            btnMetric.Text = "Metric";
            btnMetric.UseVisualStyleBackColor = true;
            btnMetric.Click += btnMetric_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 0;
            label2.Text = "Height";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 203);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 0;
            label3.Text = "Weight";
            // 
            // txtHeightFtCm
            // 
            txtHeightFtCm.Location = new Point(110, 148);
            txtHeightFtCm.Name = "txtHeightFtCm";
            txtHeightFtCm.Size = new Size(119, 27);
            txtHeightFtCm.TabIndex = 4;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(110, 199);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(146, 27);
            txtWeight.TabIndex = 4;
            // 
            // lblHeighInches
            // 
            lblHeighInches.AutoSize = true;
            lblHeighInches.BackColor = Color.Transparent;
            lblHeighInches.Font = new Font("Arial", 12F);
            lblHeighInches.ForeColor = Color.Black;
            lblHeighInches.Location = new Point(436, 152);
            lblHeighInches.Name = "lblHeighInches";
            lblHeighInches.Size = new Size(36, 23);
            lblHeighInches.TabIndex = 0;
            lblHeighInches.Text = "NA";
            // 
            // lblHeightFtCm
            // 
            lblHeightFtCm.AutoSize = true;
            lblHeightFtCm.BackColor = Color.Transparent;
            lblHeightFtCm.Font = new Font("Arial", 12F);
            lblHeightFtCm.ForeColor = Color.Black;
            lblHeightFtCm.Location = new Point(230, 152);
            lblHeightFtCm.Name = "lblHeightFtCm";
            lblHeightFtCm.Size = new Size(36, 23);
            lblHeightFtCm.TabIndex = 0;
            lblHeightFtCm.Text = "NA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 152);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 0;
            label7.Text = "Height";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.BackColor = Color.Transparent;
            lblWeight.Font = new Font("Arial", 12F);
            lblWeight.ForeColor = Color.Black;
            lblWeight.Location = new Point(262, 203);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(36, 23);
            lblWeight.TabIndex = 0;
            lblWeight.Text = "NA";
            // 
            // txtHeightInches
            // 
            txtHeightInches.Location = new Point(311, 148);
            txtHeightInches.Name = "txtHeightInches";
            txtHeightInches.Size = new Size(119, 27);
            txtHeightInches.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(110, 261);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 318);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 450);
            Controls.Add(label4);
            Controls.Add(txtWeight);
            Controls.Add(txtHeightInches);
            Controls.Add(txtHeightFtCm);
            Controls.Add(lblWeight);
            Controls.Add(lblHeighInches);
            Controls.Add(lblHeightFtCm);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(btnMetric);
            Controls.Add(btnCalculate);
            Controls.Add(btnStandard);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnStandard;
        private Button btnMetric;
        private Label label2;
        private Label label3;
        private TextBox txtHeightFtCm;
        private TextBox txtWeight;
        private Label lblHeighInches;
        private Label lblHeightFtCm;
        private Label label7;
        private Label lblWeight;
        private TextBox txtHeightInches;
        private Button btnCalculate;
        private Label label4;
    }
}
