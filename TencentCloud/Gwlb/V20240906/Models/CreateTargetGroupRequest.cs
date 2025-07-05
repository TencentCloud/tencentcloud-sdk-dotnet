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
        /// 目标组名称，限定60个字符。
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }

        /// <summary>
        /// 网关负载均衡后端目标组所属的网络 ID，如vpc-12345678，可以通过 [DescribeVpcs](https://cloud.tencent.com/document/product/215/15778)  接口获取。 不填此参数则默认为DefaultVPC。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 目标组的默认端口， 后续添加服务器时可使用该默认端口。Port和TargetGroupInstances.N中的port二者必填其一。仅支持6081。
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 目标组绑定的后端服务器
        /// </summary>
        [JsonProperty("TargetGroupInstances")]
        public TargetGroupInstance[] TargetGroupInstances{ get; set; }

        /// <summary>
        /// 网关负载均衡目标组协议。
        /// - TENCENT_GENEVE ：GENEVE 标准协议
        /// - AWS_GENEVE：GENEVE 兼容协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 健康检查设置。
        /// </summary>
        [JsonProperty("HealthCheck")]
        public TargetGroupHealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// 均衡算法。
        /// - IP_HASH_3_ELASTIC：弹性哈希
        /// </summary>
        [JsonProperty("ScheduleAlgorithm")]
        public string ScheduleAlgorithm{ get; set; }

        /// <summary>
        /// 是否支持全死全活。默认支持。
        /// </summary>
        [JsonProperty("AllDeadToAlive")]
        public bool? AllDeadToAlive{ get; set; }

        /// <summary>
        /// 标签。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


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
        }
    }
}

