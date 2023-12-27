namespace WeatherApp
{
    partial class WeatherView
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
            SendWeatherRequestButton = new Button();
            cityName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            temp = new Label();
            weatherDescription = new Label();
            tempMin = new Label();
            tempFeelsLike = new Label();
            label8 = new Label();
            label9 = new Label();
            weather = new Label();
            tempMax = new Label();
            label10 = new Label();
            wind = new Label();
            label11 = new Label();
            windDegree = new Label();
            label12 = new Label();
            windGust = new Label();
            label13 = new Label();
            status = new Label();
            SuspendLayout();
            // 
            // SendWeatherRequestButton
            // 
            SendWeatherRequestButton.Font = new Font("Cascadia Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            SendWeatherRequestButton.Location = new Point(592, 12);
            SendWeatherRequestButton.Name = "SendWeatherRequestButton";
            SendWeatherRequestButton.Size = new Size(196, 48);
            SendWeatherRequestButton.TabIndex = 0;
            SendWeatherRequestButton.Text = "Узнать";
            SendWeatherRequestButton.UseVisualStyleBackColor = true;
            SendWeatherRequestButton.Click += SendWeatherRequestButton_Click;
            // 
            // cityName
            // 
            cityName.Font = new Font("Cascadia Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cityName.Location = new Point(12, 16);
            cityName.Name = "cityName";
            cityName.Size = new Size(574, 39);
            cityName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 2;
            label1.Text = "Температура";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(321, 97);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 3;
            label2.Text = "Погода";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(592, 97);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 4;
            label3.Text = "Ветер";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(79, 136);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 5;
            label4.Text = "Текущая:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 173);
            label5.Name = "label5";
            label5.Size = new Size(168, 28);
            label5.TabIndex = 6;
            label5.Text = "Максимальная:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(31, 215);
            label6.Name = "label6";
            label6.Size = new Size(156, 28);
            label6.TabIndex = 7;
            label6.Text = "Минимальная:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(31, 259);
            label7.Name = "label7";
            label7.Size = new Size(156, 28);
            label7.TabIndex = 8;
            label7.Text = "Чувствуется:";
            // 
            // temp
            // 
            temp.AutoSize = true;
            temp.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            temp.Location = new Point(193, 136);
            temp.Name = "temp";
            temp.Size = new Size(48, 28);
            temp.TabIndex = 9;
            temp.Text = "N/A";
            // 
            // weatherDescription
            // 
            weatherDescription.AutoSize = true;
            weatherDescription.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            weatherDescription.Location = new Point(447, 173);
            weatherDescription.Name = "weatherDescription";
            weatherDescription.Size = new Size(48, 28);
            weatherDescription.TabIndex = 10;
            weatherDescription.Text = "N/A";
            // 
            // tempMin
            // 
            tempMin.AutoSize = true;
            tempMin.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tempMin.Location = new Point(193, 215);
            tempMin.Name = "tempMin";
            tempMin.Size = new Size(48, 28);
            tempMin.TabIndex = 11;
            tempMin.Text = "N/A";
            // 
            // tempFeelsLike
            // 
            tempFeelsLike.AutoSize = true;
            tempFeelsLike.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tempFeelsLike.Location = new Point(193, 259);
            tempFeelsLike.Name = "tempFeelsLike";
            tempFeelsLike.Size = new Size(48, 28);
            tempFeelsLike.TabIndex = 12;
            tempFeelsLike.Text = "N/A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(333, 136);
            label8.Name = "label8";
            label8.Size = new Size(108, 28);
            label8.TabIndex = 13;
            label8.Text = "Текущая:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(321, 173);
            label9.Name = "label9";
            label9.Size = new Size(120, 28);
            label9.TabIndex = 14;
            label9.Text = "Описание:";
            // 
            // weather
            // 
            weather.AutoSize = true;
            weather.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            weather.Location = new Point(447, 136);
            weather.Name = "weather";
            weather.Size = new Size(48, 28);
            weather.TabIndex = 15;
            weather.Text = "N/A";
            // 
            // tempMax
            // 
            tempMax.AutoSize = true;
            tempMax.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tempMax.Location = new Point(193, 173);
            tempMax.Name = "tempMax";
            tempMax.Size = new Size(48, 28);
            tempMax.TabIndex = 16;
            tempMax.Text = "N/A";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(575, 136);
            label10.Name = "label10";
            label10.Size = new Size(108, 28);
            label10.TabIndex = 17;
            label10.Text = "Текущая:";
            // 
            // wind
            // 
            wind.AutoSize = true;
            wind.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            wind.Location = new Point(689, 136);
            wind.Name = "wind";
            wind.Size = new Size(48, 28);
            wind.TabIndex = 18;
            wind.Text = "N/A";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(611, 173);
            label11.Name = "label11";
            label11.Size = new Size(72, 28);
            label11.TabIndex = 19;
            label11.Text = "Угол:";
            // 
            // windDegree
            // 
            windDegree.AutoSize = true;
            windDegree.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            windDegree.Location = new Point(689, 173);
            windDegree.Name = "windDegree";
            windDegree.Size = new Size(48, 28);
            windDegree.TabIndex = 20;
            windDegree.Text = "N/A";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(599, 215);
            label12.Name = "label12";
            label12.Size = new Size(84, 28);
            label12.TabIndex = 21;
            label12.Text = "Порыв:";
            // 
            // windGust
            // 
            windGust.AutoSize = true;
            windGust.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            windGust.Location = new Point(689, 215);
            windGust.Name = "windGust";
            windGust.Size = new Size(48, 28);
            windGust.TabIndex = 22;
            windGust.Text = "N/A";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(12, 413);
            label13.Name = "label13";
            label13.Size = new Size(96, 28);
            label13.TabIndex = 23;
            label13.Text = "Статус:";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            status.Location = new Point(114, 413);
            status.Name = "status";
            status.Size = new Size(48, 28);
            status.TabIndex = 24;
            status.Text = "N/A";
            // 
            // WeatherView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(status);
            Controls.Add(label13);
            Controls.Add(windGust);
            Controls.Add(label12);
            Controls.Add(windDegree);
            Controls.Add(label11);
            Controls.Add(wind);
            Controls.Add(label10);
            Controls.Add(tempMax);
            Controls.Add(weather);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(tempFeelsLike);
            Controls.Add(tempMin);
            Controls.Add(weatherDescription);
            Controls.Add(temp);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cityName);
            Controls.Add(SendWeatherRequestButton);
            Name = "WeatherView";
            Text = "Weather";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SendWeatherRequestButton;
        private TextBox cityName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label temp;
        private Label weatherDescription;
        private Label tempMin;
        private Label tempFeelsLike;
        private Label label8;
        private Label label9;
        private Label weather;
        private Label tempMax;
        private Label label10;
        private Label wind;
        private Label label11;
        private Label windDegree;
        private Label label12;
        private Label windGust;
        private Label label13;
        private Label status;
    }
}