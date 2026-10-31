namespace FuelAccounting.Forms
{
    partial class FormDrivers
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
            buttonEdit = new Button();
            buttonDelete = new Button();
            dataGridViewDrivers = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonAdd);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(814, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 420);
            panel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImage = Properties.Resources.add;
            buttonAdd.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdd.Location = new Point(30, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(121, 115);
            buttonAdd.TabIndex = 0;
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.BackgroundImage = Properties.Resources.edit;
            buttonEdit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEdit.Location = new Point(30, 155);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(121, 107);
            buttonEdit.TabIndex = 1;
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = Properties.Resources.cancel;
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete.Location = new Point(30, 287);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(121, 107);
            buttonDelete.TabIndex = 2;
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDrivers
            // 
            dataGridViewDrivers.AllowUserToAddRows = false;
            dataGridViewDrivers.AllowUserToDeleteRows = false;
            dataGridViewDrivers.AllowUserToResizeColumns = false;
            dataGridViewDrivers.AllowUserToResizeRows = false;
            dataGridViewDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrivers.Dock = DockStyle.Fill;
            dataGridViewDrivers.Location = new Point(0, 0);
            dataGridViewDrivers.MultiSelect = false;
            dataGridViewDrivers.Name = "dataGridViewDrivers";
            dataGridViewDrivers.ReadOnly = true;
            dataGridViewDrivers.RowHeadersVisible = false;
            dataGridViewDrivers.RowHeadersWidth = 51;
            dataGridViewDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDrivers.Size = new Size(814, 420);
            dataGridViewDrivers.TabIndex = 1;
            // 
            // FormDrivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 420);
            Controls.Add(dataGridViewDrivers);
            Controls.Add(panel1);
            Name = "FormDrivers";
            Text = "FormDrivers";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private DataGridView dataGridViewDrivers;
    }
}