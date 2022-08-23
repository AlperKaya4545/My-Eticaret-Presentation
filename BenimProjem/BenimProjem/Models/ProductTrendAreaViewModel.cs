using BenimProjem.Entites;
using System.Collections.Generic;

namespace BenimProjem.Models
{
    // bu classla component içinde aynı anda 3 data gönderimi yapacağız( yan taraftakileri de burdan görürürüz sanırım)
    public class ProductTrendAreaViewModel : Product
    {
        public List<ProductImagesCustomModel> NewProducts { get; set; }
        public List<ProductImagesCustomModel> MostView { get; set; }

        // BestSeller Ekle
    }
}
