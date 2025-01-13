using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Location { get; set; }
        public DateTime Date { get; set; }
        public string? BuildingType { get; set; }
        public string? ParcelArea { get; set; }
        public string? BuildingArea { get; set; }
        public bool IsDone { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public List<ProjectImage> Images { get; set; }

    }
}
