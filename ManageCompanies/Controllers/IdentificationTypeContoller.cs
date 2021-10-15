using AutoMapper;
using ManageCompanies.Service.Contract;
using ManageCompanies.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageCompanies.Web.Controllers
{
    [ApiController]
    [Route("api/")]
    public class IdentificationTypeContoller : Controller
    {
        private readonly IIdentificationTypeService _identificationTypeService;
        private readonly IMapper _mapper;

        public IdentificationTypeContoller(IIdentificationTypeService identificationTypeService, IMapper mapper)
        {
            _identificationTypeService = identificationTypeService;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetIdentificationType()
        {
            try
            {
                var response = await _identificationTypeService.GetAll();
                var identificationType = _mapper.Map<List<IdentificationTypeModel>>(response);

                if (identificationType.Count == 0 || identificationType == null)
                    return NotFound("No hay resgistros");
                else
                    return Ok(identificationType);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError); ;
            }
        }
    }
}
