﻿using System;

namespace ServiceAutoLibrary.Repository.Read.Material
{
    internal interface IReadMaterialRepository: IReadRepository<ServiceAutoLibrary.Material>
    {
        /// <summary>
        /// Gets the denumire.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the material denumire.</returns>
        string GetDenumire(int id);

        /// <summary>
        /// Gets the cantitate.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A decimal that represents the cantitate.</returns>
        decimal GetCantitate(int id);

        /// <summary>
        /// Gets the pret.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A deciaml that represents the pret.</returns>
        decimal GetPret(int id);

        /// <summary>
        /// Gets the data aprovizionare.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the data aprovizionare.</returns>
        DateTime GetDataAprovizionare(int id);
    }
}
