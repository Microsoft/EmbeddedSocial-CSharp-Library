// Copyright (c) Microsoft Corporation. All rights reserved. Licensed under
// the MIT License. See LICENSE in the project root for license information.
// <autogenerated> This file was generated using AutoRest. </autogenerated>

namespace SocialPlus.Client.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Count response
    /// </summary>
    public partial class CountResponse
    {
        /// <summary>
        /// Initializes a new instance of the CountResponse class.
        /// </summary>
        public CountResponse() { }

        /// <summary>
        /// Initializes a new instance of the CountResponse class.
        /// </summary>
        public CountResponse(long count)
        {
            Count = count;
        }

        /// <summary>
        /// Gets or sets count
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long Count { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}