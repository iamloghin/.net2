namespace ServiceAutoLibrary.Repository.Write.Operatie
{
    /// <inheritdoc />
    /// <summary>
    /// Interface IWriteOperatieRepository
    /// Implements the <see cref="!:ServiceAutoLibrary.Repository.Write.IWriteRepository{ServiceAutoLibrary.Operatie}" />
    /// </summary>
    /// <seealso cref="!:ServiceAutoLibrary.Repository.Write.IWriteRepository{ServiceAutoLibrary.Operatie}" />
    internal interface IWriteOperatieRepository: IWriteRepository<ServiceAutoLibrary.Operatie>
    {
        /// <summary>
        /// Sets the timp executie.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="timpExecutie">The timp executie.</param>
        void SetTimpExecutie(int id, decimal timpExecutie);

        /// <summary>
        /// Sets the denumire.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="denumire">The denumire.</param>
        void SetDenumire(int id, string denumire);
    }
}
