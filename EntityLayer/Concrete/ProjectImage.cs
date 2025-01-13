using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProjectImage
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string? Source { get; set; }
        public bool IsThumbnailImage { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public Project Project { get; set; }
    }
}
