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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateProbeTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 批量任务名-地址
        /// </summary>
        [JsonProperty("BatchTasks")]
        public ProbeTaskBasicConfiguration[] BatchTasks{ get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 拨测节点
        /// </summary>
        [JsonProperty("Nodes")]
        public string[] Nodes{ get; set; }

        /// <summary>
        /// 拨测间隔
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// 拨测参数
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// 任务分类
        /// <li>1 = PC</li>
        /// <li> 2 = Mobile </li>
        /// </summary>
        [JsonProperty("TaskCategory")]
        public long? TaskCategory{ get; set; }

        /// <summary>
        /// 定时任务cron表达式
        /// </summary>
        [JsonProperty("Cron")]
        public string Cron{ get; set; }

        /// <summary>
        /// 资源标签值
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// 测试类型，包含定时测试与即时测试
        /// </summary>
        [JsonProperty("ProbeType")]
        public ulong? ProbeType{ get; set; }

        /// <summary>
        /// 插件类型
        /// </summary>
        [JsonProperty("PluginSource")]
        public string PluginSource{ get; set; }

        /// <summary>
        /// 客户端ID
        /// </summary>
        [JsonProperty("ClientNum")]
        public string ClientNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "BatchTasks.", this.BatchTasks);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "Nodes.", this.Nodes);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamSimple(map, prefix + "TaskCategory", this.TaskCategory);
            this.SetParamSimple(map, prefix + "Cron", this.Cron);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "ProbeType", this.ProbeType);
            this.SetParamSimple(map, prefix + "PluginSource", this.PluginSource);
            this.SetParamSimple(map, prefix + "ClientNum", this.ClientNum);
        }
    }
}

