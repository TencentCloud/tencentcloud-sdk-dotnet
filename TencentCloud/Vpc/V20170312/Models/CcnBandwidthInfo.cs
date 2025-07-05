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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CcnBandwidthInfo : AbstractModel
    {
        
        /// <summary>
        /// 带宽所属的云联网ID。
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// 实例的创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 实例的过期时间
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// 带宽实例的唯一ID。
        /// </summary>
        [JsonProperty("RegionFlowControlId")]
        public string RegionFlowControlId{ get; set; }

        /// <summary>
        /// 带宽是否自动续费的标记。
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 描述带宽的地域和限速上限信息。在地域间限速的情况下才会返回参数，出口限速模式不返回。
        /// </summary>
        [JsonProperty("CcnRegionBandwidthLimit")]
        public CcnRegionBandwidthLimit CcnRegionBandwidthLimit{ get; set; }

        /// <summary>
        /// 云市场实例ID。
        /// </summary>
        [JsonProperty("MarketId")]
        public string MarketId{ get; set; }

        /// <summary>
        /// 资源绑定的标签列表
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// `true表示`Qos默认带宽；`false`表示非Qos默认带宽；
        /// </summary>
        [JsonProperty("DefaultQosBandwidthFlag")]
        public bool? DefaultQosBandwidthFlag{ get; set; }

        /// <summary>
        /// 服务等级信息。
        /// </summary>
        [JsonProperty("QosLevel")]
        public string QosLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "RegionFlowControlId", this.RegionFlowControlId);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamObj(map, prefix + "CcnRegionBandwidthLimit.", this.CcnRegionBandwidthLimit);
            this.SetParamSimple(map, prefix + "MarketId", this.MarketId);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "DefaultQosBandwidthFlag", this.DefaultQosBandwidthFlag);
            this.SetParamSimple(map, prefix + "QosLevel", this.QosLevel);
        }
    }
}

