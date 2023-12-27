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
            label14 = new Label();
            pressure = new Label();
            humidity = new Label();
            label16 = new Label();
            SuspendLayout();
            // 
            // SendWeatherRequestButton
            // 
            SendWeatherRequestButton.Font = new Font("Cascadia Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            SendWeatherRequestButton.Location = new Point(677, 16);
            SendWeatherRequestButton.Margin = new Padding(3, 4, 3, 4);
            SendWeatherRequestButton.Name = "SendWeatherRequestButton";
            SendWeatherRequestButton.Size = new Size(224, 64);
            SendWeatherRequestButton.TabIndex = 0;
            SendWeatherRequestButton.Text = "Узнать";
            SendWeatherRequestButton.UseVisualStyleBackColor = true;
            SendWeatherRequestButton.Click += SendWeatherRequestButton_Click;
            // 
            // cityName
            // 
            cityName.Font = new Font("Cascadia Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cityName.Location = new Point(14, 21);
            cityName.Margin = new Padding(3, 4, 3, 4);
            cityName.Name = "cityName";
            cityName.Size = new Size(655, 47);
            cityName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 129);
            label1.Name = "label1";
            label1.Size = new Size(191, 35);
            label1.TabIndex = 2;
            label1.Text = "Температура";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(457, 129);
            label2.Name = "label2";
            label2.Size = new Size(111, 35);
            label2.TabIndex = 3;
            label2.Text = "Погода";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(473, 287);
            label3.Name = "label3";
            label3.Size = new Size(95, 35);
            label3.TabIndex = 4;
            label3.Text = "Ветер";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(90, 181);
            label4.Name = "label4";
            label4.Size = new Size(143, 35);
            label4.TabIndex = 5;
            label4.Text = "Текущая:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 231);
            label5.Name = "label5";
            label5.Size = new Size(223, 35);
            label5.TabIndex = 6;
            label5.Text = "Максимальная:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 287);
            label6.Name = "label6";
            label6.Size = new Size(207, 35);
            label6.TabIndex = 7;
            label6.Text = "Минимальная:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(26, 345);
            label7.Name = "label7";
            label7.Size = new Size(207, 35);
            label7.TabIndex = 8;
            label7.Text = "Чувствуется:";
            // 
            // temp
            // 
            temp.AutoSize = true;
            temp.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            temp.Location = new Point(239, 181);
            temp.Name = "temp";
            temp.Size = new Size(63, 35);
            temp.TabIndex = 9;
            temp.Text = "N/A";
            // 
            // weatherDescription
            // 
            weatherDescription.AutoSize = true;
            weatherDescription.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            weatherDescription.Location = new Point(620, 231);
            weatherDescription.Name = "weatherDescription";
            weatherDescription.Size = new Size(63, 35);
            weatherDescription.TabIndex = 10;
            weatherDescription.Text = "N/A";
            // 
            // tempMin
            // 
            tempMin.AutoSize = true;
            tempMin.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tempMin.Location = new Point(239, 287);
            tempMin.Name = "tempMin";
            tempMin.Size = new Size(63, 35);
            tempMin.TabIndex = 11;
            tempMin.Text = "N/A";
            // 
            // tempFeelsLike
            // 
            tempFeelsLike.AutoSize = true;
            tempFeelsLike.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tempFeelsLike.Location = new Point(239, 345);
            tempFeelsLike.Name = "tempFeelsLike";
            tempFeelsLike.Size = new Size(63, 35);
            tempFeelsLike.TabIndex = 12;
            tempFeelsLike.Text = "N/A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(471, 181);
            label8.Name = "label8";
            label8.Size = new Size(143, 35);
            label8.TabIndex = 13;
            label8.Text = "Текущая:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(453, 231);
            label9.Name = "label9";
            label9.Size = new Size(159, 35);
            label9.TabIndex = 14;
            label9.Text = "Описание:";
            // 
            // weather
            // 
            weather.AutoSize = true;
            weather.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            weather.Location = new Point(620, 181);
            weather.Name = "weather";
            weather.Size = new Size(63, 35);
            weather.TabIndex = 15;
            weather.Text = "N/A";
            // 
            // tempMax
            // 
            tempMax.AutoSize = true;
            tempMax.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tempMax.Location = new Point(239, 231);
            tempMax.Name = "tempMax";
            tempMax.Size = new Size(63, 35);
            tempMax.TabIndex = 16;
            tempMax.Text = "N/A";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(450, 335);
            label10.Name = "label10";
            label10.Size = new Size(159, 35);
            label10.TabIndex = 17;
            label10.Text = "Скорость:";
            // 
            // wind
            // 
            wind.AutoSize = true;
            wind.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            wind.Location = new Point(615, 335);
            wind.Name = "wind";
            wind.Size = new Size(63, 35);
            wind.TabIndex = 18;
            wind.Text = "N/A";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(514, 385);
            label11.Name = "label11";
            label11.Size = new Size(95, 35);
            label11.TabIndex = 19;
            label11.Text = "Угол:";
            // 
            // windDegree
            // 
            windDegree.AutoSize = true;
            windDegree.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            windDegree.Location = new Point(615, 385);
            windDegree.Name = "windDegree";
            windDegree.Size = new Size(63, 35);
            windDegree.TabIndex = 20;
            windDegree.Text = "N/A";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(501, 441);
            label12.Name = "label12";
            label12.Size = new Size(111, 35);
            label12.TabIndex = 21;
            label12.Text = "Порыв:";
            // 
            // windGust
            // 
            windGust.AutoSize = true;
            windGust.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            windGust.Location = new Point(615, 441);
            windGust.Name = "windGust";
            windGust.Size = new Size(63, 35);
            windGust.TabIndex = 22;
            windGust.Text = "N/A";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(14, 551);
            label13.Name = "label13";
            label13.Size = new Size(127, 35);
            label13.TabIndex = 23;
            label13.Text = "Статус:";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            status.Location = new Point(130, 551);
            status.Name = "status";
            status.Size = new Size(63, 35);
            status.TabIndex = 24;
            status.Text = "N/A";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(74, 400);
            label14.Name = "label14";
            label14.Size = new Size(159, 35);
            label14.TabIndex = 25;
            label14.Text = "Давление:";
            // 
            // pressure
            // 
            pressure.AutoSize = true;
            pressure.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            pressure.Location = new Point(239, 400);
            pressure.Name = "pressure";
            pressure.Size = new Size(63, 35);
            pressure.TabIndex = 26;
            pressure.Text = "N/A";
            // 
            // humidity
            // 
            humidity.AutoSize = true;
            humidity.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            humidity.Location = new Point(239, 457);
            humidity.Name = "humidity";
            humidity.Size = new Size(63, 35);
            humidity.TabIndex = 28;
            humidity.Text = "N/A";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(58, 457);
            label16.Name = "label16";
            label16.Size = new Size(175, 35);
            label16.TabIndex = 27;
            label16.Text = "Влажность:";
            // 
            // WeatherView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(humidity);
            Controls.Add(label16);
            Controls.Add(pressure);
            Controls.Add(label14);
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
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(932, 647);
            MinimumSize = new Size(932, 647);
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
        private Label label14;
        private Label pressure;
        private Label humidity;
        private Label label16;
    }
}