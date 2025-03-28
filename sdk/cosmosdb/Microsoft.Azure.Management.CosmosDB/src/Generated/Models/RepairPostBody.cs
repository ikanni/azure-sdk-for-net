// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specification of the keyspaces and tables to run repair on.
    /// </summary>
    public partial class RepairPostBody
    {
        /// <summary>
        /// Initializes a new instance of the RepairPostBody class.
        /// </summary>
        public RepairPostBody()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RepairPostBody class.
        /// </summary>
        /// <param name="keyspace">The name of the keyspace that repair should
        /// be run on.</param>
        /// <param name="tables">List of tables in the keyspace to repair. If
        /// omitted, repair all tables in the keyspace.</param>
        public RepairPostBody(string keyspace, IList<string> tables = default(IList<string>))
        {
            Keyspace = keyspace;
            Tables = tables;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the keyspace that repair should be run on.
        /// </summary>
        [JsonProperty(PropertyName = "keyspace")]
        public string Keyspace { get; set; }

        /// <summary>
        /// Gets or sets list of tables in the keyspace to repair. If omitted,
        /// repair all tables in the keyspace.
        /// </summary>
        [JsonProperty(PropertyName = "tables")]
        public IList<string> Tables { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Keyspace == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Keyspace");
            }
        }
    }
}
