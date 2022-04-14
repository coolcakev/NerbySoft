﻿using Microsoft.EntityFrameworkCore;
using nedrysoft_TestTask.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nedrysoft_TestTask
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        public DbSet<Announcement> Announcements  { get; set; }

    }
}
