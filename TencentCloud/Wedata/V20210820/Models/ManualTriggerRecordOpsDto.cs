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

    public class ManualTriggerRecordOpsDto : AbstractModel
    {
        
        /// <summary>
        /// <p>运行触发记录ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerId")]
        public string TriggerId{ get; set; }

        /// <summary>
        /// <p>用户提交运行时配置的运行名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// <p>用户提交运行的备注</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>数据时间列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatetimeList")]
        public string[] DatetimeList{ get; set; }

        /// <summary>
        /// <p>任务数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskCnt")]
        public ulong? TaskCnt{ get; set; }

        /// <summary>
        /// <p>实例数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceCnt")]
        public ulong? InstanceCnt{ get; set; }

        /// <summary>
        /// <p>已完成的实例数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinishedInstanceCnt")]
        public ulong? FinishedInstanceCnt{ get; set; }

        /// <summary>
        /// <p>成功的实例数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessInstanceCnt")]
        public ulong? SuccessInstanceCnt{ get; set; }

        /// <summary>
        /// <p>记录运行状态<br> INIT, RUNNING, FINISHED</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>用户提交运行时的入参，主要用于前端反显和记录原始提交信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerParams")]
        public string TriggerParams{ get; set; }

        /// <summary>
        /// <p>用户主账号ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>用户ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserUin")]
        public string UserUin{ get; set; }

        /// <summary>
        /// <p>用户展示名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>租户ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>数据实例时间的时区</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// <p>时间类型，DATA_TIME：数据时间、SCHEDULE_TIME：计划调度时间, 为空时会被当成DATA_TIME处理</p>
        /// </summary>
        [JsonProperty("TimeType")]
        public string TimeType{ get; set; }

        /// <summary>
        /// <p>触发类型</p><p>枚举值：</p><ul><li>SUB_PROCESS_TRIGGER： 由嵌套工作流 SP 任务触发</li><li>SUB_PROCESS_MAKEUP： 由嵌套工作流 SP 任务补录触发</li><li>MANUAL_RUN_BY_USER： 手动触发</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerSource")]
        public string TriggerSource{ get; set; }

        /// <summary>
        /// <p>触发实例ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerSourceId")]
        public string TriggerSourceId{ get; set; }

        /// <summary>
        /// <p>父嵌套工作流任务 ID。仅 <code>triggerSource</code> 以 <code>SUB_PROCESS_</code> 开头时有值</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentSpTaskId")]
        public string ParentSpTaskId{ get; set; }

        /// <summary>
        /// <p>父嵌套工作流任务实例名称（即任务名称）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentSpInstanceName")]
        public string ParentSpInstanceName{ get; set; }

        /// <summary>
        /// <p>父嵌套工作流任务实例数据时间</p><p>参数格式：YYYY-MM-DD hh:mm:ss</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentSpInstanceDataTime")]
        public string ParentSpInstanceDataTime{ get; set; }

        /// <summary>
        /// <p>数据时间列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleTimeList")]
        public string[] ScheduleTimeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TriggerId", this.TriggerId);
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArraySimple(map, prefix + "DatetimeList.", this.DatetimeList);
            this.SetParamSimple(map, prefix + "TaskCnt", this.TaskCnt);
            this.SetParamSimple(map, prefix + "InstanceCnt", this.InstanceCnt);
            this.SetParamSimple(map, prefix + "FinishedInstanceCnt", this.FinishedInstanceCnt);
            this.SetParamSimple(map, prefix + "SuccessInstanceCnt", this.SuccessInstanceCnt);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TriggerParams", this.TriggerParams);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "UserUin", this.UserUin);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamSimple(map, prefix + "TimeType", this.TimeType);
            this.SetParamSimple(map, prefix + "TriggerSource", this.TriggerSource);
            this.SetParamSimple(map, prefix + "TriggerSourceId", this.TriggerSourceId);
            this.SetParamSimple(map, prefix + "ParentSpTaskId", this.ParentSpTaskId);
            this.SetParamSimple(map, prefix + "ParentSpInstanceName", this.ParentSpInstanceName);
            this.SetParamSimple(map, prefix + "ParentSpInstanceDataTime", this.ParentSpInstanceDataTime);
            this.SetParamArraySimple(map, prefix + "ScheduleTimeList.", this.ScheduleTimeList);
        }
    }
}

