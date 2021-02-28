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
            this.SuspendLayout();
            // 
            // ellipse
            // 
            this.ellipse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ellipse.Location = new System.Drawing.Point(12, 12);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(114, 33);
            this.ellipse.TabIndex = 0;
            this.ellipse.Text = "Эллипс";
            this.ellipse.UseVisualStyleBackColor = false;
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rectangle.Location = new System.Drawing.Point(311, 12);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(165, 33);
            this.rectangle.TabIndex = 2;
            this.rectangle.Text = "Прямоугольник";
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // Polygon
            // 
            this.Polygon.BackColor = System.Drawing.SystemColors.Info;
            this.Polygon.Location = new System.Drawing.Point(495, 12);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(145, 33);
            this.Polygon.TabIndex = 3;
            this.Polygon.Text = "Многоульник";
            this.Polygon.UseVisualStyleBackColor = false;
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // Lines
            // 
            this.Lines.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lines.Location = new System.Drawing.Point(672, 12);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(114, 33);
            this.Lines.TabIndex = 4;
            this.Lines.Text = "Ломаная";
            this.Lines.UseVisualStyleBackColor = false;
            this.Lines.Click += new System.EventHandler(this.Lines_Click);
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.SystemColors.Info;
            this.Line.Location = new System.Drawing.Point(168, 12);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(114, 33);
            this.Line.TabIndex = 5;
            this.Line.Text = "Прямая";
            this.Line.UseVisualStyleBackColor = false;
            this.Line.Click += new System.EventHandler(this.Line_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Lines);
            this.Controls.Add(this.Polygon);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.ellipse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ellipse;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button Polygon;
        private System.Windows.Forms.Button Lines;
        private System.Windows.Forms.Button Line;
    }
}

