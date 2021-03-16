namespace lab_1
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
            this.ellipse = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.Polygon = new System.Windows.Forms.Button();
            this.Lines = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.outline_color = new System.Windows.Forms.Button();
            this.fill_color = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ellipse
            // 
            this.ellipse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ellipse.Location = new System.Drawing.Point(12, 12);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(165, 33);
            this.ellipse.TabIndex = 0;
            this.ellipse.Text = "Эллипс";
            this.ellipse.UseVisualStyleBackColor = false;
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rectangle.Location = new System.Drawing.Point(12, 90);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(165, 32);
            this.rectangle.TabIndex = 2;
            this.rectangle.Text = "Прямоугольник";
            this.rectangle.UseVisualStyleBackColor = false;
            // 
            // Polygon
            // 
            this.Polygon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Polygon.Location = new System.Drawing.Point(12, 128);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(165, 33);
            this.Polygon.TabIndex = 3;
            this.Polygon.Text = "Многоульник";
            this.Polygon.UseVisualStyleBackColor = false;
            // 
            // Lines
            // 
            this.Lines.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Lines.Location = new System.Drawing.Point(12, 167);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(165, 33);
            this.Lines.TabIndex = 4;
            this.Lines.Text = "Ломаная";
            this.Lines.UseVisualStyleBackColor = false;
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Line.Location = new System.Drawing.Point(12, 51);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(165, 33);
            this.Line.TabIndex = 5;
            this.Line.Text = "Прямая";
            this.Line.UseVisualStyleBackColor = false;
            // 
            // outline_color
            // 
            this.outline_color.Location = new System.Drawing.Point(12, 206);
            this.outline_color.Name = "outline_color";
            this.outline_color.Size = new System.Drawing.Size(40, 40);
            this.outline_color.TabIndex = 6;
            this.outline_color.UseVisualStyleBackColor = true;
            this.outline_color.Click += new System.EventHandler(this.outline_color_Click);
            // 
            // fill_color
            // 
            this.fill_color.Location = new System.Drawing.Point(12, 252);
            this.fill_color.Name = "fill_color";
            this.fill_color.Size = new System.Drawing.Size(40, 40);
            this.fill_color.TabIndex = 7;
            this.fill_color.UseVisualStyleBackColor = true;
            this.fill_color.Click += new System.EventHandler(this.fill_color_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Цвет заливки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Цвет линии";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 314);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown1.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(12, 346);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Толщина линии";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Кол-во углов";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(196, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 492);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(11, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Сериализация";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(11, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "Десериализация";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(852, 516);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fill_color);
            this.Controls.Add(this.outline_color);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Lines);
            this.Controls.Add(this.Polygon);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.ellipse);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ellipse;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button Polygon;
        private System.Windows.Forms.Button Lines;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button outline_color;
        private System.Windows.Forms.Button fill_color;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

