using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

using erp_api.Models;
using erp_api.Contexts;
using erp_api.Data.DTO;

namespace erp_api.Repositories
{
    public class ClientsRepository: GenericRepository<Client, ErpContext, string>
    {
        public ClientsRepository(ErpContext context): base(context)
        {
        }

        public async Task<ClientDto> GetFull(Client _client)
        {
            List<Client> clients = await GetContext().Set<Client>().ToListAsync();
            List<Profile> profiles = await GetContext().Set<Profile>().ToListAsync();
            List<Contact> contacts = await GetContext().Set<Contact>().ToListAsync();

            Client selected_client = new Client();
            foreach (var client in clients)
            {
                if(client.Id == _client.Id)
                {
                    selected_client = client;
                    break;
                }
            }

            Profile selected_profile = new Profile();
            foreach (var profile in profiles)
            {
                if(profile.Id == selected_client.ProfileId)
                {
                    selected_profile = profile;
                    break;
                }
            }

            Contact selected_contact = new Contact();
            foreach (var contact in contacts)
            {
                if(contact.Id == selected_profile.ContactId)
                {
                    selected_contact = contact;
                    break;
                }
            }
            
            return new ClientDto(selected_contact, selected_profile, selected_client);
        }
    }
}