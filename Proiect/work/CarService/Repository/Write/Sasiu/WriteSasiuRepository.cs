using System;
using System.Data.Entity.Migrations;

namespace CarService.Repository.Write.Sasiu
{
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class WriteSasiuRepository.
    /// Implements the <see cref="T:CarService.Repository.Write.Sasiu.IWriteSasiuRepository" />
    /// </summary>
    /// <seealso cref="T:CarService.Repository.Write.Sasiu.IWriteSasiuRepository" />
    internal class WriteSasiuRepository: IWriteSasiuRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteSasiuRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteSasiuRepository(CarServiceModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Creates the specified sasiu.
        /// </summary>
        /// <param name="sasiu">The sasiu.</param>
        public void Create(CarService.Sasiu sasiu)
        {
            _context.Sasiuri.Add(sasiu);
        }

        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(Guid id)
        {
            var sasiu = _context.Sasiuri.First(s => s.Id == id);
            _context.Sasiuri.Remove(sasiu);
        }

        public void Update(CarService.Sasiu sasiu)
        {
            _context.Sasiuri.AddOrUpdate(sasiu);
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(Guid id)
        {
            return _context.Sasiuri.Any(s => s.Id == id);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Saves the changes.
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
