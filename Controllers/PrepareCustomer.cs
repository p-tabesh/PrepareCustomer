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
using AspNETProj.DatabaseContext;
namespace AspNETProj.Controllers;

public class PrepareCustomer: Controller
{
    private readonly Context _context;
    public PrepareCustomer(Context context)
    {
        _context = context;
    }

    [HttpPost]
    [AllowAnonymous]
    [Route("/api/Register")]
    public IActionResult Register([FromBody] CustomerModel model)
    {
        try
        {
            var createCustomer = new CreateCustomer(model.nationalCode, model.phoneNumber, _context);
            return Ok("Customer Added");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
        
    }
    [HttpGet]
    [Route("/api/GetCustomer")]
    public IActionResult GetCustomer(int id)
    {
        throw new NotImplementedException();
        
    }

    public IActionResult GetAllCustomers()
    {
        throw new NotImplementedException();
    }


}
