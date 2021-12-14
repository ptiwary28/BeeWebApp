using System;
using BeeCore.Services;
using BeeWebApp;

namespace BeeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BeeService beeService = new BeeService();
            Queen queen = new Queen();
            Console.WriteLine("Queen initial health -" + queen.Health);
            QueenService queenService = new QueenService();
            queen.Health = queenService.Damage(beeService.GenerateRandomNumber());
            Console.WriteLine("Queen health after calling damage-" + queen.Health);
             
            Worker worker = new Worker();
            Console.WriteLine("Worker initial health -" + worker.Health);
            WorkerService workerService = new WorkerService();
            worker.Health = workerService.Damage(beeService.GenerateRandomNumber());
            Console.WriteLine("Worker after calling damage-" + worker.Health);
              
            Drone drone = new Drone();
            Console.WriteLine("Drone initial health -" + drone.Health);
            DroneService droneService = new DroneService();
            drone.Health = droneService.Damage(beeService.GenerateRandomNumber());
            Console.WriteLine("Drone health after calling damage-" + drone.Health);
        }
    }
}
