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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskGroupAction : AbstractModel
    {
        
        /// <summary>
        /// 任务分组动作ID
        /// </summary>
        [JsonProperty("TaskGroupActionId")]
        public long? TaskGroupActionId{ get; set; }

        /// <summary>
        /// 任务分组动作实例列表
        /// </summary>
        [JsonProperty("TaskGroupInstances")]
        public TaskGroupInstance[] TaskGroupInstances{ get; set; }

        /// <summary>
        /// 动作ID
        /// </summary>
        [JsonProperty("ActionId")]
        public long? ActionId{ get; set; }

        /// <summary>
        /// 分组动作顺序
        /// </summary>
        [JsonProperty("TaskGroupActionOrder")]
        public long? TaskGroupActionOrder{ get; set; }

        /// <summary>
        /// 分组动作通用配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskGroupActionGeneralConfiguration")]
        public string TaskGroupActionGeneralConfiguration{ get; set; }

        /// <summary>
        /// 分组动作自定义配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskGroupActionCustomConfiguration")]
        public string TaskGroupActionCustomConfiguration{ get; set; }

        /// <summary>
        /// 分组动作状态
        /// </summary>
        [JsonProperty("TaskGroupActionStatus")]
        public long? TaskGroupActionStatus{ get; set; }

        /// <summary>
        /// 动作分组创建时间
        /// </summary>
        [JsonProperty("TaskGroupActionCreateTime")]
        public string TaskGroupActionCreateTime{ get; set; }

        /// <summary>
        /// 动作分组更新时间
        /// </summary>
        [JsonProperty("TaskGroupActionUpdateTime")]
        public string TaskGroupActionUpdateTime{ get; set; }

        /// <summary>
        /// 动作名称
        /// </summary>
        [JsonProperty("ActionTitle")]
        public string ActionTitle{ get; set; }

        /// <summary>
        /// 状态类型: 0 -- 无状态，1 -- 成功，2-- 失败，3--终止，4--跳过
        /// </summary>
        [JsonProperty("TaskGroupActionStatusType")]
        public long? TaskGroupActionStatusType{ get; set; }

        /// <summary>
        /// RandomId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskGroupActionRandomId")]
        public long? TaskGroupActionRandomId{ get; set; }

        /// <summary>
        /// RecoverId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskGroupActionRecoverId")]
        public long? TaskGroupActionRecoverId{ get; set; }

        /// <summary>
        /// ExecuteId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskGroupActionExecuteId")]
        public long? TaskGroupActionExecuteId{ get; set; }

        /// <summary>
        /// 调用api类型，0:tat, 1:云api
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionApiType")]
        public long? ActionApiType{ get; set; }

        /// <summary>
        /// 1:故障，2:恢复
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionAttribute")]
        public long? ActionAttribute{ get; set; }

        /// <summary>
        /// 动作类型：平台、自定义
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskGroupActionId", this.TaskGroupActionId);
            this.SetParamArrayObj(map, prefix + "TaskGroupInstances.", this.TaskGroupInstances);
            this.SetParamSimple(map, prefix + "ActionId", this.ActionId);
            this.SetParamSimple(map, prefix + "TaskGroupActionOrder", this.TaskGroupActionOrder);
            this.SetParamSimple(map, prefix + "TaskGroupActionGeneralConfiguration", this.TaskGroupActionGeneralConfiguration);
            this.SetParamSimple(map, prefix + "TaskGroupActionCustomConfiguration", this.TaskGroupActionCustomConfiguration);
            this.SetParamSimple(map, prefix + "TaskGroupActionStatus", this.TaskGroupActionStatus);
            this.SetParamSimple(map, prefix + "TaskGroupActionCreateTime", this.TaskGroupActionCreateTime);
            this.SetParamSimple(map, prefix + "TaskGroupActionUpdateTime", this.TaskGroupActionUpdateTime);
            this.SetParamSimple(map, prefix + "ActionTitle", this.ActionTitle);
            this.SetParamSimple(map, prefix + "TaskGroupActionStatusType", this.TaskGroupActionStatusType);
            this.SetParamSimple(map, prefix + "TaskGroupActionRandomId", this.TaskGroupActionRandomId);
            this.SetParamSimple(map, prefix + "TaskGroupActionRecoverId", this.TaskGroupActionRecoverId);
            this.SetParamSimple(map, prefix + "TaskGroupActionExecuteId", this.TaskGroupActionExecuteId);
            this.SetParamSimple(map, prefix + "ActionApiType", this.ActionApiType);
            this.SetParamSimple(map, prefix + "ActionAttribute", this.ActionAttribute);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
        }
    }
}

