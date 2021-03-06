/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.NetStandard;
using MundiAPI.NetStandard.Utilities;


namespace MundiAPI.NetStandard.Models
{
    public class CreatePaymentAuthentiticationRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string type;
        private Models.Create3DSAuthentiticationRequest threedSecure;

        /// <summary>
        /// The Authentication type
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// The 3D-S authentication object
        /// </summary>
        [JsonProperty("threed_secure")]
        public Models.Create3DSAuthentiticationRequest ThreedSecure 
        { 
            get 
            {
                return this.threedSecure; 
            } 
            set 
            {
                this.threedSecure = value;
                onPropertyChanged("ThreedSecure");
            }
        }
    }
} 