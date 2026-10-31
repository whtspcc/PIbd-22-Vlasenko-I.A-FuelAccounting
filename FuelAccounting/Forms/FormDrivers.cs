// Forms/FormDrivers.cs
using FuelAccounting.Repositories;
using Unity;

namespace FuelAccounting.Forms;

public partial class FormDrivers : Form
{
    private readonly IDriverRepository _driverRepository;
    private readonly IUnityContainer _container;

    public FormDrivers(IDriverRepository driverRepository, IUnityContainer container)
    {
        InitializeComponent();
        _driverRepository = driverRepository ?? throw new ArgumentNullException(nameof(driverRepository));
        _container = container ?? throw new ArgumentNullException(nameof(container));

        buttonAdd.Click += buttonAdd_Click;
        buttonEdit.Click += buttonEdit_Click;
        buttonDelete.Click += buttonDelete_Click;
    }

    private void FormDrivers_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        try
        {
            var drivers = _driverRepository.ReadDrivers()
                .Select(d => new
                {
                    d.Id,
                    d.FirstName,
                    d.LastName,
                    d.CarCategory
                })
                .ToList();

            dataGridViewDrivers.DataSource = drivers;

            dataGridViewDrivers.Columns["Id"].Visible = false;
            dataGridViewDrivers.Columns["FirstName"].HeaderText = "Имя";
            dataGridViewDrivers.Columns["LastName"].HeaderText = "Фамилия";
            dataGridViewDrivers.Columns["CarCategory"].HeaderText = "Категория";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при получении данных",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        _container.Resolve<FormDriver>().ShowDialog();
        LoadData();
    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
        if (dataGridViewDrivers.CurrentRow == null)
        {
            MessageBox.Show("Выберите запись", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var form = _container.Resolve<FormDriver>();
        form.Id = (int)dataGridViewDrivers.CurrentRow.Cells["Id"].Value;
        form.ShowDialog();
        LoadData();
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        if (dataGridViewDrivers.CurrentRow == null)
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
            var id = (int)dataGridViewDrivers.CurrentRow.Cells["Id"].Value;
            _driverRepository.DeleteDriver(id);
            LoadData();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}