﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Models
{
    public class MovieCreateRequestModel
    {
        public int Id { get; set; }
        [Column("Title")]
        [Required(ErrorMessage = "Movie Title is required")]
        public string Title { get; set; }
        public string Overview { get; set; }
        [Required(ErrorMessage = "Overview is required")]
        public string Tagline { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? Budget { get; set; }
        public string ImdbUrl { get; set; }
        public string TmdbUrl { get; set; }
        public string PosterUrl { get; set; }
        public string BackdropUrl { get; set; }
        public string OriginalLanguage { get; set; }
        public DateTime? ReleaseDate { get; set; } = DateTime.Now;
        public int? RunTime { get; set; }
        public decimal? Price { get; set; }
        public List<GenreModel> Genres { get; set; }


    }
}
