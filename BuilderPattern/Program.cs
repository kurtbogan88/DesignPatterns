using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var vr = new ProductBuilderDirector(new NewCustomerProcduct());
            var md = vr.CreateWithDiscount();
            var me = vr.CreateWithoutDiscount();

        }




    }

    class ProcuctModelView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int DiscountPriced { get; set; }
        public bool DiscountApply { get; set; }
    }

    abstract class ProductBuilder
    {
        public abstract void GenerateProduct();
        public abstract void AppliyPrice();
        public abstract ProcuctModelView GetProcuct();


    }

    class NewCustomerProcduct : ProductBuilder
    {
        ProcuctModelView vm = new ProcuctModelView();
        public override void AppliyPrice()
        {
            vm.DiscountApply = true;
            vm.DiscountPriced = 10;
        }

        public override void GenerateProduct()
        {
            vm.Id = 1;
            vm.Name = "Laptop";
            vm.Price = 50;
        }

        public override ProcuctModelView GetProcuct()
        {
            return vm;
        }
    }

    class OldCustomerProduct : ProductBuilder
    {
        ProcuctModelView vm = new ProcuctModelView();
        public override void AppliyPrice()
        {
            throw new NotImplementedException();
        }

        public override void GenerateProduct()
        {
            vm.Name = "Fare";
            vm.Price = 10;
        }

        public override ProcuctModelView GetProcuct()
        {
            return vm;
        }
    }

    class ProductBuilderDirector
    {
        ProductBuilder productBuilder;
        public ProductBuilderDirector(ProductBuilder productBuilder)
        {
            this.productBuilder = productBuilder;
        }
        public ProcuctModelView CreateWithDiscount()
        {
            productBuilder.GenerateProduct();
            productBuilder.AppliyPrice();
            return productBuilder.GetProcuct();
        }

        public ProcuctModelView CreateWithoutDiscount()
        {
            productBuilder.GenerateProduct();
            return productBuilder.GetProcuct();
        }
    }
}


