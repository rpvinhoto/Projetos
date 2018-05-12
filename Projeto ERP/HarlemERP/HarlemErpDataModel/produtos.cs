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
    
    public partial class produtos
    {
        public produtos()
        {
            this.estoque = new HashSet<estoque>();
            this.precos = new HashSet<precos>();
            this.vendasproduto = new HashSet<vendasproduto>();
        }
    
        public int id { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public int marca { get; set; }
        public int categoria { get; set; }
        public Nullable<System.DateTime> datacadastro { get; set; }
        public int usuariocadastro { get; set; }
    
        public virtual ICollection<estoque> estoque { get; set; }
        public virtual marcas marcas { get; set; }
        public virtual ICollection<precos> precos { get; set; }
        public virtual produtoscategoria produtoscategoria { get; set; }
        public virtual usuarios usuarios { get; set; }
        public virtual ICollection<vendasproduto> vendasproduto { get; set; }
    }
}
