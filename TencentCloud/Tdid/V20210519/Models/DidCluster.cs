/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DidCluster : AbstractModel
    {
        
        /// <summary>
        /// 链ID
        /// </summary>
        [JsonProperty("ChainId")]
        public ulong? ChainId{ get; set; }

        /// <summary>
        /// 链名称
        /// </summary>
        [JsonProperty("ChainName")]
        public string ChainName{ get; set; }

        /// <summary>
        /// 组织数量
        /// </summary>
        [JsonProperty("AgencyCount")]
        public ulong? AgencyCount{ get; set; }

        /// <summary>
        /// 联盟ID
        /// </summary>
        [JsonProperty("ConsortiumId")]
        public ulong? ConsortiumId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 网络状态
        /// </summary>
        [JsonProperty("ChainStatus")]
        public ulong? ChainStatus{ get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 网络ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 联盟名称
        /// </summary>
        [JsonProperty("ConsortiumName")]
        public string ConsortiumName{ get; set; }

        /// <summary>
        /// 组织ID
        /// </summary>
        [JsonProperty("AgencyId")]
        public ulong? AgencyId{ get; set; }

        /// <summary>
        /// 自动续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 网络节点总数
        /// </summary>
        [JsonProperty("TotalNetworkNode")]
        public ulong? TotalNetworkNode{ get; set; }

        /// <summary>
        /// 本机构节点数
        /// </summary>
        [JsonProperty("TotalCreateNode")]
        public ulong? TotalCreateNode{ get; set; }

        /// <summary>
        /// 总群组数
        /// </summary>
        [JsonProperty("TotalGroups")]
        public ulong? TotalGroups{ get; set; }

        /// <summary>
        /// DID总数
        /// </summary>
        [JsonProperty("DidCount")]
        public ulong? DidCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChainId", this.ChainId);
            this.SetParamSimple(map, prefix + "ChainName", this.ChainName);
            this.SetParamSimple(map, prefix + "AgencyCount", this.AgencyCount);
            this.SetParamSimple(map, prefix + "ConsortiumId", this.ConsortiumId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ChainStatus", this.ChainStatus);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ConsortiumName", this.ConsortiumName);
            this.SetParamSimple(map, prefix + "AgencyId", this.AgencyId);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "TotalNetworkNode", this.TotalNetworkNode);
            this.SetParamSimple(map, prefix + "TotalCreateNode", this.TotalCreateNode);
            this.SetParamSimple(map, prefix + "TotalGroups", this.TotalGroups);
            this.SetParamSimple(map, prefix + "DidCount", this.DidCount);
        }
    }
}

