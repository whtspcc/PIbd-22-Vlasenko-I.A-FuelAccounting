// Forms/FormFuelReplenishment.cs
using FuelAccounting.Entities;
using FuelAccounting.Repositories;

namespace FuelAccounting.Forms;

public partial class FormFuelReplenishment : Form
{
    private readonly IFuelReplenishmentRepository _fuelReplenishmentRepository;

    public FormFuelReplenishment(IFuelReplenishmentRepository fuelReplenishmentRepository,
        IDriverRepository driverRepository,
        IFuelRepository fuelRepository)
    {
        InitializeComponent();
        _fuelReplenishmentRepository = fuelReplenishmentRepository ?? throw new ArgumentNullException(nameof(fuelReplenishmentRepository));

        comboBoxDriver.DataSource = driverRepository.ReadDrivers().ToList();
        comboBoxDriver.DisplayMember = "FirstName";
        comboBoxDriver.ValueMember = "Id";

        ColumnFuel.DataSource = fuelRepository.ReadFuels().ToList();
        ColumnFuel.DisplayMember = "Name";
        ColumnFuel.ValueMember = "Id";

        buttonSave.Click += buttonSave_Click;
        buttonCancel.Click += buttonCancel_Click;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxDriver.SelectedIndex < 0)
            {
                throw new Exception("Выберите водителя");
            }

            var elements = CreateElementsFromGrid();
            if (elements.Count == 0)
            {
                throw new Exception("Добавьте хотя бы одну позицию топлива");
            }

            _fuelReplenishmentRepository.CreateFuelReplenishment(FuelReplenishment.CreateOperation(
                0,
                (int)comboBoxDriver.SelectedValue!,
                elements));

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

    private List<FuelReplenishmentItem> CreateElementsFromGrid()
    {
        var list = new List<FuelReplenishmentItem>();

        foreach (DataGridViewRow row in dataGridViewFuels.Rows)
        {
            // Последняя строка пустая: в ней пользователь добавляет новую позицию
            if (row.IsNewRow)
            {
                continue;
            }

            var fuelValue = row.Cells[ColumnFuel.Name].Value;
            var litersValue = row.Cells[ColumnLiters.Name].Value;
            if (fuelValue == null || litersValue == null)
            {
                continue;
            }

            list.Add(FuelReplenishmentItem.CreateElement(
                0,
                Convert.ToInt32(fuelValue),
                Convert.ToDouble(litersValue)));
        }

        return list;
    }
}