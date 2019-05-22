namespace CarService.Repository.Read.Auto
{
    using System;
    using System.Collections.Generic;

    using Auto = CarService.Auto;

    /// <inheritdoc />
    /// <summary>
    /// Interface IReadAutoRepository
    /// Implements the <see cref="Auto" />
    /// </summary>
    /// <seealso cref="Auto" />
    internal interface IReadAutoRepository : IReadRepository<Auto>
    {
        /// <summary>
        /// Gets the numar automatic.
        /// </summary>
        /// <param name="id">The auto identifier.</param>
        /// <returns>A string that represents the numar auto.</returns>
        string GetNumarAuto(Guid id);

        /// <summary>
        /// Gets the serie sasiu.
        /// </summary>
        /// <param name="id">The auto identifier id.</param>
        /// <returns>A string that represents the serie sasiu.</returns>
        string GetSerieSasiu(Guid id);

        /// <summary>
        /// Gets the automatic client.
        /// </summary>
        /// <param name="id">The client identifier.</param>
        /// <returns>The auto Client</returns>
        IList<Auto> GetAutoByClient(Guid id);
    }
}
