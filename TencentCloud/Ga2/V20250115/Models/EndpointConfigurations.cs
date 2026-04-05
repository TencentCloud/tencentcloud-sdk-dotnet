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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EndpointConfigurations : AbstractModel
    {
        
        /// <summary>
        /// 域名类型。可选值'Domain', 'PublicIp'。
        /// </summary>
        [JsonProperty("EndpointType")]
        public string EndpointType{ get; set; }

        /// <summary>
        /// 域名。
        /// </summary>
        [JsonProperty("EndpointService")]
        public string EndpointService{ get; set; }

        /// <summary>
        /// 权重。
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// 健康检查状态；HEALTH：健康；UNHEALTH：不健康。
        /// </summary>
        [JsonProperty("HealthCheckStatus")]
        public string HealthCheckStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndpointType", this.EndpointType);
            this.SetParamSimple(map, prefix + "EndpointService", this.EndpointService);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "HealthCheckStatus", this.HealthCheckStatus);
        }
    }
}

