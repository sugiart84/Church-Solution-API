using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Church_Solution_API.Models
{
    [Table("MenuDesign")]
    public class MenuDesign
    {
        [Key]
        public string MenuDesignId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool MasterDesign { get; set; }
        public bool FromClone { get; set; }
        public bool isActive { get; set; }
    }

    [Table("MenuDesignDetail")]
    public class MenuDesignDetail
    {
        [Key]
        public int MenuDesignDetailId { get; set; }
        [StringLength(50)]
        public string MenuDesignId { get; set; }
        [StringLength(50)]
        public string MenuId { get; set; }
    }

    [Table("MenuPattern")]
    public class MenuPattern
    {
        [Key]
        public string MenuId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
        public int? ParentId { get; set; }
        [StringLength(50)]
        public string PageId { get; set; }
        public bool isParent { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool isMaster { get; set; }
        public bool isActive { get; set; }
    }

    [Table("MenuUserAssigment")]
    public class MenuUserAssigment
    {
        [Key]
        public string MenuRoleAssigmentId { get; set; }

        [StringLength(50)]
        public string MenuDesignId { get; set; }
        [StringLength(50)]
        public string UserId { get; set; }
    }

    //[Table("MenuDesignChild")]
    //public class MenuDesignChild
    //{
    //    [Key]
    //    public string MenuChildId { get; set; }
    //    [StringLength(50)]
    //    public string MenuParentId { get; set; }

    //    [StringLength(100)]
    //    public string Name { get; set; }
    //    [StringLength(200)]
    //    public string PageUrl { get; set; }
    //    [StringLength(50)]
    //    public string CreatedBy { get; set; }
    //    public DateTime CreatedDate { get; set; }
    //    public bool isActive { get; set; }
    //}

    [Table("PermissionNamespace")]
    public class PermissionNamespace
    {
        [Key]
        public string PermissionNamespaceId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool isActive { get; set; }
    }

    [Table("PermissionAction")]
    public class PermissionAction
    {
        [Key]
        public string PermissionActionId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool isActive { get; set; }
    }

    [Table("PermissionRoleAssigment")]
    public class PermissionRoleAssigment
    {
        [Key]
        public string PermissionRoleAssigmentId { get; set; }
        public string PermissionNamespaceId { get; set; }
        public string PermissionActionId { get; set; }
        public string RoleId { get; set; }
    }

    [Table("PermissionUserAssigment")]
    public class PermissionUserAssigment
    {
        [Key]
        public string PermissionUserAssigmentId { get; set; }
        public string PermissionNamespaceId { get; set; }
        public string PermissionActionId { get; set; }
        public string UserId { get; set; }
    }
}
