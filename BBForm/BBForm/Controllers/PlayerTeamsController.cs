using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BBForm.Models;

namespace BBForm.Controllers
{
    public class PlayerTeamsController : Controller
    {
        private readonly BBFormContext _context;

        public PlayerTeamsController(BBFormContext context)
        {
            _context = context;
        }

        // GET: PlayerTeams
        public async Task<IActionResult> Index(string searchString)
        {
            var teams = from t in _context.PlayerTeam
                        select t;

            if (!String.IsNullOrEmpty(searchString))
            {
                teams = teams.Where(x => x.TeamName.Contains(searchString));
            }

            return View(await teams.ToListAsync());
            //return View(await _context.PlayerTeam.ToListAsync());
        }

        // GET: PlayerTeams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerTeam = await _context.PlayerTeam
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playerTeam == null)
            {
                return NotFound();
            }

            return View(playerTeam);
        }

        // GET: PlayerTeams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlayerTeams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TeamName,PlayerName")] PlayerTeam playerTeam)
        {
            if (ModelState.IsValid)
            {
                if(!UpdatePlayerTeam.PlayerTeamRecordExists(_context, playerTeam.PlayerName, playerTeam.TeamName))
                {
                    _context.Add(playerTeam);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(playerTeam);
        }

        // GET: PlayerTeams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerTeam = await _context.PlayerTeam.FindAsync(id);
            if (playerTeam == null)
            {
                return NotFound();
            }
            return View(playerTeam);
        }

        // POST: PlayerTeams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeamName,PlayerName")] PlayerTeam playerTeam)
        {
            if (id != playerTeam.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(playerTeam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerTeamExists(playerTeam.Id))
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
            return View(playerTeam);
        }

        // GET: PlayerTeams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerTeam = await _context.PlayerTeam
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playerTeam == null)
            {
                return NotFound();
            }

            return View(playerTeam);
        }

        // POST: PlayerTeams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var playerTeam = await _context.PlayerTeam.FindAsync(id);
            _context.PlayerTeam.Remove(playerTeam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerTeamExists(int id)
        {
            return _context.PlayerTeam.Any(e => e.Id == id);
        }
    }
}
