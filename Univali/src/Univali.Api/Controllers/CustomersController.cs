using Microsoft.AspNetCore.Mvc;
using Univali.Api.Entities;

namespace Univali.Api.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomersController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Customer>> GetCustomers()
    {
        var result = Data.Instance.Customers;
        return Ok(result);
    }

    [HttpGet("{id}")]
    public ActionResult<Customer> GetCustomer ([FromRoute] int id) 
    {
        var result = Data.Instance.Customers.FirstOrDefault(c => c.Id == id);

        if(result != null) return Ok(result);

        return NotFound();
    }
}