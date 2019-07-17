using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    [Bind(Exclude = "SongId")]
    public class Song
    {
        [Key]
        [ScaffoldColumn(false)]
        public int SongId { get; set; }

        public string Name { get; set; }
        public string Artist { get; set; }

        public Album Album { get; set; }
        public int AlbumId { get; set; }
    }
}