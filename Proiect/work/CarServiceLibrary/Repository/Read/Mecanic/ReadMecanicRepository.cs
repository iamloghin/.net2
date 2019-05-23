namespace ServiceAutoLibrary.Repository.Read.Mecanic
{
    using System.Collections.Generic;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class ReadMecanicRepository.
    /// Implements the <see cref="T:ServiceAutoLibrary.Repository.Read.Mecanic.IReadMecanicRepository" />
    /// </summary>
    /// <seealso cref="T:ServiceAutoLibrary.Repository.Read.Mecanic.IReadMecanicRepository" />
    internal class ReadMecanicRepository: IReadMecanicRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadMecanicRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadMecanicRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Mecanic.</returns>
        public ServiceAutoLibrary.Mecanic GetById(int id)
        {
            return _context.Mecanics.FirstOrDefault(m => m.MecanicId == id);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;Mecanici&gt;.</returns>
        public IReadOnlyList<ServiceAutoLibrary.Mecanic> GetAll()
        {
            return _context.Mecanics.ToList();
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(int id)
        {
            return _context.Mecanics.Any(m => m.MecanicId == id);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets the nume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents mecanic nume.</returns>
        public string GetNume(int id)
        {
            return _context.Mecanics.FirstOrDefault(m => m.MecanicId == id)?.Nume;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets the prenume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents mecanic prenume.</returns>
        public string GetPrenume(int id)
        {
            return _context.Mecanics.FirstOrDefault(m => m.MecanicId == id)?.Prenume;
        }
    }
}
