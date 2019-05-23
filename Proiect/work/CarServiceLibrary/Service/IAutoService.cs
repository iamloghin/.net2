namespace ServiceAutoLibrary.Service
{
    using System.Collections.Generic;
    using System;

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
        /// <param name="detaliuComandaId">The detaliu comanda identifier.</param>
        /// <param name="operatieId">The operatie identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool AddOperatie(int detaliuComandaId, int operatieId);

        /// <summary>
        /// Adds the mecanic.
        /// </summary>
        /// <param name="detaliuComandaId">The detaliu comanda identifier.</param>
        /// <param name="operatieId">The operatie identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool AddMecanic(int detaliuComandaId, int operatieId);

        /// <summary>
        /// Searches the client.
        /// </summary>
        /// <param name="searchClientString">Search by SerieSasiu, Telefon, Email</param>
        /// <returns>System.Int32.</returns>
        Client GetClient(string searchClientString);

        /// <summary>
        /// Gets the client autos.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <returns>IList&lt;Auto&gt;.</returns>
        IList<Auto> GetClientAutos(int clientId);

        /// <summary>
        /// Gets the availabel mecanics.
        /// </summary>
        /// <returns>IList&lt;Mecanic&gt;.</returns>
        IList<Mecanic> GetAvailabelMecanics();

        /// <summary>
        /// Determines whether this instance [can be refuzata] the specified comanda identifier.
        /// </summary>
        /// <param name="comandaId">The comanda identifier.</param>
        /// <returns><c>true</c> if this instance [can be refuzata] the specified comanda identifier; otherwise, <c>false</c>.</returns>
        bool CanBeRefuzata(int comandaId);

        /// <summary>
        /// Sets the comanda status.
        /// </summary>
        /// <param name="comandaId">The comanda identifier.</param>
        /// <param name="stareComanda">The stare comanda.</param>
        /// <param name="descriere">The descriere.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool SetComandaStatus(int comandaId, StareComanda stareComanda, string descriere);

        /// <summary>
        /// Comandas the add material.
        /// </summary>
        /// <param name="comandaId">The comanda identifier.</param>
        /// <param name="materialId">The material identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool ComandaAddMaterial(int comandaId, int materialId);

        /// <summary>
        /// Gets the programare clients list.
        /// </summary>
        /// <param name="dataProgramare">The data programare.</param>
        /// <returns>IList&lt;Client&gt;.</returns>
        IList<Client> GetProgramareClientsList(DateTime dataProgramare);
    }
}
