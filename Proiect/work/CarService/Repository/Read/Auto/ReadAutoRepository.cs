namespace CarService.Repository.Read.Auto
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auto = CarService.Auto;

    /// <inheritdoc />
    /// <summary>
    /// Class ReadAutoRepository.
    /// Implements the <see cref="IReadAutoRepository" />
    /// </summary>
    /// <seealso cref="IReadAutoRepository" />
    internal class ReadAutoRepository: IReadAutoRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadAutoRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadAutoRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The Auto.</returns>
        public Auto GetById(Guid id)
        {
            return _context.Autos.FirstOrDefault(a => a.Id == id);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;Autos&gt;.</returns>
        public IReadOnlyList<Auto> GetAll()
        {
            return _context.Autos.ToList();
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(Guid id)
        {
            return _context.Autos.Any(a => a.Id == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the numar automatic.
        /// </summary>
        /// <param name="id">The auto identifier.</param>
        /// <returns>A string that represents the numar auto.</returns>
        public string GetNumarAuto(Guid id)
        {
            return _context.Autos.FirstOrDefault(a => a.Id == id)?.NumarAuto;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the serie sasiu.
        /// </summary>
        /// <param name="id">The auto identifier id.</param>
        /// <returns>A string that represents the serie sasiu.</returns>
        public string GetSerieSasiu(Guid id)
        {
            return _context.Autos.FirstOrDefault(a => a.Id == id)?.SerieSasiu;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the automatic client.
        /// </summary>
        /// <param name="id">The client identifier.</param>
        /// <returns>The auto Client</returns>
        public IList<Auto> GetAutoByClient(Guid id)
        {
            return _context.Autos.Where(a => a.Client.Id.Equals(id)).ToList();
        }
    }
}
