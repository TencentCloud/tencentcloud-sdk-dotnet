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

    public class TaskGroup : AbstractModel
    {
        
        /// <summary>
        /// 任务动作ID
        /// </summary>
        [JsonProperty("TaskGroupId")]
        public long? TaskGroupId{ get; set; }

        /// <summary>
        /// 分组标题
        /// </summary>
        [JsonProperty("TaskGroupTitle")]
        public string TaskGroupTitle{ get; set; }

        /// <summary>
        /// 分组描述
        /// </summary>
        [JsonProperty("TaskGroupDescription")]
        public string TaskGroupDescription{ get; set; }

        /// <summary>
        /// 任务分组顺序
        /// </summary>
        [JsonProperty("TaskGroupOrder")]
        public long? TaskGroupOrder{ get; set; }

        /// <summary>
        /// 对象类型ID
        /// </summary>
        [JsonProperty("ObjectTypeId")]
        public long? ObjectTypeId{ get; set; }

        /// <summary>
        /// 任务分组创建时间
        /// </summary>
        [JsonProperty("TaskGroupCreateTime")]
        public string TaskGroupCreateTime{ get; set; }

        /// <summary>
        /// 任务分组更新时间
        /// </summary>
        [JsonProperty("TaskGroupUpdateTime")]
        public string TaskGroupUpdateTime{ get; set; }

        /// <summary>
        /// 动作分组动作列表
        /// </summary>
        [JsonProperty("TaskGroupActions")]
        public TaskGroupAction[] TaskGroupActions{ get; set; }

        /// <summary>
        /// 实例列表
        /// </summary>
        [JsonProperty("TaskGroupInstanceList")]
        public string[] TaskGroupInstanceList{ get; set; }

        /// <summary>
        /// 执行模式。1 --- 顺序执行，2 --- 阶段执行
        /// </summary>
        [JsonProperty("TaskGroupMode")]
        public long? TaskGroupMode{ get; set; }

        /// <summary>
        /// 不参演的实例列表
        /// </summary>
        [JsonProperty("TaskGroupDiscardInstanceList")]
        public string[] TaskGroupDiscardInstanceList{ get; set; }

        /// <summary>
        /// 参演实例列表
        /// </summary>
        [JsonProperty("TaskGroupSelectedInstanceList")]
        public string[] TaskGroupSelectedInstanceList{ get; set; }

        /// <summary>
        /// 机器选取规则
        /// </summary>
        [JsonProperty("TaskGroupInstancesExecuteRule")]
        public TaskGroupInstancesExecuteRules[] TaskGroupInstancesExecuteRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskGroupId", this.TaskGroupId);
            this.SetParamSimple(map, prefix + "TaskGroupTitle", this.TaskGroupTitle);
            this.SetParamSimple(map, prefix + "TaskGroupDescription", this.TaskGroupDescription);
            this.SetParamSimple(map, prefix + "TaskGroupOrder", this.TaskGroupOrder);
            this.SetParamSimple(map, prefix + "ObjectTypeId", this.ObjectTypeId);
            this.SetParamSimple(map, prefix + "TaskGroupCreateTime", this.TaskGroupCreateTime);
            this.SetParamSimple(map, prefix + "TaskGroupUpdateTime", this.TaskGroupUpdateTime);
            this.SetParamArrayObj(map, prefix + "TaskGroupActions.", this.TaskGroupActions);
            this.SetParamArraySimple(map, prefix + "TaskGroupInstanceList.", this.TaskGroupInstanceList);
            this.SetParamSimple(map, prefix + "TaskGroupMode", this.TaskGroupMode);
            this.SetParamArraySimple(map, prefix + "TaskGroupDiscardInstanceList.", this.TaskGroupDiscardInstanceList);
            this.SetParamArraySimple(map, prefix + "TaskGroupSelectedInstanceList.", this.TaskGroupSelectedInstanceList);
            this.SetParamArrayObj(map, prefix + "TaskGroupInstancesExecuteRule.", this.TaskGroupInstancesExecuteRule);
        }
    }
}

