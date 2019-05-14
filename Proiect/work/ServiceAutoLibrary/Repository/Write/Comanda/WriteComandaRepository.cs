namespace ServiceAutoLibrary.Repository.Write.Comanda
{
    using System;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class WriteComandaRepository.
    /// Implements the <see cref="IWriteComandaRepository" />
    /// </summary>
    /// <seealso cref="IWriteComandaRepository" />
    internal class WriteComandaRepository: IWriteComandaRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteComandaRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteComandaRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Creates the specified comanda.
        /// </summary>
        /// <param name="comanda">The comanda.</param>
        public void Create(ServiceAutoLibrary.Comanda comanda)
        {
            _context.Comenzi.Add(comanda);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            var comanda = _context.Comenzi.First(c => c.ComandaId == id);
            _context.Comenzi.Remove(comanda);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(int id)
        {
            return _context.Comenzi.Any(c => c.ComandaId == id);
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
        /// <summary>Sets the data finalizare.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="dataFinalizare">The data finalizare.</param>
        public void SetDataFinalizare(int id, string dataFinalizare)
        {
            _context.Comenzi.First(c => c.ComandaId == id).DataFinalizare = DateTime.Parse(dataFinalizare);
        }
        
        /// <inheritdoc />
        /// <summary>Sets the stare comanda.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="stareComanda">The stare comanda.</param>
        public void SetStareComanda(int id, StareComanda stareComanda)
        {
            _context.Comenzi.First(c => c.ComandaId == id).StareComanda = stareComanda;
        }
        
        /// <inheritdoc />
        /// <summary>Sets the descriere.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="descriere">The descriere.</param>
        public void SetDescriere(int id, string descriere)
        {
            _context.Comenzi.First(c => c.ComandaId == id).Descriere = descriere;
        }
    }
}
