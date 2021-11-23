
namespace CalculatorSC
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.dote = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumberEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberEvent);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(84, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumberEvent);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(160, 252);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumberEvent);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(236, 252);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumberEvent);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(84, 328);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumberEvent);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(160, 328);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 70);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumberEvent);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(236, 328);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 70);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumberEvent);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(84, 404);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(146, 70);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.NumberEvent);
            // 
            // dote
            // 
            this.dote.Location = new System.Drawing.Point(236, 404);
            this.dote.Name = "dote";
            this.dote.Size = new System.Drawing.Size(70, 70);
            this.dote.TabIndex = 10;
            this.dote.Text = ".";
            this.dote.UseVisualStyleBackColor = true;
            this.dote.Click += new System.EventHandler(this.dote_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(312, 404);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(70, 70);
            this.add.TabIndex = 11;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.OperandEvent);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(312, 328);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(70, 70);
            this.sub.TabIndex = 12;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.OperandEvent);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(312, 252);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(70, 70);
            this.mul.TabIndex = 13;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.OperandEvent);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(312, 176);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(70, 70);
            this.div.TabIndex = 14;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.OperandEvent);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(388, 328);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(70, 146);
            this.equal.TabIndex = 15;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(388, 252);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(70, 70);
            this.bC.TabIndex = 16;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bCE
            // 
            this.bCE.Location = new System.Drawing.Point(388, 176);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(70, 70);
            this.bCE.TabIndex = 17;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(84, 130);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(374, 22);
            this.txtResult.TabIndex = 18;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(81, 97);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 16);
            this.lbResult.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dote);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.OperandEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button dote;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lbResult;
    }
}

