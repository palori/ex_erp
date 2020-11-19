import { Entity } from '.';

export class Order extends Entity {
    priority: number;
    ordered: Date;
    referenceId: any; // contact Id
    addressId: any;
}