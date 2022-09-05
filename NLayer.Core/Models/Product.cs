namespace NLayer.Core.Models
{
    public class Product : BaseEntity
    {
        //Mümkün oldukça custom isim vermeden kaçın
        //public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        //Navigation Properties
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
        // public ProductFeature? ProductFeature { get; set; }
        //.Net6 ile gelmiş soru işareti koyuyoruz referans tiplerde class srting vs.

    }
}
