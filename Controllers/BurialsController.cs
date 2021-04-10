using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BYUEgyptExcavation.Models;
using Microsoft.AspNetCore.Authorization;

namespace BYUEgyptExcavation.Controllers
{
    public class BurialsController : Controller
    {
        private readonly BYUEgyptExcavationsFagelGamousContext _context;

        public BurialsController(BYUEgyptExcavationsFagelGamousContext context)
        {
            _context = context;
        }

        // GET: Burials
        public async Task<IActionResult> Index()
        {
            return View(await _context.Burial.ToListAsync());
        }


        // GET: Researcher Burials
        //[Authorize(Roles = "Research")]
        public async Task<IActionResult> ResearchIndex()
        {
            return View(await _context.Burial.ToListAsync());
        }

        // GET: Burials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = await _context.Burial
                .FirstOrDefaultAsync(m => m.MummyId == id);
            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        // GET: Burials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Burials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MummyId,BurialId,BurialNumber,BurialLocationNs,LowPairNs,HighPairNs,BurialLocationEw,LowPairEw,HighPairEw,BurialSubplot,BurialDepth,SouthToHead,SouthToFeet,EastToHead,EastToFeet,LengthOfRemains,PreservationIndex,BurialSituationNotes,ArtifactsTakenNotes,SampleTakenNotes,HairTaken,SoftTissueTaken,BoneTaken,ToothTaken,TextileTaken,ArtifactFound,Wrapped,HeadDirection,YearFound,MonthFound,DayFound,UserInitials,GenderGe,GenderMethod,GeFunctionTotal,GenderBodyCol,HairColor,EstimateAge,AgeMethod,EstimateLivingStature,ToothAttrition,ToothEruption,PathologyAnomalies,SampleNumber,BasilarSuture,VentralArc,SubpubicAngle,SciaticNotch,PubicBone,PreaurSulcus,MedialIpRamus,DorsalPitting,ForemanMagnum,FemurHead,HumerusHead,Osteophytosis,PubicSymphysis,FemurLength,HumerusLength,TibiaLength,Robust,SupraorbitalRidges,OrbitEdge,ParietalBossing,Gonian,NuchalCrest,ZygomaticCrest,CranialSuture,MaximumCranialLength,MaximumCranialBreadth,BasionBregmaHeight,BasionNasion,BasionProsthionLength,BizygomaticDiameter,NasionProsthion,MaximumNasalBreadth,InterorbitalBreadth,EpiphysealUnion")] Burial burial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(burial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(burial);
        }

        // GET: Burials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = await _context.Burial.FindAsync(id);
            if (burial == null)
            {
                return NotFound();
            }
            return View(burial);
        }

        // POST: Burials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MummyId,BurialId,BurialNumber,BurialLocationNs,LowPairNs,HighPairNs,BurialLocationEw,LowPairEw,HighPairEw,BurialSubplot,BurialDepth,SouthToHead,SouthToFeet,EastToHead,EastToFeet,LengthOfRemains,PreservationIndex,BurialSituationNotes,ArtifactsTakenNotes,SampleTakenNotes,HairTaken,SoftTissueTaken,BoneTaken,ToothTaken,TextileTaken,ArtifactFound,Wrapped,HeadDirection,YearFound,MonthFound,DayFound,UserInitials,GenderGe,GenderMethod,GeFunctionTotal,GenderBodyCol,HairColor,EstimateAge,AgeMethod,EstimateLivingStature,ToothAttrition,ToothEruption,PathologyAnomalies,SampleNumber,BasilarSuture,VentralArc,SubpubicAngle,SciaticNotch,PubicBone,PreaurSulcus,MedialIpRamus,DorsalPitting,ForemanMagnum,FemurHead,HumerusHead,Osteophytosis,PubicSymphysis,FemurLength,HumerusLength,TibiaLength,Robust,SupraorbitalRidges,OrbitEdge,ParietalBossing,Gonian,NuchalCrest,ZygomaticCrest,CranialSuture,MaximumCranialLength,MaximumCranialBreadth,BasionBregmaHeight,BasionNasion,BasionProsthionLength,BizygomaticDiameter,NasionProsthion,MaximumNasalBreadth,InterorbitalBreadth,EpiphysealUnion")] Burial burial)
        {
            if (id != burial.MummyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(burial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BurialExists(burial.MummyId))
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
            return View(burial);
        }

        // GET: Burials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = await _context.Burial
                .FirstOrDefaultAsync(m => m.MummyId == id);
            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        // POST: Burials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var burial = await _context.Burial.FindAsync(id);
            _context.Burial.Remove(burial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BurialExists(int id)
        {
            return _context.Burial.Any(e => e.MummyId == id);
        }
    }
}
