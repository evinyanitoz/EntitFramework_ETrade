using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EntitFramework_ETrade
{
    public class ProductDal
    {
        public List<Product> GetAll() {


            using (ETradeContext context=new ETradeContext()) {

                return context.Products.ToList();
            
            }
           
        
        
        }
        public void Add(Product product)
        {
            using (ETradeContext context=new ETradeContext()) {


                context.Products.Add(product);
                context.SaveChanges();
            }
        
        
        }


        public void Update(Product product)
        {
            using (ETradeContext context=new ETradeContext()) {

                var entity = context.Entry(product);
                //Contexte abone ol kim için product için.
                //BU şu demek aslında veritabanındaki productla bu producta eşitle.

                entity.State = EntityState.Modified;
                //Varlığı ayarladığınızda. State = EntityState.Modified değiştirildi ,
                //entity varlığı değiştirildi olarak işaretler, bu nedenle SaveChanges()
                //öğesini çağırdığınızda,
                //veritabanındaki bu varlığı yeni değerleriyle güncellemeyi bilir.

                context.SaveChanges();  

            }


        }

        public void Delete(Product product) {

            using (ETradeContext context = new ETradeContext())
            { 
            
               var entity=context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            
            }
        
        
        
        
        }
    }
}
