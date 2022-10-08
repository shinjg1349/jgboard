using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jgboard.Models
{
    public class BoardDTO
    {
        [key]
        int SEQ { set; get; }
        [Required]
        string Title { set; get; }

        string ContestS { set; get; }

        int Date { set; get; }


    }
}