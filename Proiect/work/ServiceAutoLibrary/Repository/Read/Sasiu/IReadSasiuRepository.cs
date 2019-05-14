namespace ServiceAutoLibrary.Repository.Read.Sasiu
{
    /// <inheritdoc />
    /// <summary>
    /// Interface IReadSasiuRepository
    /// Implements the <see cref="!:ServiceAutoLibrary.Repository.Read.IReadRepository{ServiceAutoLibrary.Sasiu}" />
    /// </summary>
    /// <seealso cref="!:ServiceAutoLibrary.Repository.Read.IReadRepository{ServiceAutoLibrary.Sasiu}" />
    internal interface IReadSasiuRepository: IReadRepository<ServiceAutoLibrary.Sasiu>
    {
        /// <summary>
        /// Gets the cod sasiu.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the cod sasiu.</returns>
        string GetCodSasiu(int id);

        /// <summary>
        /// Gets the denumire.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the sasiu denumire.</returns>
        string GetDenumire(int id);
    }
}
