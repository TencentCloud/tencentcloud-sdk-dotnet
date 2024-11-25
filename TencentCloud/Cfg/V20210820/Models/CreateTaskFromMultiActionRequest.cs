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

    public class CreateTaskFromMultiActionRequest : AbstractModel
    {
        
        /// <summary>
        /// 参与演练的实例ID
        /// </summary>
        [JsonProperty("TaskInstances")]
        public string[] TaskInstances{ get; set; }

        /// <summary>
        /// 演练名称，不填则默认取动作名称
        /// </summary>
        [JsonProperty("TaskTitle")]
        public string TaskTitle{ get; set; }

        /// <summary>
        /// 演练描述，不填则默认取动作描述
        /// </summary>
        [JsonProperty("TaskDescription")]
        public string TaskDescription{ get; set; }

        /// <summary>
        /// 演练自动暂停时间，单位分钟, 不填则默认为60
        /// </summary>
        [JsonProperty("TaskPauseDuration")]
        public ulong? TaskPauseDuration{ get; set; }

        /// <summary>
        /// 演练动作组配置
        /// </summary>
        [JsonProperty("TaskAction")]
        public TaskGroupForAction[] TaskAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TaskInstances.", this.TaskInstances);
            this.SetParamSimple(map, prefix + "TaskTitle", this.TaskTitle);
            this.SetParamSimple(map, prefix + "TaskDescription", this.TaskDescription);
            this.SetParamSimple(map, prefix + "TaskPauseDuration", this.TaskPauseDuration);
            this.SetParamArrayObj(map, prefix + "TaskAction.", this.TaskAction);
        }
    }
}

