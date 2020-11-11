using System.Collections.Generic;
using System.Threading.Tasks;

using erp_api.Models;
using erp_api.Repositories;
using erp_api.Data.DTO;

namespace erp_api.Services
{
    public class TeamMemberProfileContactService: IService
    {
        private readonly TeamMembersRepository teamMembers;
        private readonly ProfilesRepository profiles;
        private readonly ContactsRepository contacts;
        public TeamMemberProfileContactService(){}
        public TeamMemberProfileContactService(TeamMembersRepository teamMembers, ProfilesRepository profiles, ContactsRepository contacts)
        {
            this.teamMembers = teamMembers;
            this.profiles = profiles;
            this.contacts = contacts;
        }

        public async Task<TeamMemberDto> Get(TeamMemberDto _tm)
        {
            List<TeamMember> teamMembers = await this.teamMembers.GetAll();
            List<Profile> profiles = await this.profiles.GetAll();
            List<Contact> contacts = await this.contacts.GetAll();

            TeamMember selected_teamMember = new TeamMember();
            Profile selected_profile = new Profile();
            Contact selected_contact = new Contact();

            // find team member in DB
            foreach (var tm in teamMembers)
            {
                if(tm.Id == _tm.Id)
                {
                    selected_teamMember = tm;
                    break;
                }
            }

            if (selected_teamMember.Id != null)
            {
                // find team member profile
                foreach (var profile in profiles)
                {
                    if(profile.Id == selected_teamMember.ProfileId)
                    {
                        selected_profile = profile;
                        break;
                    }
                }

                // find team member contact
                foreach (var contact in contacts)
                {
                    if(contact.Id == selected_profile.ContactId)
                    {
                        selected_contact = contact;
                        break;
                    }
                }
            }

            return new TeamMemberDto(selected_contact, selected_profile, selected_teamMember);
        }

        // GetAll() - Approach 1:
        public async Task<List<TeamMemberDto>> GetAll()
        {
            List<TeamMember> teamMembers = await this.teamMembers.GetAll();
            List<Profile> profiles = await this.profiles.GetAll();
            List<Contact> contacts = await this.contacts.GetAll();
            List<TeamMemberDto> teamMembersDto = new List<TeamMemberDto>();

            foreach (var tm in teamMembers)
            {
                // Find team member profile
                Profile selected_profile = new Profile();
                foreach (var profile in profiles)
                {
                    if(profile.Id == tm.ProfileId)
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

                // create teamMemberDTO and append to the list
                teamMembersDto.Add(new TeamMemberDto(selected_contact, selected_profile, tm));
            }
            
            return teamMembersDto;
        }

    }
}