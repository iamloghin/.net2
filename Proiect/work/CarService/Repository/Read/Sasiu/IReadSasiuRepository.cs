namespace CarService.Repository.Read.Sasiu
{
    using System;

    using Sasiu = CarService.Sasiu;

    /// <inheritdoc />
    /// <summary>
    /// Interface IReadSasiuRepository
    /// Implements the <see cref="Sasiu" />
    /// </summary>
    /// <seealso cref="Sasiu" />
    internal interface IReadSasiuRepository: IReadRepository<Sasiu>
    {
        /// <summary>
        /// Gets the cod sasiu.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the cod sasiu.</returns>
        string GetCodSasiu(Guid id);

        /// <summary>
        /// Gets the denumire.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the sasiu denumire.</returns>
        string GetDenumire(Guid id);
    }
}
