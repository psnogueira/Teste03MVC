using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mini_Mundo.Data;
using Mini_Mundo.Models;

namespace Mini_Mundo.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly LojaImpactaContext _context;

        public ProdutosController(LojaImpactaContext context)
        {
            _context = context;
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Produto.ToListAsync());
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto
                .FirstOrDefaultAsync(m => m.ProdutoID == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produtos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produtos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProdutoID,Nome,Descricao,Preco,QuantidadeEstoque")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        // POST: Produtos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProdutoID,Nome,Descricao,Preco,QuantidadeEstoque")] Produto produto)
        {
            if (id != produto.ProdutoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.ProdutoID))
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
            return View(produto);
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto
                .FirstOrDefaultAsync(m => m.ProdutoID == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _context.Produto.FindAsync(id);
            if (produto != null)
            {
                _context.Produto.Remove(produto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produto.Any(e => e.ProdutoID == id);
        }
    }
}
