using System;
using System.Data.Entity.Migrations;

namespace CarService.Repository.Write.Operatie
{
    using System.Linq;
            
    /// <inheritdoc />
    /// <summary>
    /// Class WriteOperatieRepository.
    /// Implements the <see cref="IWriteOperatieRepository" />
    /// </summary>
    /// <seealso cref="IWriteOperatieRepository" />
    internal class WriteOperatieRepository: IWriteOperatieRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteOperatieRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteOperatieRepository(CarServiceModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Creates the specified operate.
        /// </summary>
        /// <param name="operate">The operate.</param>
        public void Create(CarService.Operatie operate)
        {
            _context.Operatii.Add(operate);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(Guid id)
        {
            var operate = _context.Operatii.First(o => o.Id == id);
            _context.Operatii.Remove(operate);
        }

        public void Update(CarService.Operatie operate)
        {
            _context.Operatii.AddOrUpdate(operate);
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(Guid id)
        {
            return _context.Operatii.Any(o => o.Id == id);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Saves the changes.
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        /// <inheritdoc />
        /// <summary>Sets the timp executie.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="timpExecutie">The timp executie.</param>
        public void SetTimpExecutie(Guid id, decimal timpExecutie)
        {
            _context.Operatii.First(o => o.Id == id).TimpExecutie = timpExecutie;
        }

        /// <inheritdoc />
        /// <summary>Sets the denumire.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="denumire">The denumire.</param>
        public void SetDenumire(Guid id, string denumire)
        {
            _context.Operatii.First(o => o.Id == id).Denumire = denumire;
        }
    }
}
