namespace CarService.Repository.Write.Imagine
{
    using System;
    using System.Linq;
    using System.Data.Entity.Migrations;

    using Imagine = CarService.Imagine;

    /// <inheritdoc />
    /// <summary>
    /// Class WriteImagineRepository.
    /// Implements the <see cref="IWriteImagineRepository" />
    /// </summary>
    /// <seealso cref="IWriteImagineRepository" />
    internal class WriteImagineRepository: IWriteImagineRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteImagineRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WriteImagineRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates the specified imagine.
        /// </summary>
        /// <param name="imagine">The imagine.</param>
        public void Create(Imagine imagine)
        {
            _context.Imagini.Add(imagine);
        }

        /// <inheritdoc />
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(Guid id)
        {
            var imagine = _context.Imagini.First(i => i.Id == id);
            _context.Imagini.Remove(imagine);
        }

        public void Update(Imagine imagine)
        {
            _context.Imagini.AddOrUpdate(imagine);
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(Guid id)
        {
            return _context.Imagini.Any(i => i.Id == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Saves the changes.
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
