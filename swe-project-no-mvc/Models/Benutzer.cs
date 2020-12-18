using System;
namespace swe_project_no_mvc.Models
{
    public class Benutzer
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachanme { get; set; }
        public string Email { get; set; }
        public bool Positiv { get; set; }
        public DateTime PositivAblauf { get; set; }

        public Benutzer()
        {
        }

        public Benutzer(int id, string vorname, string nachanme, string email, bool positiv, DateTime positivAblauf)
        {
            Id = id;
            Vorname = vorname;
            Nachanme = nachanme;
            Email = email;
            Positiv = positiv;
            PositivAblauf = positivAblauf;
        }
    }
}
