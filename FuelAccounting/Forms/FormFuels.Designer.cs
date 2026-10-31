namespace FuelAccounting.Forms
{
    partial class FormFuels
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
            dataGridViewFuels = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuels).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonAdd);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(813, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 441);
            panel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImage = Properties.Resources.add;
            buttonAdd.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdd.Location = new Point(49, 25);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(122, 116);
            buttonAdd.TabIndex = 0;
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.BackgroundImage = Properties.Resources.edit;
            buttonEdit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEdit.Location = new Point(49, 170);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(122, 111);
            buttonEdit.TabIndex = 1;
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = Properties.Resources.cancel;
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete.Location = new Point(49, 304);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(122, 113);
            buttonDelete.TabIndex = 2;
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFuels
            // 
            dataGridViewFuels.AllowUserToAddRows = false;
            dataGridViewFuels.AllowUserToDeleteRows = false;
            dataGridViewFuels.AllowUserToResizeColumns = false;
            dataGridViewFuels.AllowUserToResizeRows = false;
            dataGridViewFuels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFuels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuels.Dock = DockStyle.Fill;
            dataGridViewFuels.Location = new Point(0, 0);
            dataGridViewFuels.MultiSelect = false;
            dataGridViewFuels.Name = "dataGridViewFuels";
            dataGridViewFuels.ReadOnly = true;
            dataGridViewFuels.RowHeadersVisible = false;
            dataGridViewFuels.RowHeadersWidth = 51;
            dataGridViewFuels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFuels.Size = new Size(813, 441);
            dataGridViewFuels.TabIndex = 1;
            // 
            // FormFuels
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 441);
            Controls.Add(dataGridViewFuels);
            Controls.Add(panel1);
            Name = "FormFuels";
            Text = "FormFuels";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuels).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private DataGridView dataGridViewFuels;
    }
}