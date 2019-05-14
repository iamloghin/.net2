using System;

namespace CarService.Repository.Read.Client
{
    using System.Collections.Generic;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class ReadClientRepository.
    /// Implements the <see cref="T:CarService.Repository.Read.Client.IReadClientRepository" />
    /// </summary>
    /// <seealso cref="T:CarService.Repository.Read.Client.IReadClientRepository" />
    internal class ReadClientRepository: IReadClientRepository
    {
        private readonly CarServiceModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadClientRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadClientRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The Client.</returns>
        public CarService.Client GetById(Guid id)
        {
            return !Exists(id) ? null : _context.Clienti.FirstOrDefault(c => c.Id == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;The Clients&gt;.</returns>
        public IReadOnlyList<CarService.Client> GetAll()
        {
            return _context.Clienti.ToList();
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(Guid id)
        {
            return _context.Clienti.Any(c => c.Id == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="email">The identifier.</param>
        /// <returns>The Client.</returns>
        public CarService.Client GetByEmail(string email)
        {
            return _context.Clienti.Any(a => a.Email.Equals(email)) ? _context.Clienti.FirstOrDefault(c => c.Email.Equals(email)) : null;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="serieSaius">The identifier.</param>
        /// <returns>The Client.</returns>
        public CarService.Client GetBySerieSasiu(string serieSaius)
        {
            if (!_context.Autos.Any(a => a.SerieSasiu.Equals(serieSaius))) return null;
            
            var auto = _context.Autos.FirstOrDefault(a => a.SerieSasiu.Equals(serieSaius));
            return _context.Clienti.FirstOrDefault(c => c.Id.Equals(auto.Client.Id));
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="telefon">The identifier.</param>
        /// <returns>The Client.</returns>
        public CarService.Client GetByTelefon(string telefon)
        {
            return _context.Clienti.Any(a => a.Telefon.Equals(telefon)) ? _context.Clienti.FirstOrDefault(c => c.Telefon.Equals(telefon)) : null;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the nume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client nume.</returns>
        public string GetNume(Guid id)
        {
            return !Exists(id) ? null : _context.Clienti.FirstOrDefault(c => c.Id == id)?.Nume;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the prenume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client prenume.</returns>
        public string GetPrenume(Guid id)
        {
            return !Exists(id) ? null : _context.Clienti.FirstOrDefault(c => c.Id == id)?.Prenume;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the adresa.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client adress.</returns>
        public string GetAdresa(Guid id)
        {
            return !Exists(id) ? null : _context.Clienti.FirstOrDefault(c => c.Id == id)?.Adresa;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the localitate.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client localitate.</returns>
        public string GetLocalitate(Guid id)
        {
            return !Exists(id) ? null : _context.Clienti.FirstOrDefault(c => c.Id == id)?.Localitate;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the judet.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client judet.</returns>
        public string GetJudet(Guid id)
        {
            return !Exists(id) ? null : _context.Clienti.FirstOrDefault(c => c.Id == id)?.Judet;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the telefon.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client telefon.</returns>
        public string GetTelefon(Guid id)
        {
            return !Exists(id) ? null : _context.Clienti.FirstOrDefault(c => c.Id == id)?.Telefon;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the email.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client email.</returns>
        public string GetEmail(Guid id)
        {
            return !Exists(id) ? null : _context.Clienti.FirstOrDefault(c => c.Id == id)?.Email;
        }

        /// <inheritdoc />
        /// <summary>
        /// Autoses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;CarService.Auto&gt;.</returns>
        public ICollection<CarService.Auto> Autos(Guid id)
        {
            return !Exists(id) ? null : _context.Autos.Where(a => a.Client.Id == id).ToList();
        }

        /// <inheritdoc />
        /// <summary>
        /// Comandases the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;CarService.Comanda&gt;.</returns>
        public ICollection<CarService.Comanda> Comandas(Guid id)
        {
            return !Exists(id) ? null : _context.Comenzi.Where(c => c.Client.Id == id).ToList();
        }
    }
}
