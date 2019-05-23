namespace ServiceAutoLibrary.Repository.Read.Client
{
    using System.Collections.Generic;

    /// <inheritdoc />
    /// <summary>
    /// Interface IReadClientRepository
    /// Implements the <see cref="!:ServiceAutoLibrary.Repository.Read.IReadRepository{ServiceAutoLibrary.Client}" />
    /// </summary>
    /// <seealso cref="!:ServiceAutoLibrary.Repository.Read.IReadRepository{ServiceAutoLibrary.Client}" />
    internal interface IReadClientRepository: IReadRepository<ServiceAutoLibrary.Client>
    {
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="email">The identifier.</param>
        /// <returns>The Client.</returns>
        ServiceAutoLibrary.Client GetByEmail(string email);

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="serieSaius">The identifier.</param>
        /// <returns>The Client.</returns>
        ServiceAutoLibrary.Client GetBySerieSasiu(string serieSaius);


        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="telefon">The identifier.</param>
        /// <returns>The Client.</returns>
        ServiceAutoLibrary.Client GetByTelefon(string telefon);

        /// <summary>
        /// Gets the nume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client nume.</returns>
        string GetNume(int id);

        /// <summary>
        /// Gets the prenume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client prenume.</returns>
        string GetPrenume(int id);

        /// <summary>
        /// Gets the adresa.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client adress.</returns>
        string GetAdresa(int id);

        /// <summary>
        /// Gets the localitate.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client localitate.</returns>
        string GetLocalitate(int id);

        /// <summary>
        /// Gets the judet.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client judet.</returns>
        string GetJudet(int id);

        /// <summary>
        /// Gets the telefon.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client telefon.</returns>
        string GetTelefon(int id);

        /// <summary>
        /// Gets the email.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client email.</returns>
        string GetEmail(int id);

        /// <summary>
        /// Autoses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;ServiceAutoLibrary.Auto&gt;.</returns>
        ICollection<ServiceAutoLibrary.Auto> Autos(int id);

        /// <summary>
        /// Comandases the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;ServiceAutoLibrary.Comanda&gt;.</returns>
        ICollection<ServiceAutoLibrary.Comanda> Comandas(int id);
    }
}
