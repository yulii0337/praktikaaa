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
    
    public partial class товары_на_складе
    {
        public int ID_товары_на_складе { get; set; }
        public int ID_склада { get; set; }
        public int ID_товара { get; set; }
    
        public virtual склад склад { get; set; }
        public virtual товары товары { get; set; }
    }
}
