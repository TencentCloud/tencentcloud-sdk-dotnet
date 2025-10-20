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

    public class ReplaceRoutePolicyEntriesRequest : AbstractModel
    {
        
        /// <summary>
        /// 路由策略实例ID，例如：rrp-azd4dt1c。
        /// </summary>
        [JsonProperty("RoutePolicyId")]
        public string RoutePolicyId{ get; set; }

        /// <summary>
        /// 路由策略规则列表。需要指定路由策略规则ID（RoutePolicyEntryId）。
        /// </summary>
        [JsonProperty("RoutePolicyEntrySet")]
        public RoutePolicyEntry[] RoutePolicyEntrySet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoutePolicyId", this.RoutePolicyId);
            this.SetParamArrayObj(map, prefix + "RoutePolicyEntrySet.", this.RoutePolicyEntrySet);
        }
    }
}

