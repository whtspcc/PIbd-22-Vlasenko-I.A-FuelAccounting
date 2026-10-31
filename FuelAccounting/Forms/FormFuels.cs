using FuelAccounting.Repositories;
using Unity;

namespace FuelAccounting.Forms;

public partial class FormFuels : Form
{
    private readonly IFuelRepository _fuelRepository;
    private readonly IUnityContainer _container;

    public FormFuels(IFuelRepository fuelRepository, IUnityContainer container)
    {
        InitializeComponent();
        _fuelRepository = fuelRepository ?? throw new ArgumentNullException(nameof(fuelRepository));
        _container = container ?? throw new ArgumentNullException(nameof(container));

        Load += FormFuels_Load;
        buttonAdd.Click += buttonAdd_Click;
        buttonEdit.Click += buttonEdit_Click;
        buttonDelete.Click += buttonDelete_Click;
    }

    private void FormFuels_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        try
        {
            var fuels = _fuelRepository.ReadFuels()
                .Select(f => new
                {
                    f.Id,
                    f.Name,
                    f.FuelType,
                    f.Description
                })
                .ToList();

            dataGridViewFuels.DataSource = fuels;

            dataGridViewFuels.Columns["Id"].Visible = false;
            dataGridViewFuels.Columns["Name"].HeaderText = "Название";
            dataGridViewFuels.Columns["FuelType"].HeaderText = "Тип топлива";
            dataGridViewFuels.Columns["Description"].HeaderText = "Описание";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при получении данных",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        _container.Resolve<FormFuel>().ShowDialog();
        LoadData();
    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
        if (dataGridViewFuels.CurrentRow == null)
        {
            MessageBox.Show("Выберите запись", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var form = _container.Resolve<FormFuel>();
        form.Id = (int)dataGridViewFuels.CurrentRow.Cells["Id"].Value;
        form.ShowDialog();
        LoadData();
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        if (dataGridViewFuels.CurrentRow == null)
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
            var id = (int)dataGridViewFuels.CurrentRow.Cells["Id"].Value;
            _fuelRepository.DeleteFuel(id);
            LoadData();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}