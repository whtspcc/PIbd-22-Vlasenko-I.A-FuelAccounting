using FuelAccounting.Entities;
using FuelAccounting.Repositories;

namespace FuelAccounting.Forms;

public partial class FormFuelingCar : Form
{
    private readonly IFuelingCarRepository _fuelingCarRepository;

    public FormFuelingCar(IFuelingCarRepository fuelingCarRepository,
        IFuelRepository fuelRepository,
        IDriverRepository driverRepository,
        ICarRepository carRepository)
    {
        InitializeComponent();
        _fuelingCarRepository = fuelingCarRepository ?? throw new ArgumentNullException(nameof(fuelingCarRepository));

        comboBoxDriver.DataSource = driverRepository.ReadDrivers().ToList();
        comboBoxDriver.DisplayMember = "FirstName";
        comboBoxDriver.ValueMember = "Id";

        comboBoxFuel.DataSource = fuelRepository.ReadFuels().ToList();
        comboBoxFuel.DisplayMember = "Name";
        comboBoxFuel.ValueMember = "Id";

        comboBoxCar.DataSource = carRepository.ReadCars().ToList();
        comboBoxCar.DisplayMember = "LicensePlate";
        comboBoxCar.ValueMember = "Id";

        buttonSave.Click += buttonSave_Click;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxDriver.SelectedIndex < 0 ||
                comboBoxFuel.SelectedIndex < 0 ||
                comboBoxCar.SelectedIndex < 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            _fuelingCarRepository.CreateFuelingCar(FuelingCar.CreateOperation(
                0,
                (int)comboBoxFuel.SelectedValue!,
                (int)comboBoxDriver.SelectedValue!,
                (int)comboBoxCar.SelectedValue!,
                Convert.ToDouble(numericUpDownLiters.Value)));

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}