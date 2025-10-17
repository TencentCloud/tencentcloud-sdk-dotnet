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

    public class TaskInfoVo : AbstractModel
    {
        
        /// <summary>
        /// 租户id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppID")]
        public string AppID{ get; set; }

        /// <summary>
        /// 项目id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 任务id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 任务类型id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public ulong? TaskTypeId{ get; set; }

        /// <summary>
        /// 主账号id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OnwerUid")]
        public string OnwerUid{ get; set; }

        /// <summary>
        /// 负责人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InChargeId")]
        public string InChargeId{ get; set; }

        /// <summary>
        /// 实例id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// jobId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 引擎类型，DLC、EMR
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// 引擎名称。在wedata侧若获取不到引擎名，则是wedata侧自动生成的标识，与集群侧的引擎名有可能不一致
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineName")]
        public string EngineName{ get; set; }

        /// <summary>
        /// 引擎子类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineSubType")]
        public string EngineSubType{ get; set; }

        /// <summary>
        /// 引擎taskId，集成任务部分会使用资源组的资源运行任务，没有提交到引擎侧，所以没有引擎侧id
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineTaskId")]
        public string EngineTaskId{ get; set; }

        /// <summary>
        /// 引擎执行状态，枚举
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineExeStatus")]
        public string EngineExeStatus{ get; set; }

        /// <summary>
        /// 引擎执行用户
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineExeUser")]
        public string EngineExeUser{ get; set; }

        /// <summary>
        /// 引擎执行开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineExeStartTime")]
        public string EngineExeStartTime{ get; set; }

        /// <summary>
        /// 引擎执行结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineExeEndTime")]
        public string EngineExeEndTime{ get; set; }

        /// <summary>
        /// 数据来源,DATA_INTEGRATION、DATA_EXPLORATION、DATA_QUALITY、OM_CENTER等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductSource")]
        public string ProductSource{ get; set; }

        /// <summary>
        /// 集成任务的任务类型，表明是读端还是写端，可选择READ、WRITE
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntegrationType")]
        public string IntegrationType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "OnwerUid", this.OnwerUid);
            this.SetParamSimple(map, prefix + "InChargeId", this.InChargeId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "EngineName", this.EngineName);
            this.SetParamSimple(map, prefix + "EngineSubType", this.EngineSubType);
            this.SetParamSimple(map, prefix + "EngineTaskId", this.EngineTaskId);
            this.SetParamSimple(map, prefix + "EngineExeStatus", this.EngineExeStatus);
            this.SetParamSimple(map, prefix + "EngineExeUser", this.EngineExeUser);
            this.SetParamSimple(map, prefix + "EngineExeStartTime", this.EngineExeStartTime);
            this.SetParamSimple(map, prefix + "EngineExeEndTime", this.EngineExeEndTime);
            this.SetParamSimple(map, prefix + "ProductSource", this.ProductSource);
            this.SetParamSimple(map, prefix + "IntegrationType", this.IntegrationType);
        }
    }
}

