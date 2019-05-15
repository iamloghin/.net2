namespace CarService.Service
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;

    [ServiceContract]
    public interface IAutoService
    {
        [OperationContract]
        bool CreateClient(Client client);

        [OperationContract]
        bool CreateAuto(Auto auto);

        [OperationContract]
        bool CreateMaterial(Material material);

        [OperationContract]
        bool CreateDetaliuComanda(DetaliuComanda detaliuComanda);

        [OperationContract]
        bool CreateImagine(Imagine imagine);

        [OperationContract]
        bool CreateOperatie(Operatie operatie);

        [OperationContract]
        bool CreateMecanic(Mecanic mecanic);

        [OperationContract]
        bool CreateComanda(Comanda comanda);

        [OperationContract]
        bool AddOperatie(Operatie operatieId, DetaliuComanda detaliuComanda);

        [OperationContract]
        bool AddMecanics(List<Mecanic> selectedMecanics, DetaliuComanda detaliuComanda);




        [OperationContract]
        bool UpdateClient(Client client);

        [OperationContract]
        bool UpdateDetaliuComanda(DetaliuComanda detaliuComanda);

        [OperationContract]
        bool UpdateMaterial(Material material);

        [OperationContract]
        bool DeleteMecanic(Mecanic mecanic);

        [OperationContract]
        bool DeleteOperatie(Operatie operatie);

        [OperationContract]
        bool DeleteMaterial(Material material);



        [OperationContract]
        Client GetClient(string searchClientString);

        [OperationContract]
        IList<Auto> GetClientAutos(Guid Id);

        [OperationContract]
        IList<DetaliuComanda> GetAllDetaliuComandas();

        [OperationContract]
        IList<Material> GetAllMaterials();

        [OperationContract]
        IList<Mecanic> GetAvailabelMecanics();

        [OperationContract]
        IList<Material> GetAvailabelMaterials();

        [OperationContract]
        IList<Mecanic> GetAllMecanics();



        [OperationContract]
        bool CanBeRefuzata(Guid id);

        [OperationContract]
        bool SetComandaStatus(Guid id, StareComanda stareComanda, string descriere);

        [OperationContract]
        bool ComandaAddMaterial(Guid materialId, Guid detaliuComandaId);

        [OperationContract]
        IList<Client> GetProgramareClientsList(DateTime dataProgramare);
    }
}
