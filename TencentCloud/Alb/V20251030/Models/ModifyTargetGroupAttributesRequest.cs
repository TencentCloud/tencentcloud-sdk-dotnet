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

    public class ModifyTargetGroupAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>是否预览此次请求。</p><ul><li><strong>false</strong>（默认）：发送普通请求，直接修改目标组。</li><li><strong>true</strong>：发送预览请求，检查修改目标组的参数、格式、业务限制等是否符合要求。</li></ul>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// <p>健康检查配置。</p>
        /// </summary>
        [JsonProperty("HealthCheckConfig")]
        public HealthCheckConfig HealthCheckConfig{ get; set; }

        /// <summary>
        /// <p>是否开启长连接。</p>
        /// </summary>
        [JsonProperty("KeepaliveEnabled")]
        public bool? KeepaliveEnabled{ get; set; }

        /// <summary>
        /// <p>调度算法。取值：</p><ul><li><strong>wrr</strong>：加权轮询，按照权重选择后端服务器，权重越高的服务器被轮询到的概率越高。</li><li><strong>wlc</strong>：加权最小连接数，当不同后端服务器权重值相同时，当前连接数越小的后端服务器被轮询到的概率越高。</li></ul>
        /// </summary>
        [JsonProperty("SchedulerAlgorithm")]
        public string SchedulerAlgorithm{ get; set; }

        /// <summary>
        /// <p>会话保持配置。</p>
        /// </summary>
        [JsonProperty("StickySessionConfig")]
        public StickySessionConfig StickySessionConfig{ get; set; }

        /// <summary>
        /// <p>目标组 ID，格式为 lbtg- 后接 8 位字母数字。</p>
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// <p>目标组名称。长度为 1~255 个字符，可包含数字、大小写字母、中文、半角句号（.）、下划线（_）和短划线（-）。不传目标组名称时默认使用ID作为目标组名称。</p>
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamObj(map, prefix + "HealthCheckConfig.", this.HealthCheckConfig);
            this.SetParamSimple(map, prefix + "KeepaliveEnabled", this.KeepaliveEnabled);
            this.SetParamSimple(map, prefix + "SchedulerAlgorithm", this.SchedulerAlgorithm);
            this.SetParamObj(map, prefix + "StickySessionConfig.", this.StickySessionConfig);
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
        }
    }
}

