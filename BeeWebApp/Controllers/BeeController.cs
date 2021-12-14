using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeeCore.Services;
using BeeWebApp.Models;
using System.Dynamic;

namespace BeeWebApp.Controllers
{
    public class BeeController : Controller
    {
        // GET: BeeController
        public ActionResult GetAllBeeDetails()
        {
            BeeListViewModel beeListViewModel = new BeeListViewModel();
            DroneService droneService = new DroneService();
            beeListViewModel.Drones = droneService.GetBeeDetails();
            QueenService queenService = new QueenService();
            beeListViewModel.Queens = queenService.GetBeeDetails();
            WorkerService workerService = new WorkerService();
            beeListViewModel.Workers = workerService.GetBeeDetails();
            return View(beeListViewModel);
        }

        // GET: BeeController/Details/5
        public ActionResult GetWorkerDetails(Worker worker)
        {
            BeeService beeService = new BeeService();
            int number= beeService.GenerateRandomNumber();
            WorkerService workerService = new WorkerService();
            worker.Health = workerService.Damage(number);
            return View(worker);
        }
        public ActionResult GetQueenDetails(Queen queen)
        {
            BeeService beeService = new BeeService();
            int number = beeService.GenerateRandomNumber();
            QueenService queenService = new QueenService();
            queen.Health = queenService.Damage(number);
            return View(queen);
        }
        public ActionResult GetDroneDetails(Drone drone)
        {
            BeeService beeService = new BeeService();
            int number = beeService.GenerateRandomNumber();
            DroneService droneService = new DroneService();
            drone.Health=droneService.Damage(number);
            return View(drone);
        }
    }
}
