//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Cart = new HashSet<Cart>();
            this.OrderDetail = new HashSet<OrderDetail>();
            this.ProductImage = new HashSet<ProductImage>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> TypeId { get; set; }
        public Nullable<decimal> OldPrice { get; set; }
        public Nullable<decimal> NewPrice { get; set; }
        public Nullable<int> ProductColorId { get; set; }
        public Nullable<int> ProductSizeId { get; set; }
        public Nullable<int> Sales { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<bool> OnSale { get; set; }
        public string Detail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Cart { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual ProductColor ProductColor { get; set; }
        public virtual ProductSize ProductSize { get; set; }
        public virtual ProductType ProductType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductImage> ProductImage { get; set; }
    }
}
