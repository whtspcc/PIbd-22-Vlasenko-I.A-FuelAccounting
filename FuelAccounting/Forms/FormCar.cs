using FuelAccounting.Entities;
using FuelAccounting.Entities.Enums;
using FuelAccounting.Repositories;

namespace FuelAccounting.Forms;

public partial class FormCar : Form
{
    private readonly ICarRepository _carRepository;

    private int? _carId;

    public int Id
    {
        set
        {
            try
            {
                var car = _carRepository.ReadCarById(value);
                if (car == null)
                {
                    throw new InvalidDataException(nameof(car));
                }

                _carId = car.Id;
                textBoxLicensePlate.Text = car.LicensePlate;
                textBoxModel.Text = car.Model;
                numericUpDownTankCapacity.Value = (decimal)car.TankCapacity;
                comboBoxCategory.SelectedItem = car.CarCategory;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormCar(ICarRepository carRepository)
    {
        InitializeComponent();
        _carRepository = carRepository ?? throw new ArgumentNullException(nameof(carRepository));

        var categories = Enum.GetValues(typeof(CarCategory))
            .Cast<CarCategory>()
            .Where(c => c != CarCategory.None)
            .ToList();

        comboBoxCategory.DataSource = categories;
        comboBoxCategory.SelectedIndex = 0;

        buttonSave.Click += buttonSave_Click;
        buttonCancel.Click += buttonCancel_Click;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxLicensePlate.Text) ||
                string.IsNullOrWhiteSpace(textBoxModel.Text))
            {
                throw new Exception("Заполните все текстовые поля");
            }

            if (comboBoxCategory.SelectedItem == null)
            {
                throw new Exception("Выберите категорию");
            }

            if (_carId.HasValue)
            {
                _carRepository.UpdateCar(CreateCar(_carId.Value));
            }
            else
            {
                _carRepository.CreateCar(CreateCar(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private Car CreateCar(int id)
    {
        return Car.CreateEntity(
            id,
            textBoxLicensePlate.Text,
            textBoxModel.Text,
            (CarCategory)comboBoxCategory.SelectedItem!,
            (double)numericUpDownTankCapacity.Value);
    }
}