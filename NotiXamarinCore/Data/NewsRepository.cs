using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using NotiXamarinCore.Models;

namespace NotiXamarinCore.Data
{
    public class NewsRepository
    {
        private List<News> iNews;
        public NewsRepository()
        {
            this.iNews = new List<News>
            {
                new News()
                {
                    Id=1,
                    Title="Boca Juniors",
                    Body="Es considerado el equipo mas grande del mundo",
                    ImageName="Bombonera"

                },
                new News()
                {
                    Id=2,
                    Title="Coronavirus",
                    Body="Sigue el distanciamiento social hasta el 20/12/2020",
                    ImageName="imagen Coronavirus"
                },
                new News()
                {
                    Id=3,
                    Title="NAVIDAD",
                    Body="Falta tan solo un mes para la navidad",
                    ImageName="Papa Noel"
                },
            };
        }
        public List<News> ObtenerTodasLasNoticias() 
        {
            return this.iNews;
        }

        public News ObtenerUnaNoricia(int pId)
        {
            // return this.iNews.Where(x => x.Id == pId).First();
            return this.iNews.FirstOrDefault(x => x.Id == pId);
        }
    }
}