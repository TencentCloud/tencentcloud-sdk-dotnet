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

    public class CreateTargetGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>目标组类型。取值：</p><ul><li><strong>Instance</strong>（默认）：Cvm服务器类型或者Eni网卡类型。</li></ul>
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// <p>私有网络 ID。</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>是否预览此次请求。</p><ul><li><strong>false</strong>（默认）：发送普通请求，直接创建目标组。</li><li><strong>true</strong>：发送预览请求，检查创建目标组的参数、格式、业务限制等是否符合要求。</li></ul>
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
        /// <p>后端服务协议类型。取值：</p><ul><li><strong>HTTP</strong>（默认）：支持绑定HTTP、HTTPS的监听器</li><li><strong>HTTPS</strong>：支持绑定HTTPS类型的监听器</li><li><strong>GRPC</strong>：支持绑定HTTPS类型的监听器</li><li><strong>GRPCS</strong>：支持绑定HTTPS类型的监听器</li></ul>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>调度算法。取值：</p><ul><li><strong>wrr</strong>（默认）：加权轮询，按照权重选择后端服务器，权重越高的服务器被轮询到的概率越高。</li><li><strong>wlc</strong>：加权最小连接数，当不同后端服务器权重值相同时，当前连接数越小的后端服务器被轮询到的概率越高。</li></ul>
        /// </summary>
        [JsonProperty("SchedulerAlgorithm")]
        public string SchedulerAlgorithm{ get; set; }

        /// <summary>
        /// <p>会话保持配置。</p>
        /// </summary>
        [JsonProperty("StickySessionConfig")]
        public StickySessionConfig StickySessionConfig{ get; set; }

        /// <summary>
        /// <p>标签。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>目标组名称。默认为目标组ID。长度为 <strong>1-255</strong> 个字符，可包含数字、大小写字母、中文、半角句号（.）、下划线（_）和短划线（-）。</p>
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamObj(map, prefix + "HealthCheckConfig.", this.HealthCheckConfig);
            this.SetParamSimple(map, prefix + "KeepaliveEnabled", this.KeepaliveEnabled);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "SchedulerAlgorithm", this.SchedulerAlgorithm);
            this.SetParamObj(map, prefix + "StickySessionConfig.", this.StickySessionConfig);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
        }
    }
}

