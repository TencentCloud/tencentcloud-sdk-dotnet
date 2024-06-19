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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BizTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 用户appid
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 延迟执行时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DelayTime")]
        public string DelayTime{ get; set; }

        /// <summary>
        /// 任务失败信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

        /// <summary>
        /// 异步任务流id
        /// </summary>
        [JsonProperty("FlowId")]
        public long? FlowId{ get; set; }

        /// <summary>
        /// 任务输入信息
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// 实例组id
        /// </summary>
        [JsonProperty("InstanceGrpId")]
        [System.Obsolete]
        public string InstanceGrpId{ get; set; }

        /// <summary>
        /// 实例组id
        /// </summary>
        [JsonProperty("InstanceGroupId")]
        public string InstanceGroupId{ get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 任务操作对象id
        /// </summary>
        [JsonProperty("ObjectId")]
        public string ObjectId{ get; set; }

        /// <summary>
        /// 任务操作对象类型
        /// </summary>
        [JsonProperty("ObjectType")]
        public string ObjectType{ get; set; }

        /// <summary>
        /// 操作者uin
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 任务输出信息
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 触发本任务的父任务ID
        /// </summary>
        [JsonProperty("TriggerTaskId")]
        public long? TriggerTaskId{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 任务开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 任务进度
        /// </summary>
        [JsonProperty("Process")]
        public long? Process{ get; set; }

        /// <summary>
        /// 修改参数任务信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyParamsData")]
        public ModifyParamsData[] ModifyParamsData{ get; set; }

        /// <summary>
        /// 创建集群任务信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateClustersData")]
        public CreateClustersData CreateClustersData{ get; set; }

        /// <summary>
        /// 集群回档任务信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RollbackData")]
        public RollbackData RollbackData{ get; set; }

        /// <summary>
        /// 实例变配任务信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyInstanceData")]
        public ModifyInstanceData ModifyInstanceData{ get; set; }

        /// <summary>
        /// 手动备份任务信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ManualBackupData")]
        public ManualBackupData ManualBackupData{ get; set; }

        /// <summary>
        /// 修改内核版本任务信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyDbVersionData")]
        public ModifyDbVersionData ModifyDbVersionData{ get; set; }

        /// <summary>
        /// 集群可用区信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterSlaveData")]
        public ClusterSlaveData ClusterSlaveData{ get; set; }

        /// <summary>
        /// 转换集群日志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SwitchClusterLogBin")]
        public SwitchClusterLogBin SwitchClusterLogBin{ get; set; }

        /// <summary>
        /// 修改实例参数数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyInstanceParamsData")]
        public BizTaskModifyParamsData ModifyInstanceParamsData{ get; set; }

        /// <summary>
        /// 维护时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskMaintainInfo")]
        public TaskMaintainInfo TaskMaintainInfo{ get; set; }

        /// <summary>
        /// 实例日志投递信息
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceCLSDeliveryInfos")]
        public InstanceCLSDeliveryInfo[] InstanceCLSDeliveryInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamSimple(map, prefix + "InstanceGrpId", this.InstanceGrpId);
            this.SetParamSimple(map, prefix + "InstanceGroupId", this.InstanceGroupId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ObjectId", this.ObjectId);
            this.SetParamSimple(map, prefix + "ObjectType", this.ObjectType);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TriggerTaskId", this.TriggerTaskId);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Process", this.Process);
            this.SetParamArrayObj(map, prefix + "ModifyParamsData.", this.ModifyParamsData);
            this.SetParamObj(map, prefix + "CreateClustersData.", this.CreateClustersData);
            this.SetParamObj(map, prefix + "RollbackData.", this.RollbackData);
            this.SetParamObj(map, prefix + "ModifyInstanceData.", this.ModifyInstanceData);
            this.SetParamObj(map, prefix + "ManualBackupData.", this.ManualBackupData);
            this.SetParamObj(map, prefix + "ModifyDbVersionData.", this.ModifyDbVersionData);
            this.SetParamObj(map, prefix + "ClusterSlaveData.", this.ClusterSlaveData);
            this.SetParamObj(map, prefix + "SwitchClusterLogBin.", this.SwitchClusterLogBin);
            this.SetParamObj(map, prefix + "ModifyInstanceParamsData.", this.ModifyInstanceParamsData);
            this.SetParamObj(map, prefix + "TaskMaintainInfo.", this.TaskMaintainInfo);
            this.SetParamArrayObj(map, prefix + "InstanceCLSDeliveryInfos.", this.InstanceCLSDeliveryInfos);
        }
    }
}

