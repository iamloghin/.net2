namespace ServiceAutoLibrary.Repository.Write.Comanda
{
    /// <inheritdoc />
    /// <summary>
    /// Interface IWriteComandaRepository
    /// Implements the <see cref="Write.IWriteRepository{ServiceAutoLibrary.Comanda}" />
    /// </summary>
    /// <seealso cref="Write.IWriteRepository{ServiceAutoLibrary.Comanda}" />
    internal interface IWriteComandaRepository: IWriteRepository<ServiceAutoLibrary.Comanda>
    {
        /// <summary>
        /// Sets the data finalizare.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataFinalizare">The data finalizare.</param>
        void SetDataFinalizare(int id, string dataFinalizare);

        /// <summary>
        /// Sets the stare comanda.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="stareComanda">The stare comanda.</param>
        void SetStareComanda(int id, StareComanda stareComanda);

        /// <summary>
        /// Sets the descriere.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descriere">The descriere.</param>
        void SetDescriere(int id, string descriere);
    }
}
