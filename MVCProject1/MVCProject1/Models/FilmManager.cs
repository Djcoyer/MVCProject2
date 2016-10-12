using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject1.Models
{
    public class FilmManager
    {
        public static List<Film> GetFilms()
        {
            var films = new List<Film>();
            var db = new FilmsEntities1();

            foreach (var film in db.Films)
            {
                var _film = new Film();
                _film.Details = film.Details;
                _film.FilmId = film.FilmId;
                _film.Genre = film.Genre;
                _film.Name = film.Name;
                _film.NumberofSeries = film.NumberofSeries;
                _film.Year = film.Year;
                films.Add(_film);
                _film.Series = film.Series;
                _film.Available = film.Available;
            }

            return films;
        }

     /*   public static void saveFilms(List<Film> films)
        {
            var db = new FilmsEntities();
            foreach (var film in films)
            {
                var entityFilm = new Film();
                entityFilm.FilmId = film.FilmId;
                entityFilm.Genre = film.Genre;
                entityFilm.Name = film.Name;
                entityFilm.Series = film.Series;
                entityFilm.Year = film.Year;
                entityFilm.Details = film.Details;
                db.Films.Add(entityFilm);
            }
            db.SaveChanges();

        }
        */
    }
}



/*     List<Film> films = new List<Film>()
        {
            new Film {Genre="Action", NumberofSeries=1, Series="The Lord of the Rings", Name="The Fellowship of the Ring", FilmId=1, Year = 2001,
                Details = "Set in Middle-earth, the story tells of the Dark Lord Sauron (Sala Baker), who is seeking the One Ring. The Ring has found its way to the young hobbit Frodo Baggins (Elijah Wood). " + 
                "The fate of Middle-earth hangs in the balance as Frodo and eight companions who form the Fellowship of the Ring begin their journey to Mount Doom in the land of Mordor, the only place where the Ring can be destroyed."},

                new Film {Genre="Comedy", NumberofSeries=1, Series="The Rush Hour Trilogy", Name="Rush Hour", FilmId=2, Year = 1998,
                    Details = "Rush Hour is a 1998 Chinese-American buddy action comedy film directed by Brett Ratner. It stars Jackie Chan and Chris Tucker as mismatched cops who must rescue the Chinese Consul's kidnapped daughter."},

                new Film {Genre="Action", NumberofSeries=1, Series="Captain America", Name="The First Avenger", FilmId=3, Year = 2011,
                    Details = "Set predominantly during World War II, Captain America: The First Avenger tells the story of Steve Rogers, a sickly man from Brooklyn who is transformed into super-soldier Captain America and must stop the Red Skull, "+
                    "who intends to use an artifact called the \"Tesseract\" as an energy-source for world domination."},

                new Film {Genre="Action", NumberofSeries=2, Series="The Lord of the Rings", Name="The Two Towers", FilmId=4, Year = 2002,
                    Details="Continuing the plot of The Fellowship of the Ring, the film intercuts three storylines. Frodo and Sam continue their journey towards " + 
                    "Mordor to destroy the One Ring, meeting and joined by Gollum, the ring's former owner. Aragorn, Legolas, and Gimli come to the war-torn nation of " + 
                    "Rohan and are reunited with the resurrected Gandalf, before fighting at the Battle of Helm's Deep. Merry and Pippin escape capture, meet Treebeard the Ent, and help to plan an attack on Isengard."},

                new Film {Genre="Comedy", NumberofSeries=2, Series="The Rush Hour Trilogy", Name="Rush Hour 2", FilmId=5, Year = 2004,
                Details="Rush Hour 2 is a 2001 Chinese-American martial arts buddy action comedy film. It is the sequel to the 1998 film Rush Hour and the second installment in the Rush Hour film series. " + 
                "The film stars Jackie Chan and Chris Tucker who respectively reprise their roles as Inspector Lee and Detective Carter. The film finds Lee and Carter embroiled in a counterfeit scam involving the Triads."},

                new Film {Genre="Action", NumberofSeries=2, Series="Captain America", Name="The Winter Soldier", FilmId=6, Year = 2014,
                    Details="In Captain America: The Winter Soldier, Captain America, Black Widow, and Falcon join forces to uncover a conspiracy within S.H.I.E.L.D. while facing a mysterious assassin known as the Winter Soldier." },

                new Film {Genre="Action", NumberofSeries=3, Series="The Lord of the Rings", Name="The Return of the King", FilmId=7, Year = 2003,
                Details="Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."},

                new Film {Genre="Comedy", NumberofSeries=3, Series="The Rush Hour Trilogy", Name="Rush Hour 3", FilmId=8, Year = 2007,
                Details="After an attempted assassination on Ambassador Han, Lee and Carter head to Paris to protect a French woman with knowledge of the Triads' secret leaders."},

                new Film {Genre="Action", NumberofSeries=3, Series="Captain America", Name="Civil War", FilmId=9, Year = 2016,
                Details="olitical interference in the Avengers' activities causes a rift between former allies Captain America and Iron Man."}
        };
            return films;
            */
