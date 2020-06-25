using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.Courses
{
    public class CreateModel : DepartmentNamePageModel
    {
        private readonly ContosoUniversity.Models.SchoolContext _context;

        public CreateModel(ContosoUniversity.Models.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            //  ViewData["DepartmentID"] = new SelectList(_context.Departments, "DepartmentID", "DepartmentID");
           PopulateDepartmentDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public Course Course { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            // if (!ModelState.IsValid)
            // {
            //     return Page();
            // }

            // _context.Course.Add(Course);
            // await _context.SaveChangesAsync();

            // return RedirectToPage("./Index");
            var emptyCourse= new Course();
            if(await TryUpdateModelAsync<Course>(
                emptyCourse,"course",
                s => s.CourseID, s => s.DepartmentID,s => s.Title, s => s.Credits
            )){
                _context.Course.Add(emptyCourse);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            PopulateDepartmentDropDownList(_context, emptyCourse.DepartmentID);
            return Page();
        }
    }
}
