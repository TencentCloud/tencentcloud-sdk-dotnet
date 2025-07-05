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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoadBalancer : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称，可输入 1-200 个字符，允许字符为 a-z，A-Z，0-9，_，-。	
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 实例类型，取值有：
        /// <li>HTTP：HTTP 专用型，支持添加 HTTP 专用型和通用型源站组，仅支持被站点加速相关服务引用（如域名服务和规则引擎）；</li>
        /// <li>GENERAL：通用型，仅支持添加通用型源站组，能被站点加速服务（如域名服务和规则引擎）和四层代理引用。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 健康检查策略。详情请参考 [健康检查策略介绍](https://cloud.tencent.com/document/product/1552/104228)。
        /// </summary>
        [JsonProperty("HealthChecker")]
        public HealthChecker HealthChecker{ get; set; }

        /// <summary>
        /// 源站组间的流量调度策略，取值有：
        /// <li>Pritory：按优先级顺序进行故障转移 。</li>
        /// </summary>
        [JsonProperty("SteeringPolicy")]
        public string SteeringPolicy{ get; set; }

        /// <summary>
        /// 实际访问某源站失败时的请求重试策略，详情请参考 [请求重试策略介绍](https://cloud.tencent.com/document/product/1552/104227)，取值有：
        /// <li>OtherOriginGroup：单次请求失败后，请求优先重试下一优先级源站组；</li>
        /// <li>OtherRecordInOriginGroup：单次请求失败后，请求优先重试同源站组内的其他源站。</li>
        /// </summary>
        [JsonProperty("FailoverPolicy")]
        public string FailoverPolicy{ get; set; }

        /// <summary>
        /// 源站组健康状态。
        /// </summary>
        [JsonProperty("OriginGroupHealthStatus")]
        public OriginGroupHealthStatus[] OriginGroupHealthStatus{ get; set; }

        /// <summary>
        /// 负载均衡状态，取值有：
        /// <li>Pending：部署中；</li>
        /// <li>Deleting：删除中；</li>
        /// <li>Running：已生效。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 该负载均衡实例绑的四层代理实例的列表。
        /// </summary>
        [JsonProperty("L4UsedList")]
        public string[] L4UsedList{ get; set; }

        /// <summary>
        /// 该负载均衡实例绑定的七层域名列表。
        /// </summary>
        [JsonProperty("L7UsedList")]
        public string[] L7UsedList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "HealthChecker.", this.HealthChecker);
            this.SetParamSimple(map, prefix + "SteeringPolicy", this.SteeringPolicy);
            this.SetParamSimple(map, prefix + "FailoverPolicy", this.FailoverPolicy);
            this.SetParamArrayObj(map, prefix + "OriginGroupHealthStatus.", this.OriginGroupHealthStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "L4UsedList.", this.L4UsedList);
            this.SetParamArraySimple(map, prefix + "L7UsedList.", this.L7UsedList);
        }
    }
}

