using System;

namespace ServiceAutoLibrary.Repository.Read.Imagine
{
    internal interface IReadImagineRepository: IReadRepository<ServiceAutoLibrary.Imagine>
    {
        /// <summary>
        /// Gets the titlu.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the imagine titlu.</returns>
        string GetTitlu(int id);

        /// <summary>
        /// Gets the descriere.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the imagine descriere.</returns>
        string GetDescriere(int id);

        /// <summary>
        /// Gets the imagine data.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A date time that represents the imagine date.</returns>
        DateTime GetImagineData(int id);

        /// <summary>
        /// Gets the foto.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The Foto.</returns>
        byte[] GetFoto(int id);
    }
}
