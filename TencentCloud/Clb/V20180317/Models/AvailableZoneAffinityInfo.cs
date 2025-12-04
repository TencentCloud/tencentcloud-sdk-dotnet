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

    public class AvailableZoneAffinityInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否开启可用区转发亲和。true：开启可用区转发亲和；false：开启可用区转发亲和。
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// 可用区转发亲和失效阈值，当可用区内后端服务健康比例小于该阈值时，负载均衡会退出可用区转发亲和，转为全可用区转发。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExitRatio")]
        public ulong? ExitRatio{ get; set; }

        /// <summary>
        /// 可用区转发亲和的重新生效阈值，当处于全可用区转发，且负载均衡可用区内的后端服务健康比例大于等于该阈值时，负载均衡会重新进入可用区转发亲和。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReentryRatio")]
        public ulong? ReentryRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "ExitRatio", this.ExitRatio);
            this.SetParamSimple(map, prefix + "ReentryRatio", this.ReentryRatio);
        }
    }
}

