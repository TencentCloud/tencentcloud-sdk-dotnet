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

    public class AgentAppServiceVO : AbstractModel
    {
        
        /// <summary>
        /// <p>ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// <p>应用ID</p>
        /// </summary>
        [JsonProperty("AgentAppID")]
        public string AgentAppID{ get; set; }

        /// <summary>
        /// <p>服务ID</p>
        /// </summary>
        [JsonProperty("ServiceID")]
        public string ServiceID{ get; set; }

        /// <summary>
        /// <p>是否限流</p>
        /// </summary>
        [JsonProperty("InvokeLimitConfigStatus")]
        public bool? InvokeLimitConfigStatus{ get; set; }

        /// <summary>
        /// <p>限流配置</p>
        /// </summary>
        [JsonProperty("InvokeLimitConfig")]
        public InvokeLimitConfigDTO InvokeLimitConfig{ get; set; }

        /// <summary>
        /// <p>服务详情</p>
        /// </summary>
        [JsonProperty("ServiceVO")]
        public ServiceVO ServiceVO{ get; set; }

        /// <summary>
        /// <p>关联时间</p>
        /// </summary>
        [JsonProperty("RelateTime")]
        public string RelateTime{ get; set; }

        /// <summary>
        /// <p>是否需要认证</p>
        /// </summary>
        [JsonProperty("NeedAuth")]
        public bool? NeedAuth{ get; set; }

        /// <summary>
        /// <p>凭据ID</p>
        /// </summary>
        [JsonProperty("AgentCredentialID")]
        public string AgentCredentialID{ get; set; }

        /// <summary>
        /// <p>凭据详情</p>
        /// </summary>
        [JsonProperty("AgentCredentialVO")]
        public DescribeAgentCredentialResp AgentCredentialVO{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "AgentAppID", this.AgentAppID);
            this.SetParamSimple(map, prefix + "ServiceID", this.ServiceID);
            this.SetParamSimple(map, prefix + "InvokeLimitConfigStatus", this.InvokeLimitConfigStatus);
            this.SetParamObj(map, prefix + "InvokeLimitConfig.", this.InvokeLimitConfig);
            this.SetParamObj(map, prefix + "ServiceVO.", this.ServiceVO);
            this.SetParamSimple(map, prefix + "RelateTime", this.RelateTime);
            this.SetParamSimple(map, prefix + "NeedAuth", this.NeedAuth);
            this.SetParamSimple(map, prefix + "AgentCredentialID", this.AgentCredentialID);
            this.SetParamObj(map, prefix + "AgentCredentialVO.", this.AgentCredentialVO);
        }
    }
}

