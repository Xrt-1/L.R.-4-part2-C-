namespace L.R._4_part2_C_
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
            this.numUpDwnA = new System.Windows.Forms.NumericUpDown();
            this.numUpDwnB = new System.Windows.Forms.NumericUpDown();
            this.numUpDwnC = new System.Windows.Forms.NumericUpDown();
            this.tBoxA = new System.Windows.Forms.TextBox();
            this.tBoxB = new System.Windows.Forms.TextBox();
            this.tBoxC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnC)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDwnA
            // 
            this.numUpDwnA.Location = new System.Drawing.Point(37, 175);
            this.numUpDwnA.Name = "numUpDwnA";
            this.numUpDwnA.Size = new System.Drawing.Size(120, 22);
            this.numUpDwnA.TabIndex = 0;
            this.numUpDwnA.ValueChanged += new System.EventHandler(this.numUpDwnA_ValueChanged);
            // 
            // numUpDwnB
            // 
            this.numUpDwnB.Location = new System.Drawing.Point(234, 175);
            this.numUpDwnB.Name = "numUpDwnB";
            this.numUpDwnB.Size = new System.Drawing.Size(120, 22);
            this.numUpDwnB.TabIndex = 1;
            this.numUpDwnB.ValueChanged += new System.EventHandler(this.numUpDwnB_ValueChanged);
            // 
            // numUpDwnC
            // 
            this.numUpDwnC.Location = new System.Drawing.Point(396, 175);
            this.numUpDwnC.Name = "numUpDwnC";
            this.numUpDwnC.Size = new System.Drawing.Size(120, 22);
            this.numUpDwnC.TabIndex = 2;
            this.numUpDwnC.ValueChanged += new System.EventHandler(this.numUpDwnC_ValueChanged);
            // 
            // tBoxA
            // 
            this.tBoxA.BackColor = System.Drawing.Color.White;
            this.tBoxA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxA.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxA.Location = new System.Drawing.Point(60, 72);
            this.tBoxA.Name = "tBoxA";
            this.tBoxA.ReadOnly = true;
            this.tBoxA.Size = new System.Drawing.Size(64, 53);
            this.tBoxA.TabIndex = 3;
            this.tBoxA.Text = "A";
            // 
            // tBoxB
            // 
            this.tBoxB.BackColor = System.Drawing.Color.White;
            this.tBoxB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxB.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxB.Location = new System.Drawing.Point(268, 72);
            this.tBoxB.Name = "tBoxB";
            this.tBoxB.ReadOnly = true;
            this.tBoxB.Size = new System.Drawing.Size(64, 53);
            this.tBoxB.TabIndex = 4;
            this.tBoxB.Text = "B";
            // 
            // tBoxC
            // 
            this.tBoxC.BackColor = System.Drawing.Color.White;
            this.tBoxC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxC.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxC.Location = new System.Drawing.Point(429, 72);
            this.tBoxC.Name = "tBoxC";
            this.tBoxC.ReadOnly = true;
            this.tBoxC.Size = new System.Drawing.Size(43, 53);
            this.tBoxC.TabIndex = 5;
            this.tBoxC.Text = "C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 271);
            this.Controls.Add(this.tBoxC);
            this.Controls.Add(this.tBoxB);
            this.Controls.Add(this.tBoxA);
            this.Controls.Add(this.numUpDwnC);
            this.Controls.Add(this.numUpDwnB);
            this.Controls.Add(this.numUpDwnA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDwnA;
        private System.Windows.Forms.NumericUpDown numUpDwnB;
        private System.Windows.Forms.NumericUpDown numUpDwnC;
        private System.Windows.Forms.TextBox tBoxA;
        private System.Windows.Forms.TextBox tBoxB;
        private System.Windows.Forms.TextBox tBoxC;
    }
}

