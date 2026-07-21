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

    public class MCPTaskResultInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>任务 ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// <p>结果集 Schema</p>
        /// </summary>
        [JsonProperty("ResultSchema")]
        public Column[] ResultSchema{ get; set; }

        /// <summary>
        /// <p>结果集</p>
        /// </summary>
        [JsonProperty("ResultSet")]
        public string ResultSet{ get; set; }

        /// <summary>
        /// <p>是否还有其他结果</p>
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// <p>影响行数</p>
        /// </summary>
        [JsonProperty("RowAffectInfo")]
        public string RowAffectInfo{ get; set; }

        /// <summary>
        /// <p>输出信息</p>
        /// </summary>
        [JsonProperty("OutputMessage")]
        public string OutputMessage{ get; set; }

        /// <summary>
        /// <p>展示 format</p>
        /// </summary>
        [JsonProperty("DisplayFormat")]
        public string DisplayFormat{ get; set; }

        /// <summary>
        /// <p>能否下载</p>
        /// </summary>
        [JsonProperty("CanDownload")]
        public bool? CanDownload{ get; set; }

        /// <summary>
        /// <p>结果花费时间</p><p>单位：毫秒</p>
        /// </summary>
        [JsonProperty("QueryResultTime")]
        public float? QueryResultTime{ get; set; }

        /// <summary>
        /// <p>是否超大</p>
        /// </summary>
        [JsonProperty("IsResultOversize")]
        public bool? IsResultOversize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArrayObj(map, prefix + "ResultSchema.", this.ResultSchema);
            this.SetParamSimple(map, prefix + "ResultSet", this.ResultSet);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "RowAffectInfo", this.RowAffectInfo);
            this.SetParamSimple(map, prefix + "OutputMessage", this.OutputMessage);
            this.SetParamSimple(map, prefix + "DisplayFormat", this.DisplayFormat);
            this.SetParamSimple(map, prefix + "CanDownload", this.CanDownload);
            this.SetParamSimple(map, prefix + "QueryResultTime", this.QueryResultTime);
            this.SetParamSimple(map, prefix + "IsResultOversize", this.IsResultOversize);
        }
    }
}

