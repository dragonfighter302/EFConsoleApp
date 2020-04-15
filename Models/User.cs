using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp.Models
{
    class User
    {
        public int Id{ get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string LastName { get; set; }

    }
}
