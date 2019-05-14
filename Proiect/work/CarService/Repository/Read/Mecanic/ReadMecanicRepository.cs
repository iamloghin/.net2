using System;
using System.Collections;
using CarService.Repository.Read.DetaliuComanda;

namespace CarService.Repository.Read.Mecanic
{
    using System.Collections.Generic;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class ReadMecanicRepository.
    /// Implements the <see cref="T:CarService.Repository.Read.Mecanic.IReadMecanicRepository" />
    /// </summary>
    /// <seealso cref="T:CarService.Repository.Read.Mecanic.IReadMecanicRepository" />
    internal class ReadMecanicRepository: IReadMecanicRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadMecanicRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadMecanicRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Mecanic.</returns>
        public CarService.Mecanic GetById(Guid id)
        {
            return !Exists(id) ? null : _context.Mecanici.FirstOrDefault(m => m.Id == id);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;Mecanici&gt;.</returns>
        public IReadOnlyList<CarService.Mecanic> GetAll()
        {
            return _context.Mecanici.ToList();
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
        /// Gets the nume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents mecanic nume.</returns>
        public string GetNume(Guid id)
        {
            return !Exists(id) ? null : _context.Mecanici.FirstOrDefault(m => m.Id == id)?.Nume;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets the prenume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents mecanic prenume.</returns>
        public string GetPrenume(Guid id)
        {
            return !Exists(id) ? null : _context.Mecanici.FirstOrDefault(m => m.Id == id)?.Prenume;
        }

        public List<CarService.Mecanic> GetAvailables()
        {
            var allComands = _context.DetaliiComanda.ToList();

            var allMecanics = _context.Mecanici.ToList();

            var availableMecanics = new List<CarService.Mecanic>();

            foreach (var mecanic in allMecanics)
            {
                var itemFound = false;

                foreach (var detaliuComanda in allComands)
                {
                    if (detaliuComanda.Mecanici.Contains(mecanic)) itemFound = true;
                }

                if (!itemFound)
                {
                    availableMecanics.Add(mecanic);
                }
            }

            return availableMecanics;
        }
    }
}
