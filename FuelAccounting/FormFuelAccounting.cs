using FuelAccounting.Forms;
using Unity;

namespace FuelAccounting
{
    public partial class FormFuelAccounting : Form
    {
        private readonly IUnityContainer _container;

        public FormFuelAccounting(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormCars>().ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormDrivers>().ShowDialog();
        }

        private void FuelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormFuels>().ShowDialog();
        }

        private void fuelingCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormFuelingCars>().ShowDialog();
        }

        private void fuelReplenishmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormFuelReplenishments>().ShowDialog();
        }
    }
}