
namespace WindowsFormsApp1
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
            this.valueOne = new System.Windows.Forms.TextBox();
            this.valueTwo = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueOne
            // 
            this.valueOne.Location = new System.Drawing.Point(90, 51);
            this.valueOne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valueOne.Name = "valueOne";
            this.valueOne.Size = new System.Drawing.Size(76, 20);
            this.valueOne.TabIndex = 0;
            // 
            // valueTwo
            // 
            this.valueTwo.Location = new System.Drawing.Point(206, 51);
            this.valueTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valueTwo.Name = "valueTwo";
            this.valueTwo.Size = new System.Drawing.Size(76, 20);
            this.valueTwo.TabIndex = 1;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(166, 101);
            this.result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(32, 13);
            this.result.TabIndex = 2;
            this.result.Text = "result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.valueTwo);
            this.Controls.Add(this.valueOne);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valueOne;
        private System.Windows.Forms.TextBox valueTwo;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
    }
}

