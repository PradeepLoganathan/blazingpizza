﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace BlazingPizza.Server.Models
{
    public partial class PizzaStoreContextModel
    {
        partial void Initialize()
        {
            var address = AddressEntityType.Create(this);
            var latLong = LatLongEntityType.Create(this);
            var notificationSubscription = NotificationSubscriptionEntityType.Create(this);
            var order = OrderEntityType.Create(this);
            var pizza = PizzaEntityType.Create(this);
            var pizzaSpecial = PizzaSpecialEntityType.Create(this);
            var pizzaTopping = PizzaToppingEntityType.Create(this);
            var pizzaStoreUser = PizzaStoreUserEntityType.Create(this);
            var topping = ToppingEntityType.Create(this);
            var deviceFlowCodes = DeviceFlowCodesEntityType.Create(this);
            var key = KeyEntityType.Create(this);
            var persistedGrant = PersistedGrantEntityType.Create(this);
            var identityRole = IdentityRoleEntityType.Create(this);
            var identityRoleClaimstring = IdentityRoleClaimstringEntityType.Create(this);
            var identityUserClaimstring = IdentityUserClaimstringEntityType.Create(this);
            var identityUserLoginstring = IdentityUserLoginstringEntityType.Create(this);
            var identityUserRolestring = IdentityUserRolestringEntityType.Create(this);
            var identityUserTokenstring = IdentityUserTokenstringEntityType.Create(this);

            LatLongEntityType.CreateForeignKey1(latLong, order);
            OrderEntityType.CreateForeignKey1(order, address);
            PizzaEntityType.CreateForeignKey1(pizza, order);
            PizzaEntityType.CreateForeignKey2(pizza, pizzaSpecial);
            PizzaToppingEntityType.CreateForeignKey1(pizzaTopping, pizza);
            PizzaToppingEntityType.CreateForeignKey2(pizzaTopping, topping);
            IdentityRoleClaimstringEntityType.CreateForeignKey1(identityRoleClaimstring, identityRole);
            IdentityUserClaimstringEntityType.CreateForeignKey1(identityUserClaimstring, pizzaStoreUser);
            IdentityUserLoginstringEntityType.CreateForeignKey1(identityUserLoginstring, pizzaStoreUser);
            IdentityUserRolestringEntityType.CreateForeignKey1(identityUserRolestring, identityRole);
            IdentityUserRolestringEntityType.CreateForeignKey2(identityUserRolestring, pizzaStoreUser);
            IdentityUserTokenstringEntityType.CreateForeignKey1(identityUserTokenstring, pizzaStoreUser);

            AddressEntityType.CreateAnnotations(address);
            LatLongEntityType.CreateAnnotations(latLong);
            NotificationSubscriptionEntityType.CreateAnnotations(notificationSubscription);
            OrderEntityType.CreateAnnotations(order);
            PizzaEntityType.CreateAnnotations(pizza);
            PizzaSpecialEntityType.CreateAnnotations(pizzaSpecial);
            PizzaToppingEntityType.CreateAnnotations(pizzaTopping);
            PizzaStoreUserEntityType.CreateAnnotations(pizzaStoreUser);
            ToppingEntityType.CreateAnnotations(topping);
            DeviceFlowCodesEntityType.CreateAnnotations(deviceFlowCodes);
            KeyEntityType.CreateAnnotations(key);
            PersistedGrantEntityType.CreateAnnotations(persistedGrant);
            IdentityRoleEntityType.CreateAnnotations(identityRole);
            IdentityRoleClaimstringEntityType.CreateAnnotations(identityRoleClaimstring);
            IdentityUserClaimstringEntityType.CreateAnnotations(identityUserClaimstring);
            IdentityUserLoginstringEntityType.CreateAnnotations(identityUserLoginstring);
            IdentityUserRolestringEntityType.CreateAnnotations(identityUserRolestring);
            IdentityUserTokenstringEntityType.CreateAnnotations(identityUserTokenstring);

            AddAnnotation("ProductVersion", "6.0.0");
        }
    }
}
