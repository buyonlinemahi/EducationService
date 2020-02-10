using System.ServiceModel;
using AutoMapper;
using HCRGUniversity.Core.BL;
using HCRGUniversityService.Contracts;
using HCRGUniversityService.CustomServiceBehaviors;
using System.Collections.Generic;
using HCRGUniversityService.DTO;

namespace HCRGUniversityService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [AutoMapperServiceBehavior]
    public class ClientService : IClientService
    {

        private readonly IClient _client;
        private readonly IOrganization _organization;
        private readonly IOrganizationContact _organizationContact;


        public ClientService(IClient client, IOrganization organization, IOrganizationContact organizationContact)
        {
            _client = client;
            _organization = organization;
            _organizationContact = organizationContact;
        }


        public int AddClient(DTO.Client client)
        {
            return _client.AddClient(Mapper.Map<DTO.Client, HCRGUniversity.Core.Data.Model.Client>(client));
        }

        public int UpdateClient(DTO.Client client)
        {
            return _client.UpdateClient(Mapper.Map<DTO.Client, HCRGUniversity.Core.Data.Model.Client>(client));
        }

        public void DeleteClient(int clientID)
        {
            _client.DeleteClient(clientID);
        }
        public DTO.Paged.PagedClient GetOrganizationClientsByID(int OrganizationID, int Skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedClient>(_client.GetOrganizationClientsByID(OrganizationID, Skip, take));
        }

        public IEnumerable<Client> GetAllClients()
        {
            return Mapper.Map<IEnumerable<Client>>(_client.GetAllClients());
        }


        public Client GetClientByEmailID(string EmailID)
        {
            return Mapper.Map<Client>(_client.GetClientByEmailID(EmailID));

        }

        public Client GetClientByID(int clientID)
        {
            return Mapper.Map<Client>(_client.GetClientByID(clientID));
        }
        //===================  organization  =====================================================================================================//
        public int AddOrganization(DTO.Organization organization)
        {
            return _organization.AddOrganization(Mapper.Map<DTO.Organization, HCRGUniversity.Core.Data.Model.Organization>(organization));
        }

        public int UpdateOrganization(DTO.Organization organization)
        {
            return _organization.UpdateOrganization(Mapper.Map<DTO.Organization, HCRGUniversity.Core.Data.Model.Organization>(organization));
        }

        public void DeleteOrganization(int organizationID)
        {
            _organization.DeleteOrganization(organizationID);
        }

        public IEnumerable<Organization> getAllOrganization()
        {
            return Mapper.Map<IEnumerable<Organization>>(_organization.getAllOrganization());
        }

        public IEnumerable<Organization> getOrganizationByOrganizationID(int organizationID)
        {
            return Mapper.Map<IEnumerable<Organization>>(_organization.getAllOrganizationByOrganizationID(organizationID));
        }

        public Organization GetOrganizationByID(int organizationID)
        {
            return Mapper.Map<Organization>(_organization.GetOrganizationByID(organizationID));
        }

        public IEnumerable<Menu> GetOrganizationMenuByOrganizationID(int organizationID)
        {
            return Mapper.Map<IEnumerable<Menu>>(_organization.GetOrganizationMenuByOrganizationID(organizationID));
        }




        #region OrganizationContact
        public int AddOrganizationContact(DTO.OrganizationContact contact)
        {
            return _organizationContact.AddOrganizationContact(Mapper.Map<DTO.OrganizationContact, HCRGUniversity.Core.Data.Model.OrganizationContact>(contact));

        }

        public int UpdateOrganizationContact(DTO.OrganizationContact contact)
        {
            return _organizationContact.UpdateOrganizationContact(Mapper.Map<DTO.OrganizationContact, HCRGUniversity.Core.Data.Model.OrganizationContact>(contact));
        }

        public void DeleteOrganizationContact(int contactID)
        {
            _organizationContact.DeleteOrganizationContact(contactID);
        }

        public IEnumerable<OrganizationContact> GetOrganizationContactByOrganizationID(int organizationID, int ClientID)
        {
            return Mapper.Map<IEnumerable<OrganizationContact>>(_organizationContact.GetOrganizationContactByOrganizationID(organizationID, ClientID));
        }

        public OrganizationContact GetSingleOrgContactByOrgID(int _orgID)
        {
            return Mapper.Map<OrganizationContact>(_organizationContact.GetSingleOrgContactByOrgID(_orgID));
        }


        public OrganizationContact GetOrganizationContactByID(int orgContactID)
        {
            return Mapper.Map<OrganizationContact>(_organizationContact.GetOrganizationContactByID(orgContactID));
        }

        #endregion

        //=========================================================================================================================================//

        public DTO.Paged.PagedClient GetClientVerifiedDetails(int _skip, int _take)
        {
            return Mapper.Map<DTO.Paged.PagedClient>(_client.GetClientVerifiedDetails(_skip, _take));
        }
        public DTO.Client GetClientByClientName(string clientName)
        {
            return Mapper.Map<DTO.Client>(_client.GetClientByClientName(clientName));
        }

        public DTO.Client GetClientByEmailAndOrganizationId(string _clientEmailID, int OrganizationID)
        {
            return Mapper.Map<DTO.Client>(_client.GetClientByEmailAndOrganizationId(_clientEmailID, OrganizationID));
        }

        public IEnumerable<DTO.Client> GetClientsByPlanID(int planID)
        {
            return Mapper.Map<IEnumerable<DTO.Client>>(_client.GetClientsByPlanID(planID));
        }

        public DTO.Paged.PagedClient GetClientsByOrganizationID(int OrganizationID)
        {
            return Mapper.Map<DTO.Paged.PagedClient>(_client.GetClientsByOrganizationID(OrganizationID));
        }

        public DTO.Paged.PagedClient GetClientsOrganization()
        {
            return Mapper.Map<DTO.Paged.PagedClient>(_client.GetClientsOrganization());
        }
        public DTO.Paged.PagedClient GetClientsByName(string name, int skip, int take, int clientID)
        {
            return Mapper.Map<DTO.Paged.PagedClient>(_client.GetClientsByName(name, skip, take, clientID));
        }
        public void ResetClientPassword(int _clientID, string password)
        {
            _client.ResetClientPassword(_clientID, password);
        }

        public void UpdateClientSessionIDByClientID(int clientId, string clientSessionID)
        {
            _client.UpdateClientSessionIDByClientID(clientId, clientSessionID);
        }

        public void ResetClientSessionID(int ClientID)
        {
            _client.ResetClientSessionID(ClientID);
        }
    }
}
