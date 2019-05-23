namespace ServiceAutoLibrary.Repository.Read.Operatie
{
    /// <inheritdoc />
    /// <summary>
    /// Interface IReadOperatieRepository
    /// Implements the <see cref="!:ServiceAutoLibrary.Repository.Read.IReadRepository{ServiceAutoLibrary.Operatie}" />
    /// </summary>
    /// <seealso cref="!:ServiceAutoLibrary.Repository.Read.IReadRepository{ServiceAutoLibrary.Operatie}" />
    internal interface IReadOperatieRepository: IReadRepository<ServiceAutoLibrary.Operatie>
    {
        /// <summary>
        /// Gets the denumire.
        /// </summary>
        /// <param name="id">The operatie identifier.</param>
        /// <returns>A string that represents operatie denumire.</returns>
        string GetDenumire(int id);

        /// <summary>
        /// Gets the timp executie.
        /// </summary>
        /// <param name="id">The operatie identifier.</param>
        /// <returns>A string that represents timp executie</returns>
        decimal GetTimpExecutie(int id);
    }
}
