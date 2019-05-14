namespace ServiceAutoLibrary.Repository.Read.DetaliuComanda
{
    using System.Collections.Generic;

    /// <inheritdoc />
    /// <summary>
    /// Interface IReadDetaliuComandaRepository
    /// Implements the <see cref="!:ServiceAutoLibrary.Repository.Read.IReadRepository{ServiceAutoLibrary.DetaliuComanda}" />
    /// </summary>
    /// <seealso cref="!:ServiceAutoLibrary.Repository.Read.IReadRepository{ServiceAutoLibrary.DetaliuComanda}" />
    internal interface IReadDetaliuComandaRepository: IReadRepository<ServiceAutoLibrary.DetaliuComanda>
    {
        /// <summary>
        /// Gets the comanda.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The Comanda.</returns>
        ServiceAutoLibrary.Comanda GetComanda(int id);

        /// <summary>
        /// Gets the mecanics.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;ServiceAutoLibrary.Mecanic&gt;.</returns>
        ICollection<ServiceAutoLibrary.Mecanic> GetMecanics(int id);
        /// <summary>
        /// Gets the materials.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;ServiceAutoLibrary.Material&gt;.</returns>
        ICollection<ServiceAutoLibrary.Material> GetMaterials(int id);
        /// <summary>
        /// Operatieses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;ServiceAutoLibrary.Operatie&gt;.</returns>
        ICollection<ServiceAutoLibrary.Operatie> Operaties(int id);

        /// <summary>
        /// Imagineses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;ServiceAutoLibrary.Imagine&gt;.</returns>
        ICollection<ServiceAutoLibrary.Imagine> Imagines(int id);
    }
}
