namespace CarService.Repository.Read.Mecanic
{
    using System;
    using System.Collections.Generic;

    using Mecanic = CarService.Mecanic;

    /// <inheritdoc />
    /// <summary>
    /// Interface IReadMecanicRepository
    /// Implements the <see cref="Mecanic" />
    /// </summary>
    /// <seealso cref="Mecanic" />
    internal interface IReadMecanicRepository: IReadRepository<Mecanic>
    {
        /// <summary>
        /// Gets the nume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents mecanic nume.</returns>
        string GetNume(Guid id);

        /// <summary>
        /// Gets the prenume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents mecanic prenume.</returns>
        string GetPrenume(Guid id);

        /// <summary>
        /// Gets the available mecanics.
        /// </summary>
        /// <returns>A list of available mecanics.</returns>
        List<Mecanic> GetAvailables();
    }
}
