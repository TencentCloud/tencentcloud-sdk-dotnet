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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNetworkAccessStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>云原生API网关实例ID。</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>分组id</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>网络类型： </p><ul><li>Open 公网</li><li>Internal 内网    （暂不支持）</li></ul>
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// <p>ip地址</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>访问控制策略</p>
        /// </summary>
        [JsonProperty("AccessControl")]
        public NetworkAccessControl AccessControl{ get; set; }

        /// <summary>
        /// <p>GlobalConfig / Custom；不传默认 Custom</p>
        /// </summary>
        [JsonProperty("AccessControlSource")]
        public string AccessControlSource{ get; set; }

        /// <summary>
        /// <p>全局配置ID</p>
        /// </summary>
        [JsonProperty("GlobalConfigId")]
        public string GlobalConfigId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamObj(map, prefix + "AccessControl.", this.AccessControl);
            this.SetParamSimple(map, prefix + "AccessControlSource", this.AccessControlSource);
            this.SetParamSimple(map, prefix + "GlobalConfigId", this.GlobalConfigId);
        }
    }
}

