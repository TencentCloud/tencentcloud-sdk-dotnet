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

namespace TencentCloud.Workbuddyenterprise.V20260709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateScheduledTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>任务关联的 Agent 配置</p>
        /// </summary>
        [JsonProperty("AgentConfig")]
        public AgentConfig AgentConfig{ get; set; }

        /// <summary>
        /// <p>Cron 表达式</p>
        /// </summary>
        [JsonProperty("CronExpr")]
        public string CronExpr{ get; set; }

        /// <summary>
        /// <p>任务描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>调度类型：CRON（按 Cron 周期执行，默认）或 ONCE（单次执行）</p>
        /// </summary>
        [JsonProperty("FrequencyType")]
        public string FrequencyType{ get; set; }

        /// <summary>
        /// <p>生效日期开始时间（YYYY-MM-DD 格式），可选，不传时不限制开始时间</p>
        /// </summary>
        [JsonProperty("EffectiveStart")]
        public string EffectiveStart{ get; set; }

        /// <summary>
        /// <p>生效日期结束时间（YYYY-MM-DD 格式），可选，不传时不限制结束时间</p>
        /// </summary>
        [JsonProperty("EffectiveEnd")]
        public string EffectiveEnd{ get; set; }

        /// <summary>
        /// <p>投递目标集合（BOT_CHANNEL / WEBHOOK 可并存）</p>
        /// </summary>
        [JsonProperty("DeliveryTargetSet")]
        public DeliveryTarget[] DeliveryTargetSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamObj(map, prefix + "AgentConfig.", this.AgentConfig);
            this.SetParamSimple(map, prefix + "CronExpr", this.CronExpr);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "FrequencyType", this.FrequencyType);
            this.SetParamSimple(map, prefix + "EffectiveStart", this.EffectiveStart);
            this.SetParamSimple(map, prefix + "EffectiveEnd", this.EffectiveEnd);
            this.SetParamArrayObj(map, prefix + "DeliveryTargetSet.", this.DeliveryTargetSet);
        }
    }
}

