namespace FuelAccounting.Forms
{
    partial class FormFuel
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
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            checkedListBoxFuelTypes = new CheckedListBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 80);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Тип корма";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 214);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 283);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Описание";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(201, 214);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(239, 27);
            textBoxName.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(201, 280);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(239, 122);
            textBoxDescription.TabIndex = 4;
            // 
            // checkedListBoxFuelTypes
            // 
            checkedListBoxFuelTypes.FormattingEnabled = true;
            checkedListBoxFuelTypes.Location = new Point(201, 80);
            checkedListBoxFuelTypes.Name = "checkedListBoxFuelTypes";
            checkedListBoxFuelTypes.Size = new Size(239, 114);
            checkedListBoxFuelTypes.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(110, 462);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(367, 462);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormFuel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 546);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(checkedListBoxFuelTypes);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormFuel";
            Text = "Топливо";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private CheckedListBox checkedListBoxFuelTypes;
        private Button buttonSave;
        private Button buttonCancel;
    }
}