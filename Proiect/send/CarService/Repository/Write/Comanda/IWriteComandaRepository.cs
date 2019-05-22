namespace CarService.Repository.Write.Comanda
{
    using System;

    using Comanda = CarService.Comanda;

    /// <inheritdoc />
    /// <summary>
    /// Interface IWriteComandaRepository
    /// Implements the <see cref="Comanda" />
    /// </summary>
    /// <seealso cref="Comanda" />
    internal interface IWriteComandaRepository: IWriteRepository<Comanda>
    {
        /// <summary>
        /// Sets the data finalizare.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataFinalizare">The data finalizare.</param>
        void SetDataFinalizare(Guid id, string dataFinalizare);

        /// <summary>
        /// Sets the stare comanda.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="stareComanda">The stare comanda.</param>
        void SetStareComanda(Guid id, StareComanda stareComanda);

        /// <summary>
        /// Sets the descriere.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descriere">The descriere.</param>
        void SetDescriere(Guid id, string descriere);
    }
}
