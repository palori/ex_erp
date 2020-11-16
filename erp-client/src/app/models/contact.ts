import { Entity } from '.';

export class Contact extends Entity {
    name: string;
    phoneNumber: string;
    email: string;
    registered: Date;
    lastUpdated: Date;
    token?: string;
}