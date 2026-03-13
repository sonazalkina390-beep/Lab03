namespace Lab03
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
            Name = new Label();
            lblPrompt = new Label();
            txtInputNumber = new TextBox();
            btnCheckNaive = new Button();
            btnCheckOptimized = new Button();
            lblResultNaive = new Label();
            lblResultOptimized = new Label();
            lblTimeNaive = new Label();
            lblTimeOptimized = new Label();
            lblOpsNaive = new Label();
            lblOpsOptimized = new Label();
            lblValueResultNaive = new Label();
            lblValueResultOptimized = new Label();
            lblValueTimeNaive = new Label();
            lblValueTimeOptimized = new Label();
            lblValueOpsNaive = new Label();
            lblValueOpsOptimized = new Label();
            SuspendLayout();
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Name.Location = new Point(134, 23);
            Name.Name = "Name";
            Name.Size = new Size(266, 29);
            Name.TabIndex = 0;
            Name.Text = "Проверка на пустоту числа";
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPrompt.Location = new Point(45, 73);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(227, 26);
            lblPrompt.TabIndex = 1;
            lblPrompt.Text = "Введите число для проверки:";
            // 
            // txtInputNumber
            // 
            txtInputNumber.Location = new Point(318, 75);
            txtInputNumber.Name = "txtInputNumber";
            txtInputNumber.Size = new Size(139, 27);
            txtInputNumber.TabIndex = 2;
            // 
            // btnCheckNaive
            // 
            btnCheckNaive.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCheckNaive.Location = new Point(45, 117);
            btnCheckNaive.Name = "btnCheckNaive";
            btnCheckNaive.Size = new Size(213, 48);
            btnCheckNaive.TabIndex = 3;
            btnCheckNaive.Text = "Проверить (Наивный)";
            btnCheckNaive.UseVisualStyleBackColor = true;
            btnCheckNaive.Click += btnCheckNaive_Click;
            // 
            // btnCheckOptimized
            // 
            btnCheckOptimized.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCheckOptimized.Location = new Point(289, 117);
            btnCheckOptimized.Name = "btnCheckOptimized";
            btnCheckOptimized.Size = new Size(213, 48);
            btnCheckOptimized.TabIndex = 4;
            btnCheckOptimized.Text = "Проверить (Оптимиз.)";
            btnCheckOptimized.UseVisualStyleBackColor = true;
            // 
            // lblResultNaive
            // 
            lblResultNaive.AutoSize = true;
            lblResultNaive.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblResultNaive.Location = new Point(60, 190);
            lblResultNaive.Name = "lblResultNaive";
            lblResultNaive.Size = new Size(174, 26);
            lblResultNaive.TabIndex = 5;
            lblResultNaive.Text = "Результат (Наивный):";
            // 
            // lblResultOptimized
            // 
            lblResultOptimized.AutoSize = true;
            lblResultOptimized.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblResultOptimized.Location = new Point(60, 227);
            lblResultOptimized.Name = "lblResultOptimized";
            lblResultOptimized.Size = new Size(174, 26);
            lblResultOptimized.TabIndex = 6;
            lblResultOptimized.Text = "Результат (Оптимиз.):";
            // 
            // lblTimeNaive
            // 
            lblTimeNaive.AutoSize = true;
            lblTimeNaive.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTimeNaive.Location = new Point(60, 275);
            lblTimeNaive.Name = "lblTimeNaive";
            lblTimeNaive.Size = new Size(149, 26);
            lblTimeNaive.TabIndex = 7;
            lblTimeNaive.Text = "Время (Наивный):";
            // 
            // lblTimeOptimized
            // 
            lblTimeOptimized.AutoSize = true;
            lblTimeOptimized.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTimeOptimized.Location = new Point(60, 310);
            lblTimeOptimized.Name = "lblTimeOptimized";
            lblTimeOptimized.Size = new Size(149, 26);
            lblTimeOptimized.TabIndex = 8;
            lblTimeOptimized.Text = "Время (Оптимиз.):";
            // 
            // lblOpsNaive
            // 
            lblOpsNaive.AutoSize = true;
            lblOpsNaive.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOpsNaive.Location = new Point(60, 356);
            lblOpsNaive.Name = "lblOpsNaive";
            lblOpsNaive.Size = new Size(176, 26);
            lblOpsNaive.TabIndex = 9;
            lblOpsNaive.Text = "Операции (Наивный):";
            // 
            // lblOpsOptimized
            // 
            lblOpsOptimized.AutoSize = true;
            lblOpsOptimized.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblOpsOptimized.Location = new Point(60, 393);
            lblOpsOptimized.Name = "lblOpsOptimized";
            lblOpsOptimized.Size = new Size(176, 26);
            lblOpsOptimized.TabIndex = 10;
            lblOpsOptimized.Text = "Операции (Оптимиз.):";
            // 
            // lblValueResultNaive
            // 
            lblValueResultNaive.AutoSize = true;
            lblValueResultNaive.BackColor = Color.White;
            lblValueResultNaive.Location = new Point(318, 195);
            lblValueResultNaive.Name = "lblValueResultNaive";
            lblValueResultNaive.Size = new Size(89, 20);
            lblValueResultNaive.TabIndex = 11;
            lblValueResultNaive.Text = "                    ";
            // 
            // lblValueResultOptimized
            // 
            lblValueResultOptimized.AutoSize = true;
            lblValueResultOptimized.BackColor = Color.White;
            lblValueResultOptimized.Location = new Point(318, 232);
            lblValueResultOptimized.Name = "lblValueResultOptimized";
            lblValueResultOptimized.Size = new Size(89, 20);
            lblValueResultOptimized.TabIndex = 12;
            lblValueResultOptimized.Text = "                    ";
            // 
            // lblValueTimeNaive
            // 
            lblValueTimeNaive.AutoSize = true;
            lblValueTimeNaive.BackColor = Color.White;
            lblValueTimeNaive.Location = new Point(318, 280);
            lblValueTimeNaive.Name = "lblValueTimeNaive";
            lblValueTimeNaive.Size = new Size(89, 20);
            lblValueTimeNaive.TabIndex = 13;
            lblValueTimeNaive.Text = "                    ";
            // 
            // lblValueTimeOptimized
            // 
            lblValueTimeOptimized.AutoSize = true;
            lblValueTimeOptimized.BackColor = Color.White;
            lblValueTimeOptimized.Location = new Point(318, 315);
            lblValueTimeOptimized.Name = "lblValueTimeOptimized";
            lblValueTimeOptimized.Size = new Size(89, 20);
            lblValueTimeOptimized.TabIndex = 14;
            lblValueTimeOptimized.Text = "                    ";
            // 
            // lblValueOpsNaive
            // 
            lblValueOpsNaive.AutoSize = true;
            lblValueOpsNaive.BackColor = Color.White;
            lblValueOpsNaive.Location = new Point(318, 362);
            lblValueOpsNaive.Name = "lblValueOpsNaive";
            lblValueOpsNaive.Size = new Size(89, 20);
            lblValueOpsNaive.TabIndex = 15;
            lblValueOpsNaive.Text = "                    ";
            // 
            // lblValueOpsOptimized
            // 
            lblValueOpsOptimized.AutoSize = true;
            lblValueOpsOptimized.BackColor = Color.White;
            lblValueOpsOptimized.Location = new Point(318, 398);
            lblValueOpsOptimized.Name = "lblValueOpsOptimized";
            lblValueOpsOptimized.Size = new Size(89, 20);
            lblValueOpsOptimized.TabIndex = 16;
            lblValueOpsOptimized.Text = "                    ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(557, 450);
            Controls.Add(lblValueOpsOptimized);
            Controls.Add(lblValueOpsNaive);
            Controls.Add(lblValueTimeOptimized);
            Controls.Add(lblValueTimeNaive);
            Controls.Add(lblValueResultOptimized);
            Controls.Add(lblValueResultNaive);
            Controls.Add(lblOpsOptimized);
            Controls.Add(lblOpsNaive);
            Controls.Add(lblTimeOptimized);
            Controls.Add(lblTimeNaive);
            Controls.Add(lblResultOptimized);
            Controls.Add(lblResultNaive);
            Controls.Add(btnCheckOptimized);
            Controls.Add(btnCheckNaive);
            Controls.Add(txtInputNumber);
            Controls.Add(lblPrompt);
            Controls.Add(Name);
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name;
        private Label lblPrompt;
        private TextBox txtInputNumber;
        private Button btnCheckNaive;
        private Button btnCheckOptimized;
        private Label lblResultNaive;
        private Label lblResultOptimized;
        private Label lblTimeNaive;
        private Label lblTimeOptimized;
        private Label lblOpsNaive;
        private Label lblOpsOptimized;
        private Label lblValueResultNaive;
        private Label lblValueResultOptimized;
        private Label lblValueTimeNaive;
        private Label lblValueTimeOptimized;
        private Label lblValueOpsNaive;
        private Label lblValueOpsOptimized;
    }
}
