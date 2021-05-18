
namespace Simulation9Lab
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_prob1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_prob2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_prob3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_prob4 = new System.Windows.Forms.NumericUpDown();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.numericUpDown_prob6 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_prob7 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_prob5 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Бросить восьмигранник";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вероятность выпадения первой грани";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вероятность выпадения второй грани";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вероятность выпадения третьей грани";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Вероятность выпадения четвертой грани";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Вероятность выпадения восьмой грани";
            // 
            // numericUpDown_prob1
            // 
            this.numericUpDown_prob1.DecimalPlaces = 3;
            this.numericUpDown_prob1.Location = new System.Drawing.Point(509, 12);
            this.numericUpDown_prob1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_prob1.Name = "numericUpDown_prob1";
            this.numericUpDown_prob1.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown_prob1.TabIndex = 14;
            this.numericUpDown_prob1.Value = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            // 
            // numericUpDown_prob2
            // 
            this.numericUpDown_prob2.DecimalPlaces = 3;
            this.numericUpDown_prob2.Location = new System.Drawing.Point(509, 55);
            this.numericUpDown_prob2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_prob2.Name = "numericUpDown_prob2";
            this.numericUpDown_prob2.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown_prob2.TabIndex = 15;
            this.numericUpDown_prob2.Value = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            // 
            // numericUpDown_prob3
            // 
            this.numericUpDown_prob3.DecimalPlaces = 3;
            this.numericUpDown_prob3.Location = new System.Drawing.Point(509, 103);
            this.numericUpDown_prob3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_prob3.Name = "numericUpDown_prob3";
            this.numericUpDown_prob3.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown_prob3.TabIndex = 16;
            this.numericUpDown_prob3.Value = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            // 
            // numericUpDown_prob4
            // 
            this.numericUpDown_prob4.DecimalPlaces = 3;
            this.numericUpDown_prob4.Location = new System.Drawing.Point(509, 152);
            this.numericUpDown_prob4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_prob4.Name = "numericUpDown_prob4";
            this.numericUpDown_prob4.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown_prob4.TabIndex = 17;
            this.numericUpDown_prob4.Value = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(509, 335);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(67, 22);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "auto";
            // 
            // numericUpDown_prob6
            // 
            this.numericUpDown_prob6.DecimalPlaces = 3;
            this.numericUpDown_prob6.Location = new System.Drawing.Point(509, 243);
            this.numericUpDown_prob6.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_prob6.Name = "numericUpDown_prob6";
            this.numericUpDown_prob6.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown_prob6.TabIndex = 19;
            this.numericUpDown_prob6.Value = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Вероятность выпадения шестой грани";
            // 
            // numericUpDown_prob7
            // 
            this.numericUpDown_prob7.DecimalPlaces = 3;
            this.numericUpDown_prob7.Location = new System.Drawing.Point(509, 293);
            this.numericUpDown_prob7.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_prob7.Name = "numericUpDown_prob7";
            this.numericUpDown_prob7.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown_prob7.TabIndex = 21;
            this.numericUpDown_prob7.Value = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Вероятность выпадения седьмой грани";
            // 
            // numericUpDown_prob5
            // 
            this.numericUpDown_prob5.DecimalPlaces = 3;
            this.numericUpDown_prob5.Location = new System.Drawing.Point(509, 195);
            this.numericUpDown_prob5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_prob5.Name = "numericUpDown_prob5";
            this.numericUpDown_prob5.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown_prob5.TabIndex = 23;
            this.numericUpDown_prob5.Value = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Вероятность выпадения пятой грани";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(284, 385);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 29);
            this.label_result.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.numericUpDown_prob5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_prob7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_prob6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_prob4);
            this.Controls.Add(this.numericUpDown_prob3);
            this.Controls.Add(this.numericUpDown_prob2);
            this.Controls.Add(this.numericUpDown_prob1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Восьмигранник челленж";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_prob1;
        private System.Windows.Forms.NumericUpDown numericUpDown_prob2;
        private System.Windows.Forms.NumericUpDown numericUpDown_prob3;
        private System.Windows.Forms.NumericUpDown numericUpDown_prob4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown_prob6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_prob7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_prob5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_result;
    }
}

