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

    public class TargetGroupOutput : AbstractModel
    {
        
        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 健康检查配置。
        /// </summary>
        [JsonProperty("HealthCheckConfig")]
        public HealthCheckConfig HealthCheckConfig{ get; set; }

        /// <summary>
        /// 是否开启长连接。
        /// </summary>
        [JsonProperty("KeepaliveEnabled")]
        public bool? KeepaliveEnabled{ get; set; }

        /// <summary>
        /// 后端服务协议类型。取值：
        /// - **HTTP**（默认）：支持绑定HTTP、HTTPS的监听器
        /// - **HTTPS**：支持绑定HTTPS类型的监听器
        /// - **GRPC**：支持绑定HTTPS类型的监听器
        /// - **GRPCS**：支持绑定HTTPS类型的监听器
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 目标组关联的负载均衡数量。
        /// </summary>
        [JsonProperty("RelatedLoadBalancersCount")]
        public long? RelatedLoadBalancersCount{ get; set; }

        /// <summary>
        /// 调度算法。
        /// </summary>
        [JsonProperty("SchedulerAlgorithm")]
        public string SchedulerAlgorithm{ get; set; }

        /// <summary>
        /// 会话保持配置。
        /// </summary>
        [JsonProperty("StickySessionConfig")]
        public StickySessionConfig StickySessionConfig{ get; set; }

        /// <summary>
        /// 标签。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 目标组 ID，格式为 lbtg- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// 目标组名称。默认为目标组ID。长度为 **1-255** 个字符，可包含数字、大小写字母、中文、半角句号（.）、下划线（_）和短划线（-）。
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }

        /// <summary>
        /// 目标组状态。取值：
        /// - **Provisioning**：创建中。
        /// - **ProvisionFailed**：创建失败。
        /// - **Active**: 运行中。
        /// - **Configuring**：配置变更中。
        /// </summary>
        [JsonProperty("TargetGroupStatus")]
        public string TargetGroupStatus{ get; set; }

        /// <summary>
        /// 目标组类型。取值：
        /// - **Instance**：Cvm服务器类型或Eni弹性网卡类型
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// 私有网络 ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "HealthCheckConfig.", this.HealthCheckConfig);
            this.SetParamSimple(map, prefix + "KeepaliveEnabled", this.KeepaliveEnabled);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "RelatedLoadBalancersCount", this.RelatedLoadBalancersCount);
            this.SetParamSimple(map, prefix + "SchedulerAlgorithm", this.SchedulerAlgorithm);
            this.SetParamObj(map, prefix + "StickySessionConfig.", this.StickySessionConfig);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
            this.SetParamSimple(map, prefix + "TargetGroupStatus", this.TargetGroupStatus);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
        }
    }
}

