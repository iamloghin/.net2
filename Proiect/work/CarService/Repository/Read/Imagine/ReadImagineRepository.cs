namespace CarService.Repository.Read.Imagine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Imagine = CarService.Imagine;

    /// <summary>
    /// Class ReadImagineRepository.
    /// Implements the <see cref="IReadImagineRepository" />
    /// </summary>
    /// <seealso cref="IReadImagineRepository" />
    internal class ReadImagineRepository: IReadImagineRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadImagineRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadImagineRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The Imagine.</returns>
        public CarService.Imagine GetById(Guid id)
        {
            return !Exists(id) ? null : _context.Imagini.FirstOrDefault(i => i.Id == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;Imagini&gt;.</returns>
        public IReadOnlyList<Imagine> GetAll()
        {
            return _context.Imagini.ToList();
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(Guid id)
        {
            return _context.Imagini.Any(i => i.Id == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the titlu.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the imagine titlu.</returns>
        public string GetTitlu(Guid id)
        {
            return !Exists(id) ? null : _context.Imagini.FirstOrDefault(i => i.Id == id)?.Titlu;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the descriere.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the imagine descriere.</returns>
        public string GetDescriere(Guid id)
        {
            return !Exists(id) ? null : _context.Imagini.FirstOrDefault(i => i.Id == id)?.Descriere;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the imagine data.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the imagine date.</returns>
        public DateTime GetImagineData(Guid id)
        {
            return _context.Imagini.FirstOrDefault(i => i.Id == id).Data;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the foto.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The Foto.</returns>
        public byte[] GetFoto(Guid id)
        {
            return _context.Imagini.FirstOrDefault(i => i.Id == id)?.Foto;
        }
    }
}
