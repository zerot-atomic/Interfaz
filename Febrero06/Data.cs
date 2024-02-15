using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Febrero06
{
  public class Data
  {
    public static int Count { get; set; }

    private static List<Movie> Movies = new List<Movie>();

    public static void Add_Movie(Movie newmovie)
    {  
      Movies.Add(newmovie); 
    }
    public static List<Movie> Get_Movies() 
    { 
      return Movies;
    
    }
    public static void Delete(int index)
    {
        Movies.RemoveAt(index);
    }
    public static void Update(Movie peliculaAnterior, Movie peliculaActualizada) 
    {
            Movies.Remove(peliculaAnterior);
            Movies.Add(peliculaActualizada);
    }
  }
}
