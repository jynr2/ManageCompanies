#nullable disable

namespace ManageCompanies.Repository.Entities
{
    public partial class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyTown { get; set; }
        public string CompanyPhone { get; set; }
        public int CompanyIdentificationId { get; set; }
        public string CompanyEmail { get; set; }
        public long CompanyIdentificationNumbre { get; set; }

        public virtual IdentificationType CompanyIdentification { get; set; }
    }
}
