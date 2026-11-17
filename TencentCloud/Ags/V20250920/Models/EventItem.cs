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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventItem : AbstractModel
    {
        
        /// <summary>
        /// <p>事件唯一标识，用于区分事件及识别重复投递。聚合模式下为该聚合结果代表事件的标识。</p>
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// <p>事件来源。</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>事件关联的对象类型。</p>
        /// </summary>
        [JsonProperty("ObjectType")]
        public string ObjectType{ get; set; }

        /// <summary>
        /// <p>事件关联的对象 ID。</p>
        /// </summary>
        [JsonProperty("ObjectId")]
        public string ObjectId{ get; set; }

        /// <summary>
        /// <p>事件级别。Normal 表示正常事件，Warning 表示告警事件。</p>
        /// </summary>
        [JsonProperty("EventLevel")]
        public string EventLevel{ get; set; }

        /// <summary>
        /// <p>事件类型。</p>
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// <p>事件原因标识，无原因信息时不返回。例如 Manual 表示通过停止接口主动停止，包括人工、脚本或 SDK 调用，不代表一定由人工操作。</p>
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// <p>事件的说明文本。建议使用 EventType 和 Reason 判断事件类型及原因，不依赖说明文本进行业务判断。</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>事件扩展信息，以 JSON 字符串返回。当前 Sandbox 事件包含 ToolId、ToolType，以及可选的 ToolName。调用方需解析 JSON 字符串后读取扩展字段。</p>
        /// </summary>
        [JsonProperty("Extensions")]
        public string Extensions{ get; set; }

        /// <summary>
        /// <p>事件发生时间，RFC3339 格式。仅 Raw 模式返回。</p>
        /// </summary>
        [JsonProperty("OccurredAt")]
        public string OccurredAt{ get; set; }

        /// <summary>
        /// <p>当前查询范围内，该聚合结果包含的去重事件数。仅 Aggregate 模式返回。当前生命周期事件逐条展示，该值为 1。</p>
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// <p>当前查询范围内，该聚合结果中最早的事件发生时间，RFC3339 格式。仅 Aggregate 模式返回，不代表该对象历史上的首次事件时间。</p>
        /// </summary>
        [JsonProperty("FirstOccurredAt")]
        public string FirstOccurredAt{ get; set; }

        /// <summary>
        /// <p>当前查询范围内，该聚合结果中最近的事件发生时间，RFC3339 格式。仅 Aggregate 模式返回，不代表该对象此后不会再发生事件。</p>
        /// </summary>
        [JsonProperty("LastOccurredAt")]
        public string LastOccurredAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "ObjectType", this.ObjectType);
            this.SetParamSimple(map, prefix + "ObjectId", this.ObjectId);
            this.SetParamSimple(map, prefix + "EventLevel", this.EventLevel);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "Extensions", this.Extensions);
            this.SetParamSimple(map, prefix + "OccurredAt", this.OccurredAt);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "FirstOccurredAt", this.FirstOccurredAt);
            this.SetParamSimple(map, prefix + "LastOccurredAt", this.LastOccurredAt);
        }
    }
}

