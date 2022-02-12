﻿using Fiap.Web.AspNet2.Data;
using Fiap.Web.AspNet2.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet2.Controllers
{
    public class LojaController: Controller
    {
        private readonly DataContext context;
        private readonly LojaRepository lojaRepository;
        public LojaController(DataContext dataContext)
        {
            context = dataContext;
            lojaRepository = new LojaRepository(context);
        }
        public IActionResult Index()
        {
            var l = lojaRepository.FindById(1);
            return View();
        }
    }
}