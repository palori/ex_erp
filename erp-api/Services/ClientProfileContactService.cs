using System.Collections.Generic;
using System.Threading.Tasks;

using erp_api.Models;
using erp_api.Repositories;
using erp_api.Data.DTO;

namespace erp_api.Services
{
    public class ClientProfileContactService: IService
    {
        private readonly ClientsRepository clients;
        private readonly ProfilesRepository profiles;
        private readonly ContactsRepository contacts;
        public ClientProfileContactService(){}
        public ClientProfileContactService(ClientsRepository clients, ProfilesRepository profiles, ContactsRepository contacts)
        {
            this.clients = clients;
            this.profiles = profiles;
            this.contacts = contacts;
        }

        public async Task<ClientDto> Get(ClientDto _client)
        {
            List<Client> clients = await this.clients.GetAll();
            List<Profile> profiles = await this.profiles.GetAll();
            List<Contact> contacts = await this.contacts.GetAll();

            Client selected_client = new Client();
            Profile selected_profile = new Profile();
            Contact selected_contact = new Contact();

            // find client in DB
            foreach (var client in clients)
            {
                if(client.Id == _client.Id)
                {
                    selected_client = client;
                    break;
                }
            }

            if (selected_client.Id != null)
            {
                // find client profile
                foreach (var profile in profiles)
                {
                    if(profile.Id == selected_client.ProfileId)
                    {
                        selected_profile = profile;
                        break;
                    }
                }

                // find client contact
                foreach (var contact in contacts)
                {
                    if(contact.Id == selected_profile.ContactId)
                    {
                        selected_contact = contact;
                        break;
                    }
                }
            }

            return new ClientDto(selected_contact, selected_profile, selected_client);
        }

        // GetAll() - Approach 1:
        public async Task<List<ClientDto>> GetAll()
        {
            List<Client> clients = await this.clients.GetAll();
            List<Profile> profiles = await this.profiles.GetAll();
            List<Contact> contacts = await this.contacts.GetAll();
            List<ClientDto> clientsDto = new List<ClientDto>();

            foreach (var client in clients)
            {
                // Find client profile
                Profile selected_profile = new Profile();
                foreach (var profile in profiles)
                {
                    if(profile.Id == client.ProfileId)
                    {
                        selected_profile = profile;
                        break;
                    }
                }

                // Find profile contact
                Contact selected_contact = new Contact();
                foreach (var contact in contacts)
                {
                    if(contact.Id == selected_profile.ContactId)
                    {
                        selected_contact = contact;
                        break;
                    }
                }

                // create clientDTO and append to the list
                clientsDto.Add(new ClientDto(selected_contact, selected_profile, client));
            }
            
            return clientsDto;
        }

        // GetAll() - Approach 2: more accesses to the DB (might be slower)
        // public async Task<List<ClientDto>> GetAll()
        // {
        //     List<Client> clients = await this.clients.GetAll();
        //     List<ClientDto> clientsDto = new List<ClientDto>();

        //     foreach (var client in clients)
        //     {
        //         // Find client profile
        //         Profile selected_profile = new Profile();
        //         selected_profile = await this.profiles.Get(client.ProfileId);

        //         // Find profile contact
        //         Contact selected_contact = new Contact();
        //         selected_contact = await this.contacts.Get(client.ProfileId);

        //         // create clientDTO and append to the list
        //         clientsDto.Add(new ClientDto(selected_contact, selected_profile, client));
        //     }
            
        //     return clientsDto;
        // }


        public async Task<bool> Update(ClientDto client0)
        {
            Client client = await this.clients.Get(client0.Id);
            client.Update<ClientDto>(client0, null, null);

            // Find client profile
            Profile profile = await this.profiles.Get(client.ProfileId);
            profile.Update<ClientDto>(client0, null, null);

            // Find profile contact
            Contact contact = await this.contacts.Get(profile.ContactId);
            contact.Update<ClientDto>(client0, null);

            // Update DB
            bool client_updated = false, profile_updated = false, contact_updated = false;
            client_updated = await this.clients.Update(client);
            if (client_updated)
            {
                profile_updated = await this.profiles.Update(profile);
                if (profile_updated)
                {
                    contact_updated = await this.contacts.Update(contact);
                }
            }
            
            return client_updated && profile_updated && contact_updated;
        }

        public async Task<ClientDto> Add(ClientDto client0)
        {
            // Some code to generate the Id's
            string cliId = "C3"; // generated somewhere
            //string addId = "A-"+cliId;
            string profId = cliId;
            string contId = cliId;
            client0.Id = cliId; // assign client Id, no matter what they send

            // Contact
            Contact contact = new Contact();
            contact.Update<ClientDto>(client0, contId);
            Contact cont = await this.contacts.Add(contact);

            // Profile
            Profile profile = new Profile();
            profile.Update<ClientDto>(client0, profId, contact);
            Profile prof = await this.profiles.Add(profile);

            // Client
            Client client = new Client();
            client.Update<ClientDto>(client0, profile, null);
            Client cli = await this.clients.Add(client);

            return new ClientDto(cont, prof, cli);
        }

        public async Task<ClientDto> Delete(ClientDto client0)
        {
            Client client = await this.clients.Get(client0.Id);
            Profile profile = await this.profiles.Get(client.ProfileId);
            Contact contact = await this.contacts.Get(profile.ContactId);
            
            Client del_client = await this.clients.Delete(client);
            if (del_client != null)
            {
                Profile del_profile = await this.profiles.Delete(profile);

                if (del_profile != null)
                {
                    Contact del_contact = await this.contacts.Delete(contact);
                    // maybe check if contact has been deleted properly
                }
            }

            // further considerations: compliance if some of them can be deleted bu not all...
            return new ClientDto(contact, profile, client);
        }

    }
}