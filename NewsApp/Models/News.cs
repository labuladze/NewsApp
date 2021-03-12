using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }

        public string Url { get; set; }

        public string Header { get; set; }

        public string Desctiption { get; set; }

        public string Mobile { get; set; }
    }
}
