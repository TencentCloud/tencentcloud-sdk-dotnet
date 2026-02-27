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

namespace TencentCloud.Gwlb.V20240906.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTargetGroupAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>目标组的ID，可以通过<a href="https://cloud.tencent.com/document/product/214/40554">DescribeTargetGroups</a>获取。</p>
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// <p>目标组的新名称。命名规则：1-80 个英文字母、汉字等国际通用语言字符，数字，连接线“-”、下划线“_”等常见字符（禁止Unicode补充字符，如emoji表情、生僻汉字等）。</p>
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }

        /// <summary>
        /// <p>健康检查详情。</p>
        /// </summary>
        [JsonProperty("HealthCheck")]
        public TargetGroupHealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// <p>是否支持全死全活。</p>
        /// </summary>
        [JsonProperty("AllDeadToAlive")]
        public bool? AllDeadToAlive{ get; set; }

        /// <summary>
        /// <p>重新调度功能内的解绑后端服务开关，开关打开后解绑后端服务会触发重新调度。</p>
        /// </summary>
        [JsonProperty("RescheduleUnbindRs")]
        public bool? RescheduleUnbindRs{ get; set; }

        /// <summary>
        /// <p>解绑RS后开启重调度的时间，可配置0s-3600s，默认0s</p>
        /// </summary>
        [JsonProperty("RescheduleUnbindRsStartTime")]
        public long? RescheduleUnbindRsStartTime{ get; set; }

        /// <summary>
        /// <p>重新调度功能内的后端服务健康探测异常开关，开关打开后后端服务健康检查异常会触发重新调度。</p>
        /// </summary>
        [JsonProperty("RescheduleUnhealthy")]
        public bool? RescheduleUnhealthy{ get; set; }

        /// <summary>
        /// <p>后端服务健康探测异常后开启重调度的时间，可配置0s-3600s，默认0s</p>
        /// </summary>
        [JsonProperty("RescheduleUnhealthyStartTime")]
        public long? RescheduleUnhealthyStartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamSimple(map, prefix + "AllDeadToAlive", this.AllDeadToAlive);
            this.SetParamSimple(map, prefix + "RescheduleUnbindRs", this.RescheduleUnbindRs);
            this.SetParamSimple(map, prefix + "RescheduleUnbindRsStartTime", this.RescheduleUnbindRsStartTime);
            this.SetParamSimple(map, prefix + "RescheduleUnhealthy", this.RescheduleUnhealthy);
            this.SetParamSimple(map, prefix + "RescheduleUnhealthyStartTime", this.RescheduleUnhealthyStartTime);
        }
    }
}

