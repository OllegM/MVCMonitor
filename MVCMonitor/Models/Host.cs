using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCMonitor.Models
{
    public class Host
    {
        public int HostId { get; set; }
        [Required()]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required()]
        [DataType(DataType.Text)]
        public string IPAddress { get; set; }
    }
}