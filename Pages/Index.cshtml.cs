using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.EntityFrameworkCore;                            //ACCESS DATA USING ENTITY FRAMEWORK
using RazorPage.Data;                                           //CALL DATA CLASS
using RazorPage.Models;                                         //CALL ENTITY MODELS CLASS

namespace RazorPage.Pages
{
    public class IndexModel : PageModel
    {   
        private readonly DefaultConnection _context;    //DECLARATION OF DATABASE CONNECTION

        public IndexModel(DefaultConnection context)    //CALL DATABASE CONNECTION
        {
           _context = context;                          //INSERT DATABASE CONNECTION ON DATABASE DECLARATION
        }

        public IList<Table_Razor_Page> view { get; set;}        //DECLARE ENTITY BY USING LIST TO GET DATA FROM LOOP
        public Table_Razor_Page delete { get; set;}             //DECLARE ENTITY FOR DELETE DATA BY ONE ROW

        public async Task<ActionResult> OnGet()                         //RUN WHEN PAGE LOAD
        {
            view = await _context.Table_Razor_Page.ToListAsync();       //GET DATA FROM DB AND INSERT DATA TO ENTITY view

            if(view==null)                                              //CHECK WHETHER ENTITY IS NULL
            {
                view = new List<Table_Razor_Page>();                    //IF ENTITY IS NULL, CREATE NEW LIST
            }

            return Page();                                              //RETURN INTERFACE - DOES NOT RELOAD PAGE
        }

        public async Task<ActionResult> OnPostDelete(int id)                                //RUN WHEN FORM IS SUBMIT AND GET PARAMATER id FROM asp-route-id DECLARE ON INTERFACE
        {
            delete = await _context.Table_Razor_Page.FirstOrDefaultAsync(x=>x.ID==id);      //FIND ROW WITH CERTAIN id AND INSERT IT INTO ENTITY delete
            _context.Table_Razor_Page.Remove(delete);                                       //REMOVE DATA ENTITY FROM DATABASE

            await _context.SaveChangesAsync();                                              //SAVE ANY CHANGE THAT HAPPENS

            return RedirectToPage();                                                        //RETURN INTERFACE - RELOAD PAGE
        }
    }
}
