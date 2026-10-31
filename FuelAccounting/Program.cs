using FuelAccounting.Repositories;
using FuelAccounting.Repositories.Implementations;
using Unity;
using Unity.Lifetime;

namespace FuelAccounting
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<FormFuelAccounting>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<ICarRepository, CarRepository>(new TransientLifetimeManager());
            container.RegisterType<IDriverRepository, DriverRepository>(new TransientLifetimeManager());
            container.RegisterType<IFuelRepository, FuelRepository>(new TransientLifetimeManager());
            container.RegisterType<IFuelReplenishmentRepository, FuelReplenishmentRepository>(new TransientLifetimeManager());
            container.RegisterType<IFuelingCarRepository, FuelingCarRepository>(new TransientLifetimeManager());

            return container;
        }
    }
}