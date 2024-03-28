using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShoesShop.Models;

namespace ShoesShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class InvoicesController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly ILogger<InvoicesController> _logger;
        public override void OnActionExecuting(ActionExecutingContext context) => ViewData["MenuBar"] = "Invoices";

        public InvoicesController(DatabaseContext context, ILogger<InvoicesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Admin/Invoices
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Invoices.Include(i => i.AppUser).Include(i => i.Status).OrderByDescending(q => q.DateOrdered);
            return View(await databaseContext.ToListAsync());
        }



        

        // GET: Admin/Invoices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice == null)
            {
                return NotFound();
            }
            invoice.InvoiceItems = await _context.InvoiceItems
                                        .Where(q => q.InvoiceId == id)
                                        .Include(q => q.ProductItem)
                                        .ThenInclude(q => q.Product)
                                        .Include(q => q.ProductItem)
                                        .ThenInclude(q => q.Size)
                                        .ToListAsync();

            ViewData["StatusId"] = new SelectList(_context.Set<InvoiceStatus>(), "Id", "Status", invoice.StatusId);
            return View(invoice);
        }

        // POST: Admin/Invoices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Address,StatusId")] Invoice updateInvoice)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice == null)
            {
                return NotFound();
            }
            invoice.InvoiceItems = await _context.InvoiceItems
                                        .Where(q => q.InvoiceId == id)
                                        .Include(q => q.ProductItem)
                                        .ThenInclude(q => q.Product)
                                        .Include(q => q.ProductItem)
                                        .ThenInclude(q => q.Size)
                                        .ToListAsync();
           
            
            if (ModelState.IsValid)
            {
                try
                {
                    invoice.Address = updateInvoice.Address;
                    invoice.StatusId = updateInvoice.StatusId;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoiceExists(updateInvoice.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusId"] = new SelectList(_context.Set<InvoiceStatus>(), "Id", "Status", updateInvoice.StatusId);
            return View(invoice);
        }

        // GET: Admin/Invoices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoices
                .Include(i => i.AppUser)
                .Include(i => i.Status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoice == null)
            {
                return NotFound();
            }

            return View(invoice);
        }

        // POST: Admin/Invoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice != null)
            {
                _context.Invoices.Remove(invoice);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvoiceExists(int id)
        {
            return _context.Invoices.Any(e => e.Id == id);
        }
    }
}
