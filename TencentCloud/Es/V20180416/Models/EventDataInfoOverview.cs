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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventDataInfoOverview : AbstractModel
    {
        
        /// <summary>
        /// <p>1：硬件异常；2：用户变更；3：智能运维</p>
        /// </summary>
        [JsonProperty("EventType")]
        public long? EventType{ get; set; }

        /// <summary>
        /// <p>事件任务Id</p>
        /// </summary>
        [JsonProperty("EventTaskId")]
        public long? EventTaskId{ get; set; }

        /// <summary>
        /// <p>事件名称</p>
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// <p>事件重要程度;0: 一般  1: 重要</p>
        /// </summary>
        [JsonProperty("EventImportance")]
        public long? EventImportance{ get; set; }

        /// <summary>
        /// <p>事件内容</p>
        /// </summary>
        [JsonProperty("EventContent")]
        public string EventContent{ get; set; }

        /// <summary>
        /// <p>ES集群Id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>集群名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>ES集群节点id</p>
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>节点类型</p>
        /// </summary>
        [JsonProperty("NodeRole")]
        public string NodeRole{ get; set; }

        /// <summary>
        /// <p>事件状态：0:待处理，1:处理中，2:处理完成</p>
        /// </summary>
        [JsonProperty("EventStatus")]
        public long? EventStatus{ get; set; }

        /// <summary>
        /// <p>事件发生时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>事件结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>子事件类型</p>
        /// </summary>
        [JsonProperty("SubEventType")]
        public long? SubEventType{ get; set; }

        /// <summary>
        /// <p>子事件名称</p>
        /// </summary>
        [JsonProperty("SubEventName")]
        public string SubEventName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "EventTaskId", this.EventTaskId);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "EventImportance", this.EventImportance);
            this.SetParamSimple(map, prefix + "EventContent", this.EventContent);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeRole", this.NodeRole);
            this.SetParamSimple(map, prefix + "EventStatus", this.EventStatus);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SubEventType", this.SubEventType);
            this.SetParamSimple(map, prefix + "SubEventName", this.SubEventName);
        }
    }
}

