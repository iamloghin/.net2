using System;

namespace CarService.Repository.Read.Sasiu
{
    using System.Collections.Generic;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class ReadSasiuRepository.
    /// Implements the <see cref="T:CarService.Repository.Read.Sasiu.IReadSasiuRepository" />
    /// </summary>
    /// <seealso cref="T:CarService.Repository.Read.Sasiu.IReadSasiuRepository" />
    internal class ReadSasiuRepository: IReadSasiuRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadSasiuRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadSasiuRepository(CarServiceModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Sasiu.</returns>
        public CarService.Sasiu GetById(Guid id)
        {
            return !Exists(id) ? null : _context.Sasiuri.FirstOrDefault(s => s.Id == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;Sasiuri&gt;.</returns>
        public IReadOnlyList<CarService.Sasiu> GetAll()
        {
            return _context.Sasiuri.ToList();
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
        /// Gets the cod sasiu.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the cod sasiu.</returns>
        public string GetCodSasiu(Guid id)
        {
            return !Exists(id) ? null : _context.Sasiuri.FirstOrDefault(s => s.Id == id)?.CodSasiu;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets the denumire.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the sasiu denumire.</returns>
        public string GetDenumire(Guid id)
        {
            return !Exists(id) ? null : _context.Sasiuri.FirstOrDefault(s => s.Id == id)?.Denumire;
        }
    }
}
