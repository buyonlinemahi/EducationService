using HCRGUniversityService.DTO;
using System.Collections.Generic;
using System.ServiceModel;

namespace HCRGUniversityService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrganizationService" in both code and config file together.
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        int AddClient(DTO.Client client);
        [OperationContract]
        int UpdateClient(DTO.Client client);
        [OperationContract]
        void DeleteClient(int clientID);
        //===================  organization =========================================//
        [OperationContract]
        int AddOrganization(DTO.Organization organization);
        [OperationContract]
        int UpdateOrganization(DTO.Organization organization);
        [OperationContract]
        void DeleteOrganization(int organizationID);
        [OperationContract]
        IEnumerable<Organization> getAllOrganization();
        [OperationContract]
        IEnumerable<Organization> getOrganizationByOrganizationID(int organizationID);
        [OperationContract]
        Organization GetOrganizationByID(int organizationID);
        [OperationContract]
        IEnumerable<Menu> GetOrganizationMenuByOrganizationID(int organizationID);


        #region Organization Contact

        [OperationContract]
        int AddOrganizationContact(DTO.OrganizationContact contact);
        [OperationContract]
        int UpdateOrganizationContact(DTO.OrganizationContact contact);
        [OperationContract]
        void DeleteOrganizationContact(int contactID);
        [OperationContract]
        IEnumerable<OrganizationContact> GetOrganizationContactByOrganizationID(int organizationID, int ClientID);
        [OperationContract]
        OrganizationContact GetOrganizationContactByID(int orgContactID);
        [OperationContract]
        OrganizationContact GetSingleOrgContactByOrgID(int _orgID);

        #endregion

        //===========================================================================//
        [OperationContract]
        DTO.Paged.PagedClient GetOrganizationClientsByID(int OrganizationID, int Skip, int take);
        [OperationContract]
        IEnumerable<Client> GetAllClients();
        [OperationContract]
        Client GetClientByEmailID(string EmailID);
        [OperationContract]
         Client GetClientByID(int clientID);
        [OperationContract]
        DTO.Paged.PagedClient GetClientVerifiedDetails(int _skip, int _take);
        [OperationContract]
        Client GetClientByClientName(string clientName);
        [OperationContract]
        DTO.Client GetClientByEmailAndOrganizationId(string _clientEmailID, int OrganizationID);
        [OperationContract]
        IEnumerable<DTO.Client> GetClientsByPlanID(int planID);
        [OperationContract]
        DTO.Paged.PagedClient GetClientsByOrganizationID(int OrganizationID);
        [OperationContract]
        DTO.Paged.PagedClient GetClientsOrganization();
        [OperationContract]
        DTO.Paged.PagedClient GetClientsByName(string name, int skip, int take, int clientID);
        [OperationContract]
        void ResetClientPassword(int _clientID, string password);
        [OperationContract]
        void UpdateClientSessionIDByClientID(int clientId, string clientSessionID);
        [OperationContract]
        void ResetClientSessionID(int ClientID);
    }
}
