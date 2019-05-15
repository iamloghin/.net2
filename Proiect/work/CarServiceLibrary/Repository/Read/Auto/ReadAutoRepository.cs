namespace ServiceAutoLibrary.Repository.Read.Auto
{
    using System.Linq;
    using System.Collections.Generic;

    /// <inheritdoc />
    /// <summary>
    /// Class ReadAutoRepository.
    /// Implements the <see cref="T:ServiceAutoLibrary.Repository.Read.Auto.IReadAutoRepository" />
    /// </summary>
    /// <seealso cref="T:ServiceAutoLibrary.Repository.Read.Auto.IReadAutoRepository" />
    internal class ReadAutoRepository: IReadAutoRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadAutoRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadAutoRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The Auto.</returns>
        public ServiceAutoLibrary.Auto GetById(int id)
        {
            return _context.Autos.FirstOrDefault(a => a.AutoId == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;Autos&gt;.</returns>
        public IReadOnlyList<ServiceAutoLibrary.Auto> GetAll()
        {
            return _context.Autos.ToList();
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(int id)
        {
            return _context.Autos.Any(a => a.AutoId == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the numar automatic.
        /// </summary>
        /// <param name="id">The auto identifier.</param>
        /// <returns>A string that represents the numar auto.</returns>
        public string GetNumarAuto(int id)
        {
            return _context.Autos.FirstOrDefault(a => a.AutoId == id)?.NumarAuto;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the serie sasiu.
        /// </summary>
        /// <param name="id">The auto identifier id.</param>
        /// <returns>A string that represents the serie sasiu.</returns>
        public string GetSerieSasiu(int id)
        {
            return _context.Autos.FirstOrDefault(a => a.AutoId == id)?.SerieSasiu;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the automatic client.
        /// </summary>
        /// <param name="id">The client identifier.</param>
        /// <returns>The auto Client</returns>
        public IList<ServiceAutoLibrary.Auto> GetAutoByClient(int id)
        {
            return _context.Autos.Where(a => a.Client.ClientId.Equals(id)).ToList();
        }
    }
}
