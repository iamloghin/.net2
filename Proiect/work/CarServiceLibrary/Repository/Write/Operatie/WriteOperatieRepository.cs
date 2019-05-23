namespace ServiceAutoLibrary.Repository.Write.Operatie
{
    using System.Linq;
            
    /// <inheritdoc />
    /// <summary>
    /// Class WriteOperatieRepository.
    /// Implements the <see cref="IWriteOperatieRepository" />
    /// </summary>
    /// <seealso cref="IWriteOperatieRepository" />
    internal class WriteOperatieRepository: IWriteOperatieRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteOperatieRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteOperatieRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Creates the specified operate.
        /// </summary>
        /// <param name="operate">The operate.</param>
        public void Create(ServiceAutoLibrary.Operatie operate)
        {
            _context.Operatii.Add(operate);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            var operate = _context.Operatii.First(o => o.OperatieId == id);
            _context.Operatii.Remove(operate);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(int id)
        {
            return _context.Operatii.Any(o => o.OperatieId == id);
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
        /// <summary>Sets the timp executie.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="timpExecutie">The timp executie.</param>
        public void SetTimpExecutie(int id, decimal timpExecutie)
        {
            _context.Operatii.First(o => o.OperatieId == id).TimpExecutie = timpExecutie;
        }

        /// <inheritdoc />
        /// <summary>Sets the denumire.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="denumire">The denumire.</param>
        public void SetDenumire(int id, string denumire)
        {
            _context.Operatii.First(o => o.OperatieId == id).Denumire = denumire;
        }
    }
}
