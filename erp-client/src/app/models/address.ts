import { Entity } from '.';

export class Address extends Entity {
    street: string;
    number: number;
    floor_door: string;
    city: string;
    postalCode: number;
    country: string;
}