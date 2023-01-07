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
      [Required]
      public string Contents { set; get; }
      [Required]
      public string Date { set; get; }

    }
}