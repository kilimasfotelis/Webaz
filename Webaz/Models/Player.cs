using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Webaz.Models
{
    [Table("Highscore")]
    public class Player
    {
        [Key]
        public int Nickname { get; set; }
        public int Score { get; set; }
    }
}