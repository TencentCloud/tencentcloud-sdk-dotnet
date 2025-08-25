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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePendingSubmitTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 修改类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyType")]
        public string ModifyType{ get; set; }

        /// <summary>
        /// 任务状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// 提交预检查（Y/N）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubmitPreCheck")]
        public string SubmitPreCheck{ get; set; }

        /// <summary>
        /// 提交预检查提交可能会失败的原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubmitPreCheckDetailList")]
        public TaskSubmitPreCheckDetailInfo[] SubmitPreCheckDetailList{ get; set; }

        /// <summary>
        /// 资源组编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// 资源组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorGroupName")]
        public string ExecutorGroupName{ get; set; }

        /// <summary>
        /// <p>任务类型id，取值范围：</p>
        /// <ul>
        /// <li>26 离线集成任务</li>
        /// <li>30 Python任务</li>
        /// <li>31 PySpark任务</li>
        /// <li>34 HiveSQL任务</li>
        /// <li>35 Shell任务</li>
        /// <li>36 SparkSQL任务</li>
        /// <li>21 JdbcSQL任务</li>
        /// <li>23 TDSQL-PostgreSQL任务</li>
        /// <li>32 DLCSQL任务</li>
        /// <li>33 Impala任务</li>
        /// <li>41 Kettle任务</li>
        /// <li>42 Tchouse-X任务</li>
        /// <li>43 TCHouse-X SQL任务</li>
        /// <li>46 DLCSpark任务</li>
        /// <li>50 DLC-PySpark任务</li>
        /// <li>47 TiOne任务</li>
        /// <li>48 Trino任务</li>
        /// <li>39 Spark任务</li>
        /// <li>92 MapReduce任务</li>
        /// <li>38 Shell表单模式任务</li>
        /// <li>130 BranchNode任务</li>
        /// <li>131 MergeNode任务</li>
        /// <li>132 Notebook任务</li>
        /// <li>133 SSH任务</li>
        /// <li>134 StarRocks任务</li>
        /// <li>137 For-each任务</li>
        /// </ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public long? TaskTypeId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "ModifyType", this.ModifyType);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "SubmitPreCheck", this.SubmitPreCheck);
            this.SetParamArrayObj(map, prefix + "SubmitPreCheckDetailList.", this.SubmitPreCheckDetailList);
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "ExecutorGroupName", this.ExecutorGroupName);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
        }
    }
}

