namespace CarService.Repository.Read.Operatie
{
    using System;

    using Operatie = CarService.Operatie;

    /// <inheritdoc />
    /// <summary>
    /// Interface IReadOperatieRepository
    /// Implements the <see cref="Operatie" />
    /// </summary>
    /// <seealso cref="Operatie" />
    internal interface IReadOperatieRepository: IReadRepository<Operatie>
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
