namespace CarService.Repository.Read.Comanda
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// Interface IReadComandaRepository
    /// Implements the <see cref="!:CarService.Repository.Read.IReadRepository{CarService.Comanda}" />
    /// </summary>
    /// <seealso cref="!:CarService.Repository.Read.IReadRepository{CarService.Comanda}" />
    internal interface IReadComandaRepository: IReadRepository<CarService.Comanda>
    {
        /// <summary>
        /// Gets the stare comanda.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the stare comanda.</returns>
        string GetStareComanda(Guid id);

        /// <summary>
        /// Gets the data system.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data system</returns>
        DateTime GetDataSystem(Guid id);

        /// <summary>
        /// Gets the data programare.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data programare.</returns>
        DateTime GetDataProgramare(Guid id);

        /// <summary>
        /// Gets the data finalizare.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data finalizare.</returns>
        DateTime? GetDataFinalizare(Guid id);

        /// <summary>
        /// Gets the km board.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>An Guideger that represents the km auto board.</returns>
        int? GetKmBoard(Guid id);

        /// <summary>
        /// Gets the descriere.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the comanda descriere.</returns>
        string GetDescriere(Guid id);

        /// <summary>
        /// Gets the valoare piese.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A decimal that represents the valoare piese.</returns>
        decimal? GetValoarePiese(Guid id);
    }
}
