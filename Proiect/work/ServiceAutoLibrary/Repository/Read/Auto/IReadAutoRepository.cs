using System.Collections.Generic;

namespace ServiceAutoLibrary.Repository.Read.Auto
{
    /// <inheritdoc />
    /// <summary>
    /// Interface IReadAutoRepository
    /// Implements the <see cref="!:ServiceAutoLibrary.Repository.Read.IReadRepository{ServiceAutoLibrary.Auto}" />
    /// </summary>
    /// <seealso cref="!:ServiceAutoLibrary.Repository.Read.IReadRepository{ServiceAutoLibrary.Auto}" />
    internal interface IReadAutoRepository : IReadRepository<ServiceAutoLibrary.Auto>
    {
        /// <summary>
        /// Gets the numar automatic.
        /// </summary>
        /// <param name="id">The auto identifier.</param>
        /// <returns>A string that represents the numar auto.</returns>
        string GetNumarAuto(int id);

        /// <summary>
        /// Gets the serie sasiu.
        /// </summary>
        /// <param name="id">The auto identifier id.</param>
        /// <returns>A string that represents the serie sasiu.</returns>
        string GetSerieSasiu(int id);

        /// <summary>
        /// Gets the automatic client.
        /// </summary>
        /// <param name="id">The client identifier.</param>
        /// <returns>The auto Client</returns>
        IList<ServiceAutoLibrary.Auto> GetAutoByClient(int id);
    }
}
