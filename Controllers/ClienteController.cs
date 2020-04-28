using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AulaMVC.Models;
using System;

namespace AulaMVC.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost()]
       public IActionResult ReceberDados(string nomeCliente, DateTime dataNascimento)
       {
           Cliente clienteModel =  new Cliente();
           clienteModel.Nome = nomeCliente;

           switch(dataNascimento.DayOfWeek)
           {
               case DayOfWeek.Friday:
               clienteModel.DaiDaSemana = "Sexta-Feira";
               break;
               case DayOfWeek.Saturday:
               clienteModel.DaiDaSemana = "Sábado";
               break;
               default:
               clienteModel.DaiDaSemana = "Dia não existe";
               break;

           }

           return View(clienteModel);
       }
    }
}
