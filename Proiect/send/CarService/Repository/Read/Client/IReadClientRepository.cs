namespace CarService.Repository.Read.Client
{
    using System;
    using System.Collections.Generic;

    using Auto = CarService.Auto;
    using Client = CarService.Client;
    using Comanda = CarService.Comanda;

    /// <inheritdoc />
    /// <summary>
    /// Interface IReadClientRepository
    /// Implements the <see cref="Client" />
    /// </summary>
    /// <seealso cref="Client" />
    internal interface IReadClientRepository: IReadRepository<Client>
    {
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="email">The identifier.</param>
        /// <returns>The Client.</returns>
        Client GetByEmail(string email);

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="serieSaius">The identifier.</param>
        /// <returns>The Client.</returns>
        Client GetBySerieSasiu(string serieSaius);


        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="telefon">The identifier.</param>
        /// <returns>The Client.</returns>
        Client GetByTelefon(string telefon);

        /// <summary>
        /// Gets the nume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client nume.</returns>
        string GetNume(Guid id);

        /// <summary>
        /// Gets the prenume.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client prenume.</returns>
        string GetPrenume(Guid id);

        /// <summary>
        /// Gets the adresa.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client adress.</returns>
        string GetAdresa(Guid id);

        /// <summary>
        /// Gets the localitate.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client localitate.</returns>
        string GetLocalitate(Guid id);

        /// <summary>
        /// Gets the judet.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client judet.</returns>
        string GetJudet(Guid id);

        /// <summary>
        /// Gets the telefon.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client telefon.</returns>
        string GetTelefon(Guid id);

        /// <summary>
        /// Gets the email.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A string that represents the client email.</returns>
        string GetEmail(Guid id);

        /// <summary>
        /// Autoses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;Auto&gt;.</returns>
        ICollection<Auto> Autos(Guid id);

        /// <summary>
        /// Comandases the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;Comanda&gt;.</returns>
        ICollection<Comanda> Comandas(Guid id);
    }
}
