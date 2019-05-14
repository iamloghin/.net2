using System;
using System.Data.Entity.Migrations;

namespace CarService.Repository.Write.Mecanic
{
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class WriteMecanicRepository.
    /// Implements the <see cref="T:CarService.Repository.Write.Mecanic.IWriteMecanicRepository" />
    /// </summary>
    /// <seealso cref="T:CarService.Repository.Write.Mecanic.IWriteMecanicRepository" />
    internal class WriteMecanicRepository: IWriteMecanicRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteMecanicRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteMecanicRepository(CarServiceModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Creates the specified mecanic.
        /// </summary>
        /// <param name="mecanic">The mecanic.</param>
        public void Create(CarService.Mecanic mecanic)
        {
            _context.Mecanici.Add(mecanic);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(Guid id)
        {
            var mecanic = _context.Mecanici.First(m => m.Id == id);
            _context.Mecanici.Remove(mecanic);
        }

        public void Update(CarService.Mecanic mecanic)
        {
            _context.Mecanici.AddOrUpdate(mecanic);
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(Guid id)
        {
            return _context.Mecanici.Any(m => m.Id == id);
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
