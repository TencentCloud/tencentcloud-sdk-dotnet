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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RayJobEventItem : AbstractModel
    {
        
        /// <summary>
        /// <p>事件时间（Unix 时间戳，毫秒）</p>
        /// </summary>
        [JsonProperty("EventTime")]
        public ulong? EventTime{ get; set; }

        /// <summary>
        /// <p>组件名称，来源于 event.involvedObject.kind</p>
        /// </summary>
        [JsonProperty("Component")]
        public string Component{ get; set; }

        /// <summary>
        /// <p>事件级别，来源于 event.type 的原始值（如 Normal、Warning）</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>事件内容，来源于 event.message</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>关联的 K8s 对象名称，来源于 event.involvedObject.name</p>
        /// </summary>
        [JsonProperty("InvolvedObjectName")]
        public string InvolvedObjectName{ get; set; }

        /// <summary>
        /// <p>事件来源组件，来源于 event.source.component</p>
        /// </summary>
        [JsonProperty("SourceComponent")]
        public string SourceComponent{ get; set; }

        /// <summary>
        /// <p>事件原因，来源于 event.reason</p>
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "InvolvedObjectName", this.InvolvedObjectName);
            this.SetParamSimple(map, prefix + "SourceComponent", this.SourceComponent);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

