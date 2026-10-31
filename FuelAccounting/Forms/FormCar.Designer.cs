namespace FuelAccounting.Forms
{
    partial class FormCar
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
            textBoxLicensePlate = new TextBox();
            textBoxModel = new TextBox();
            numericUpDownTankCapacity = new NumericUpDown();
            comboBoxCategory = new ComboBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTankCapacity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 55);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Госномер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 137);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Модель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 221);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Объем бака, л";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 307);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Категория";
            // 
            // textBoxLicensePlate
            // 
            textBoxLicensePlate.Location = new Point(211, 52);
            textBoxLicensePlate.Name = "textBoxLicensePlate";
            textBoxLicensePlate.Size = new Size(257, 27);
            textBoxLicensePlate.TabIndex = 4;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(211, 130);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(257, 27);
            textBoxModel.TabIndex = 5;
            // 
            // numericUpDownTankCapacity
            // 
            numericUpDownTankCapacity.Location = new Point(212, 214);
            numericUpDownTankCapacity.Name = "numericUpDownTankCapacity";
            numericUpDownTankCapacity.Size = new Size(150, 27);
            numericUpDownTankCapacity.TabIndex = 6;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(212, 299);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 28);
            comboBoxCategory.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(111, 404);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(327, 404);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 480);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxCategory);
            Controls.Add(numericUpDownTankCapacity);
            Controls.Add(textBoxModel);
            Controls.Add(textBoxLicensePlate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCar";
            Text = "FormCar";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTankCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxLicensePlate;
        private TextBox textBoxModel;
        private NumericUpDown numericUpDownTankCapacity;
        private ComboBox comboBoxCategory;
        private Button buttonSave;
        private Button buttonCancel;
    }
}