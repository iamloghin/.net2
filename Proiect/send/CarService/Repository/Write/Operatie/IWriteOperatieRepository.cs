using System;

namespace CarService.Repository.Write.Operatie
{
    /// <inheritdoc />
    /// <summary>
    /// Interface IWriteOperatieRepository
    /// Implements the <see cref="!:CarService.Repository.Write.IWriteRepository{CarService.Operatie}" />
    /// </summary>
    /// <seealso cref="!:CarService.Repository.Write.IWriteRepository{CarService.Operatie}" />
    internal interface IWriteOperatieRepository: IWriteRepository<CarService.Operatie>
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
