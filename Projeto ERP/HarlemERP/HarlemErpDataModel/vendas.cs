//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HarlemErpDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class vendas
    {
        public vendas()
        {
            this.vendasproduto = new HashSet<vendasproduto>();
        }
    
        public int id { get; set; }
        public int cliente { get; set; }
        public double valor { get; set; }
        public Nullable<double> desconto { get; set; }
        public double valorpago { get; set; }
        public System.DateTime datacompra { get; set; }
        public int usuariovenda { get; set; }
    
        public virtual clientes clientes { get; set; }
        public virtual usuarios usuarios { get; set; }
        public virtual ICollection<vendasproduto> vendasproduto { get; set; }
    }
}