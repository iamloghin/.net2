namespace CarService.Repository.Read.DetaliuComanda
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Comanda = CarService.Comanda;
    using DetaliuComanda = CarService.DetaliuComanda;
    using Imagine = CarService.Imagine;
    using Material = CarService.Material;
    using Mecanic = CarService.Mecanic;
    using Operatie = CarService.Operatie;

    /// <inheritdoc />
    /// <summary>
    /// Class ReadDetaliuComandaRepository.
    /// Implements the <see cref="IReadDetaliuComandaRepository" />
    /// </summary>
    /// <seealso cref="IReadDetaliuComandaRepository" />
    internal class ReadDetaliuComandaRepository: IReadDetaliuComandaRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadDetaliuComandaRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadDetaliuComandaRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The DetaliuComanda.</returns>
        public DetaliuComanda GetById(Guid id)
        {
            return !Exists(id) ? null : _context.DetaliiComanda.FirstOrDefault(c => c.Id == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;DetaliiComanda&gt;.</returns>
        public IReadOnlyList<DetaliuComanda> GetAll()
        {
            return _context.DetaliiComanda.ToList();
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(Guid id)
        {
            return _context.DetaliiComanda.Any(c => c.Id == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the comanda.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The Comanda.</returns>
        public Comanda GetComanda(Guid id)
        {
            return !Exists(id) ? null : _context.Comenzi.FirstOrDefault(c => c.Id == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the Mecanici.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;CarService.Mecanic&gt;.</returns>
        public ICollection<Mecanic> GetMecanics(Guid id)
        {
            return !Exists(id) ? null : _context.DetaliiComanda.FirstOrDefault(c => c.Id == id)?.Mecanici;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the materials.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;CarService.Material&gt;.</returns>
        public ICollection<Material> GetMaterials(Guid id)
        {
            return !Exists(id) ? null : _context.DetaliiComanda.FirstOrDefault(c => c.Id == id)?.Materials;
        }

        /// <inheritdoc />
        /// <summary>
        /// Operatieses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;CarService.Operatie&gt;.</returns>
        public ICollection<Operatie> Operaties(Guid id)
        {
            return !Exists(id) ? null : _context.DetaliiComanda.FirstOrDefault(c => c.Id == id)?.Operaties;
        }

        /// <inheritdoc />
        /// <summary>
        /// Imagineses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;CarService.Imagine&gt;.</returns>
        public ICollection<Imagine> Imagines(Guid id)
        {
            return !Exists(id) ? null : _context.DetaliiComanda.FirstOrDefault(c => c.Id == id)?.Imagines;
        }
    }
}
