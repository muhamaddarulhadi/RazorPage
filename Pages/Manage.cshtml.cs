using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.EntityFrameworkCore;
using RazorPage.Data;
using RazorPage.Models;

namespace RazorPage.Pages
{
    public class ManageModel : PageModel
    {
        private readonly DefaultConnection _context;
        DateTime now = DateTime.Now;                        //GET NOW DATE AND TIME

        public ManageModel(DefaultConnection context)
        {
           _context = context;
        }

        [BindProperty]
        public Table_Razor_Page manage { get; set;}

        public Table_Razor_Page update { get; set;}

        public bool IsNull { get; set; }                    //SET ENTITY FOR PARAMATER IsNull

        public ActionResult OnGetInsert()
        {
            IsNull = true;                                  //SET PARAMATER IsNull TO true, IF TRUE, PAGE WILL DISPLAY INSERT INTERFACE
            manage = new Table_Razor_Page();

            return Page();
        }

        public async Task<ActionResult> OnGetUpdate(int? id)
        {
            if(id==null || id==0)
            {
                return RedirectToPage("Index");                 //LOAD OTHER PAGE
            }
            else if(id!=null && id!=0)
            {
                IsNull = false;                                                                 //SET PARAMATER IsNull TO false, IF FALSE, PAGE WILL DISPLAY UPDATE INTERFACE
                manage = await _context.Table_Razor_Page.FirstOrDefaultAsync(x=>x.ID==id);
            }

            return Page();
        }

        public async Task<ActionResult> OnPostInsert()
        {
            manage.dateTimeInsert = now;                            //INSERT NOW DATE INTO ENTITY VARIABLE AND TIME THAT WE ALREADY DECLARE ABOVE
            manage.dateTimeUpdate = now;

            await _context.Table_Razor_Page.AddAsync(manage);       //ADD NEW ROW ON TABLE INSIDE DATABASE
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }

        public async Task<ActionResult> OnPostUpdate()
        {
            update = await _context.Table_Razor_Page.FirstOrDefaultAsync(x=>x.ID==manage.ID);       //FIND ROW BY CERTAIN id
            update.Name=manage.Name;                                                                //UPDATE NEW VALUE ON FIELD BY ID THAT WE GOT 
            update.dateOfBirth=manage.dateOfBirth;
            update.dateTimeUpdate = now; 

            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
