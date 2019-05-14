using System;

namespace CarService.Repository.Read.Mecanic
{
    /// <inheritdoc />
    /// <summary>
    /// Interface IReadMecanicRepository
    /// Implements the <see cref="!:CarService.Repository.Read.IReadRepository{CarService.Mecanic}" />
    /// </summary>
    /// <seealso cref="!:CarService.Repository.Read.IReadRepository{CarService.Mecanic}" />
    internal interface IReadMecanicRepository: IReadRepository<CarService.Mecanic>
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
    }
}
