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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWHealthCheckSetting : AbstractModel
    {
        
        /// <summary>
        /// <p>健康检查类型</p><p>枚举值：</p><ul><li>MCP： 标准mcp</li><li>HTTP： http</li></ul>
        /// </summary>
        [JsonProperty("HealthCheckType")]
        public string HealthCheckType{ get; set; }

        /// <summary>
        /// <p>检查间隔</p>
        /// </summary>
        [JsonProperty("HealthCheckIntervalSecond")]
        public ulong? HealthCheckIntervalSecond{ get; set; }

        /// <summary>
        /// <p>检查超时时间</p>
        /// </summary>
        [JsonProperty("HealthCheckTimeout")]
        public ulong? HealthCheckTimeout{ get; set; }

        /// <summary>
        /// <p>检查失败阈值</p>
        /// </summary>
        [JsonProperty("HealthCheckFailThreshold")]
        public ulong? HealthCheckFailThreshold{ get; set; }

        /// <summary>
        /// <p>检查恢复阈值</p>
        /// </summary>
        [JsonProperty("HealthCheckRecoverThreshold")]
        public ulong? HealthCheckRecoverThreshold{ get; set; }

        /// <summary>
        /// <p>检查路径</p>
        /// </summary>
        [JsonProperty("HealthCheckPath")]
        public string HealthCheckPath{ get; set; }

        /// <summary>
        /// <p>检查方法</p>
        /// </summary>
        [JsonProperty("HealthCheckMethod")]
        public string HealthCheckMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthCheckType", this.HealthCheckType);
            this.SetParamSimple(map, prefix + "HealthCheckIntervalSecond", this.HealthCheckIntervalSecond);
            this.SetParamSimple(map, prefix + "HealthCheckTimeout", this.HealthCheckTimeout);
            this.SetParamSimple(map, prefix + "HealthCheckFailThreshold", this.HealthCheckFailThreshold);
            this.SetParamSimple(map, prefix + "HealthCheckRecoverThreshold", this.HealthCheckRecoverThreshold);
            this.SetParamSimple(map, prefix + "HealthCheckPath", this.HealthCheckPath);
            this.SetParamSimple(map, prefix + "HealthCheckMethod", this.HealthCheckMethod);
        }
    }
}

