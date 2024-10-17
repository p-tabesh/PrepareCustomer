using AspNETProj.Models;
using AspNETProj.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AspNETProj.Entities;

public class Customer
{
    public int Id { get; set; }
    public string NationalCode { get; private set; }
    public string Phone { get; private set; }
    
    public DateTime CreationDate { get; private set; }

    public Customer() {} // For EF Core
    public Customer(string natioalcode, string phonenumber)
    {
        if (String.IsNullOrEmpty(natioalcode))
        {
            throw new Exception("nationalCode must have value");
        } if (String.IsNullOrEmpty(phonenumber))
        {
            throw new Exception("Phone must have value");
        }

        NationalCode = natioalcode;
        Phone = phonenumber;
        CreationDate = DateTime.Now;
    }
}





