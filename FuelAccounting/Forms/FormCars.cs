// Forms/FormCars.cs
using FuelAccounting.Repositories;
using Unity;

namespace FuelAccounting.Forms;

public partial class FormCars : Form
{
    private readonly ICarRepository _carRepository;
    private readonly IUnityContainer _container;

    public FormCars(ICarRepository carRepository, IUnityContainer container)
    {
        InitializeComponent();
        _carRepository = carRepository ?? throw new ArgumentNullException(nameof(carRepository));
        _container = container ?? throw new ArgumentNullException(nameof(container));

        Load += FormCars_Load;
        buttonAdd.Click += buttonAdd_Click;
        buttonEdit.Click += buttonEdit_Click;
        buttonDelete.Click += buttonDelete_Click;
    }

    private void FormCars_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        try
        {
            var cars = _carRepository.ReadCars()
                .Select(c => new
                {
                    c.Id,
                    c.LicensePlate,
                    c.Model,
                    c.CarCategory,
                    c.TankCapacity
                })
                .ToList();

            dataGridViewCars.DataSource = cars;

            dataGridViewCars.Columns["Id"].Visible = false;
            dataGridViewCars.Columns["LicensePlate"].HeaderText = "Госномер";
            dataGridViewCars.Columns["Model"].HeaderText = "Модель";
            dataGridViewCars.Columns["CarCategory"].HeaderText = "Категория";
            dataGridViewCars.Columns["TankCapacity"].HeaderText = "Объем бака, л";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при получении данных",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        _container.Resolve<FormCar>().ShowDialog();
        LoadData();
    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
        if (dataGridViewCars.CurrentRow == null)
        {
            MessageBox.Show("Выберите запись", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var form = _container.Resolve<FormCar>();
        form.Id = (int)dataGridViewCars.CurrentRow.Cells["Id"].Value;
        form.ShowDialog();
        LoadData();
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        if (dataGridViewCars.CurrentRow == null)
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
            var id = (int)dataGridViewCars.CurrentRow.Cells["Id"].Value;
            _carRepository.DeleteCar(id);
            LoadData();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}