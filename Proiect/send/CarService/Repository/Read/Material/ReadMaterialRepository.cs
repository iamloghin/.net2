namespace CarService.Repository.Read.Material
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Material = CarService.Material;

    /// <summary>
    /// Class ReadMaterialRepository.
    /// Implements the <see cref="IReadMaterialRepository" />
    /// </summary>
    /// <seealso cref="IReadMaterialRepository" />
    internal class ReadMaterialRepository: IReadMaterialRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadMaterialRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadMaterialRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Material.</returns>
        public CarService.Material GetById(Guid id)
        {
            return !Exists(id) ? null : _context.Materiale.FirstOrDefault(m => m.Id == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;Materiale&gt;.</returns>
        public IReadOnlyList<Material> GetAll()
        {
            return _context.Materiale.ToList();
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
        /// Gets the denumire.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the material denumire.</returns>
        public string GetDenumire(Guid id)
        {
            return !Exists(id) ? null : _context.Materiale.FirstOrDefault(m => m.Id == id)?.Denumire;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the cantitate.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A decimal that represents the cantitate.</returns>
        public decimal GetCantitate(Guid id)
        {
            return _context.Materiale.FirstOrDefault(m => m.Id == id).Cantitate;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the pret.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A deciaml that represents the pret.</returns>
        public decimal GetPret(Guid id)
        {
            return _context.Materiale.FirstOrDefault(m => m.Id == id).Pret;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the data aprovizionare.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data aprovizionare.</returns>
        public DateTime GetDataAprovizionare(Guid id)
        {
            return _context.Materiale.FirstOrDefault(m => m.Id == id).DataAprovizionare;
        }

        public IList<Material> GetAvailables()
        {
            var allMaterials = _context.Materiale.ToList();
            var availableMaterials = new List<Material>();

            foreach (var material in allMaterials)
            {
                if (material.Cantitate > 0)
                {
                    availableMaterials.Add(material);
                }
            }

            return availableMaterials;
        }
    }
}
