using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            // 'using' kullanilmasinin amaci blok bittigi anda nesneyi bellekten atmaya zorlar. Bunu istememizin nedeni ETradeContext bellek 
            // icin bir yuktur. using kullanilmasa bile eninde sonunda cop toplayici onu atacaktir ancak biz hemen atilmasini istiyoruz.
            using (ETradeContext context = new ETradeContext())
            {
                // Entity Frameworkde veri tabani kayitlarina ulasmak bu kadar kisa ve kolay
                return context.Products.ToList();
            }
        }
        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                // isime gore sorgu gonderdik
                return context.Products.Where(p => p.Name.Contains(key)).ToList();
            }
        }
        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                // FirstOrDefault : eselesen ilk kaydi getir. Yoksa Default(null) gonder.
                // SingleOrDefault : Birden fazla kayit gelme durumlarinda hata veriri.
                var result = context.Products.FirstOrDefault(p => p.Id == id);
                return result;
            }
        }
        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                // bu fiyatin altindakileri listelettik *sorgu
                return context.Products.Where(p => p.UnitPrice >= price).ToList();
            }
        }
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                // Bu fiyat araligindaki urunleri getir *sorgu
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();
            }
        }
        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                context.Products.Add(product); // veritabanina ekle
                /*
                  var entity = context.Entry(product);                                   
                  entity.State = EntityState.Added;
                 */

                context.SaveChanges(); // degisiklikleri kaydet
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product); // contexte bu product uzerinden abone ol.
                                                     // Yani gonderilen product'i veritabanindaki product ile esitliyor
                entity.State = EntityState.Modified;
                context.SaveChanges(); // degisiklikleri kaydet
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product); // contexte bu product uzerinden abone ol.
                                                     // Yani gonderilen product'i veritabanindaki product ile esitliyor
                entity.State = EntityState.Deleted; // silinecek
                context.SaveChanges(); // degisiklikleri kaydet
            }
        }
    }
}
