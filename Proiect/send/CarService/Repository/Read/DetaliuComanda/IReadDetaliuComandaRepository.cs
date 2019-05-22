namespace CarService.Repository.Read.DetaliuComanda
{
    using System;
    using System.Collections.Generic;

    using DetaliuComanda = CarService.DetaliuComanda;
    using Imagine = CarService.Imagine;
    using Material = CarService.Material;
    using Mecanic = CarService.Mecanic;
    using Operatie = CarService.Operatie;

    /// <inheritdoc />
    /// <summary>
    /// Interface IReadDetaliuComandaRepository
    /// Implements the <see cref="DetaliuComanda" />
    /// </summary>
    /// <seealso cref="DetaliuComanda" />
    internal interface IReadDetaliuComandaRepository: IReadRepository<DetaliuComanda>
    {
        /// <summary>
        /// Gets the comanda.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The Comanda.</returns>
        CarService.Comanda GetComanda(Guid id);

        /// <summary>
        /// Gets the Mecanici.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;CarService.Mecanic&gt;.</returns>
        ICollection<Mecanic> GetMecanics(Guid id);
        /// <summary>
        /// Gets the materials.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;CarService.Material&gt;.</returns>
        ICollection<Material> GetMaterials(Guid id);
        /// <summary>
        /// Operatieses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;CarService.Operatie&gt;.</returns>
        ICollection<Operatie> Operaties(Guid id);

        /// <summary>
        /// Imagineses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;CarService.Imagine&gt;.</returns>
        ICollection<Imagine> Imagines(Guid id);
    }
}
