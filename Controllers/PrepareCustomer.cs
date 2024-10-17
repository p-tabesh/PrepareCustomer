using System.Diagnostics;
using AspNETProj.Entities;
using Microsoft.AspNetCore.Mvc;
using AspNETProj.Models;
using AspNETProj.Services;
using AspNETProj.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using AspNETProj.Repositories;
using System.Text.Json.Nodes;
using System.Runtime.InteropServices;

namespace AspNETProj.Controllers;

public class PrepareCustomer: Controller
{
    [HttpPost]
    [AllowAnonymous]
    public IActionResult Register([FromBody] CustomerModel model)
    {
        try
        {
            var createCustomer = new CreateCustomer(model.nationalCode, model.phoneNumber);
            return Ok("Customer Added");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
        
    }
    [HttpGet]
    public IActionResult GetCustomer(int id)
    {
        throw new NotImplementedException();
        
    }

    public IActionResult GetAllCustomers()
    {
        throw new NotImplementedException();
    }


}
