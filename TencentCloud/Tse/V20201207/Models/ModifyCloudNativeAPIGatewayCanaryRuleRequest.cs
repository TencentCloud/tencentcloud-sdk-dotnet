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

    public class ModifyCloudNativeAPIGatewayCanaryRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 网关 ID
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 服务 ID
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// 优先级，同一个服务的灰度规则优先级是唯一的
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 灰度规则配置
        /// </summary>
        [JsonProperty("CanaryRule")]
        public CloudNativeAPIGatewayCanaryRule CanaryRule{ get; set; }

        /// <summary>
        /// 灰度规则配置列表，如果配置了此参数，将以此参数为准，忽略Priority和CanaryRule参数
        /// </summary>
        [JsonProperty("CanaryRuleList")]
        public CanaryPriorityRule[] CanaryRuleList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamObj(map, prefix + "CanaryRule.", this.CanaryRule);
            this.SetParamArrayObj(map, prefix + "CanaryRuleList.", this.CanaryRuleList);
        }
    }
}

