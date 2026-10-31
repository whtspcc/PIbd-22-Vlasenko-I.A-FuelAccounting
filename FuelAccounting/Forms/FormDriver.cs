// Forms/FormDriver.cs
using FuelAccounting.Entities;
using FuelAccounting.Entities.Enums;
using FuelAccounting.Repositories;

namespace FuelAccounting.Forms;

public partial class FormDriver : Form
{
    private readonly IDriverRepository _driverRepository;

    private int? _driverId;

    public int Id
    {
        set
        {
            try
            {
                var driver = _driverRepository.ReadDriverById(value);
                if (driver == null)
                {
                    throw new InvalidDataException(nameof(driver));
                }

                _driverId = driver.Id;
                textBoxLastName.Text = driver.LastName;
                textBoxFirstName.Text = driver.FirstName;
                comboBoxCategory.SelectedItem = driver.CarCategory;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormDriver(IDriverRepository driverRepository)
    {
        InitializeComponent();
        _driverRepository = driverRepository ?? throw new ArgumentNullException(nameof(driverRepository));

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
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                throw new Exception("Заполните все текстовые поля");
            }

            if (comboBoxCategory.SelectedItem == null)
            {
                throw new Exception("Выберите категорию");
            }

            if (_driverId.HasValue)
            {
                _driverRepository.UpdateDriver(CreateDriver(_driverId.Value));
            }
            else
            {
                _driverRepository.CreateDriver(CreateDriver(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private Driver CreateDriver(int id)
    {
        return Driver.CreateEntity(
            id,
            textBoxFirstName.Text,
            textBoxLastName.Text,
            (CarCategory)comboBoxCategory.SelectedItem!);
    }
}