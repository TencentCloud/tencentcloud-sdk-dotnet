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

    public class CreateTargetGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>目标组名称。命名规则：1-80 个英文字母、汉字等国际通用语言字符，数字，连接线“-”、下划线“_”等常见字符（禁止Unicode补充字符，如emoji表情、生僻汉字等）。</p>
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }

        /// <summary>
        /// <p>网关负载均衡后端目标组所属的网络 ID，如vpc-12345678，可以通过 <a href="https://cloud.tencent.com/document/product/215/15778">DescribeVpcs</a>  接口获取。 不填此参数则默认为DefaultVPC。</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>目标组的默认端口， 后续添加服务器时可使用该默认端口。Port和TargetGroupInstances.N中的port二者必填其一。仅支持6081。</p>
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// <p>目标组绑定的后端服务器</p>
        /// </summary>
        [JsonProperty("TargetGroupInstances")]
        public TargetGroupInstance[] TargetGroupInstances{ get; set; }

        /// <summary>
        /// <p>网关负载均衡目标组协议。</p><ul><li>TENCENT_GENEVE ：GENEVE 标准协议</li><li>AWS_GENEVE：GENEVE 兼容协议</li></ul>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>健康检查设置。</p>
        /// </summary>
        [JsonProperty("HealthCheck")]
        public TargetGroupHealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// <p>均衡算法。</p><ul><li>IP_HASH_2_CONSISTENT：二元组一致性哈希</li><li>IP_HASH_3_CONSISTENT：三元组一致性哈希</li><li>IP_HASH_5_CONSISTENT：五元组一致性哈希</li></ul>
        /// </summary>
        [JsonProperty("ScheduleAlgorithm")]
        public string ScheduleAlgorithm{ get; set; }

        /// <summary>
        /// <p>是否支持全死全活。默认支持。</p>
        /// </summary>
        [JsonProperty("AllDeadToAlive")]
        public bool? AllDeadToAlive{ get; set; }

        /// <summary>
        /// <p>标签。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>流量分发方式</p><ul><li>STATELESS：无状态</li><li>STATEFUL： 有状态</li></ul>
        /// </summary>
        [JsonProperty("ForwardingMode")]
        public string ForwardingMode{ get; set; }

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
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamArrayObj(map, prefix + "TargetGroupInstances.", this.TargetGroupInstances);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamSimple(map, prefix + "ScheduleAlgorithm", this.ScheduleAlgorithm);
            this.SetParamSimple(map, prefix + "AllDeadToAlive", this.AllDeadToAlive);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ForwardingMode", this.ForwardingMode);
            this.SetParamSimple(map, prefix + "RescheduleUnbindRs", this.RescheduleUnbindRs);
            this.SetParamSimple(map, prefix + "RescheduleUnbindRsStartTime", this.RescheduleUnbindRsStartTime);
            this.SetParamSimple(map, prefix + "RescheduleUnhealthy", this.RescheduleUnhealthy);
            this.SetParamSimple(map, prefix + "RescheduleUnhealthyStartTime", this.RescheduleUnhealthyStartTime);
        }
    }
}

