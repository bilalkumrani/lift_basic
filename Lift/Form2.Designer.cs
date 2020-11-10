namespace Lift
{
    partial class Form2
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
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(69, 55);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 60);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.click_func);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(160, 55);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 60);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.click_func);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(69, 131);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 60);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.click_func);
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(69, 197);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(70, 60);
            this.btnG.TabIndex = 3;
            this.btnG.Text = "0";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.click_func);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(160, 131);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 60);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.click_func);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(160, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 60);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 273);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnCancel;
    }
}