//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Adverts
    {
        public long Id { get; set; }
        public int Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime Created { get; set; }
        public System.Guid CreatedUserId { get; set; }
        public double Price { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int MessageType { get; set; }
        public System.Data.Entity.Spatial.DbGeography Position { get; set; }
        public string ImgUrls { get; set; }
        public string YouTubeUrl { get; set; }
        public bool IsApproved { get; set; }
        public Nullable<System.DateTime> WhenAdminApproved { get; set; }
    }
}
