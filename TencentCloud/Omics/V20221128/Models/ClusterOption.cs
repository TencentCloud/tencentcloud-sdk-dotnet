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
        /// 计算集群可用区。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 计算集群类型，取值范围：
        /// - KUBERNETES
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 计算集群Service CIDR，不能与VPC网段重合。
        /// </summary>
        [JsonProperty("ServiceCidr")]
        public string ServiceCidr{ get; set; }

        /// <summary>
        /// 资源配额。
        /// </summary>
        [JsonProperty("ResourceQuota")]
        public ResourceQuota ResourceQuota{ get; set; }

        /// <summary>
        /// 限制范围。
        /// </summary>
        [JsonProperty("LimitRange")]
        public LimitRange LimitRange{ get; set; }


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
        }
    }
}

