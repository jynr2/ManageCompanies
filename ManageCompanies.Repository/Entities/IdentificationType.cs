using System.Collections.Generic;

#nullable disable

namespace ManageCompanies.Repository.Entities
{
    public partial class IdentificationType
    {
        public IdentificationType()
        {
            Companies = new HashSet<Company>();
        }

        public int Id { get; set; }
        public string IdentificationTypeName { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
