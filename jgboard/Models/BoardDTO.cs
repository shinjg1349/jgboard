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
      public  int SEQ { set; get; }
      [Required]
      public string Title { set; get; }

        string ContestS { set; get; }

        int Date { set; get; }


    }
}