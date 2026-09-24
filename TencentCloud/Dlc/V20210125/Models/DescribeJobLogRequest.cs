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

    public class DescribeJobLogRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>作业 ID（必填）。</p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>日志类型（必填）。可选值：SPARK_SQL_OPERATION / SPARK_BATCH_OPERATION / SPARK_LAUNCH / SPARK_DRIVER_STDOUT / SPARK_DRIVER_LOG4J / SPARK_EXECUTOR_STDOUT / SPARK_EXECUTOR_LOG4J。</p>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>Statement 序号（1-based，仅 LogType=SPARK_SQL_OPERATION 时可传），定位多语句作业中的具体语句。</p>
        /// </summary>
        [JsonProperty("StatementIndex")]
        public long? StatementIndex{ get; set; }

        /// <summary>
        /// <p>分页游标（首页不传，后续页原样透传上一响应的 Cursor；不透明，无需解析）。无法续读时以 HasMore=false 终止分页。</p>
        /// </summary>
        [JsonProperty("Cursor")]
        public string Cursor{ get; set; }

        /// <summary>
        /// <p>返回上限（行数），范围 [1, 1000]。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>关键词过滤。</p>
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// <p>Pod 名称过滤。</p>
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// <p>日志级别过滤。取值：ERROR / WARN / INFO / DEBUG / TRACE，非法值拒绝。</p>
        /// </summary>
        [JsonProperty("LogLevel")]
        public string LogLevel{ get; set; }

        /// <summary>
        /// <p>起始时间，Unix 毫秒。</p>
        /// </summary>
        [JsonProperty("From")]
        public long? From{ get; set; }

        /// <summary>
        /// <p>结束时间，Unix 毫秒。</p>
        /// </summary>
        [JsonProperty("To")]
        public long? To{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "StatementIndex", this.StatementIndex);
            this.SetParamSimple(map, prefix + "Cursor", this.Cursor);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "LogLevel", this.LogLevel);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
        }
    }
}

