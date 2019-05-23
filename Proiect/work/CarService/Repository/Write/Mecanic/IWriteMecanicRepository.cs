namespace CarService.Repository.Write.Mecanic
{
    using Mecanic = CarService.Mecanic;

    /// <inheritdoc />
    /// <summary>
    /// Interface IWriteMecanicRepository
    /// Implements the <see cref="Mecanic" />
    /// </summary>
    /// <seealso cref="Mecanic" />
    internal interface IWriteMecanicRepository: IWriteRepository<Mecanic>
    {
    }
}
