using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Church_Solution_API.Models
{
    [Table("Family")]
    public class FamilyModel
    {
        [Key]
        public string FamilyCode { get; set; }
        [StringLength(200)]
        public string FamilyName { get; set; }
        public DateTime JointDate { get; set; }
        public string PhotoPath { get; set; }
        public bool Single { get; set; }
        public bool isActive { get; set; }
        public DateTime CreatedDate { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [NotMapped]
        public FamilyMemberModel ListFamilyMemberModel { get; set; }
    }

    [Table("FamilyMember")]
    public class FamilyMemberModel
    {
        [Key]
        public string MemberCode { get; set; }
        [StringLength(50)]
        public string FamilyCode { get; set; }
        [StringLength(50)]
        public string FullName { get; set; }
        [StringLength(20)]
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        [StringLength(100)]
        public string PlaceofBirth { get; set; }
        [StringLength(20)]
        public string Etnic { get; set; }
        [StringLength(20)]
        public string FamilyStatus { get; set; }
        public bool PKBMember { get; set; }
        public bool PWMember { get; set; }
        public bool PemudaMember { get; set; }
        public bool RemajaMember { get; set; }
        public bool SekolahMingguMember { get; set; }
        public bool HasPassesAway { get; set; }
        public string PhotoPath { get; set; }
        public DateTime CreatedDate { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public bool isActive { get; set; }
    }

    [Table("MajelisType")]
    public class MajelisTypeModel
    {
        [Key]
        public string MajelisTypeCode { get; set; }
        [StringLength(100)]
        public string MajelisTypeName { get; set; }
        public bool isActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }

    [Table("MajelisPeriod")]
    public class MajelisPeriodModel
    {
        [Key]
        public string MajelisPeriodCode { get; set; }
        [StringLength(100)]
        public string MajelisPeriodName { get; set; }
        public int StartMonthPeriod { get; set; }
        public int StartYearPeriod { get; set; }
        public int EndMonthPeriod { get; set; }
        public int EndYearPeriod { get; set; }
        public bool isActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }

    [Table("Majelis")]
    public class MajelisModel
    {
        [Key]
        public string MajelisCode { get; set; }
        [StringLength(50)]
        public string MajelisTypeCode { get; set; }
        [StringLength(50)]
        public string MajelisPeriodCode { get; set; }
        public string PhotoPath { get; set; }
        [StringLength(50)]
        public string MemberCode { get; set; }
        public bool isActive { get; set; }
        public DateTime CreatedDate { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
    }
}
