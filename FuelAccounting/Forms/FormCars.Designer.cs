namespace FuelAccounting.Forms
{
    partial class FormCars
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
            panelButtons = new Panel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            dataGridViewCars = new DataGridView();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonAdd);
            panelButtons.Controls.Add(buttonEdit);
            panelButtons.Controls.Add(buttonDelete);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(762, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(162, 428);
            panelButtons.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImage = Properties.Resources.add;
            buttonAdd.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdd.Location = new Point(25, 22);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(115, 112);
            buttonAdd.TabIndex = 1;
            buttonAdd.TextAlign = ContentAlignment.MiddleRight;
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.BackgroundImage = Properties.Resources.edit;
            buttonEdit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEdit.Location = new Point(25, 157);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(115, 108);
            buttonEdit.TabIndex = 2;
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = Properties.Resources.cancel;
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete.Location = new Point(25, 283);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(115, 110);
            buttonDelete.TabIndex = 3;
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.AllowUserToAddRows = false;
            dataGridViewCars.AllowUserToDeleteRows = false;
            dataGridViewCars.AllowUserToResizeColumns = false;
            dataGridViewCars.AllowUserToResizeRows = false;
            dataGridViewCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Dock = DockStyle.Fill;
            dataGridViewCars.Location = new Point(0, 0);
            dataGridViewCars.MultiSelect = false;
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.ReadOnly = true;
            dataGridViewCars.RowHeadersVisible = false;
            dataGridViewCars.RowHeadersWidth = 51;
            dataGridViewCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCars.Size = new Size(762, 428);
            dataGridViewCars.TabIndex = 1;
            // 
            // FormCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 428);
            Controls.Add(dataGridViewCars);
            Controls.Add(panelButtons);
            Name = "FormCars";
            Text = "Автомобили";
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Button buttonDelete;
        private Button buttonAdd;
        private Button buttonEdit;
        private DataGridView dataGridViewCars;
    }
}