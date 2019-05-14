using System;

namespace CarService.Repository.Read.Client
{
    using System.Collections.Generic;

    /// <inheritdoc />
    /// <summary>
    /// Interface IReadClientRepository
    /// Implements the <see cref="!:CarService.Repository.Read.IReadRepository{CarService.Client}" />
    /// </summary>
    /// <seealso cref="!:CarService.Repository.Read.IReadRepository{CarService.Client}" />
    internal interface IReadClientRepository: IReadRepository<CarService.Client>
    {
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="email">The identifier.</param>
        /// <returns>The Client.</returns>
        CarService.Client GetByEmail(string email);

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="serieSaius">The identifier.</param>
        /// <returns>The Client.</returns>
        CarService.Client GetBySerieSasiu(string serieSaius);


        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="telefon">The identifier.</param>
        /// <returns>The Client.</returns>
        CarService.Client GetByTelefon(string telefon);

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
        /// <returns>ICollection&lt;CarService.Auto&gt;.</returns>
        ICollection<CarService.Auto> Autos(Guid id);

        /// <summary>
        /// Comandases the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ICollection&lt;CarService.Comanda&gt;.</returns>
        ICollection<CarService.Comanda> Comandas(Guid id);
    }
}
