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

    public class ModifyLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 负载均衡实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称，可输入 1-200 个字符，允许字符为 a-z，A-Z，0-9，_，-。不填写表示维持原有配置。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 源站组列表及其对应的容灾调度优先级。详情请参考 [快速创建负载均衡实例](https://cloud.tencent.com/document/product/1552/104223) 中的示例场景。不填写表示维持原有配置。
        /// </summary>
        [JsonProperty("OriginGroups")]
        public OriginGroupInLoadBalancer[] OriginGroups{ get; set; }

        /// <summary>
        /// 健康检查策略。详情请参考 [健康检查策略介绍](https://cloud.tencent.com/document/product/1552/104228)。不填写表示维持原有配置。
        /// </summary>
        [JsonProperty("HealthChecker")]
        public HealthChecker HealthChecker{ get; set; }

        /// <summary>
        /// 源站组间的流量调度策略，取值有：
        /// <li>Pritory：按优先级顺序进行故障转移 。</li>不填写表示维持原有配置。
        /// </summary>
        [JsonProperty("SteeringPolicy")]
        public string SteeringPolicy{ get; set; }

        /// <summary>
        /// 实际访问某源站失败时的请求重试策略，详情请参考 [请求重试策略介绍](https://cloud.tencent.com/document/product/1552/104227)，取值有：
        /// <li>OtherOriginGroup：单次请求失败后，请求优先重试下一优先级源站组；</li>
        /// <li>OtherRecordInOriginGroup：单次请求失败后，请求优先重试同源站组内的其他源站。</li>不填写表示维持原有配置。
        /// </summary>
        [JsonProperty("FailoverPolicy")]
        public string FailoverPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "OriginGroups.", this.OriginGroups);
            this.SetParamObj(map, prefix + "HealthChecker.", this.HealthChecker);
            this.SetParamSimple(map, prefix + "SteeringPolicy", this.SteeringPolicy);
            this.SetParamSimple(map, prefix + "FailoverPolicy", this.FailoverPolicy);
        }
    }
}

