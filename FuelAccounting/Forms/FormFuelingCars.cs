// Forms/FormFuelingCars.cs
using FuelAccounting.Repositories;
using Unity;

namespace FuelAccounting.Forms;

public partial class FormFuelingCars : Form
{
    private readonly IUnityContainer _container;
    private readonly IFuelingCarRepository _fuelingCarRepository;

    public FormFuelingCars(IUnityContainer container, IFuelingCarRepository fuelingCarRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _fuelingCarRepository = fuelingCarRepository ?? throw new ArgumentNullException(nameof(fuelingCarRepository));

        Load += FormFuelingCars_Load;
        buttonAdd.Click += buttonAdd_Click;
    }

    private void FormFuelingCars_Load(object sender, EventArgs e)
    {
        LoadList();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormFuelingCar>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList()
    {
        try
        {
            var fuelingCars = _fuelingCarRepository.ReadFuelingCars()
                .Select(f => new
                {
                    f.Id,
                    f.FuelingDate,
                    f.DriverId,
                    f.CarId,
                    f.FuelId,
                    f.Liters
                })
                .ToList();

            dataGridViewFuelingCars.DataSource = fuelingCars;

            dataGridViewFuelingCars.Columns["Id"].Visible = false;
            dataGridViewFuelingCars.Columns["FuelingDate"].HeaderText = "Дата";
            dataGridViewFuelingCars.Columns["DriverId"].HeaderText = "Водитель";
            dataGridViewFuelingCars.Columns["CarId"].HeaderText = "Автомобиль";
            dataGridViewFuelingCars.Columns["FuelId"].HeaderText = "Топливо";
            dataGridViewFuelingCars.Columns["Liters"].HeaderText = "Литры";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}