using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jgboard.Models;

namespace jgboard.Controllers
{
    public class BoardController : Controller
    {

        public List<BoardDTO> dr= new List<BoardDTO>();


        public ActionResult BoardList()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;port=3306;Database=project;Uid=root;pwd=134078;SslMode=none;"))
                try
                {

                    connection.Open();
                    string sql = "select * from board_x";

                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader rs = cmd.ExecuteReader();

                    while (rs.Read())
                    {
                        dr.Add(new BoardDTO
                        {
                            
                            Title = rs["x_title"].ToString()


                        });

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());

                }



                return View();
        }
    }
}