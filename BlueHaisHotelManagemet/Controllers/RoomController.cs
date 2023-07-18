using BlueHaisHotelManagemet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace BlueHaisHotelManagemet.Controllers
{

    public class RoomController : Controller
    {
        private readonly BlueHaisDbContext _Context;

        public RoomController(BlueHaisDbContext context)
        {
            _Context = context;
        }
        public ActionResult Index()
        {

            return View();
        }
    }
}
