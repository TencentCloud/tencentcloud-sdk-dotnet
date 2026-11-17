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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UsageTimePoint : AbstractModel
    {
        
        /// <summary>
        /// <p>时间 YYYY-MM-DD HH:00:00</p>
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// <p>上报量</p>
        /// </summary>
        [JsonProperty("ReportVolume")]
        public long? ReportVolume{ get; set; }

        /// <summary>
        /// <p>聚合桶时间。与旧字段 Time 同源，保留 Time 及其格式；按查询服务运行时区输出。</p><p>参数格式：RFC3339，带数值时区偏移，例如 2026-10-01T00:00:00+08:00。</p>
        /// </summary>
        [JsonProperty("Datetime")]
        public string Datetime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "ReportVolume", this.ReportVolume);
            this.SetParamSimple(map, prefix + "Datetime", this.Datetime);
        }
    }
}

