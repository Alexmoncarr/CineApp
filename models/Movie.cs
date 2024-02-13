using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp;
public class Movie
{
    public string Title
    {
        get; set;
    }
    public string ImagePath
    {
        get; set;
    }
    public string Description
    {
        get; set;
    }
    public string TrailerUrl
    {
        get; set;
    }

    public Movie(string title, string imagePath, string description, string trailerUrl)
    {
        Title = title;
        ImagePath = imagePath;
        Description = description;
        TrailerUrl = trailerUrl;
    }
}

