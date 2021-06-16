/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class TaskResponseInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务所属Database的名称。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 任务数据量。
        /// </summary>
        [JsonProperty("DataAmount")]
        public long? DataAmount{ get; set; }

        /// <summary>
        /// 任务Id。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 计算时长，单位： ms。
        /// </summary>
        [JsonProperty("UsedTime")]
        public long? UsedTime{ get; set; }

        /// <summary>
        /// 任务输出路径。
        /// </summary>
        [JsonProperty("OutputPath")]
        public string OutputPath{ get; set; }

        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务状态, 0 初始化， 1 执行中， 2 执行成功，3 数据写入中，-1 执行失败。
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// 任务SQL类型，DDL|DML等
        /// </summary>
        [JsonProperty("SQLType")]
        public string SQLType{ get; set; }

        /// <summary>
        /// 任务SQL语句
        /// </summary>
        [JsonProperty("SQL")]
        public string SQL{ get; set; }

        /// <summary>
        /// 结果是否过期。
        /// </summary>
        [JsonProperty("ResultExpired")]
        public bool? ResultExpired{ get; set; }

        /// <summary>
        /// 数据影响统计信息。
        /// </summary>
        [JsonProperty("RowAffectInfo")]
        public string RowAffectInfo{ get; set; }

        /// <summary>
        /// 任务结果数据表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSet")]
        public string DataSet{ get; set; }

        /// <summary>
        /// 失败信息, 例如：errorMessage。该字段已废弃。
        /// </summary>
        [JsonProperty("Error")]
        public string Error{ get; set; }

        /// <summary>
        /// 任务执行进度num/100(%)
        /// </summary>
        [JsonProperty("Percentage")]
        public long? Percentage{ get; set; }

        /// <summary>
        /// 任务执行输出信息。
        /// </summary>
        [JsonProperty("OutputMessage")]
        public string OutputMessage{ get; set; }

        /// <summary>
        /// 执行SQL的引擎类型
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "DataAmount", this.DataAmount);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "UsedTime", this.UsedTime);
            this.SetParamSimple(map, prefix + "OutputPath", this.OutputPath);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "SQLType", this.SQLType);
            this.SetParamSimple(map, prefix + "SQL", this.SQL);
            this.SetParamSimple(map, prefix + "ResultExpired", this.ResultExpired);
            this.SetParamSimple(map, prefix + "RowAffectInfo", this.RowAffectInfo);
            this.SetParamSimple(map, prefix + "DataSet", this.DataSet);
            this.SetParamSimple(map, prefix + "Error", this.Error);
            this.SetParamSimple(map, prefix + "Percentage", this.Percentage);
            this.SetParamSimple(map, prefix + "OutputMessage", this.OutputMessage);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
        }
    }
}

