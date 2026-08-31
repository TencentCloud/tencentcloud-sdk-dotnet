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

    public class ServiceProviderHealthCheckConfigItemInput : AbstractModel
    {
        
        /// <summary>
        /// <p>是否开启健康检查</p><p>枚举值：</p><ul><li>true： 是</li><li>false： 否</li></ul>
        /// </summary>
        [JsonProperty("HealthCheckEnabled")]
        public bool? HealthCheckEnabled{ get; set; }

        /// <summary>
        /// <p>健康检查间隔。支持以300s为步长配置。</p><p>取值范围：[300, 14400]</p><p>单位：s</p><p>默认值：300</p>
        /// </summary>
        [JsonProperty("HealthCheckInterval")]
        public ulong? HealthCheckInterval{ get; set; }

        /// <summary>
        /// <p>不健康阈值。表示当模型连续多少次不健康时认为该模型不健康。</p><p>取值范围：[1, 10]</p>
        /// </summary>
        [JsonProperty("HealthCheckUnhealthyThreshold")]
        public ulong? HealthCheckUnhealthyThreshold{ get; set; }

        /// <summary>
        /// <p>健康检查使用的最大Token数量。部分模型如gpt系列可能仅支持大于等于16。</p><p>取值范围：[1, 1024]</p><p>默认值：1</p>
        /// </summary>
        [JsonProperty("HealthCheckMaxTokens")]
        public ulong? HealthCheckMaxTokens{ get; set; }

        /// <summary>
        /// <p>健康检查协议</p><p>枚举值：</p><ul><li>chat： 表示/chat/completion协议</li><li>messages： 表示/v1/messages协议</li><li>responses： 表示/v1/messages协议</li></ul>
        /// </summary>
        [JsonProperty("HealthCheckProtocol")]
        public string HealthCheckProtocol{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthCheckEnabled", this.HealthCheckEnabled);
            this.SetParamSimple(map, prefix + "HealthCheckInterval", this.HealthCheckInterval);
            this.SetParamSimple(map, prefix + "HealthCheckUnhealthyThreshold", this.HealthCheckUnhealthyThreshold);
            this.SetParamSimple(map, prefix + "HealthCheckMaxTokens", this.HealthCheckMaxTokens);
            this.SetParamSimple(map, prefix + "HealthCheckProtocol", this.HealthCheckProtocol);
        }
    }
}

