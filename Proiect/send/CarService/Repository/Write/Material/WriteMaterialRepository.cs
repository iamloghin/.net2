using System.Data.Entity.Migrations;

namespace CarService.Repository.Write.Material
{
    using System;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class WriteMaterialRepository.
    /// Implements the <see cref="IWriteMaterialRepository" />
    /// </summary>
    /// <seealso cref="IWriteMaterialRepository" />
    internal class WriteMaterialRepository: IWriteMaterialRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteMaterialRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteMaterialRepository(CarServiceModelContainer context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Creates the specified material.
        /// </summary>
        /// <param name="material">The material.</param>
        public void Create(CarService.Material material)
        {
            _context.Materiale.Add(material);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(Guid id)
        {
            var material = _context.Materiale.First(m => m.Id == id);
            _context.Materiale.Remove(material);
        }

        public void Update(CarService.Material material)
        {
            _context.Materiale.AddOrUpdate(material);
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(Guid id)
        {
            return _context.Materiale.Any(m => m.Id == id);
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
        /// <summary>Sets the cantitate.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="cantitate">The cantitate.</param>
        public void SetCantitate(Guid id, decimal cantitate)
        {
            _context.Materiale.First(m => m.Id == id).Cantitate = cantitate;
        }
        
        /// <inheritdoc />
        /// <summary>Sets the pret.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="pret">The pret.</param>
        public void SetPret(Guid id, decimal pret)
        {
            _context.Materiale.First(m => m.Id == id).Pret = pret;
        }
        
        /// <inheritdoc />
        /// <summary>Sets the data aprovizionare.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="dataAprovizionare">The data aprovizionare.</param>
        public void SetDataAprovizionare(Guid id, string dataAprovizionare)
        {
            _context.Materiale.First(m => m.Id == id).DataAprovizionare = DateTime.Parse(dataAprovizionare);
        }
    }
}
