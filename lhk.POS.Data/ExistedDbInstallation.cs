using ExistingDatabaseConverter;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lhk.POS.Data
{
    public class ExistedDbInstallation
    {
        private DbFirstContext _context = new DbFirstContext();
        private IDbContext _destination;

        public ExistedDbInstallation(IDbContext cxt)
        {
            _destination = cxt;
        }

        public bool isConnectToExistedDB { get { return _context.Database.Exists(); } }

        public void MoveAllDb()
        {
            IEnumerable<Category> categories = _context.Categories.ToList();
            foreach (var item in categories)
            {
                var temp = item.ToDomainObject();
                var parent = _context.Categories.SingleOrDefault(i => i.id == item.fatherId);
                if (parent != null)
                {
                    temp.ParentId = _destination.Set<lhk.POS.Core.Domain.Category>().FirstOrDefault(i => i.Name == parent.name).Id;
                }
                _destination.Set<lhk.POS.Core.Domain.Category>().Add(temp);
                _destination.SaveChanges();
            }


            IEnumerable<Customer> cus = _context.Customers.ToList();
            foreach (var item in cus)
            {
                _destination.Set<lhk.POS.Core.Domain.Customer>().Add(item.ToDomainObject());
            }
            _destination.SaveChanges();


            IEnumerable<Manufacturer> manu = _context.Manufacturers.ToList();
            foreach (var item in manu)
            {
                _destination.Set<lhk.POS.Core.Domain.Manufacturer>().Add(item.ToDomainObject());
            }
            _destination.SaveChanges();

            IEnumerable<Unit> units = _context.Units.ToList();
            foreach (var item in units)
            {
                _destination.Set<lhk.POS.Core.Domain.Unit>().Add(item.ToDomainObject());
            }
            _destination.SaveChanges();

            IEnumerable<Product> products = _context.Products.ToList();
            foreach (var item in products)
            {
                var product = item.ToDomainObject();
                product.Unit = _destination.Set<lhk.POS.Core.Domain.Unit>().FirstOrDefault(i => i.Name == item.Unit1.name);
                product.Category = _destination.Set<lhk.POS.Core.Domain.Category>().FirstOrDefault(i => i.Name == item.Category1.name);
                product.Manufacturer = _destination.Set<lhk.POS.Core.Domain.Manufacturer>().FirstOrDefault(i => i.Name == item.Manufacturer1.name);
                product.Price = decimal.Parse(item.ProductPrices.FirstOrDefault(i => i.iscurrentprice).price.ToString());
                product.Cost = decimal.Parse(item.ProductPrices.FirstOrDefault(i => i.iscurrentprice).importprice.ToString());

                List<lhk.POS.Core.Domain.ProductPrice> prices = new List<lhk.POS.Core.Domain.ProductPrice>();
                item.ProductPrices.ToList().ForEach(i => prices.Add(i.ToDomainObject()));
                product.ProductPrices = prices;

                _destination.Set<lhk.POS.Core.Domain.Product>().Add(product);
                _destination.SaveChanges();
            }

            //IEnumerable<ProductPrice> prices = _context.ProductPrices.ToList();
            //foreach (var item in prices)
            //{
            //    var price = item.ToDomainObject();
            //    _destination.Set<lhk.POS.Core.Domain.ProductPrice>().Add();
            //}
            //_destination.SaveChanges();
        }
    }
}
