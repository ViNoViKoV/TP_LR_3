namespace TP_LR_3_1st_contrib
{
    partial class FirstForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExchangeButton = new System.Windows.Forms.Button();
            this.TemperatureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(86, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите форму для загрузки";
            // 
            // ExchangeButton
            // 
            this.ExchangeButton.Location = new System.Drawing.Point(12, 130);
            this.ExchangeButton.Name = "ExchangeButton";
            this.ExchangeButton.Size = new System.Drawing.Size(164, 74);
            this.ExchangeButton.TabIndex = 1;
            this.ExchangeButton.Text = "Курс валют";
            this.ExchangeButton.UseVisualStyleBackColor = true;
            this.ExchangeButton.Click += new System.EventHandler(this.ExchangeButton_Click);
            // 
            // TemperatureButton
            // 
            this.TemperatureButton.Location = new System.Drawing.Point(269, 130);
            this.TemperatureButton.Name = "TemperatureButton";
            this.TemperatureButton.Size = new System.Drawing.Size(164, 74);
            this.TemperatureButton.TabIndex = 2;
            this.TemperatureButton.Text = "Температура в Августе";
            this.TemperatureButton.UseVisualStyleBackColor = true;
            this.TemperatureButton.Click += new System.EventHandler(this.TemperatureButton_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 216);
            this.Controls.Add(this.TemperatureButton);
            this.Controls.Add(this.ExchangeButton);
            this.Controls.Add(this.label1);
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button ExchangeButton;
        private Button TemperatureButton;
    }
}