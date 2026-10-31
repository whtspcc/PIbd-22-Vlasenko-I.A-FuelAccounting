// Forms/FormFuelReplenishments.cs
using FuelAccounting.Repositories;
using Unity;

namespace FuelAccounting.Forms;

public partial class FormFuelReplenishments : Form
{
    private readonly IUnityContainer _container;
    private readonly IFuelReplenishmentRepository _fuelReplenishmentRepository;

    public FormFuelReplenishments(IUnityContainer container,
        IFuelReplenishmentRepository fuelReplenishmentRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _fuelReplenishmentRepository = fuelReplenishmentRepository ?? throw new ArgumentNullException(nameof(fuelReplenishmentRepository));

        Load += FormFuelReplenishments_Load;
        buttonAdd.Click += buttonAdd_Click;
        buttonDelete.Click += buttonDelete_Click;
    }

    private void FormFuelReplenishments_Load(object sender, EventArgs e)
    {
        LoadList();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormFuelReplenishment>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        if (dataGridViewFuelReplenishments.CurrentRow == null)
        {
            MessageBox.Show("Выберите запись", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var result = MessageBox.Show("Удалить выбранную запись?", "Подтверждение",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result != DialogResult.Yes)
        {
            return;
        }

        try
        {
            var id = (int)dataGridViewFuelReplenishments.CurrentRow.Cells["Id"].Value;
            _fuelReplenishmentRepository.DeleteFuelReplenishment(id);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList()
    {
        try
        {
            var replenishments = _fuelReplenishmentRepository.ReadFuelReplenishments()
                .Select(r => new
                {
                    r.Id,
                    r.DateReceipt,
                    r.DriverId
                })
                .ToList();

            dataGridViewFuelReplenishments.DataSource = replenishments;

            dataGridViewFuelReplenishments.Columns["Id"].Visible = false;
            dataGridViewFuelReplenishments.Columns["DateReceipt"].HeaderText = "Дата";
            dataGridViewFuelReplenishments.Columns["DriverId"].HeaderText = "Водитель";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}