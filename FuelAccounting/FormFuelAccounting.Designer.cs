namespace FuelAccounting
{
    partial class FormFuelAccounting
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
            menuStrip1 = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            автомобилиToolStripMenuItem = new ToolStripMenuItem();
            водителиToolStripMenuItem = new ToolStripMenuItem();
            топливоToolStripMenuItem = new ToolStripMenuItem();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            заправкаАвтомобилейToolStripMenuItem = new ToolStripMenuItem();
            пополнениеТопливаToolStripMenuItem = new ToolStripMenuItem();
            отчетыToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, операцииToolStripMenuItem, отчетыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(841, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { автомобилиToolStripMenuItem, водителиToolStripMenuItem, топливоToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(117, 24);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // автомобилиToolStripMenuItem
            // 
            автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            автомобилиToolStripMenuItem.Size = new Size(180, 26);
            автомобилиToolStripMenuItem.Text = "Автомобили";
            автомобилиToolStripMenuItem.Click += carsToolStripMenuItem_Click;
            // 
            // водителиToolStripMenuItem
            // 
            водителиToolStripMenuItem.Name = "водителиToolStripMenuItem";
            водителиToolStripMenuItem.Size = new Size(180, 26);
            водителиToolStripMenuItem.Text = "Водители";
            водителиToolStripMenuItem.Click += driversToolStripMenuItem_Click;
            // 
            // топливоToolStripMenuItem
            // 
            топливоToolStripMenuItem.Name = "топливоToolStripMenuItem";
            топливоToolStripMenuItem.Size = new Size(180, 26);
            топливоToolStripMenuItem.Text = "Топливо";
            топливоToolStripMenuItem.Click += FuelToolStripMenuItem_Click;
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { заправкаАвтомобилейToolStripMenuItem, пополнениеТопливаToolStripMenuItem });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(95, 24);
            операцииToolStripMenuItem.Text = "Операции";
            // 
            // заправкаАвтомобилейToolStripMenuItem
            // 
            заправкаАвтомобилейToolStripMenuItem.Name = "заправкаАвтомобилейToolStripMenuItem";
            заправкаАвтомобилейToolStripMenuItem.Size = new Size(255, 26);
            заправкаАвтомобилейToolStripMenuItem.Text = "Заправка автомобилей";
            заправкаАвтомобилейToolStripMenuItem.Click += fuelingCarsToolStripMenuItem_Click;
            // 
            // пополнениеТопливаToolStripMenuItem
            // 
            пополнениеТопливаToolStripMenuItem.Name = "пополнениеТопливаToolStripMenuItem";
            пополнениеТопливаToolStripMenuItem.Size = new Size(255, 26);
            пополнениеТопливаToolStripMenuItem.Text = "Пополнение топлива";
            пополнениеТопливаToolStripMenuItem.Click += fuelReplenishmentToolStripMenuItem_Click;
            // 
            // отчетыToolStripMenuItem
            // 
            отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            отчетыToolStripMenuItem.Size = new Size(73, 24);
            отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // FormFuelAccounting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(841, 452);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormFuelAccounting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Учет ГСМ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem автомобилиToolStripMenuItem;
        private ToolStripMenuItem водителиToolStripMenuItem;
        private ToolStripMenuItem топливоToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem заправкаАвтомобилейToolStripMenuItem;
        private ToolStripMenuItem пополнениеТопливаToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
    }
}