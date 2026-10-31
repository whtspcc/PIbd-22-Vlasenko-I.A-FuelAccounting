namespace FuelAccounting.Forms
{
    partial class FormFuelReplenishment
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
            comboBoxDriver = new ComboBox();
            groupBoxFuels = new GroupBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            dataGridViewFuels = new DataGridView();
            ColumnFuel = new DataGridViewComboBoxColumn();
            ColumnLiters = new DataGridViewTextBoxColumn();
            groupBoxFuels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuels).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 71);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Водитель";
            // 
            // comboBoxDriver
            // 
            comboBoxDriver.FormattingEnabled = true;
            comboBoxDriver.Location = new Point(209, 71);
            comboBoxDriver.Name = "comboBoxDriver";
            comboBoxDriver.Size = new Size(227, 28);
            comboBoxDriver.TabIndex = 1;
            // 
            // groupBoxFuels
            // 
            groupBoxFuels.Controls.Add(dataGridViewFuels);
            groupBoxFuels.Location = new Point(77, 123);
            groupBoxFuels.Name = "groupBoxFuels";
            groupBoxFuels.Size = new Size(359, 348);
            groupBoxFuels.TabIndex = 2;
            groupBoxFuels.TabStop = false;
            groupBoxFuels.Text = "Топливо";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(77, 519);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(342, 519);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFuels
            // 
            dataGridViewFuels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuels.Columns.AddRange(new DataGridViewColumn[] { ColumnFuel, ColumnLiters });
            dataGridViewFuels.Dock = DockStyle.Fill;
            dataGridViewFuels.Location = new Point(3, 23);
            dataGridViewFuels.Name = "dataGridViewFuels";
            dataGridViewFuels.RowHeadersWidth = 51;
            dataGridViewFuels.Size = new Size(353, 322);
            dataGridViewFuels.TabIndex = 0;
            // 
            // ColumnFuel
            // 
            ColumnFuel.HeaderText = "Топливо";
            ColumnFuel.MinimumWidth = 6;
            ColumnFuel.Name = "ColumnFuel";
            ColumnFuel.Width = 125;
            // 
            // ColumnLiters
            // 
            ColumnLiters.HeaderText = "Литры";
            ColumnLiters.MinimumWidth = 6;
            ColumnLiters.Name = "ColumnLiters";
            ColumnLiters.Width = 125;
            // 
            // FormFuelReplenishment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 604);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(groupBoxFuels);
            Controls.Add(comboBoxDriver);
            Controls.Add(label1);
            Name = "FormFuelReplenishment";
            Text = "FormFuelReplenishment";
            groupBoxFuels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuels).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxDriver;
        private GroupBox groupBoxFuels;
        private DataGridView dataGridViewFuels;
        private Button buttonSave;
        private Button buttonCancel;
        private DataGridViewComboBoxColumn ColumnFuel;
        private DataGridViewTextBoxColumn ColumnLiters;
    }
}