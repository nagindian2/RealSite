using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealSite.DBProvider;
using RealSite.DBProvider.Model;
using RealSite.Enums;
using RealSiteAPI.Repository;
using System.Collections.Generic;


namespace RealSiteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealSiteController : ControllerBase
    {
        private AppDbContext _appDbContext;
        public RealSiteController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    OkObjectResult response = new OkObjectResult(new object());
        //    try
        //    {
        //        IEnumerable<Employee> employees = new EmployeeRepository(_appDbContext).GetAll();
        //        response = Ok(employees);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Invalid Action Provided");
        //    }
        //    response = Ok(new object());
        //    return await Task.Run(() => response);
        //}

        [HttpGet]
        public async Task<IActionResult> Get(string service)
        {
            OkObjectResult response = new OkObjectResult(new object());
            try
            {
                ControllerActions objAction = (ControllerActions)Enum.Parse(typeof(ControllerActions), service);
                switch (objAction)
                {

                    case ControllerActions.GetEmployeeDetails:
                        IEnumerable<Employee> employees = new EmployeeRepo(_appDbContext).GetAll();
                        response = Ok(employees);
                        break;
                    case ControllerActions.GetFileReassignDetails:
                        IEnumerable<FileReassign> fileReassignDetails = new FileReassignRepo(_appDbContext).GetAll();
                        response = Ok(fileReassignDetails);
                        break;
                    default:
                        IEnumerable<FileReassign> top100fileReassignDetails = new FileReassignRepo(_appDbContext).GetTop100();
                        response = Ok("connected");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid Action Provided");
            }
            //   response = Ok(new object());
            return await Task.Run(() => response);
        }

        [HttpGet("top100")]
        public async Task<IActionResult> GetTop100()
        {
            OkObjectResult response = new OkObjectResult(new object());
            IEnumerable<FileReassign> top100fileReassignDetails = new FileReassignRepo(_appDbContext).GetTop100().ToList();
           
            return await Task.Run(() => response= Ok( top100fileReassignDetails));
             
        }
         
    }
}
