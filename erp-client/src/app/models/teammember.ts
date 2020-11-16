import { Profile } from '.';

export class TeamMember extends Profile {
    role: string;
    isAdmin: boolean;
    nif: string;
    salary: number;
    addressId: any;
}