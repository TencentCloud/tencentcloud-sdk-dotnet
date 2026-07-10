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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneMappingInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>子网 ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>可用区ID。最多支持添加10个可用区。若当前地域支持2个及以上的可用区，至少需要添加2个可用区。<br>您可以通过调用<a href="https://cloud.tencent.com/document/api/1822/133727">DescribeZones</a>接口获取可用区ID对应的可用区的信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>负载均衡 VIP/EIP 信息</p>
        /// </summary>
        [JsonProperty("LoadBalancerAddress")]
        public LoadBalancerAddress LoadBalancerAddress{ get; set; }

        /// <summary>
        /// <p>可用区状态。取值：</p><ul><li><strong>Active</strong>：运行中。</li><li><strong>Stopped</strong>：已停止。</li><li><strong>Shifted</strong>：已移除。</li><li><strong>Starting</strong>：启动中。</li><li><strong>Stopping</strong>：停止中。</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamObj(map, prefix + "LoadBalancerAddress.", this.LoadBalancerAddress);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

