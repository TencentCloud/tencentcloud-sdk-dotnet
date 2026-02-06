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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventTask : AbstractModel
    {
        
        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 事件任务的id	
        /// </summary>
        [JsonProperty("EventTaskId")]
        public long? EventTaskId{ get; set; }

        /// <summary>
        /// 处理人uin
        /// </summary>
        [JsonProperty("HandleUser")]
        public string HandleUser{ get; set; }

        /// <summary>
        /// 事件名称	
        /// </summary>
        [JsonProperty("EventCode")]
        public string EventCode{ get; set; }

        /// <summary>
        /// CVM相关事件的维修id
        /// </summary>
        [JsonProperty("RepairId")]
        public string RepairId{ get; set; }

        /// <summary>
        /// 事件名称描述	
        /// </summary>
        [JsonProperty("EventNameDescribe")]
        public string EventNameDescribe{ get; set; }

        /// <summary>
        /// 事件等级（0-低；1-中；2-高；3-严重）	
        /// </summary>
        [JsonProperty("EventPriority")]
        public long? EventPriority{ get; set; }

        /// <summary>
        /// 事件详情	
        /// </summary>
        [JsonProperty("EventDetail")]
        public string EventDetail{ get; set; }

        /// <summary>
        /// 影响集群节点	
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// 事件触发时间	
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 事件状态(1-待处理;2-已预约;3-处理中;4-已完成;5-处理中;6-自动处理中;-1-已忽略;-2-已删除)	
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 是否需要授权维修：1-不需要，2-需要
        /// </summary>
        [JsonProperty("NeedAuthorization")]
        public long? NeedAuthorization{ get; set; }

        /// <summary>
        /// 该事件涉及到的操作类型（OnlineMigrationForInstance-实例在线迁移,OnlineMaintenanceForInstance-实例在线维修,等）	
        /// </summary>
        [JsonProperty("OperationType")]
        public string[] OperationType{ get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// 操作指引
        /// </summary>
        [JsonProperty("OperationGuide")]
        public string OperationGuide{ get; set; }

        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "EventTaskId", this.EventTaskId);
            this.SetParamSimple(map, prefix + "HandleUser", this.HandleUser);
            this.SetParamSimple(map, prefix + "EventCode", this.EventCode);
            this.SetParamSimple(map, prefix + "RepairId", this.RepairId);
            this.SetParamSimple(map, prefix + "EventNameDescribe", this.EventNameDescribe);
            this.SetParamSimple(map, prefix + "EventPriority", this.EventPriority);
            this.SetParamSimple(map, prefix + "EventDetail", this.EventDetail);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "NeedAuthorization", this.NeedAuthorization);
            this.SetParamArraySimple(map, prefix + "OperationType.", this.OperationType);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "OperationGuide", this.OperationGuide);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
        }
    }
}

