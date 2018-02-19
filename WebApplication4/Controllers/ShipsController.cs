using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OSSN.Models;

namespace OSSN.Controllers
{
    public class ShipsController : Controller
    {
        private readonly OpenSSNDBContext _context;

        public ShipsController(OpenSSNDBContext context)
        {
            _context = context;
        }

        // GET: Ships
        public async Task<IActionResult> Index()
        {
            var openSSNDBContext = _context.Ship.Include(s => s.CompanyCompany).Include(s => s.CountryCountry).Include(s => s.ShipbreadthtypeShipbreadthtype).Include(s => s.ShipflagcodeShipflagcode).Include(s => s.ShiphulltypeShiphulltype).Include(s => s.ShiplengthtypeShiplengthtype).Include(s => s.ShippowertypeShippowertype).Include(s => s.ShipsourceShipsource).Include(s => s.ShipstatusShipstatus).Include(s => s.ShiptypeShiptype);
            return View(await openSSNDBContext.ToListAsync());
        }

        // GET: Ships/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ship = await _context.Ship
                .Include(s => s.CompanyCompany)
                .Include(s => s.CountryCountry)
                .Include(s => s.ShipbreadthtypeShipbreadthtype)
                .Include(s => s.ShipflagcodeShipflagcode)
                .Include(s => s.ShiphulltypeShiphulltype)
                .Include(s => s.ShiplengthtypeShiplengthtype)
                .Include(s => s.ShippowertypeShippowertype)
                .Include(s => s.ShipsourceShipsource)
                .Include(s => s.ShipstatusShipstatus)
                .Include(s => s.ShiptypeShiptype)
                .SingleOrDefaultAsync(m => m.Shipid == id);
            if (ship == null)
            {
                return NotFound();
            }

            return View(ship);
        }

        // GET: Ships/Create
        public IActionResult Create()
        {
            ViewData["CompanyCompanyid"] = new SelectList(_context.Company, "Companyid", "Companyid");
            ViewData["CountryCountryid"] = new SelectList(_context.Country, "Countryid", "Countryid");
            ViewData["ShipbreadthtypeShipbreadthtypeid"] = new SelectList(_context.Shipbreadthtype, "Shipbreadthtypeid", "Shipbreadthtype1");
            ViewData["ShipflagcodeShipflagcodeid"] = new SelectList(_context.Shipflagcode, "Shipflagcodeid", "Shipflagcodeid");
            ViewData["ShiphulltypeShiphulltypeid"] = new SelectList(_context.Shiphulltype, "Shiphulltypeid", "Shiphulltype1");
            ViewData["ShiplengthtypeShiplengthtypeid"] = new SelectList(_context.Shiplengthtype, "Shiplengthtypeid", "Shiplengthtype1");
            ViewData["ShippowertypeShippowertypeid"] = new SelectList(_context.Shippowertype, "Shippowertypeid", "Shippowertype1");
            ViewData["ShipsourceShipsourceid"] = new SelectList(_context.Shipsource, "Shipsourceid", "Shipsource1");
            ViewData["ShipstatusShipstatusid"] = new SelectList(_context.Shipstatus, "Shipstatusid", "Shipstatus1");
            ViewData["ShiptypeShiptypeid"] = new SelectList(_context.Shiptype, "Shiptypeid", "Systemname");
            return View();
        }

        // POST: Ships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Shipid,ShiphulltypeShiphulltypeid,ShippowertypeShippowertypeid,ShipbreadthtypeShipbreadthtypeid,ShiplengthtypeShiplengthtypeid,ShipflagcodeShipflagcodeid,CountryCountryid,ShipsourceShipsourceid,ShipstatusShipstatusid,CompanyCompanyid,ShiptypeShiptypeid,Imono,Yearofbuild,Mmsino,Shipname,Callsign,Dwt,Grosstonnage,Shiplength,Breadth,Speed,Power,Height,Draught,Hassidethrusters,Hassidethrustersfront,Hassidethrustersback,Remark")] Ship ship)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ship);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyCompanyid"] = new SelectList(_context.Company, "Companyid", "Companyid", ship.CompanyCompanyid);
            ViewData["CountryCountryid"] = new SelectList(_context.Country, "Countryid", "Countryid", ship.CountryCountryid);
            ViewData["ShipbreadthtypeShipbreadthtypeid"] = new SelectList(_context.Shipbreadthtype, "Shipbreadthtypeid", "Shipbreadthtype1", ship.ShipbreadthtypeShipbreadthtypeid);
            ViewData["ShipflagcodeShipflagcodeid"] = new SelectList(_context.Shipflagcode, "Shipflagcodeid", "Shipflagcodeid", ship.ShipflagcodeShipflagcodeid);
            ViewData["ShiphulltypeShiphulltypeid"] = new SelectList(_context.Shiphulltype, "Shiphulltypeid", "Shiphulltype1", ship.ShiphulltypeShiphulltypeid);
            ViewData["ShiplengthtypeShiplengthtypeid"] = new SelectList(_context.Shiplengthtype, "Shiplengthtypeid", "Shiplengthtype1", ship.ShiplengthtypeShiplengthtypeid);
            ViewData["ShippowertypeShippowertypeid"] = new SelectList(_context.Shippowertype, "Shippowertypeid", "Shippowertype1", ship.ShippowertypeShippowertypeid);
            ViewData["ShipsourceShipsourceid"] = new SelectList(_context.Shipsource, "Shipsourceid", "Shipsource1", ship.ShipsourceShipsourceid);
            ViewData["ShipstatusShipstatusid"] = new SelectList(_context.Shipstatus, "Shipstatusid", "Shipstatus1", ship.ShipstatusShipstatusid);
            ViewData["ShiptypeShiptypeid"] = new SelectList(_context.Shiptype, "Shiptypeid", "Systemname", ship.ShiptypeShiptypeid);
            return View(ship);
        }

        // GET: Ships/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ship = await _context.Ship.SingleOrDefaultAsync(m => m.Shipid == id);
            if (ship == null)
            {
                return NotFound();
            }
            ViewData["CompanyCompanyid"] = new SelectList(_context.Company, "Companyid", "Companyid", ship.CompanyCompanyid);
            ViewData["CountryCountryid"] = new SelectList(_context.Country, "Countryid", "Countryid", ship.CountryCountryid);
            ViewData["ShipbreadthtypeShipbreadthtypeid"] = new SelectList(_context.Shipbreadthtype, "Shipbreadthtypeid", "Shipbreadthtype1", ship.ShipbreadthtypeShipbreadthtypeid);
            ViewData["ShipflagcodeShipflagcodeid"] = new SelectList(_context.Shipflagcode, "Shipflagcodeid", "Shipflagcodeid", ship.ShipflagcodeShipflagcodeid);
            ViewData["ShiphulltypeShiphulltypeid"] = new SelectList(_context.Shiphulltype, "Shiphulltypeid", "Shiphulltype1", ship.ShiphulltypeShiphulltypeid);
            ViewData["ShiplengthtypeShiplengthtypeid"] = new SelectList(_context.Shiplengthtype, "Shiplengthtypeid", "Shiplengthtype1", ship.ShiplengthtypeShiplengthtypeid);
            ViewData["ShippowertypeShippowertypeid"] = new SelectList(_context.Shippowertype, "Shippowertypeid", "Shippowertype1", ship.ShippowertypeShippowertypeid);
            ViewData["ShipsourceShipsourceid"] = new SelectList(_context.Shipsource, "Shipsourceid", "Shipsource1", ship.ShipsourceShipsourceid);
            ViewData["ShipstatusShipstatusid"] = new SelectList(_context.Shipstatus, "Shipstatusid", "Shipstatus1", ship.ShipstatusShipstatusid);
            ViewData["ShiptypeShiptypeid"] = new SelectList(_context.Shiptype, "Shiptypeid", "Systemname", ship.ShiptypeShiptypeid);
            return View(ship);
        }

        // POST: Ships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Shipid,ShiphulltypeShiphulltypeid,ShippowertypeShippowertypeid,ShipbreadthtypeShipbreadthtypeid,ShiplengthtypeShiplengthtypeid,ShipflagcodeShipflagcodeid,CountryCountryid,ShipsourceShipsourceid,ShipstatusShipstatusid,CompanyCompanyid,ShiptypeShiptypeid,Imono,Yearofbuild,Mmsino,Shipname,Callsign,Dwt,Grosstonnage,Shiplength,Breadth,Speed,Power,Height,Draught,Hassidethrusters,Hassidethrustersfront,Hassidethrustersback,Remark")] Ship ship)
        {
            if (id != ship.Shipid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ship);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShipExists(ship.Shipid))
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
            ViewData["CompanyCompanyid"] = new SelectList(_context.Company, "Companyid", "Companyid", ship.CompanyCompanyid);
            ViewData["CountryCountryid"] = new SelectList(_context.Country, "Countryid", "Countryid", ship.CountryCountryid);
            ViewData["ShipbreadthtypeShipbreadthtypeid"] = new SelectList(_context.Shipbreadthtype, "Shipbreadthtypeid", "Shipbreadthtype1", ship.ShipbreadthtypeShipbreadthtypeid);
            ViewData["ShipflagcodeShipflagcodeid"] = new SelectList(_context.Shipflagcode, "Shipflagcodeid", "Shipflagcodeid", ship.ShipflagcodeShipflagcodeid);
            ViewData["ShiphulltypeShiphulltypeid"] = new SelectList(_context.Shiphulltype, "Shiphulltypeid", "Shiphulltype1", ship.ShiphulltypeShiphulltypeid);
            ViewData["ShiplengthtypeShiplengthtypeid"] = new SelectList(_context.Shiplengthtype, "Shiplengthtypeid", "Shiplengthtype1", ship.ShiplengthtypeShiplengthtypeid);
            ViewData["ShippowertypeShippowertypeid"] = new SelectList(_context.Shippowertype, "Shippowertypeid", "Shippowertype1", ship.ShippowertypeShippowertypeid);
            ViewData["ShipsourceShipsourceid"] = new SelectList(_context.Shipsource, "Shipsourceid", "Shipsource1", ship.ShipsourceShipsourceid);
            ViewData["ShipstatusShipstatusid"] = new SelectList(_context.Shipstatus, "Shipstatusid", "Shipstatus1", ship.ShipstatusShipstatusid);
            ViewData["ShiptypeShiptypeid"] = new SelectList(_context.Shiptype, "Shiptypeid", "Systemname", ship.ShiptypeShiptypeid);
            return View(ship);
        }

        // GET: Ships/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ship = await _context.Ship
                .Include(s => s.CompanyCompany)
                .Include(s => s.CountryCountry)
                .Include(s => s.ShipbreadthtypeShipbreadthtype)
                .Include(s => s.ShipflagcodeShipflagcode)
                .Include(s => s.ShiphulltypeShiphulltype)
                .Include(s => s.ShiplengthtypeShiplengthtype)
                .Include(s => s.ShippowertypeShippowertype)
                .Include(s => s.ShipsourceShipsource)
                .Include(s => s.ShipstatusShipstatus)
                .Include(s => s.ShiptypeShiptype)
                .SingleOrDefaultAsync(m => m.Shipid == id);
            if (ship == null)
            {
                return NotFound();
            }

            return View(ship);
        }

        // POST: Ships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ship = await _context.Ship.SingleOrDefaultAsync(m => m.Shipid == id);
            _context.Ship.Remove(ship);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShipExists(int id)
        {
            return _context.Ship.Any(e => e.Shipid == id);
        }
    }
}
