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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UsageDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>调用来源</p>
        /// </summary>
        [JsonProperty("CallSource")]
        public CallSource CallSource{ get; set; }

        /// <summary>
        /// <p>计量 ID，用于对账/回溯</p>
        /// </summary>
        [JsonProperty("DosageId")]
        public string DosageId{ get; set; }

        /// <summary>
        /// <p>调用时间戳（Unix 秒）</p>
        /// </summary>
        [JsonProperty("EventTime")]
        public string EventTime{ get; set; }

        /// <summary>
        /// <p>MODEL 域专属</p>
        /// </summary>
        [JsonProperty("Model")]
        public ModelUsageDetail Model{ get; set; }

        /// <summary>
        /// <p>PLUGIN 域专属</p>
        /// </summary>
        [JsonProperty("Plugin")]
        public PluginUsageDetail Plugin{ get; set; }

        /// <summary>
        /// <p>调用链路追踪 ID</p>
        /// </summary>
        [JsonProperty("TraceId")]
        public string TraceId{ get; set; }

        /// <summary>
        /// <p>用户 ID</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CallSource.", this.CallSource);
            this.SetParamSimple(map, prefix + "DosageId", this.DosageId);
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
            this.SetParamObj(map, prefix + "Model.", this.Model);
            this.SetParamObj(map, prefix + "Plugin.", this.Plugin);
            this.SetParamSimple(map, prefix + "TraceId", this.TraceId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

