using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dtos
{
    public class BookDetailsDto : BookDto
    {
        public String Description { get; set; }
        public String Author { get; set; }
        public String Publisher { get; set; }
    }
}
