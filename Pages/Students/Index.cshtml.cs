﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DockerUniversity.Data;
using DockerUniversity.Models;

namespace DockerUniversity.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly DockerUniversity.Data.SchoolContext _context;

        public IndexModel(DockerUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
