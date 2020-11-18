using System.Collections.Generic;
using System.Threading.Tasks;
using System;

using erp_api.Models;
using erp_api.Repositories;
using erp_api.Data.DTO;
using erp_api.Helpers;

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

        public async Task<bool> Update(TeamMemberDto tm0)
        {
            TeamMember tm = await this.teamMembers.Get(tm0.Id);
            tm.Update<TeamMemberDto>(tm0);

            // Find tm profile
            Profile profile = await this.profiles.Get(tm.ProfileId);
            profile.Update<TeamMemberDto>(tm0);

            // Find profile contact
            Contact contact = await this.contacts.Get(profile.ContactId);
            contact.Update<TeamMemberDto>(tm0);
            contact.LastUpdated = DateTime.Now;

            // Update DB
            bool tm_updated = false, profile_updated = false, contact_updated = false;
            tm_updated = await this.teamMembers.Update(tm);
            if (tm_updated)
            {
                profile_updated = await this.profiles.Update(profile);
                if (profile_updated)
                {
                    contact_updated = await this.contacts.Update(contact);
                }
            }
            
            return tm_updated && profile_updated && contact_updated;
        }

        public async Task<TeamMemberDto> Add(TeamMemberDto tm0)
        {
            // Some code to generate the Id's
            var g = new GenerateId(".","TM");
            string newId = g.Generate();
            //string addId = "A-"+cliId;
            string profId = newId;
            string contId = newId;
            tm0.Id = newId; // assign tm Id, no matter what they send

            // Contact
            Contact contact = new Contact();
            contact.Add<TeamMemberDto>(tm0, contId);
            var just_now = DateTime.Now;
            contact.Registered = just_now;
            contact.LastUpdated = just_now;
            Contact cont = await this.contacts.Add(contact);

            // Profile
            Profile profile = new Profile();
            profile.Add<TeamMemberDto>(tm0, profId, contact);
            Profile prof = await this.profiles.Add(profile);

            // Client
            TeamMember tm = new TeamMember();
            tm.Add<TeamMemberDto>(tm0, profile, null);
            TeamMember cli = await this.teamMembers.Add(tm);

            return new TeamMemberDto(cont, prof, cli);
        }

        public async Task<TeamMemberDto> Delete(TeamMemberDto tm0)
        {
            TeamMember tm = await this.teamMembers.Get(tm0.Id);
            Profile profile = await this.profiles.Get(tm.ProfileId);
            Contact contact = await this.contacts.Get(profile.ContactId);
            
            TeamMember del_tm = await this.teamMembers.Delete(tm);
            if (del_tm != null)
            {
                Profile del_profile = await this.profiles.Delete(profile);

                if (del_profile != null)
                {
                    Contact del_contact = await this.contacts.Delete(contact);
                    // maybe check if contact has been deleted properly
                }
            }

            // further considerations: compliance if some of them can be deleted bu not all...
            return new TeamMemberDto(contact, profile, tm);
        }

    }
}