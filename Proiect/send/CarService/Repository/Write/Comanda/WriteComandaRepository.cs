using System.Data.Entity.Migrations;

namespace CarService.Repository.Write.Comanda
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
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteComandaRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteComandaRepository(CarServiceModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Creates the specified comanda.
        /// </summary>
        /// <param name="comanda">The comanda.</param>
        public void Create(CarService.Comanda comanda)
        {
            _context.Comenzi.Add(comanda);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(Guid id)
        {
            var comanda = _context.Comenzi.First(c => c.Id == id);
            _context.Comenzi.Remove(comanda);
        }

        public void Update(CarService.Comanda comanda)
        {
            _context.Comenzi.AddOrUpdate(comanda);
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(Guid id)
        {
            return _context.Comenzi.Any(c => c.Id == id);
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
        public void SetDataFinalizare(Guid id, string dataFinalizare)
        {
            _context.Comenzi.First(c => c.Id == id).DataFinalizare = DateTime.Parse(dataFinalizare);
        }
        
        /// <inheritdoc />
        /// <summary>Sets the stare comanda.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="stareComanda">The stare comanda.</param>
        public void SetStareComanda(Guid id, StareComanda stareComanda)
        {
            _context.Comenzi.First(c => c.Id == id).StareComanda = stareComanda;
        }
        
        /// <inheritdoc />
        /// <summary>Sets the descriere.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="descriere">The descriere.</param>
        public void SetDescriere(Guid id, string descriere)
        {
            _context.Comenzi.First(c => c.Id == id).Descriere = descriere;
        }
    }
}
