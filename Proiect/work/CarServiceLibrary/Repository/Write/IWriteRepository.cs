﻿namespace ServiceAutoLibrary.Repository.Write
{
    /// <summary>
    /// Interface IWriteRepository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface IWriteRepository<in T>
    {
        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Create(T entity);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        void Delete(int id);

        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool Exists(int id);

        /// <summary>
        /// Saves the changes.
        /// </summary>
        void SaveChanges();
    }
}
