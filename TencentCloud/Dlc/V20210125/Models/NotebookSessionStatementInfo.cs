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

    public class NotebookSessionStatementInfo : AbstractModel
    {
        
        /// <summary>
        /// 完成时间戳
        /// </summary>
        [JsonProperty("Completed")]
        public long? Completed{ get; set; }

        /// <summary>
        /// 开始时间戳
        /// </summary>
        [JsonProperty("Started")]
        public long? Started{ get; set; }

        /// <summary>
        /// 完成进度，百分制
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// Session Statement唯一标识
        /// </summary>
        [JsonProperty("StatementId")]
        public string StatementId{ get; set; }

        /// <summary>
        /// Session Statement状态，包含：waiting（排队中）、running（运行中）、available（正常）、error（异常）、cancelling（取消中）、cancelled（已取消）
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Statement输出信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutPut")]
        public StatementOutput OutPut{ get; set; }

        /// <summary>
        /// 批任务id
        /// </summary>
        [JsonProperty("BatchId")]
        public string BatchId{ get; set; }

        /// <summary>
        /// 运行语句
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Completed", this.Completed);
            this.SetParamSimple(map, prefix + "Started", this.Started);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "StatementId", this.StatementId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamObj(map, prefix + "OutPut.", this.OutPut);
            this.SetParamSimple(map, prefix + "BatchId", this.BatchId);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}

