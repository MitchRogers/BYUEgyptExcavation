using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BYUEgyptExcavation.Models;

namespace BYUEgyptExcavation
{
    public class MummiesController : Controller
    {
        private readonly BYUEgyptExcavationsFagelGamousContext _context;

        public MummiesController(BYUEgyptExcavationsFagelGamousContext context)
        {
            _context = context;
        }

        // GET: Mummies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mummy.ToListAsync());
        }

        // GET: Mummies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mummy = await _context.Mummy
                .FirstOrDefaultAsync(m => m.MummyId == id);
            if (mummy == null)
            {
                return NotFound();
            }

            return View(mummy);
        }

        // GET: Mummies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mummies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MummyId,GenderGe,GenderMethod,GeFunctionTotal,GenderBodyCol,HairColor,EstimateAge,AgeMethod,EstimateLivingStature,ToothAttrition,ToothEruption,PathologyAnomalies")] Mummy mummy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mummy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mummy);
        }

        // GET: Mummies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mummy = await _context.Mummy.FindAsync(id);
            if (mummy == null)
            {
                return NotFound();
            }
            return View(mummy);
        }

        // POST: Mummies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MummyId,GenderGe,GenderMethod,GeFunctionTotal,GenderBodyCol,HairColor,EstimateAge,AgeMethod,EstimateLivingStature,ToothAttrition,ToothEruption,PathologyAnomalies")] Mummy mummy)
        {
            if (id != mummy.MummyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mummy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MummyExists(mummy.MummyId))
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
            return View(mummy);
        }

        // GET: Mummies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mummy = await _context.Mummy
                .FirstOrDefaultAsync(m => m.MummyId == id);
            if (mummy == null)
            {
                return NotFound();
            }

            return View(mummy);
        }

        // POST: Mummies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mummy = await _context.Mummy.FindAsync(id);
            _context.Mummy.Remove(mummy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MummyExists(int id)
        {
            return _context.Mummy.Any(e => e.MummyId == id);
        }
    }
}
