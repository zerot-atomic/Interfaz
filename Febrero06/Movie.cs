using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace Febrero06
{
  public class Movie
  {
        private PictureBox picture;

        public string Name { get; set; }
    public string Description { get; set; }
    public int Year { get; set; }
    public Image Picture { get; set; }
    public int Rating { get; set; }
    public string Category { get; set; }

    public Movie(string name, string description, int year, String picture, int rating, string category)
    {
        this.Name = name;
        this.Description = description;
        this.Year = year;
        this.Picture = Image.FromFile(picture);
        this.Rating = rating;
        this.Category = category;
    }

        public Movie(string name, string description, int year, PictureBox picture, int rating, string category)
        {
            Name = name;
            Description = description;
            Year = year;
            this.picture = picture;
            Rating = rating;
            Category = category;
        }

        public override string ToString()
    {
      return this.Name;
    }
  }
  
}
