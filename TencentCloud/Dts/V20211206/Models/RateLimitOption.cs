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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RateLimitOption : AbstractModel
    {
        
        /// <summary>
        /// <p>当前生效的全量导出线程数，配置任务时可调整该字段值，注意：如果不设置或设置为0则表示保持当前值，最大值为16</p>
        /// </summary>
        [JsonProperty("CurrentDumpThread")]
        public long? CurrentDumpThread{ get; set; }

        /// <summary>
        /// <p>默认的全量导出线程数，该字段仅在出参有意义</p>
        /// </summary>
        [JsonProperty("DefaultDumpThread")]
        public long? DefaultDumpThread{ get; set; }

        /// <summary>
        /// <p>当前生效的全量导出Rps，配置任务时可调整该字段值，注意：如果不设置或设置为0则表示保持当前值，最大值为50000000</p>
        /// </summary>
        [JsonProperty("CurrentDumpRps")]
        public long? CurrentDumpRps{ get; set; }

        /// <summary>
        /// <p>默认的全量导出Rps，该字段仅在出参有意义</p>
        /// </summary>
        [JsonProperty("DefaultDumpRps")]
        public long? DefaultDumpRps{ get; set; }

        /// <summary>
        /// <p>当前生效的全量导入线程数，配置任务时可调整该字段值，注意：如果不设置或设置为0则表示保持当前值，最大值为16</p>
        /// </summary>
        [JsonProperty("CurrentLoadThread")]
        public long? CurrentLoadThread{ get; set; }

        /// <summary>
        /// <p>默认的全量导入线程数，该字段仅在出参有意义</p>
        /// </summary>
        [JsonProperty("DefaultLoadThread")]
        public long? DefaultLoadThread{ get; set; }

        /// <summary>
        /// <p>当前生效的全量导入Rps，配置任务时可调整该字段值，注意：如果不设置或设置为0则表示保持当前值，最大值为50000000</p>
        /// </summary>
        [JsonProperty("CurrentLoadRps")]
        public long? CurrentLoadRps{ get; set; }

        /// <summary>
        /// <p>默认的全量导入Rps，该字段仅在出参有意义</p>
        /// </summary>
        [JsonProperty("DefaultLoadRps")]
        public long? DefaultLoadRps{ get; set; }

        /// <summary>
        /// <p>当前生效的增量导入线程数，配置任务时可调整该字段值，注意：如果不设置或设置为0则表示保持当前值，最大值为128</p>
        /// </summary>
        [JsonProperty("CurrentSinkerThread")]
        public long? CurrentSinkerThread{ get; set; }

        /// <summary>
        /// <p>默认的增量导入线程数，该字段仅在出参有意义</p>
        /// </summary>
        [JsonProperty("DefaultSinkerThread")]
        public long? DefaultSinkerThread{ get; set; }

        /// <summary>
        /// <p>enum:&quot;no&quot;/&quot;yes&quot;、no表示用户未设置过限速、yes表示设置过限速，该字段仅在出参有意义</p>
        /// </summary>
        [JsonProperty("HasUserSetRateLimit")]
        public string HasUserSetRateLimit{ get; set; }

        /// <summary>
        /// <p>默认的全量导出BPS，目前仅支持mongodb链路，单位MB/s</p>
        /// </summary>
        [JsonProperty("DefaultDumpBps")]
        public long? DefaultDumpBps{ get; set; }

        /// <summary>
        /// <p>增量导入RPS，目前仅支持mongodb链路</p>
        /// </summary>
        [JsonProperty("CurrentSinkerRps")]
        public long? CurrentSinkerRps{ get; set; }

        /// <summary>
        /// <p>默认的增量导入RPS，目前仅支持mongodb链路</p>
        /// </summary>
        [JsonProperty("DefaultSinkerRps")]
        public long? DefaultSinkerRps{ get; set; }

        /// <summary>
        /// <p>当前导入BPS，暂时只有redis在用，单位MB/s</p>
        /// </summary>
        [JsonProperty("CurrentLoadBps")]
        public long? CurrentLoadBps{ get; set; }

        /// <summary>
        /// <p>目标库分片数，暂时只有redis在用</p>
        /// </summary>
        [JsonProperty("CurrentDstShardCount")]
        public long? CurrentDstShardCount{ get; set; }

        /// <summary>
        /// <p>全量导出BPS，目前仅支持mongodb链路，单位MB/s</p>
        /// </summary>
        [JsonProperty("CurrentDumpBps")]
        public long? CurrentDumpBps{ get; set; }

        /// <summary>
        /// <p>增量导入BPS，目前仅支持mongodb链路，单位MB/s</p>
        /// </summary>
        [JsonProperty("CurrentSinkerBps")]
        public long? CurrentSinkerBps{ get; set; }

        /// <summary>
        /// <p>默认的增量导入BPS，目前仅支持mongodb链路，单位MB/s</p>
        /// </summary>
        [JsonProperty("DefaultSinkerBps")]
        public long? DefaultSinkerBps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrentDumpThread", this.CurrentDumpThread);
            this.SetParamSimple(map, prefix + "DefaultDumpThread", this.DefaultDumpThread);
            this.SetParamSimple(map, prefix + "CurrentDumpRps", this.CurrentDumpRps);
            this.SetParamSimple(map, prefix + "DefaultDumpRps", this.DefaultDumpRps);
            this.SetParamSimple(map, prefix + "CurrentLoadThread", this.CurrentLoadThread);
            this.SetParamSimple(map, prefix + "DefaultLoadThread", this.DefaultLoadThread);
            this.SetParamSimple(map, prefix + "CurrentLoadRps", this.CurrentLoadRps);
            this.SetParamSimple(map, prefix + "DefaultLoadRps", this.DefaultLoadRps);
            this.SetParamSimple(map, prefix + "CurrentSinkerThread", this.CurrentSinkerThread);
            this.SetParamSimple(map, prefix + "DefaultSinkerThread", this.DefaultSinkerThread);
            this.SetParamSimple(map, prefix + "HasUserSetRateLimit", this.HasUserSetRateLimit);
            this.SetParamSimple(map, prefix + "DefaultDumpBps", this.DefaultDumpBps);
            this.SetParamSimple(map, prefix + "CurrentSinkerRps", this.CurrentSinkerRps);
            this.SetParamSimple(map, prefix + "DefaultSinkerRps", this.DefaultSinkerRps);
            this.SetParamSimple(map, prefix + "CurrentLoadBps", this.CurrentLoadBps);
            this.SetParamSimple(map, prefix + "CurrentDstShardCount", this.CurrentDstShardCount);
            this.SetParamSimple(map, prefix + "CurrentDumpBps", this.CurrentDumpBps);
            this.SetParamSimple(map, prefix + "CurrentSinkerBps", this.CurrentSinkerBps);
            this.SetParamSimple(map, prefix + "DefaultSinkerBps", this.DefaultSinkerBps);
        }
    }
}

