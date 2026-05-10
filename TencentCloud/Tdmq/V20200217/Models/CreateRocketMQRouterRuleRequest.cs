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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRocketMQRouterRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>true: 立即启动任务<br>false: 创建任务后不立即启动，可以在控制台操作启动</p>
        /// </summary>
        [JsonProperty("StartNow")]
        public bool? StartNow{ get; set; }

        /// <summary>
        /// <p>规则数据结构</p>
        /// </summary>
        [JsonProperty("Rule")]
        public RocketMQRouterRuleInfo Rule{ get; set; }

        /// <summary>
        /// <p>数据同步类型。<br>Topic：按照topic维度同步</p>
        /// </summary>
        [JsonProperty("SyncType")]
        public string SyncType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartNow", this.StartNow);
            this.SetParamObj(map, prefix + "Rule.", this.Rule);
            this.SetParamSimple(map, prefix + "SyncType", this.SyncType);
        }
    }
}

