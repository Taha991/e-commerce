using AutoMapper;
using Core.Entities;
using infrastrucure.Interfaces;
using infrastrucure.Spacification;
using MemoApi.Dtos;
using MemoApi.Healpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensController : BaseApiController
    {
        private readonly IGenericRepository<MenProductBrand> _menBrandRepo;
        private readonly IGenericRepository<MenProductType> _menTypeRepo;
        private readonly IGenericRepository<MenProducts> _menProductRepo;
        private readonly IMapper _mapper;

        public MensController(IGenericRepository<MenProductType> menTypeRepo, IGenericRepository<MenProducts> menProductRepo, IGenericRepository<MenProductBrand> menBrandRepo, IMapper mapper)
        {
            _menTypeRepo = menTypeRepo;

            _menProductRepo = menProductRepo;

            _menBrandRepo = menBrandRepo;

            _mapper = mapper;
        }

        [HttpGet]
         
        public async Task<ActionResult<Pagination<MenProductToReturnDto>>> GetMenProducts([FromQuery]MenProductSpecPrams menProductparams)
        {
            var spec = new MenProductWithTypesAndBrandsSpacification(menProductparams);
            var countSpec = new MenProductWithFilterForCountSpec(menProductparams);
            var totalItems = await _menProductRepo.CountAsync(countSpec);
            var products = await _menProductRepo.ListAsync(spec);
            var data = _mapper.Map<IReadOnlyList<MenProducts>, IReadOnlyList<MenProductToReturnDto>>(products);


            return Ok( new Pagination<MenProductToReturnDto>(menProductparams.PageIndex , menProductparams.PageSize , totalItems , data ));
        }

        [HttpGet("all")]
        public async Task<ActionResult<Pagination<MenProductToReturnDto>>> GetAllMenProducts()
        {
            var products = await _menProductRepo.GetAllAsync();
            var totalItems = products.Count;
            var data = _mapper.Map<IReadOnlyList<MenProducts>, IReadOnlyList<MenProductToReturnDto>>(products);

            return Ok(new Pagination<MenProductToReturnDto>(1, totalItems, totalItems, data));
        }



        [HttpGet("{id}")]

        public async Task<ActionResult<MenProductToReturnDto>> GetMenProduct(int id)
        {
            var spec = new MenProductWithTypesAndBrandsSpacification(id);

            var product = await _menProductRepo.GetEntityWithSpacification(spec);

            return _mapper.Map<MenProducts , MenProductToReturnDto> (product);
        }

        [HttpGet("menTypes")]

        public async Task <ActionResult<IReadOnlyList<MenProductType>>> GetMenType()
        {
            return Ok(await _menTypeRepo.GetAllAsync());
        }
        [HttpGet("menBrands")]

        public async Task<ActionResult<IReadOnlyList<MenProductType>>> GetMenBrand()
        {
            return Ok(await _menBrandRepo.GetAllAsync());
        }
    }
}
