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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJobResultResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>总记录数.</p>
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// <p>作业 ID。</p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>结果状态（对客）：SUCCEEDED（结果集可用，含 0 行——DDL/DML 等无结果集语句亦归入此类，message 说明）/ UNAVAILABLE（终态无结果：statement 已失败或取消）/ ERROR（结果集拉取出错）/ NOT_READY（结果未就绪）/ NOT_SUPPORTED（作业形态不产出结果集）。</p>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>状态描述（SUCCEEDED 0 行时为无结果集说明；ERROR 为错误信息；UNAVAILABLE 为 statement 失败/取消原因）。</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>列定义列表（按结果集列顺序；State=SUCCEEDED 才有）。</p>
        /// </summary>
        [JsonProperty("Columns")]
        public ResultColumn[] Columns{ get; set; }

        /// <summary>
        /// <p>结果集全量行数（未按在线展示上限封顶）。Total 为在线可见行数，二者不等说明仅部分行可内联查看，完整结果通过 Download 获取。</p>
        /// </summary>
        [JsonProperty("TotalRows")]
        public long? TotalRows{ get; set; }

        /// <summary>
        /// <p>行数据（State=SUCCEEDED 才有），每行为 {"Values": [单元格值...]} 数组。</p>
        /// </summary>
        [JsonProperty("Rows")]
        public ResultRow[] Rows{ get; set; }

        /// <summary>
        /// <p>本页内容是否因响应大小限制被截断（单元格/行超限，结果集仅 1 行时也可能触发）。行数超过在线展示上限不由本标记表达，以 TotalRows > Total 判断，完整结果通过 Download 获取.</p>
        /// </summary>
        [JsonProperty("Truncated")]
        public bool? Truncated{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamSimple(map, prefix + "TotalRows", this.TotalRows);
            this.SetParamArrayObj(map, prefix + "Rows.", this.Rows);
            this.SetParamSimple(map, prefix + "Truncated", this.Truncated);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

