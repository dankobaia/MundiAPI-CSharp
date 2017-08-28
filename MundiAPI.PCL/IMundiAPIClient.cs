/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using MundiAPI.PCL.Controllers;

namespace MundiAPI.PCL
{
    public partial interface IMundiAPIClient
    {

        /// <summary>
        /// Singleton access to Charges controller
        /// </summary>
        IChargesController Charges { get;}

        /// <summary>
        /// Singleton access to Customers controller
        /// </summary>
        ICustomersController Customers { get;}

        /// <summary>
        /// Singleton access to Subscriptions controller
        /// </summary>
        ISubscriptionsController Subscriptions { get;}

        /// <summary>
        /// Singleton access to Plans controller
        /// </summary>
        IPlansController Plans { get;}

        /// <summary>
        /// Singleton access to Invoices controller
        /// </summary>
        IInvoicesController Invoices { get;}

        /// <summary>
        /// Singleton access to Orders controller
        /// </summary>
        IOrdersController Orders { get;}

        /// <summary>
        /// Singleton access to Tokens controller
        /// </summary>
        ITokensController Tokens { get;}

    }
}