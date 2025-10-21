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
        /// 迁移任务 Id，可通过[DescribeMigrationJobs](https://cloud.tencent.com/document/product/571/82084)接口获取。
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 迁移任务全量导出线程数、有效值为 1-16
        /// </summary>
        [JsonProperty("DumpThread")]
        public long? DumpThread{ get; set; }

        /// <summary>
        /// 迁移全量导出的 Rps 限制、需要大于 0
        /// </summary>
        [JsonProperty("DumpRps")]
        public long? DumpRps{ get; set; }

        /// <summary>
        /// 迁移任务全量导入线程数、有效值为 1-16
        /// </summary>
        [JsonProperty("LoadThread")]
        public long? LoadThread{ get; set; }

        /// <summary>
        /// 迁移任务增量导入线程数、有效值为 1-128
        /// </summary>
        [JsonProperty("SinkerThread")]
        public long? SinkerThread{ get; set; }

        /// <summary>
        /// 全量导入Rps限制
        /// </summary>
        [JsonProperty("LoadRps")]
        public long? LoadRps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "DumpThread", this.DumpThread);
            this.SetParamSimple(map, prefix + "DumpRps", this.DumpRps);
            this.SetParamSimple(map, prefix + "LoadThread", this.LoadThread);
            this.SetParamSimple(map, prefix + "SinkerThread", this.SinkerThread);
            this.SetParamSimple(map, prefix + "LoadRps", this.LoadRps);
        }
    }
}

