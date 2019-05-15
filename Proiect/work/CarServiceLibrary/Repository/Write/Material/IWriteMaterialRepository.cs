namespace ServiceAutoLibrary.Repository.Write.Material
{
    /// <inheritdoc />
    /// <summary>
    /// Interface IWriteMaterialRepository
    /// Implements the <see cref="Write.IWriteRepository{ServiceAutoLibrary.Material}" />
    /// </summary>
    /// <seealso cref="Write.IWriteRepository{ServiceAutoLibrary.Material}" />
    internal interface IWriteMaterialRepository: IWriteRepository<ServiceAutoLibrary.Material>
    {
        /// <summary>
        /// Sets the cantitate.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cantitate">The cantitate.</param>
        void SetCantitate(int id, decimal cantitate);

        /// <summary>
        /// Sets the pret.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pret">The pret.</param>
        void SetPret(int id, decimal pret);

        /// <summary>
        /// Sets the data aprovizionare.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataAprovizionare">The data aprovizionare.</param>
        void SetDataAprovizionare(int id, string dataAprovizionare);
    }
}
