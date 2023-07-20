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

    public class BaselineInstanceVo : AbstractModel
    {
        
        /// <summary>
        /// 基线实例id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 基线id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BaselineId")]
        public long? BaselineId{ get; set; }

        /// <summary>
        /// 基线名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BaselineName")]
        public string BaselineName{ get; set; }

        /// <summary>
        /// 基线类型，D: 天基线 / H 小时基线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BaselineType")]
        public string BaselineType{ get; set; }

        /// <summary>
        /// 基线实例数据时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BaselineDataTime")]
        public string BaselineDataTime{ get; set; }

        /// <summary>
        /// 基线实例生成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 基线实例预计完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EstimatedEndTime")]
        public string EstimatedEndTime{ get; set; }

        /// <summary>
        /// 基线实例状态，P:暂停/ SF:安全/ WN:预警/ BL:破线 / TF:任务失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BaselineInstanceStatus")]
        public string BaselineInstanceStatus{ get; set; }

        /// <summary>
        /// 责任人uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InChargeUin")]
        public string InChargeUin{ get; set; }

        /// <summary>
        /// 责任人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InChargeName")]
        public string InChargeName{ get; set; }

        /// <summary>
        /// 预警余量/单位分钟
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WarningMargin")]
        public long? WarningMargin{ get; set; }

        /// <summary>
        /// 承诺时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PromiseTime")]
        public string PromiseTime{ get; set; }

        /// <summary>
        /// 告警级别 N: 普通 / I重要 / E: 紧急
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public string AlarmLevel{ get; set; }

        /// <summary>
        /// 项目id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 基线实例ready状态。NEW_GENERATED_INSTANCE:产生实例/RENDER_DAG:渲染DAG/CALCULATE_PATH:计算路径/COMPLETE:完成
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsReady")]
        public string IsReady{ get; set; }

        /// <summary>
        /// 该基线由哪个机器处理
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShardKey")]
        public string ShardKey{ get; set; }

        /// <summary>
        /// 异常任务实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExceptionalTaskInstances")]
        public BaselineTaskInstanceDto[] ExceptionalTaskInstances{ get; set; }

        /// <summary>
        /// 关联的所有任务实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskInstances")]
        public BaselineTaskInstanceDto[] TaskInstances{ get; set; }

        /// <summary>
        /// 任务实例DAG整体启动时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CriticalStartTime")]
        public string CriticalStartTime{ get; set; }

        /// <summary>
        /// 基线实例上的关键任务实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CriticalTaskInstances")]
        public BaselineTaskInstanceDto[] CriticalTaskInstances{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 基线实例与保障任务实例映射
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BaselineTaskInstances")]
        public BaselineTaskInstanceDto[] BaselineTaskInstances{ get; set; }

        /// <summary>
        /// 租户id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 主账号uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 当前用户uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserUin")]
        public string UserUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "BaselineId", this.BaselineId);
            this.SetParamSimple(map, prefix + "BaselineName", this.BaselineName);
            this.SetParamSimple(map, prefix + "BaselineType", this.BaselineType);
            this.SetParamSimple(map, prefix + "BaselineDataTime", this.BaselineDataTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EstimatedEndTime", this.EstimatedEndTime);
            this.SetParamSimple(map, prefix + "BaselineInstanceStatus", this.BaselineInstanceStatus);
            this.SetParamSimple(map, prefix + "InChargeUin", this.InChargeUin);
            this.SetParamSimple(map, prefix + "InChargeName", this.InChargeName);
            this.SetParamSimple(map, prefix + "WarningMargin", this.WarningMargin);
            this.SetParamSimple(map, prefix + "PromiseTime", this.PromiseTime);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "IsReady", this.IsReady);
            this.SetParamSimple(map, prefix + "ShardKey", this.ShardKey);
            this.SetParamArrayObj(map, prefix + "ExceptionalTaskInstances.", this.ExceptionalTaskInstances);
            this.SetParamArrayObj(map, prefix + "TaskInstances.", this.TaskInstances);
            this.SetParamSimple(map, prefix + "CriticalStartTime", this.CriticalStartTime);
            this.SetParamArrayObj(map, prefix + "CriticalTaskInstances.", this.CriticalTaskInstances);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "BaselineTaskInstances.", this.BaselineTaskInstances);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "UserUin", this.UserUin);
        }
    }
}

