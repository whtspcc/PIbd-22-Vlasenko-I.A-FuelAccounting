namespace FuelAccounting.Forms
{
    partial class FormFuelingCar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxDriver = new ComboBox();
            comboBoxFuel = new ComboBox();
            comboBoxCar = new ComboBox();
            numericUpDownLiters = new NumericUpDown();
            buttonSave = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLiters).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 81);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Водитель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 148);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Топливо";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 215);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 2;
            label3.Text = "Автомобиль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 279);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Литры";
            // 
            // comboBoxDriver
            // 
            comboBoxDriver.FormattingEnabled = true;
            comboBoxDriver.Location = new Point(220, 81);
            comboBoxDriver.Name = "comboBoxDriver";
            comboBoxDriver.Size = new Size(227, 28);
            comboBoxDriver.TabIndex = 4;
            // 
            // comboBoxFuel
            // 
            comboBoxFuel.FormattingEnabled = true;
            comboBoxFuel.Location = new Point(220, 145);
            comboBoxFuel.Name = "comboBoxFuel";
            comboBoxFuel.Size = new Size(227, 28);
            comboBoxFuel.TabIndex = 5;
            // 
            // comboBoxCar
            // 
            comboBoxCar.FormattingEnabled = true;
            comboBoxCar.Location = new Point(220, 212);
            comboBoxCar.Name = "comboBoxCar";
            comboBoxCar.Size = new Size(227, 28);
            comboBoxCar.TabIndex = 6;
            // 
            // numericUpDownLiters
            // 
            numericUpDownLiters.Location = new Point(220, 277);
            numericUpDownLiters.Name = "numericUpDownLiters";
            numericUpDownLiters.Size = new Size(227, 27);
            numericUpDownLiters.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(76, 418);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(369, 418);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormFuelingCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 539);
            Controls.Add(button2);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownLiters);
            Controls.Add(comboBoxCar);
            Controls.Add(comboBoxFuel);
            Controls.Add(comboBoxDriver);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormFuelingCar";
            Text = "Заправка автомобиля";
            ((System.ComponentModel.ISupportInitialize)numericUpDownLiters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxDriver;
        private ComboBox comboBoxFuel;
        private ComboBox comboBoxCar;
        private NumericUpDown numericUpDownLiters;
        private Button buttonSave;
        private Button button2;
    }
}