namespace CarService.Repository.Write.Client
{
    using Client = CarService.Client;

    /// <inheritdoc />
    /// <summary>
    /// Interface IWriteAutoRepository
    /// Implements the <see cref="Client" />
    /// </summary>
    /// <seealso cref="Client" />
    internal interface IWriteClientRepository: IWriteRepository<Client>
    {
    }
}
