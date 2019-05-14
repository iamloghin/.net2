using System;

namespace CarService.Repository.Write.Material
{
    /// <inheritdoc />
    /// <summary>
    /// Interface IWriteMaterialRepository
    /// Implements the <see cref="Material" />
    /// </summary>
    /// <seealso cref="Material" />
    internal interface IWriteMaterialRepository: IWriteRepository<CarService.Material>
    {
        /// <summary>
        /// Sets the cantitate.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cantitate">The cantitate.</param>
        void SetCantitate(Guid id, decimal cantitate);

        /// <summary>
        /// Sets the pret.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pret">The pret.</param>
        void SetPret(Guid id, decimal pret);

        /// <summary>
        /// Sets the data aprovizionare.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataAprovizionare">The data aprovizionare.</param>
        void SetDataAprovizionare(Guid id, string dataAprovizionare);
    }
}
