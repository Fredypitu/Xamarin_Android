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
using NotiXamarinCore.Data;
using NotiXamarinCore.Models;

namespace NotiXamarinCore.Services
{
    class NewsService
    {
        private NewsRepository iRepositorio;
        public NewsService()
        {
            this.iRepositorio = new NewsRepository();
        }

        public List<News> ObtenerTodasLasNoticias()
        {
            return this.iRepositorio.ObtenerTodasLasNoticias();
        }

        public News ObtenerUnaNoricia(int pId)
        {
            return this.iRepositorio.ObtenerUnaNoricia(pId);
        }
    }
}