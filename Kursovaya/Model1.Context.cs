﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Складской_учет_одеждыModel : DbContext
    {
        public Складской_учет_одеждыModel()
            : base("name=Складской_учет_одеждыEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<администратор> администратор { get; set; }
        public virtual DbSet<адрес> адрес { get; set; }
        public virtual DbSet<аунтификация_администратора> аунтификация_администратора { get; set; }
        public virtual DbSet<аунтификация_сотрудника> аунтификация_сотрудника { get; set; }
        public virtual DbSet<инвентаризация_склада> инвентаризация_склада { get; set; }
        public virtual DbSet<категория_товара> категория_товара { get; set; }
        public virtual DbSet<пол> пол { get; set; }
        public virtual DbSet<поставщики> поставщики { get; set; }
        public virtual DbSet<приемка_товара> приемка_товара { get; set; }
        public virtual DbSet<размеры> размеры { get; set; }
        public virtual DbSet<склад> склад { get; set; }
        public virtual DbSet<сотрудник> сотрудник { get; set; }
        public virtual DbSet<статус_качества_товара> статус_качества_товара { get; set; }
        public virtual DbSet<товары> товары { get; set; }
        public virtual DbSet<товары_на_складе> товары_на_складе { get; set; }
        public virtual DbSet<цвет> цвет { get; set; }
    }
}
