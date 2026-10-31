namespace FuelAccounting.Forms
{
    partial class FormFuelReplenishments
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
            buttonDelete = new Button();
            dataGridViewFuelReplenishments = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuelReplenishments).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(buttonDelete);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(793, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 431);
            panel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImage = Properties.Resources.add;
            buttonAdd.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdd.Location = new Point(38, 34);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(109, 108);
            buttonAdd.TabIndex = 1;
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = Properties.Resources.cancel;
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete.Location = new Point(38, 291);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(109, 104);
            buttonDelete.TabIndex = 2;
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFuelReplenishments
            // 
            dataGridViewFuelReplenishments.AllowUserToAddRows = false;
            dataGridViewFuelReplenishments.AllowUserToDeleteRows = false;
            dataGridViewFuelReplenishments.AllowUserToResizeColumns = false;
            dataGridViewFuelReplenishments.AllowUserToResizeRows = false;
            dataGridViewFuelReplenishments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFuelReplenishments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuelReplenishments.Dock = DockStyle.Fill;
            dataGridViewFuelReplenishments.Location = new Point(0, 0);
            dataGridViewFuelReplenishments.MultiSelect = false;
            dataGridViewFuelReplenishments.Name = "dataGridViewFuelReplenishments";
            dataGridViewFuelReplenishments.ReadOnly = true;
            dataGridViewFuelReplenishments.RowHeadersVisible = false;
            dataGridViewFuelReplenishments.RowHeadersWidth = 51;
            dataGridViewFuelReplenishments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFuelReplenishments.Size = new Size(793, 431);
            dataGridViewFuelReplenishments.TabIndex = 1;
            // 
            // FormFuelReplenishments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 431);
            Controls.Add(dataGridViewFuelReplenishments);
            Controls.Add(panel1);
            Name = "FormFuelReplenishments";
            Text = "FormFuelReplenishments";
            Load += FormFuelReplenishments_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuelReplenishments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonAdd;
        private Button buttonDelete;
        private DataGridView dataGridViewFuelReplenishments;
    }
}