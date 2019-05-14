using System;

namespace CarService.Repository.Read.Sasiu
{
    /// <inheritdoc />
    /// <summary>
    /// Interface IReadSasiuRepository
    /// Implements the <see cref="!:CarService.Repository.Read.IReadRepository{CarService.Sasiu}" />
    /// </summary>
    /// <seealso cref="!:CarService.Repository.Read.IReadRepository{CarService.Sasiu}" />
    internal interface IReadSasiuRepository: IReadRepository<CarService.Sasiu>
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
