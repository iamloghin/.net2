using System;

namespace CarService.Repository.Read.Operatie
{
    /// <inheritdoc />
    /// <summary>
    /// Interface IReadOperatieRepository
    /// Implements the <see cref="!:CarService.Repository.Read.IReadRepository{CarService.Operatie}" />
    /// </summary>
    /// <seealso cref="!:CarService.Repository.Read.IReadRepository{CarService.Operatie}" />
    internal interface IReadOperatieRepository: IReadRepository<CarService.Operatie>
    {
        /// <summary>
        /// Gets the denumire.
        /// </summary>
        /// <param name="id">The operatie identifier.</param>
        /// <returns>A string that represents operatie denumire.</returns>
        string GetDenumire(Guid id);

        /// <summary>
        /// Gets the timp executie.
        /// </summary>
        /// <param name="id">The operatie identifier.</param>
        /// <returns>A string that represents timp executie</returns>
        decimal? GetTimpExecutie(Guid id);
    }
}
