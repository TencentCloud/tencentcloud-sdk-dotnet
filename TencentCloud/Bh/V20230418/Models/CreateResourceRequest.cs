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

    public class CreateResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>部署region</p>
        /// </summary>
        [JsonProperty("DeployRegion")]
        public string DeployRegion{ get; set; }

        /// <summary>
        /// <p>部署堡垒机的VpcId</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>部署堡垒机的SubnetId</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>资源类型。取值:standard/pro</p>
        /// </summary>
        [JsonProperty("ResourceEdition")]
        public string ResourceEdition{ get; set; }

        /// <summary>
        /// <p>资源节点数</p>
        /// </summary>
        [JsonProperty("ResourceNode")]
        public long? ResourceNode{ get; set; }

        /// <summary>
        /// <p>计费周期</p>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// <p>计费时长</p>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// <p>计费模式 1预付费</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// <p>自动续费</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>零信任堡垒机功能包</p><p>枚举值：</p><ul><li>0： 不开通</li><li>1： 付费版（含 20 用户 / 10Mbps 带宽）</li></ul>
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
        /// <p>部署zone</p>
        /// </summary>
        [JsonProperty("DeployZone")]
        public string DeployZone{ get; set; }

        /// <summary>
        /// <p>0非试用版，1试用版</p>
        /// </summary>
        [JsonProperty("Trial")]
        public ulong? Trial{ get; set; }

        /// <summary>
        /// <p>是否共享clb</p><p>枚举值：</p><ul><li>0： 不共享</li><li>1： 共享</li></ul><p>默认值：0</p><p>公有云传0</p>
        /// </summary>
        [JsonProperty("ShareClb")]
        public ulong? ShareClb{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeployRegion", this.DeployRegion);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ResourceEdition", this.ResourceEdition);
            this.SetParamSimple(map, prefix + "ResourceNode", this.ResourceNode);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "IOAResource", this.IOAResource);
            this.SetParamSimple(map, prefix + "PackageIOAUserCount", this.PackageIOAUserCount);
            this.SetParamSimple(map, prefix + "PackageIOABandwidth", this.PackageIOABandwidth);
            this.SetParamSimple(map, prefix + "DeployZone", this.DeployZone);
            this.SetParamSimple(map, prefix + "Trial", this.Trial);
            this.SetParamSimple(map, prefix + "ShareClb", this.ShareClb);
        }
    }
}

