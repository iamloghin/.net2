namespace ServiceAutoLibrary.Repository.Read.Mecanic
{
    /// <inheritdoc />
    /// <summary>
    /// Interface IReadMecanicRepository
    /// Implements the <see cref="!:ServiceAutoLibrary.Repository.Read.IReadRepository{ServiceAutoLibrary.Mecanic}" />
    /// </summary>
    /// <seealso cref="!:ServiceAutoLibrary.Repository.Read.IReadRepository{ServiceAutoLibrary.Mecanic}" />
    internal interface IReadMecanicRepository: IReadRepository<ServiceAutoLibrary.Mecanic>
    {
        /// <summary>
        /// Gets the nume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents mecanic nume.</returns>
        string GetNume(int id);

        /// <summary>
        /// Gets the prenume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents mecanic prenume.</returns>
        string GetPrenume(int id);
    }
}
