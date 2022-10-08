using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jgboard.Models
{
    public class BoardDTO
    {
        [Request]
        int seq { set; get; }

        string x_title { set; get; }

        string x_contents { set; get; }

        int x_date { set; get; }






    }
}