﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


#nullable disable

namespace E_commerce.Models
{
    [Table("Users")]
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            ImagesUsers = new HashSet<ImagesUser>();
            InverseUsers = new HashSet<User>();
            RolesUsers = new HashSet<RolesUser>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "الاسم مطلوب")]
        [StringLength(50, ErrorMessage = "الاسم لا يزيد عن 50 حرف")]
        [DisplayName("الاسم")]
        [Column(TypeName = "nvarchar(max)")]
        public string Name { get; set; }
        [Required(ErrorMessage = "العنوان مطلوب")]
        [StringLength(50, ErrorMessage = "العنوان لا يزيد عن 50 حرف")]
        [Display(Name = "العنوان")]
        [Column(TypeName = "nvarchar(max)")]        
        public string Address { get; set; }
        [Display(Name = "كلمة المرور")]
        [Column(TypeName = "nvarchar(max)")]
        public string Password { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? CreatedAt { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? UpdatedAt { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DeletedAt { get; set; }
 
        public int UserStatusId { get; set; }
        public int PhoneId { get; set; }
        public int? PlaceId { get; set; }
        [Display(Name = "المستخدم الاعلى")]
        [Column(TypeName = "int")]
        public int? UsersId { get; set; }   
        public virtual Phone Phone { get; set; }
        public virtual Place Place { get; set; }
        public virtual UserStatus UserStatus { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual User Users { get; set; }
        public virtual AuctionsUser AuctionsUser { get; set; }
        public virtual Purchase Purchase { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Comment> Comments { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<ImagesUser> ImagesUsers { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<User> InverseUsers { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<RolesUser> RolesUsers { get; set; }
  

    }
}
