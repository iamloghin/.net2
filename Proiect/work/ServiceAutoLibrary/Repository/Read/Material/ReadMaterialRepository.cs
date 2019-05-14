namespace ServiceAutoLibrary.Repository.Read.Material
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class ReadMaterialRepository.
    /// Implements the <see cref="IReadMaterialRepository" />
    /// </summary>
    /// <seealso cref="IReadMaterialRepository" />
    internal class ReadMaterialRepository: IReadMaterialRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadMaterialRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadMaterialRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Material.</returns>
        public ServiceAutoLibrary.Material GetById(int id)
        {
            return _context.Materiale.FirstOrDefault(m => m.MaterialId == id);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;Materiale&gt;.</returns>
        public IReadOnlyList<ServiceAutoLibrary.Material> GetAll()
        {
            return _context.Materiale.ToList();
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(int id)
        {
            return _context.Materiale.Any(m => m.MaterialId == id);
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets the denumire.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the material denumire.</returns>
        public string GetDenumire(int id)
        {
            return _context.Materiale.FirstOrDefault(m => m.MaterialId == id)?.Denumire;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets the cantitate.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A decimal that represents the cantitate.</returns>
        public decimal GetCantitate(int id)
        {
            return _context.Materiale.FirstOrDefault(m => m.MaterialId == id).Cantitate;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets the pret.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A deciaml that represents the pret.</returns>
        public decimal GetPret(int id)
        {
            return _context.Materiale.FirstOrDefault(m => m.MaterialId == id).Pret;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets the data aprovizionare.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data aprovizionare.</returns>
        public DateTime GetDataAprovizionare(int id)
        {
            return _context.Materiale.FirstOrDefault(m => m.MaterialId == id).DataAprovizionare;
        }
    }
}
