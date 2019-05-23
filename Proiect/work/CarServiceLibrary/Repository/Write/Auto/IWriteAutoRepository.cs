namespace ServiceAutoLibrary.Repository.Write.Auto
{
    
    /// <inheritdoc />
    /// <summary>
    /// Interface IWriteAutoRepository
    /// Implements the <see cref="Write.IWriteRepository{ServiceAutoLibrary.Auto}" />
    /// </summary>
    /// <seealso cref="Write.IWriteRepository{ServiceAutoLibrary.Auto}" />
    internal interface IWriteAutoRepository: IWriteRepository<ServiceAutoLibrary.Auto>
    {
        /// <summary>
        /// Sets the numar automatic.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="numarAuto">The numar automatic.</param>
        void SetNumarAuto(int id, string numarAuto);

        /// <summary>
        /// Sets the serie sasiu.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="serieSasiu">The serie sasiu.</param>
        void SetSerieSasiu(int id, string serieSasiu);
    }
}
