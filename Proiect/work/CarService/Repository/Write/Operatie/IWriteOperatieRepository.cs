namespace CarService.Repository.Write.Operatie
{
    using System;
    using Operatie = CarService.Operatie;

    /// <inheritdoc />
    /// <summary>
    /// Interface IWriteOperatieRepository
    /// Implements the <see cref="Operatie" />
    /// </summary>
    /// <seealso cref="Operatie" />
    internal interface IWriteOperatieRepository: IWriteRepository<Operatie>
    {
        /// <summary>
        /// Sets the timp executie.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="timpExecutie">The timp executie.</param>
        void SetTimpExecutie(Guid id, decimal timpExecutie);

        /// <summary>
        /// Sets the denumire.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="denumire">The denumire.</param>
        void SetDenumire(Guid id, string denumire);
    }
}
