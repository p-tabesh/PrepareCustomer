using AspNETProj.Models;
using AspNETProj.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AspNETProj.Entities;

public class Customer
{
    public int Id { get; set; }
    public string NationalCode { get; private set; }
    public DateTime CreationDate { get; private set; }
    public ICollection<Phone>? Phones { get; set; }

    public Customer() 
    {
        Phones = new List<Phone>();
    } // For EF Core
    public Customer(string natioalcode)
    {

        if (String.IsNullOrEmpty(natioalcode))
        {
            throw new Exception("nationalCode must have value");
        }
        Phones = new List<Phone>();
        NationalCode = natioalcode;
        CreationDate = DateTime.Now;
    }
}




