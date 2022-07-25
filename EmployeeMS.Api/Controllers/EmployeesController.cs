using AutoMapper;
using BusinessLayer.Abstract;
using Core.Models;
using DataAccessLayer.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeMS.Api.Controllers
{
    [Route("api/[controller]")]  ///api/GetEmployee
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        public EmployeesController(IMapper mapper,
                                   IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetEmployee()
        {
            var employee = _mapper.Map<List<EmployeeGetDto>>(_employeeService.GetAll());
            return Ok(employee);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_employeeService.GetT(i => i.EmployeeId == id));
        }


        [HttpPost]
        public IActionResult Add(AddEmployeeDto addEmployeeDto)
        {
            var addedEmp = _mapper.Map<TblEmployee>(addEmployeeDto);
            _employeeService.Add(addedEmp);
            return Ok();
        }
    }
}
