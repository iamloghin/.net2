using System;

namespace CarService.Repository.Read.DetaliuComanda
{
    using System.Collections.Generic;

    /// <inheritdoc />
    /// <summary>
    /// Interface IReadDetaliuComandaRepository
    /// Implements the <see cref="!:CarService.Repository.Read.IReadRepository{CarService.DetaliuComanda}" />
    /// </summary>
    /// <seealso cref="!:CarService.Repository.Read.IReadRepository{CarService.DetaliuComanda}" />
    internal interface IReadDetaliuComandaRepository: IReadRepository<CarService.DetaliuComanda>
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
        ICollection<CarService.Mecanic> GetMecanics(Guid id);
        /// <summary>
        /// Gets the materials.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;CarService.Material&gt;.</returns>
        ICollection<CarService.Material> GetMaterials(Guid id);
        /// <summary>
        /// Operatieses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;CarService.Operatie&gt;.</returns>
        ICollection<CarService.Operatie> Operaties(Guid id);

        /// <summary>
        /// Imagineses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;CarService.Imagine&gt;.</returns>
        ICollection<CarService.Imagine> Imagines(Guid id);
    }
}
