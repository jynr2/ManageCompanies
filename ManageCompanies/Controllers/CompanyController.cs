using AutoMapper;
using ManageCompanies.Repository.Entities;
using ManageCompanies.Repository.Enums;
using ManageCompanies.Service.Contract;
using ManageCompanies.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ManageCompanies.Web.Controllers
{
    [ApiController]
    [Route("api/")]
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;

        public CompanyController(ICompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> AddCompany(CompanyModel company)
        {
            try
            {
                var result = await _companyService.AddCompany(_mapper.Map<Company>(company));
                if (result.Item1 == StatusCodeEnum.success) return Ok(company);
                else return BadRequest(result.Item1);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
