namespace Task_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartChild = new System.Windows.Forms.Button();
            this.CloseChild = new System.Windows.Forms.Button();
            this.ExitCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartChild
            // 
            this.StartChild.Location = new System.Drawing.Point(105, 27);
            this.StartChild.Name = "StartChild";
            this.StartChild.Size = new System.Drawing.Size(152, 41);
            this.StartChild.TabIndex = 0;
            this.StartChild.Text = "Start Child";
            this.StartChild.UseVisualStyleBackColor = true;
            this.StartChild.Click += new System.EventHandler(this.StartChild_Click);
            // 
            // CloseChild
            // 
            this.CloseChild.Location = new System.Drawing.Point(198, 90);
            this.CloseChild.Name = "CloseChild";
            this.CloseChild.Size = new System.Drawing.Size(152, 41);
            this.CloseChild.TabIndex = 1;
            this.CloseChild.Text = "Close Child";
            this.CloseChild.UseVisualStyleBackColor = true;
            this.CloseChild.Click += new System.EventHandler(this.CloseChild_Click);
            // 
            // ExitCode
            // 
            this.ExitCode.Location = new System.Drawing.Point(177, 157);
            this.ExitCode.Name = "ExitCode";
            this.ExitCode.ReadOnly = true;
            this.ExitCode.Size = new System.Drawing.Size(70, 20);
            this.ExitCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exit code";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Wait Child";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitCode);
            this.Controls.Add(this.CloseChild);
            this.Controls.Add(this.StartChild);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartChild;
        private System.Windows.Forms.Button CloseChild;
        private System.Windows.Forms.TextBox ExitCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

