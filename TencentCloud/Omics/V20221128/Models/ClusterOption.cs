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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterOption : AbstractModel
    {
        
        /// <summary>
        /// <p>计算集群可用区。</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>计算集群类型，取值范围：</p><ul><li>KUBERNETES</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>计算集群Service CIDR，不能与VPC网段重合。</p>
        /// </summary>
        [JsonProperty("ServiceCidr")]
        public string ServiceCidr{ get; set; }

        /// <summary>
        /// <p>资源配额。</p>
        /// </summary>
        [JsonProperty("ResourceQuota")]
        public ResourceQuota ResourceQuota{ get; set; }

        /// <summary>
        /// <p>限制范围。</p>
        /// </summary>
        [JsonProperty("LimitRange")]
        public LimitRange LimitRange{ get; set; }

        /// <summary>
        /// <p>系统节点池实例规格。详情参见<a href="https://cloud.tencent.com/document/product/213/11518">实例规格</a>描述</p>
        /// </summary>
        [JsonProperty("SystemNodeInstanceType")]
        public string SystemNodeInstanceType{ get; set; }

        /// <summary>
        /// <p>系统节点池实例数量。</p>
        /// </summary>
        [JsonProperty("SystemNodeCount")]
        public ulong? SystemNodeCount{ get; set; }

        /// <summary>
        /// <p>纳管环境自动升配</p>
        /// </summary>
        [JsonProperty("AutoUpgradeClusterLevel")]
        public bool? AutoUpgradeClusterLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ServiceCidr", this.ServiceCidr);
            this.SetParamObj(map, prefix + "ResourceQuota.", this.ResourceQuota);
            this.SetParamObj(map, prefix + "LimitRange.", this.LimitRange);
            this.SetParamSimple(map, prefix + "SystemNodeInstanceType", this.SystemNodeInstanceType);
            this.SetParamSimple(map, prefix + "SystemNodeCount", this.SystemNodeCount);
            this.SetParamSimple(map, prefix + "AutoUpgradeClusterLevel", this.AutoUpgradeClusterLevel);
        }
    }
}

