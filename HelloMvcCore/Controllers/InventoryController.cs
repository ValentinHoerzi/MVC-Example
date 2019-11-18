using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloMvcCore.Models;
using HelloMvcCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloMvcCore.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryServices _service;

        public InventoryController(IInventoryServices service)
        {
            _service = service;
        }


        /*
         * POST https://localhost:44388/v1/AddInventoryItems
         * 
         * {
	            "Id": "2",
	            "ItemName": "Lawn Moar",
	            "Price": 3334
            }
         */

        [HttpPost]
        [Route("AddInventoryItems")]
        public ActionResult<InventoryItems> AddInventoryItems(InventoryItems items)
        {
            var inventoryItems = _service.AddInventoryItems(items);

            if(inventoryItems == null)
            {
                return NotFound();
            }
            return inventoryItems;
        }


        /*
         * GET https://localhost:44388/v1/GetInventoryItems
         */
        [HttpGet]
        [Route("GetInventoryItems")]
        public ActionResult<Dictionary<string,InventoryItems>> GetInventoryItems()
        {
            var items = _service.GetInventoryItems();

            if(items == null)
            {
                return NotFound();
            }

            return items;
        }
    }
}