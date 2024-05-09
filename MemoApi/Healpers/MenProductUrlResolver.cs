using AutoMapper;
using Core.Entities;
using MemoApi.Dtos;

namespace MemoApi.Healpers
{
    public class MenProductUrlResolver : IValueResolver<MenProducts, MenProductToReturnDto, string>
    {
        private readonly IConfiguration _config;
        public MenProductUrlResolver(IConfiguration config)
        {
            _config = config;
        }
        public string Resolve(MenProducts source, MenProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _config["ApiUrl"] + source.PictureUrl;
            }
            return null;
        }

        //
    }
}
