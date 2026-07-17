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

    public class DescribeInferenceServiceDeploymentLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 推理服务 ID。
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// 部署记录 ID。
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 需检索日志的开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 需检索日志的结束时间。默认查询时间范围（EndTime - StartTime）为最近 7 天。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 排序字段，取值有：<li>timestamp：日志生成时间。</li>默认值为：timestamp。
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// 排序方式，取值有：<li>asc：升序方式；</li><li>desc：降序方式。</li>默认值为：desc。
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }

        /// <summary>
        /// 分页偏移量，默认值：0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回记录条数，默认值：20，最大值：1000。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

