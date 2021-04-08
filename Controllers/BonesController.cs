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
    public class BonesController : Controller
    {
        private readonly BYUEgyptExcavationsFagelGamousContext _context;

        public BonesController(BYUEgyptExcavationsFagelGamousContext context)
        {
            _context = context;
        }

        // GET: Bones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bones.ToListAsync());
        }

        // GET: Bones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bones = await _context.Bones
                .FirstOrDefaultAsync(m => m.MummyId == id);
            if (bones == null)
            {
                return NotFound();
            }

            return View(bones);
        }

        // GET: Bones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MummyId,SampleNumber,BasilarSuture,VentralArc,SubpubicAngle,SciaticNotch,PubicBone,PreaurSulcus,MedialIpRamus,DorsalPitting,ForemanMagnum,FemurHead,HumerusHead,Osteophytosis,PubicSymphysis,FemurLength,HumerusLength,TibiaLength,Robust,SupraorbitalRidges,OrbitEdge,ParietalBossing,Gonian,NuchalCrest,ZygomaticCrest,CranialSuture,MaximumCranialLength,MaximumCranialBreadth,BasionBregmaHeight,BasionNasion,BasionProsthionLength,BizygomaticDiameter,NasionProsthion,MaximumNasalBreadth,InterorbitalBreadth,EpiphysealUnion")] Bones bones)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bones);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bones);
        }

        // GET: Bones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bones = await _context.Bones.FindAsync(id);
            if (bones == null)
            {
                return NotFound();
            }
            return View(bones);
        }

        // POST: Bones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MummyId,SampleNumber,BasilarSuture,VentralArc,SubpubicAngle,SciaticNotch,PubicBone,PreaurSulcus,MedialIpRamus,DorsalPitting,ForemanMagnum,FemurHead,HumerusHead,Osteophytosis,PubicSymphysis,FemurLength,HumerusLength,TibiaLength,Robust,SupraorbitalRidges,OrbitEdge,ParietalBossing,Gonian,NuchalCrest,ZygomaticCrest,CranialSuture,MaximumCranialLength,MaximumCranialBreadth,BasionBregmaHeight,BasionNasion,BasionProsthionLength,BizygomaticDiameter,NasionProsthion,MaximumNasalBreadth,InterorbitalBreadth,EpiphysealUnion")] Bones bones)
        {
            if (id != bones.MummyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bones);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BonesExists(bones.MummyId))
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
            return View(bones);
        }

        // GET: Bones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bones = await _context.Bones
                .FirstOrDefaultAsync(m => m.MummyId == id);
            if (bones == null)
            {
                return NotFound();
            }

            return View(bones);
        }

        // POST: Bones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bones = await _context.Bones.FindAsync(id);
            _context.Bones.Remove(bones);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BonesExists(int id)
        {
            return _context.Bones.Any(e => e.MummyId == id);
        }
    }
}
