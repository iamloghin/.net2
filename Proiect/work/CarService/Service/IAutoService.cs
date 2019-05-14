namespace CarService.Service
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Interface IAutoService
    /// </summary>
    public interface IAutoService
    {
        /// <summary>
        /// Creates the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool CreateClient(Client client);

        /// <summary>
        /// Creates the automatic.
        /// </summary>
        /// <param name="auto">The automatic.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool CreateAuto(Auto auto);

        /// <summary>
        /// Creates the material.
        /// </summary>
        /// <param name="material">The material.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool CreateMaterial(Material material);

        /// <summary>
        /// Creates the detaliu comanda.
        /// </summary>
        /// <param name="detaliuComanda">The detaliu comanda.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool CreateDetaliuComanda(DetaliuComanda detaliuComanda);

        /// <summary>
        /// Creates the imagine.
        /// </summary>
        /// <param name="imagine">The imagine.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool CreateImagine(Imagine imagine);

        /// <summary>
        /// Creates the operatie.
        /// </summary>
        /// <param name="operatie">The operatie.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool CreateOperatie(Operatie operatie);

        /// <summary>
        /// Creates the mecanic.
        /// </summary>
        /// <param name="mecanic">The mecanic.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool CreateMecanic(Mecanic mecanic);

        /// <summary>
        /// Creates the comanda.
        /// </summary>
        /// <param name="comanda">The comanda.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool CreateComanda(Comanda comanda);

        /// <summary>
        /// Adds the operatie.
        /// </summary>
        /// <param name="operatieId">The operatie identifier.</param>
        /// <param name="detaliuComanda">The detaliu comanda.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool AddOperatie(Operatie operatieId, DetaliuComanda detaliuComanda);

        /// <summary>
        /// Adds the mecanics.
        /// </summary>
        /// <param name="selectedMecanics">The selected mecanics.</param>
        /// <param name="detaliuComanda">The detaliu comanda.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool AddMecanics(List<Mecanic> selectedMecanics, DetaliuComanda detaliuComanda);

        /// <summary>
        /// Updates the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool UpdateClient(Client client);

        /// <summary>
        /// Updates the detaliuComanda.
        /// </summary>
        /// <param name="detaliuComanda">The detaliuComanda.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool UpdateDetaliuComanda(DetaliuComanda detaliuComanda);

        /// <summary>
        /// Updates the material.
        /// </summary>
        /// <param name="material">The material.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool UpdateMaterial(Material material);

        /// <summary>
        /// Delete the mecanic.
        /// </summary>
        /// <param name="mecanic">The mecanic.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool DeleteMecanic(Mecanic mecanic);

        /// <summary>
        /// Delete the operatie.
        /// </summary>
        /// <param name="operatie">The operatie.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool DeleteOperatie(Operatie operatie);

        /// <summary>
        /// Delete the material.
        /// </summary>
        /// <param name="material">The material.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool DeleteMaterial(Material material);

        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <param name="searchClientString">The search client string.</param>
        /// <returns>Client.</returns>
        Client GetClient(string searchClientString);

        /// <summary>
        /// Gets the client autos.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>IList&lt;Auto&gt;.</returns>
        IList<Auto> GetClientAutos(Guid Id);

        /// <summary>
        /// Gets the detaliu comenzii.
        /// </summary>
        /// <returns>IList&lt;DetaliuComenza&gt;.</returns>
        IList<DetaliuComanda> GetAllDetaliuComandas();

        /// <summary>
        /// Gets the materials.
        /// </summary>
        /// <returns>IList&lt;Material&gt;.</returns>
        IList<Material> GetAllMaterials();

        /// <summary>
        /// Gets the availabel mecanics.
        /// </summary>
        /// <returns>IList&lt;Mecanic&gt;.</returns>
        IList<Mecanic> GetAvailabelMecanics();

        /// <summary>
        /// Gets the availabel materials.
        /// </summary>
        /// <returns>IList&lt;Material&gt;.</returns>
        IList<Material> GetAvailabelMaterials();

        /// <summary>
        /// Gets all mecanics.
        /// </summary>
        /// <returns>IList&lt;Mecanic&gt;.</returns>
        IList<Mecanic> GetAllMecanics();

        /// <summary>
        /// Determines whether this instance [can be refuzata] the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if this instance [can be refuzata] the specified identifier; otherwise, <c>false</c>.</returns>
        bool CanBeRefuzata(Guid id);

        /// <summary>
        /// Sets the comanda status.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="stareComanda">The stare comanda.</param>
        /// <param name="descriere">The descriere.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool SetComandaStatus(Guid id, StareComanda stareComanda, string descriere);

        /// <summary>
        /// Comandas the add material.
        /// </summary>
        /// <param name="materialId">The material identifier.</param>
        /// <param name="detaliuComandaId">The detaliu comanda identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool ComandaAddMaterial(Guid materialId, Guid detaliuComandaId);

        /// <summary>
        /// Gets the programare clients list.
        /// </summary>
        /// <param name="dataProgramare">The data programare.</param>
        /// <returns>IList&lt;Client&gt;.</returns>
        IList<Client> GetProgramareClientsList(DateTime dataProgramare);

    }
}
