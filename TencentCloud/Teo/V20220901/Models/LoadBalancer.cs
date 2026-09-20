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
        /// <p>实例 ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名称，可输入 1-200 个字符，允许字符为 a-z，A-Z，0-9，_，-。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>实例类型，取值有：</p><li>HTTP_V2：HTTP 专用型（V2），支持添加 HTTP 专用型和通用型源站组，仅支持被站点加速相关服务引用（如域名服务和规则引擎）。该实例类型支持选择发起探测的区域，可显著降低探测请求量但对源站的健康感知灵敏度更低；</li><li>HTTP：HTTP 专用型（V1），支持添加 HTTP 专用型和通用型源站组，仅支持被站点加速相关服务引用（如域名服务和规则引擎）。该实例类型不支持选择发起探测的区域，探测请求量较大但对源站的健康感知灵敏度更高；</li><li>GENERAL：通用型，仅支持添加通用型源站组，能被站点加速服务（如域名服务和规则引擎）和四层代理引用。该实例类型不支持选择发起探测的区域，探测请求量较大但对源站的健康感知灵敏度更高。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>健康检查策略。详情请参考 <a href="https://cloud.tencent.com/document/product/1552/104228">健康检查策略介绍</a>。</p>
        /// </summary>
        [JsonProperty("HealthChecker")]
        public HealthChecker HealthChecker{ get; set; }

        /// <summary>
        /// <p>源站组间的流量调度策略，取值有：</p><li>Pritory：按优先级顺序进行故障转移 。</li>
        /// </summary>
        [JsonProperty("SteeringPolicy")]
        public string SteeringPolicy{ get; set; }

        /// <summary>
        /// <p>实际访问某源站失败时的请求重试策略，详情请参考 <a href="https://cloud.tencent.com/document/product/1552/104227">请求重试策略介绍</a>，取值有：</p><li>OtherOriginGroup：单次请求失败后，请求优先重试下一优先级源站组；</li><li>OtherRecordInOriginGroup：单次请求失败后，请求优先重试同源站组内的其他源站。</li>
        /// </summary>
        [JsonProperty("FailoverPolicy")]
        public string FailoverPolicy{ get; set; }

        /// <summary>
        /// <p>源站组健康状态。</p>
        /// </summary>
        [JsonProperty("OriginGroupHealthStatus")]
        public OriginGroupHealthStatus[] OriginGroupHealthStatus{ get; set; }

        /// <summary>
        /// <p>负载均衡状态，取值有：</p><li>Pending：部署中；</li><li>Deleting：删除中；</li><li>Running：已生效。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>该负载均衡实例绑的四层代理实例的列表。</p>
        /// </summary>
        [JsonProperty("L4UsedList")]
        public string[] L4UsedList{ get; set; }

        /// <summary>
        /// <p>该负载均衡实例绑定的七层域名列表。</p>
        /// </summary>
        [JsonProperty("L7UsedList")]
        public string[] L7UsedList{ get; set; }

        /// <summary>
        /// <p>负载均衡被引用实例的列表。</p>
        /// </summary>
        [JsonProperty("References")]
        public OriginGroupReference[] References{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "References.", this.References);
        }
    }
}

