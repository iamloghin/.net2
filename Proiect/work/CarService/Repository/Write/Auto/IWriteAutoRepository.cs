namespace CarService.Repository.Write.Auto
{
    using System;

    using Auto = CarService.Auto;

    /// <inheritdoc />
    /// <summary>
    /// Interface IWriteAutoRepository
    /// Implements the <see cref="Auto" />
    /// </summary>
    /// <seealso cref="Auto" />
    internal interface IWriteAutoRepository: IWriteRepository<Auto>
    {
        /// <summary>
        /// Sets the numar automatic.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="numarAuto">The numar automatic.</param>
        void SetNumarAuto(Guid id, string numarAuto);

        /// <summary>
        /// Sets the serie sasiu.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="serieSasiu">The serie sasiu.</param>
        void SetSerieSasiu(Guid id, string serieSasiu);
    }
}
