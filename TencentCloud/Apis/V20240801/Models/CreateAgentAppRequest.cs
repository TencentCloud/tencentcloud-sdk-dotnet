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

    public class CreateAgentAppRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>认证类型</p>
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// <p>OAuth2资源服务器ID</p>
        /// </summary>
        [JsonProperty("OAuth2ResourceServerID")]
        public string OAuth2ResourceServerID{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>API认证列表</p>
        /// </summary>
        [JsonProperty("ConnectorIDs")]
        public string[] ConnectorIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "OAuth2ResourceServerID", this.OAuth2ResourceServerID);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "ConnectorIDs.", this.ConnectorIDs);
        }
    }
}

