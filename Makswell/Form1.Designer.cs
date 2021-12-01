
namespace Makswell
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scale = new System.Windows.Forms.TextBox();
            this.dt = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.temperature = new System.Windows.Forms.TextBox();
            this.Radius = new System.Windows.Forms.TextBox();
            this.Numbers = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Past_time = new System.Windows.Forms.TextBox();
            this.Stop_button = new System.Windows.Forms.Button();
            this.Start_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(905, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Масштаб, пикс/нм:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(905, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Временной шаг, нс:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(905, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ширина области, нм:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(905, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Длина области, нм:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(904, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Температурный параметр, м/с:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(904, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Радиус частиц, нм";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(905, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Количество частиц";
            // 
            // scale
            // 
            this.scale.Location = new System.Drawing.Point(795, 322);
            this.scale.Name = "scale";
            this.scale.Size = new System.Drawing.Size(104, 20);
            this.scale.TabIndex = 20;
            this.scale.Text = "40";
            this.scale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(795, 279);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(104, 20);
            this.dt.TabIndex = 19;
            this.dt.Text = "0,001";
            this.dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(795, 233);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(104, 20);
            this.width.TabIndex = 18;
            this.width.Text = "15";
            this.width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(795, 192);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(104, 20);
            this.length.TabIndex = 17;
            this.length.Text = "15";
            this.length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // temperature
            // 
            this.temperature.Location = new System.Drawing.Point(795, 151);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(104, 20);
            this.temperature.TabIndex = 16;
            this.temperature.Text = "200";
            this.temperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(795, 108);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(104, 20);
            this.Radius.TabIndex = 15;
            this.Radius.Text = "0,2";
            this.Radius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Numbers
            // 
            this.Numbers.Location = new System.Drawing.Point(795, 63);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(104, 20);
            this.Numbers.TabIndex = 14;
            this.Numbers.Text = "100";
            this.Numbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(794, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Прошедшее время, нс:";
            // 
            // Past_time
            // 
            this.Past_time.Location = new System.Drawing.Point(923, 425);
            this.Past_time.Name = "Past_time";
            this.Past_time.ReadOnly = true;
            this.Past_time.Size = new System.Drawing.Size(100, 20);
            this.Past_time.TabIndex = 3;
            // 
            // Stop_button
            // 
            this.Stop_button.Enabled = false;
            this.Stop_button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop_button.Location = new System.Drawing.Point(954, 511);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(101, 43);
            this.Stop_button.TabIndex = 30;
            this.Stop_button.Text = "Стоп";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // Start_button
            // 
            this.Start_button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_button.Location = new System.Drawing.Point(809, 511);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(108, 43);
            this.Start_button.TabIndex = 29;
            this.Start_button.Text = "Пуск";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 656);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 702);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Past_time);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scale);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.width);
            this.Controls.Add(this.length);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.Numbers);
            this.Name = "Form1";
            this.Text = "Распределение Максвелла";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scale;
        private System.Windows.Forms.TextBox dt;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox temperature;
        private System.Windows.Forms.TextBox Radius;
        private System.Windows.Forms.TextBox Numbers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Past_time;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

