namespace ServiceAutoLibrary.Repository.Read
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface IReadRepository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface IReadRepository<out T>
    {
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>T.</returns>
        T GetById(int id);
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;T&gt;.</returns>
        IReadOnlyList<T> GetAll();
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool Exists(int id);
    }
}
