//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kursovaya
{
    using System;
    using System.Collections.Generic;
    
    public partial class статус_качества_товара
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public статус_качества_товара()
        {
            this.приемка_товара = new HashSet<приемка_товара>();
        }
    
        public int ID_статуса_качества_товара { get; set; }
        public string наименование_статуса { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<приемка_товара> приемка_товара { get; set; }
    }
}
