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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Quota : AbstractModel
    {
        
        /// <summary>
        /// 配额名称，取值范围：
        /// <li> TOTAL_OPEN_CLB_QUOTA：用户当前地域下的公网CLB配额 </li>
        /// <li> TOTAL_INTERNAL_CLB_QUOTA：用户当前地域下的内网CLB配额 </li>
        /// <li> TOTAL_LISTENER_QUOTA：一个CLB下的监听器配额 </li>
        /// <li> TOTAL_LISTENER_RULE_QUOTA：一个监听器下的转发规则配额 </li>
        /// <li> TOTAL_TARGET_BIND_QUOTA：一条转发规则下可绑定设备的配额 </li>
        /// <li> TOTAL_SNAT_IP_QUOTA： 一个CLB实例下跨地域2.0的SNAT IP配额 </li>
        /// <li>TOTAL_ISP_CLB_QUOTA：用户当前地域下的三网CLB配额 </li>
        /// <li>TOTAL_FULL_PORT_RANGE_LISTENER_QUOTA：一个CLB实例下的单个协议全端口段监听器配额</li>
        /// </summary>
        [JsonProperty("QuotaId")]
        public string QuotaId{ get; set; }

        /// <summary>
        /// 当前使用数量，为 null 时表示无意义。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QuotaCurrent")]
        public long? QuotaCurrent{ get; set; }

        /// <summary>
        /// 配额数量。
        /// </summary>
        [JsonProperty("QuotaLimit")]
        public long? QuotaLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QuotaId", this.QuotaId);
            this.SetParamSimple(map, prefix + "QuotaCurrent", this.QuotaCurrent);
            this.SetParamSimple(map, prefix + "QuotaLimit", this.QuotaLimit);
        }
    }
}

