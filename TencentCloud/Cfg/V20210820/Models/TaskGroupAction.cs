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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskGroupAction : AbstractModel
    {
        
        /// <summary>
        /// <p>任务分组动作ID</p>
        /// </summary>
        [JsonProperty("TaskGroupActionId")]
        public long? TaskGroupActionId{ get; set; }

        /// <summary>
        /// <p>任务分组动作实例列表</p>
        /// </summary>
        [JsonProperty("TaskGroupInstances")]
        public TaskGroupInstance[] TaskGroupInstances{ get; set; }

        /// <summary>
        /// <p>动作ID</p>
        /// </summary>
        [JsonProperty("ActionId")]
        public long? ActionId{ get; set; }

        /// <summary>
        /// <p>分组动作顺序</p>
        /// </summary>
        [JsonProperty("TaskGroupActionOrder")]
        public long? TaskGroupActionOrder{ get; set; }

        /// <summary>
        /// <p>分组动作通用配置</p>
        /// </summary>
        [JsonProperty("TaskGroupActionGeneralConfiguration")]
        public string TaskGroupActionGeneralConfiguration{ get; set; }

        /// <summary>
        /// <p>分组动作自定义配置</p>
        /// </summary>
        [JsonProperty("TaskGroupActionCustomConfiguration")]
        public string TaskGroupActionCustomConfiguration{ get; set; }

        /// <summary>
        /// <p>分组动作状态</p><p>枚举值：</p><ul><li>2001： 未开始</li><li>2002： 待执行</li><li>2003： 执行中</li><li>2004： 执行结束</li></ul>
        /// </summary>
        [JsonProperty("TaskGroupActionStatus")]
        public long? TaskGroupActionStatus{ get; set; }

        /// <summary>
        /// <p>动作分组创建时间</p>
        /// </summary>
        [JsonProperty("TaskGroupActionCreateTime")]
        public string TaskGroupActionCreateTime{ get; set; }

        /// <summary>
        /// <p>动作分组更新时间</p>
        /// </summary>
        [JsonProperty("TaskGroupActionUpdateTime")]
        public string TaskGroupActionUpdateTime{ get; set; }

        /// <summary>
        /// <p>动作名称</p>
        /// </summary>
        [JsonProperty("ActionTitle")]
        public string ActionTitle{ get; set; }

        /// <summary>
        /// <p>状态类型: 0 -- 无状态，1 -- 成功，2-- 失败，3--终止，4--跳过</p>
        /// </summary>
        [JsonProperty("TaskGroupActionStatusType")]
        public long? TaskGroupActionStatusType{ get; set; }

        /// <summary>
        /// <p>RandomId</p>
        /// </summary>
        [JsonProperty("TaskGroupActionRandomId")]
        public long? TaskGroupActionRandomId{ get; set; }

        /// <summary>
        /// <p>RecoverId</p>
        /// </summary>
        [JsonProperty("TaskGroupActionRecoverId")]
        public long? TaskGroupActionRecoverId{ get; set; }

        /// <summary>
        /// <p>ExecuteId</p>
        /// </summary>
        [JsonProperty("TaskGroupActionExecuteId")]
        public long? TaskGroupActionExecuteId{ get; set; }

        /// <summary>
        /// <p>调用api类型，0:tat, 1:云api</p>
        /// </summary>
        [JsonProperty("ActionApiType")]
        public long? ActionApiType{ get; set; }

        /// <summary>
        /// <p>1:故障，2:恢复</p>
        /// </summary>
        [JsonProperty("ActionAttribute")]
        public long? ActionAttribute{ get; set; }

        /// <summary>
        /// <p>动作类型：平台、自定义</p>
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// <p>是否可重试</p>
        /// </summary>
        [JsonProperty("IsExecuteRedo")]
        public bool? IsExecuteRedo{ get; set; }

        /// <summary>
        /// <p>动作风险级别</p>
        /// </summary>
        [JsonProperty("ActionRisk")]
        public string ActionRisk{ get; set; }

        /// <summary>
        /// <p>动作运行时间</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("TaskGroupActionExecuteTime")]
        public long? TaskGroupActionExecuteTime{ get; set; }

        /// <summary>
        /// <p>动作开始执行时间</p>
        /// </summary>
        [JsonProperty("TaskGroupActionStartTime")]
        public string TaskGroupActionStartTime{ get; set; }


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
            this.SetParamSimple(map, prefix + "IsExecuteRedo", this.IsExecuteRedo);
            this.SetParamSimple(map, prefix + "ActionRisk", this.ActionRisk);
            this.SetParamSimple(map, prefix + "TaskGroupActionExecuteTime", this.TaskGroupActionExecuteTime);
            this.SetParamSimple(map, prefix + "TaskGroupActionStartTime", this.TaskGroupActionStartTime);
        }
    }
}

