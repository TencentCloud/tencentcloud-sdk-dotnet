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

    public class TargetHealthStatusInfo : AbstractModel
    {
        
        /// <summary>
        /// 后端服务健康状态。DescribeListenerHealthStatus 仅返回非健康后端时，该值为 UnHealthy。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 后端服务实例 ID，CVM 实例格式为 ins- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("TargetId")]
        public string TargetId{ get; set; }

        /// <summary>
        /// 后端目标服务IP。
        /// </summary>
        [JsonProperty("TargetIp")]
        public string TargetIp{ get; set; }

        /// <summary>
        /// 后端服务器端口。
        /// </summary>
        [JsonProperty("TargetPort")]
        public ulong? TargetPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TargetId", this.TargetId);
            this.SetParamSimple(map, prefix + "TargetIp", this.TargetIp);
            this.SetParamSimple(map, prefix + "TargetPort", this.TargetPort);
        }
    }
}

