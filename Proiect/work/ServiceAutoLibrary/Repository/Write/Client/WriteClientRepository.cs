namespace ServiceAutoLibrary.Repository.Write.Client
{
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class WriteClientRepository.
    /// Implements the <see cref="IWriteClientRepository" />
    /// </summary>
    /// <seealso cref="IWriteClientRepository" />
    internal class WriteClientRepository: IWriteClientRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteClientRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteClientRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Creates the specified client.
        /// </summary>
        /// <param name="client">The client.</param>
        public void Create(ServiceAutoLibrary.Client client)
        {
            _context.Clienti.Add(client);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            var client = _context.Clienti.First(c => c.ClientId == id);
            _context.Clienti.Remove(client);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(int id)
        {
            return _context.Clienti.Any(c => c.ClientId == id);
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
