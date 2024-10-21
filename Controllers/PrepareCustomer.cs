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
    public IActionResult Register(CustomerModel model)
    {
        try
        {
            var createCustomer = new CreateCustomerService(model.nationalCode, model.phoneNumber, _context);
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


    [HttpPost]
    [Route("/api/addPhone")]
    public IActionResult AddPhone(string phoneNumber, int customerId) 
    {
        try
        {
            var addPhone = new AddPhoneService(phoneNumber, customerId, _context);
            return Ok("Phone Number Added");
        }
        catch (Exception ex)
        {

            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    [Route("/api/updatePhone")]
    public IActionResult UpdatePhone(string oldValue, string newValue, int customerId)
    {
        try
        {
            var updatePhone = new UpdatePhoneService(_context);
            updatePhone.UpdatePhone(oldValue, newValue, customerId);
            return Ok("phone number updated");
        }
        catch (Exception ex)
        {

            return BadRequest(ex.Message);
        }
    }
    [HttpPost]
    [Route("/api/deletePhone")]
    public IActionResult DeletePhone(string phoneNumber, int customerId)
    {
        try
        {
            var phoneServices = new PhoneServices(_context);
            phoneServices.RemovePhone(phoneNumber, customerId);
            return Ok("Phone number Deleted");
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
