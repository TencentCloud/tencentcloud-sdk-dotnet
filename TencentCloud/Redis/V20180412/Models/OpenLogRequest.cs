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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpenLogRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>指定实例 ID。例如：crs-xjhsdj****。请登录<a href="https://console.cloud.tencent.com/redis">Redis控制台</a>在实例列表复制实例 ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>日志类型。</p><p>枚举值：</p><ul><li>auditLog： 审计日志。</li></ul>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>日志子类型。</p><p>枚举值：</p><ul><li>write： 写命令。</li><li>read： 读命令。</li><li>all： 读写命令。</li></ul>
        /// </summary>
        [JsonProperty("LogSubType")]
        public string LogSubType{ get; set; }

        /// <summary>
        /// <p>日志有效期, 单位：天。</p><p>枚举值：</p><ul><li>7：  7 天</li><li>30： 30 天</li></ul><p>默认值：7</p>
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public long? LogExpireDay{ get; set; }

        /// <summary>
        /// <p>高频日志有效期, 单位：天。</p><p>枚举值：</p><ul><li>7： 7天</li></ul><p>默认值：7</p>
        /// </summary>
        [JsonProperty("HighLogExpireDay")]
        public long? HighLogExpireDay{ get; set; }

        /// <summary>
        /// <p>日志降级策略阈值。当实例 P99 延迟达到该阈值后，系统将自动丢弃审计日志数据，以优先保障业务可用性。</p><ul><li>单位：毫秒。</li><li>默认值：500。</li><li>取值范围：[300, 1000]。</li></ul>
        /// </summary>
        [JsonProperty("DegradeStrategy")]
        public long? DegradeStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "LogSubType", this.LogSubType);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "HighLogExpireDay", this.HighLogExpireDay);
            this.SetParamSimple(map, prefix + "DegradeStrategy", this.DegradeStrategy);
        }
    }
}

