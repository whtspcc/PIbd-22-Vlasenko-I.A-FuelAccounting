using FuelAccounting.Entities;
using FuelAccounting.Entities.Enums;
using FuelAccounting.Repositories;
using FuelAccounting.Entities;
using FuelAccounting.Entities.Enums;

namespace FuelAccounting.Forms;

public partial class FormFuel : Form
{
    private readonly IFuelRepository _fuelRepository;

    private int? _fuelId;

    public int Id
    {
        set
        {
            try
            {
                var fuel = _fuelRepository.ReadFuelById(value);
                if (fuel == null)
                {
                    throw new InvalidDataException(nameof(fuel));
                }

                _fuelId = fuel.Id;
                textBoxName.Text = fuel.Name;
                textBoxDescription.Text = fuel.Description;
                SetFuelTypes(fuel.FuelType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormFuel(IFuelRepository fuelRepository)
    {
        InitializeComponent();
        _fuelRepository = fuelRepository ?? throw new ArgumentNullException(nameof(fuelRepository));

        // Все значения флагового перечисления, кроме None
        foreach (FuelType type in Enum.GetValues(typeof(FuelType)))
        {
            if (type != FuelType.None)
            {
                checkedListBoxFuelTypes.Items.Add(type);
            }
        }

        buttonSave.Click += buttonSave_Click;
        buttonCancel.Click += buttonCancel_Click;
    }

    private void SetFuelTypes(FuelType fuelType)
    {
        for (int i = 0; i < checkedListBoxFuelTypes.Items.Count; i++)
        {
            var type = (FuelType)checkedListBoxFuelTypes.Items[i];
            checkedListBoxFuelTypes.SetItemChecked(i, fuelType.HasFlag(type));
        }
    }

    private FuelType GetFuelTypes()
    {
        var result = FuelType.None;
        foreach (FuelType type in checkedListBoxFuelTypes.CheckedItems)
        {
            result |= type;
        }
        return result;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                throw new Exception("Заполните название");
            }

            if (GetFuelTypes() == FuelType.None)
            {
                throw new Exception("Выберите хотя бы один тип топлива");
            }

            if (_fuelId.HasValue)
            {
                _fuelRepository.UpdateFuel(CreateFuel(_fuelId.Value));
            }
            else
            {
                _fuelRepository.CreateFuel(CreateFuel(0));
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

    private Fuel CreateFuel(int id)
    {
        return Fuel.CreateEntity(
            id,
            GetFuelTypes(),
            textBoxName.Text,
            textBoxDescription.Text);
    }
}