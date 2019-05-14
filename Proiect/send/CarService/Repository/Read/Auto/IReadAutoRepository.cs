namespace CarService.Repository.Read.Auto
{
    using System;
    using System.Collections.Generic;

    /// <inheritdoc />
    /// <summary>
    /// Interface IReadAutoRepository
    /// Implements the <see cref="!:CarService.Repository.Read.IReadRepository{CarService.Auto}" />
    /// </summary>
    /// <seealso cref="!:CarService.Repository.Read.IReadRepository{CarService.Auto}" />
    internal interface IReadAutoRepository : IReadRepository<CarService.Auto>
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
        IList<CarService.Auto> GetAutoByClient(Guid id);
    }
}
