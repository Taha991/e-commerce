using Core.Entities;

namespace MemoApi.Dtos
{
    public class MenProductToReturnDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public string MenProductType { get; set; }
        public string MenProductBrand { get; set; }
    }
}
