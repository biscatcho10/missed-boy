namespace Homeless.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'Homeless.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}

