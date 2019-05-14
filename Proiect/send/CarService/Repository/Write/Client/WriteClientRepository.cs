using System;
using System.Data.Entity.Migrations;
using CarService;

namespace CarService.Repository.Write.Client
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
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteClientRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteClientRepository(CarServiceModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Creates the specified client.
        /// </summary>
        /// <param name="client">The client.</param>
        public void Create(CarService.Client client)
        {
            _context.Clienti.Add(client);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(Guid id)
        {
            var client = _context.Clienti.First(c => c.Id == id);
            _context.Clienti.Remove(client);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(Guid id)
        {
            return _context.Clienti.Any(c => c.Id == id);
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
        /// <summary>Updates the specified client.</summary>
        /// <param name="client">The client.</param>
        public void Update(CarService.Client client)
        {
            _context.Clienti.AddOrUpdate(client);
        }
    }
}
