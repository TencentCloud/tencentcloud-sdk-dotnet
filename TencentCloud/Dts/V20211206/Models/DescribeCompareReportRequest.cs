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

    public class DescribeCompareReportRequest : AbstractModel
    {
        
        /// <summary>
        /// 迁移任务 Id，可通过[DescribeMigrationJobs](https://cloud.tencent.com/document/product/571/82084)接口获取。
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 校验任务 Id，可通过[DescribeMigrationJobs](https://cloud.tencent.com/document/product/571/82084)接口获取。
        /// </summary>
        [JsonProperty("CompareTaskId")]
        public string CompareTaskId{ get; set; }

        /// <summary>
        /// 校验不一致结果的 limit
        /// </summary>
        [JsonProperty("DifferenceLimit")]
        public ulong? DifferenceLimit{ get; set; }

        /// <summary>
        /// 不一致的 Offset
        /// </summary>
        [JsonProperty("DifferenceOffset")]
        public ulong? DifferenceOffset{ get; set; }

        /// <summary>
        /// 搜索条件，不一致的库名
        /// </summary>
        [JsonProperty("DifferenceDB")]
        public string DifferenceDB{ get; set; }

        /// <summary>
        /// 搜索条件，不一致的表名
        /// </summary>
        [JsonProperty("DifferenceTable")]
        public string DifferenceTable{ get; set; }

        /// <summary>
        /// 未校验的 Limit
        /// </summary>
        [JsonProperty("SkippedLimit")]
        public ulong? SkippedLimit{ get; set; }

        /// <summary>
        /// 未校验的 Offset
        /// </summary>
        [JsonProperty("SkippedOffset")]
        public ulong? SkippedOffset{ get; set; }

        /// <summary>
        /// 搜索条件，未校验的库名
        /// </summary>
        [JsonProperty("SkippedDB")]
        public string SkippedDB{ get; set; }

        /// <summary>
        /// 搜索条件，未校验的表名
        /// </summary>
        [JsonProperty("SkippedTable")]
        public string SkippedTable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "CompareTaskId", this.CompareTaskId);
            this.SetParamSimple(map, prefix + "DifferenceLimit", this.DifferenceLimit);
            this.SetParamSimple(map, prefix + "DifferenceOffset", this.DifferenceOffset);
            this.SetParamSimple(map, prefix + "DifferenceDB", this.DifferenceDB);
            this.SetParamSimple(map, prefix + "DifferenceTable", this.DifferenceTable);
            this.SetParamSimple(map, prefix + "SkippedLimit", this.SkippedLimit);
            this.SetParamSimple(map, prefix + "SkippedOffset", this.SkippedOffset);
            this.SetParamSimple(map, prefix + "SkippedDB", this.SkippedDB);
            this.SetParamSimple(map, prefix + "SkippedTable", this.SkippedTable);
        }
    }
}

