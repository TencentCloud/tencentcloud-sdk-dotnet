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

    public class ModifyMigrateRateLimitRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>迁移任务 Id，可通过<a href="https://cloud.tencent.com/document/product/571/82084">DescribeMigrationJobs</a>接口获取。</p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>迁移任务全量导出线程数、有效值为 1-16</p>
        /// </summary>
        [JsonProperty("DumpThread")]
        public long? DumpThread{ get; set; }

        /// <summary>
        /// <p>迁移全量导出的 Rps 限制、需要大于 0</p>
        /// </summary>
        [JsonProperty("DumpRps")]
        public long? DumpRps{ get; set; }

        /// <summary>
        /// <p>全量导出Bps，单位MB/s，MongoDB专用，上限80</p>
        /// </summary>
        [JsonProperty("DumpBps")]
        public long? DumpBps{ get; set; }

        /// <summary>
        /// <p>迁移任务全量导入线程数、有效值为 1-16</p>
        /// </summary>
        [JsonProperty("LoadThread")]
        public long? LoadThread{ get; set; }

        /// <summary>
        /// <p>迁移任务增量导入线程数、有效值为 1-128</p>
        /// </summary>
        [JsonProperty("SinkerThread")]
        public long? SinkerThread{ get; set; }

        /// <summary>
        /// <p>全量导入Rps限制</p>
        /// </summary>
        [JsonProperty("LoadRps")]
        public long? LoadRps{ get; set; }

        /// <summary>
        /// <p>导入BPS，单位MB/s。目前仅对redis生效，表示目标库单分片流量限制大小</p>
        /// </summary>
        [JsonProperty("LoadBps")]
        public long? LoadBps{ get; set; }

        /// <summary>
        /// <p>目标库分片数，目前仅对redis生效</p>
        /// </summary>
        [JsonProperty("DstShardCount")]
        public long? DstShardCount{ get; set; }

        /// <summary>
        /// <p>增量导入Rps，MongoDB专用，上限30000</p>
        /// </summary>
        [JsonProperty("SinkerRps")]
        public long? SinkerRps{ get; set; }

        /// <summary>
        /// <p>增量导入Bps，单位MB/s，MongoDB专用，上限120</p>
        /// </summary>
        [JsonProperty("SinkerBps")]
        public long? SinkerBps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "DumpThread", this.DumpThread);
            this.SetParamSimple(map, prefix + "DumpRps", this.DumpRps);
            this.SetParamSimple(map, prefix + "DumpBps", this.DumpBps);
            this.SetParamSimple(map, prefix + "LoadThread", this.LoadThread);
            this.SetParamSimple(map, prefix + "SinkerThread", this.SinkerThread);
            this.SetParamSimple(map, prefix + "LoadRps", this.LoadRps);
            this.SetParamSimple(map, prefix + "LoadBps", this.LoadBps);
            this.SetParamSimple(map, prefix + "DstShardCount", this.DstShardCount);
            this.SetParamSimple(map, prefix + "SinkerRps", this.SinkerRps);
            this.SetParamSimple(map, prefix + "SinkerBps", this.SinkerBps);
        }
    }
}

