namespace FuelAccounting.Forms
{
    partial class FormFuelingCars
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
            panel1 = new Panel();
            buttonAdd = new Button();
            dataGridViewFuelingCars = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuelingCars).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAdd);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(804, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 455);
            panel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImage = Properties.Resources.add;
            buttonAdd.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdd.Location = new Point(46, 24);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(121, 116);
            buttonAdd.TabIndex = 0;
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFuelingCars
            // 
            dataGridViewFuelingCars.AllowUserToAddRows = false;
            dataGridViewFuelingCars.AllowUserToDeleteRows = false;
            dataGridViewFuelingCars.AllowUserToResizeColumns = false;
            dataGridViewFuelingCars.AllowUserToResizeRows = false;
            dataGridViewFuelingCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFuelingCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuelingCars.Dock = DockStyle.Fill;
            dataGridViewFuelingCars.Location = new Point(0, 0);
            dataGridViewFuelingCars.MultiSelect = false;
            dataGridViewFuelingCars.Name = "dataGridViewFuelingCars";
            dataGridViewFuelingCars.ReadOnly = true;
            dataGridViewFuelingCars.RowHeadersVisible = false;
            dataGridViewFuelingCars.RowHeadersWidth = 51;
            dataGridViewFuelingCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFuelingCars.Size = new Size(804, 455);
            dataGridViewFuelingCars.TabIndex = 1;
            // 
            // FormFuelingCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 455);
            Controls.Add(dataGridViewFuelingCars);
            Controls.Add(panel1);
            Name = "FormFuelingCars";
            Text = "FormFuelingCars";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuelingCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonAdd;
        private DataGridView dataGridViewFuelingCars;
    }
}