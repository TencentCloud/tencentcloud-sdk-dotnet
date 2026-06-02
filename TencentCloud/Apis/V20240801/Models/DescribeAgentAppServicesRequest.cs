/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Apis.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAgentAppServicesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>数据量</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>IDs</p>
        /// </summary>
        [JsonProperty("IDs")]
        public string[] IDs{ get; set; }

        /// <summary>
        /// <p>应用IDs</p>
        /// </summary>
        [JsonProperty("AgentAppIDs")]
        public string[] AgentAppIDs{ get; set; }

        /// <summary>
        /// <p>服务IDs</p>
        /// </summary>
        [JsonProperty("ServiceIDs")]
        public string[] ServiceIDs{ get; set; }

        /// <summary>
        /// <p>关键字</p>
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// <p>偏移量</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>是否有凭据</p>
        /// </summary>
        [JsonProperty("AgentCredentialExist")]
        public bool? AgentCredentialExist{ get; set; }

        /// <summary>
        /// <p>凭据ID</p>
        /// </summary>
        [JsonProperty("AgentCredentialIDs")]
        public string[] AgentCredentialIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "IDs.", this.IDs);
            this.SetParamArraySimple(map, prefix + "AgentAppIDs.", this.AgentAppIDs);
            this.SetParamArraySimple(map, prefix + "ServiceIDs.", this.ServiceIDs);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "AgentCredentialExist", this.AgentCredentialExist);
            this.SetParamArraySimple(map, prefix + "AgentCredentialIDs.", this.AgentCredentialIDs);
        }
    }
}

