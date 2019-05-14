namespace ServiceAutoLibrary.Repository.Read.Client
{
    using System.Collections.Generic;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Class ReadClientRepository.
    /// Implements the <see cref="T:ServiceAutoLibrary.Repository.Read.Client.IReadClientRepository" />
    /// </summary>
    /// <seealso cref="T:ServiceAutoLibrary.Repository.Read.Client.IReadClientRepository" />
    internal class ReadClientRepository: IReadClientRepository
    {
        private readonly ServiceAutoModelContainer _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadClientRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReadClientRepository(ServiceAutoModelContainer context)
        {
            _context = context;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The Client.</returns>
        public ServiceAutoLibrary.Client GetById(int id)
        {
            return _context.Clienti.FirstOrDefault(c => c.ClientId == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IReadOnlyList&lt;The Clients&gt;.</returns>
        public IReadOnlyList<ServiceAutoLibrary.Client> GetAll()
        {
            return _context.Clienti.ToList();
        }

        /// <inheritdoc />
        /// <summary>
        /// Existses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Exists(int id)
        {
            return _context.Clienti.Any(c => c.ClientId == id);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="email">The identifier.</param>
        /// <returns>The Client.</returns>
        public ServiceAutoLibrary.Client GetByEmail(string email)
        {
            return _context.Clienti.FirstOrDefault(c => c.Email.Equals(email));
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="serieSaius">The identifier.</param>
        /// <returns>The Client.</returns>
        public ServiceAutoLibrary.Client GetBySerieSasiu(string serieSaius)
        {
            var auto = _context.Autos.FirstOrDefault(a => a.SerieSasiu.Equals(serieSaius));
            return _context.Clienti.FirstOrDefault(c => c.ClientId.Equals(auto.Client.ClientId));
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="telefon">The identifier.</param>
        /// <returns>The Client.</returns>
        public ServiceAutoLibrary.Client GetByTelefon(string telefon)
        {
            return _context.Clienti.FirstOrDefault(c => c.Telefon.Equals(telefon));
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the nume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client nume.</returns>
        public string GetNume(int id)
        {
            return _context.Clienti.FirstOrDefault(c => c.ClientId == id)?.Nume;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the prenume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client prenume.</returns>
        public string GetPrenume(int id)
        {
            return _context.Clienti.FirstOrDefault(c => c.ClientId == id)?.Prenume;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the adresa.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client adress.</returns>
        public string GetAdresa(int id)
        {
            return _context.Clienti.FirstOrDefault(c => c.ClientId == id)?.Adresa;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the localitate.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client localitate.</returns>
        public string GetLocalitate(int id)
        {
            return _context.Clienti.FirstOrDefault(c => c.ClientId == id)?.Localitate;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the judet.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client judet.</returns>
        public string GetJudet(int id)
        {
            return _context.Clienti.FirstOrDefault(c => c.ClientId == id)?.Judet;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the telefon.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client telefon.</returns>
        public string GetTelefon(int id)
        {
            return _context.Clienti.FirstOrDefault(c => c.ClientId == id)?.Telefon;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the email.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client email.</returns>
        public string GetEmail(int id)
        {
            return _context.Clienti.FirstOrDefault(c => c.ClientId == id)?.Email;
        }

        /// <inheritdoc />
        /// <summary>
        /// Autoses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;ServiceAutoLibrary.Auto&gt;.</returns>
        public ICollection<ServiceAutoLibrary.Auto> Autos(int id)
        {
            return _context.Autos.Where(a => a.Client.ClientId == id).ToList();
        }

        /// <inheritdoc />
        /// <summary>
        /// Comandases the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;ServiceAutoLibrary.Comanda&gt;.</returns>
        public ICollection<ServiceAutoLibrary.Comanda> Comandas(int id)
        {
            return _context.Comenzi.Where(c => c.Client.ClientId == id).ToList();
        }
    }
}
