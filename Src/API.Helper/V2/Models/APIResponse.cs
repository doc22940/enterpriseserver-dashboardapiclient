﻿namespace Syncfusion.Dashboard.Server.Api.Helper.V2.Models
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;

    [Serializable]
    [DataContract]
    public class ApiResponse
    {
        /// <summary>
        /// Returns the status of the API.
        /// </summary>
        [DataMember]
        public bool ApiStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Returns data from the API.
        /// </summary>
        [DataMember]
        public object Data
        {
            get;
            set;
        }

        /// <summary>
        /// Returns status of the API request.
        /// </summary>
        [DataMember]
        public bool Status
        {
            get;
            set;
        }

        /// <summary>
        /// Returns the status message from the API.
        /// </summary>
        [DataMember]
        public string StatusMessage
        {
            get;
            set;
        }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }

    }
}