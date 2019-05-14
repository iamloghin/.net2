using System;

namespace CarService.Repository.Read.Operatie
{
    using System.Collections.Generic;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class ReadOperatieRepository.
    /// Implements the <see cref="T:CarService.Repository.Read.Operatie.IReadOperatieRepository" />
    /// </summary>
    /// <seealso cref="T:CarService.Repository.Read.Operatie.IReadOperatieRepository" />
    internal class ReadOperatieRepository: IReadOperatieRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOperatieRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadOperatieRepository(CarServiceModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Operatie.</returns>
        public CarService.Operatie GetById(Guid id)
        {
            return !Exists(id) ? null : _context.Operatii.FirstOrDefault(o => o.Id== id);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;Operatii&gt;.</returns>
        public IReadOnlyList<CarService.Operatie> GetAll()
        {
            return _context.Operatii.ToList();
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(Guid id)
        {
            return _context.Operatii.Any(o => o.Id== id);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets the denumire.
        /// </summary>
        /// <param name="id">The operatie identifier.</param>
        /// <returns>A string that represents operatie denumire.</returns>
        public string GetDenumire(Guid id)
        {
            return !Exists(id) ? null : _context.Operatii.FirstOrDefault(o => o.Id== id)?.Denumire;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the timp executie.
        /// </summary>
        /// <param name="id">The operatie identifier.</param>
        /// <returns>A string that represents timp executie</returns>
        public decimal? GetTimpExecutie(Guid id)
        {
            return !Exists(id) ? null : _context.Operatii.FirstOrDefault(o => o.Id== id)?.TimpExecutie;
        }
    }
}
