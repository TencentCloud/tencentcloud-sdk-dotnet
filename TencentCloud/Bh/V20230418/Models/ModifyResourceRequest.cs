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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>需要开通服务的资源ID</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// </summary>
        [JsonProperty("Status")]
        [System.Obsolete]
        public string Status{ get; set; }

        /// <summary>
        /// <p>实例版本</p>
        /// </summary>
        [JsonProperty("ResourceEdition")]
        public string ResourceEdition{ get; set; }

        /// <summary>
        /// <p>资源节点数</p>
        /// </summary>
        [JsonProperty("ResourceNode")]
        public long? ResourceNode{ get; set; }

        /// <summary>
        /// <p>自动续费</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>带宽扩展包个数(4M)</p>
        /// </summary>
        [JsonProperty("PackageBandwidth")]
        public long? PackageBandwidth{ get; set; }

        /// <summary>
        /// <p>授权点数扩展包个数(50点)</p>
        /// </summary>
        [JsonProperty("PackageNode")]
        public long? PackageNode{ get; set; }

        /// <summary>
        /// <p>日志投递</p>
        /// </summary>
        [JsonProperty("LogDelivery")]
        public long? LogDelivery{ get; set; }

        /// <summary>
        /// <p>零信任堡垒机功能包</p><p>枚举值：</p><ul><li>0： 不开通</li><li>1： 付费版（含 20 用户 / 10Mbps 带宽）</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("IOAResource")]
        public ulong? IOAResource{ get; set; }

        /// <summary>
        /// <p>零信任用户扩展包，1 个 = 20 用户</p><p>取值范围：[0, 999]</p>
        /// </summary>
        [JsonProperty("PackageIOAUserCount")]
        public ulong? PackageIOAUserCount{ get; set; }

        /// <summary>
        /// <p>零信任带宽扩展包，1 个 = 4Mbps</p><p>取值范围：[0, 509]</p>
        /// </summary>
        [JsonProperty("PackageIOABandwidth")]
        public ulong? PackageIOABandwidth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ResourceEdition", this.ResourceEdition);
            this.SetParamSimple(map, prefix + "ResourceNode", this.ResourceNode);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "PackageBandwidth", this.PackageBandwidth);
            this.SetParamSimple(map, prefix + "PackageNode", this.PackageNode);
            this.SetParamSimple(map, prefix + "LogDelivery", this.LogDelivery);
            this.SetParamSimple(map, prefix + "IOAResource", this.IOAResource);
            this.SetParamSimple(map, prefix + "PackageIOAUserCount", this.PackageIOAUserCount);
            this.SetParamSimple(map, prefix + "PackageIOABandwidth", this.PackageIOABandwidth);
        }
    }
}

