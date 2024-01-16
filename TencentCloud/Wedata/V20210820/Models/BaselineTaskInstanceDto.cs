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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaselineTaskInstanceDto : AbstractModel
    {
        
        /// <summary>
        /// 任务实例变更记录id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 基线实例id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BaselineInstanceId")]
        public long? BaselineInstanceId{ get; set; }

        /// <summary>
        /// 基线周期, D: 天 / H: 小时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BaselineType")]
        public string BaselineType{ get; set; }

        /// <summary>
        /// 数据时间/基线实例应该应该生成的时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BaselineDataTime")]
        public string BaselineDataTime{ get; set; }

        /// <summary>
        /// 上游实例id,多个实例用,分开.格式为taskId_curRunDate
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpstreamInstanceIds")]
        public string UpstreamInstanceIds{ get; set; }

        /// <summary>
        /// 下游实例id,多个实例用,分开.格式为taskId_curRunDate
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownstreamInstanceIds")]
        public string DownstreamInstanceIds{ get; set; }

        /// <summary>
        /// 是否是保障任务的实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsPromiseTask")]
        public bool? IsPromiseTask{ get; set; }

        /// <summary>
        /// 任务id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务实例的数据时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurRunDate")]
        public string CurRunDate{ get; set; }

        /// <summary>
        /// 任务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 是否在关键路径上，1表示在，0表示不在
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InCriticalPath")]
        public long? InCriticalPath{ get; set; }

        /// <summary>
        /// 是否在DAG首层
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InFirstLevel")]
        public bool? InFirstLevel{ get; set; }

        /// <summary>
        /// 实例预计耗时/单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EstimatedCostTime")]
        public long? EstimatedCostTime{ get; set; }

        /// <summary>
        /// 实例实际耗时/单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActualCostTime")]
        public long? ActualCostTime{ get; set; }

        /// <summary>
        /// 预计最晚开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestStartTime")]
        public string LatestStartTime{ get; set; }

        /// <summary>
        /// 实际开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActualStartTime")]
        public string ActualStartTime{ get; set; }

        /// <summary>
        /// 预计完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EstimatedEndTime")]
        public string EstimatedEndTime{ get; set; }

        /// <summary>
        /// 最晚完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestEndTime")]
        public string LatestEndTime{ get; set; }

        /// <summary>
        /// 实际完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActualEndTime")]
        public string ActualEndTime{ get; set; }

        /// <summary>
        /// 实例运行状态
        /// WAITINT_TO_RUN:等待运行 / RUNNING: 正在运行 / COMPLETED: 执行成功 / FAILED: 执行失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskInstanceStatus")]
        public string TaskInstanceStatus{ get; set; }

        /// <summary>
        /// 项目id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 该基线由哪个机器处理
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShardKey")]
        public string ShardKey{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 当前用户uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserUin")]
        public string UserUin{ get; set; }

        /// <summary>
        /// 主账号uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 租户id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 关键路径依赖
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CriticalDependency")]
        public string CriticalDependency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "BaselineInstanceId", this.BaselineInstanceId);
            this.SetParamSimple(map, prefix + "BaselineType", this.BaselineType);
            this.SetParamSimple(map, prefix + "BaselineDataTime", this.BaselineDataTime);
            this.SetParamSimple(map, prefix + "UpstreamInstanceIds", this.UpstreamInstanceIds);
            this.SetParamSimple(map, prefix + "DownstreamInstanceIds", this.DownstreamInstanceIds);
            this.SetParamSimple(map, prefix + "IsPromiseTask", this.IsPromiseTask);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "CurRunDate", this.CurRunDate);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "InCriticalPath", this.InCriticalPath);
            this.SetParamSimple(map, prefix + "InFirstLevel", this.InFirstLevel);
            this.SetParamSimple(map, prefix + "EstimatedCostTime", this.EstimatedCostTime);
            this.SetParamSimple(map, prefix + "ActualCostTime", this.ActualCostTime);
            this.SetParamSimple(map, prefix + "LatestStartTime", this.LatestStartTime);
            this.SetParamSimple(map, prefix + "ActualStartTime", this.ActualStartTime);
            this.SetParamSimple(map, prefix + "EstimatedEndTime", this.EstimatedEndTime);
            this.SetParamSimple(map, prefix + "LatestEndTime", this.LatestEndTime);
            this.SetParamSimple(map, prefix + "ActualEndTime", this.ActualEndTime);
            this.SetParamSimple(map, prefix + "TaskInstanceStatus", this.TaskInstanceStatus);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ShardKey", this.ShardKey);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "UserUin", this.UserUin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CriticalDependency", this.CriticalDependency);
        }
    }
}

