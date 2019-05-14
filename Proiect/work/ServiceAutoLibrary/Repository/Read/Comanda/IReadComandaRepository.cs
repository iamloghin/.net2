namespace ServiceAutoLibrary.Repository.Read.Comanda
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// Interface IReadComandaRepository
    /// Implements the <see cref="!:ServiceAutoLibrary.Repository.Read.IReadRepository{ServiceAutoLibrary.Comanda}" />
    /// </summary>
    /// <seealso cref="!:ServiceAutoLibrary.Repository.Read.IReadRepository{ServiceAutoLibrary.Comanda}" />
    internal interface IReadComandaRepository: IReadRepository<ServiceAutoLibrary.Comanda>
    {
        /// <summary>
        /// Gets the stare comanda.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the stare comanda.</returns>
        string GetStareComanda(int id);

        /// <summary>
        /// Gets the data system.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data system</returns>
        DateTime GetDataSystem(int id);

        /// <summary>
        /// Gets the data programare.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data programare.</returns>
        DateTime GetDataProgramare(int id);

        /// <summary>
        /// Gets the data finalizare.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data finalizare.</returns>
        DateTime GetDataFinalizare(int id);

        /// <summary>
        /// Gets the km board.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>An integer that represents the km auto board.</returns>
        int GetKmBoard(int id);

        /// <summary>
        /// Gets the descriere.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the comanda descriere.</returns>
        string GetDescriere(int id);

        /// <summary>
        /// Gets the valoare piese.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A decimal that represents the valoare piese.</returns>
        decimal GetValoarePiese(int id);
    }
}
