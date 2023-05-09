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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// 任务 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// 任务开始时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务类型。
        /// - FLOW_CREATE：创建实例。
        /// - FLOW_MODIFYCONNECTIONCONFIG：调整带宽连接数。
        /// - FLOW_MODIFYINSTANCEPASSWORDFREE：免密变更流程。
        /// - FLOW_CLEARNETWORK：VPC退还中。
        /// - FLOW_SETPWD：设置访问密码。
        /// - FLOW_EXPORSHR：扩缩容流程。
        /// - FLOW_UpgradeArch：实例架构升级流程。
        /// - FLOW_MODIFYINSTANCEPARAMS：修改实例参数。
        /// - FLOW_MODIFYINSTACEREADONLY：只读变更流程。
        /// - FLOW_CLOSE：关闭实例。
        /// - FLOW_DELETE：删除实例。
        /// - FLOW_OPEN_WAN：开启外网。
        /// - FLOW_CLEAN：清空实例。      
        /// - FLOW_MODIFYINSTANCEACCOUNT：修改实例账号。
        /// - FLOW_ENABLEINSTANCE_REPLICATE：开启副本只读。
        /// - FLOW_DISABLEINSTANCE_REPLICATE: 关闭副本只读。
        /// - FLOW_SWITCHINSTANCEVIP：交换实例 VIP。
        /// - FLOW_CHANGE_REPLICA_TO_MSTER：副本节点升主节点。
        /// - FLOW_BACKUPINSTANCE：备份实例。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 实例名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 项目 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 任务进度。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// 任务执行结束时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务执行状态。
        /// 
        /// 0：任务初始化。
        /// 1：执行中。
        /// 2：完成。
        /// 4：失败。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Result")]
        public long? Result{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Result", this.Result);
        }
    }
}

