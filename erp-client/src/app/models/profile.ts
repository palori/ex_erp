import { Contact } from '.';

export class Profile extends Contact {
    surnames: string;
    gender: boolean;
    year: number;
    contactId?: any;
}