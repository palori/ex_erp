import { Entity } from '.';

export class TradingInfo extends Entity {
    price: number;
    iva: number;
    minUnits: number;
    packUnits: number;
    deliveryTime: any; // TimeSpan in C#...
    trade: boolean; // where: 0 = buy, 1 = sell
    referendeId: any; // contact Id
}