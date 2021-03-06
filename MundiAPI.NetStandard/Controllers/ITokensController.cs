/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundiAPI.NetStandard;
using MundiAPI.NetStandard.Utilities;
using MundiAPI.NetStandard.Http.Request;
using MundiAPI.NetStandard.Http.Response;
using MundiAPI.NetStandard.Http.Client;

namespace MundiAPI.NetStandard.Controllers
{
    public partial interface ITokensController
    {
        /// <summary>
        /// Gets a token from its id
        /// </summary>
        /// <param name="id">Required parameter: Token id</param>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Models.GetTokenResponse GetToken(string id, string publicKey);

        /// <summary>
        /// Gets a token from its id
        /// </summary>
        /// <param name="id">Required parameter: Token id</param>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Task<Models.GetTokenResponse> GetTokenAsync(string id, string publicKey);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <param name="request">Required parameter: Request for creating a token</param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Models.GetTokenResponse CreateToken(string publicKey, Models.CreateTokenRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <param name="request">Required parameter: Request for creating a token</param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Task<Models.GetTokenResponse> CreateTokenAsync(string publicKey, Models.CreateTokenRequest request);

    }
} 