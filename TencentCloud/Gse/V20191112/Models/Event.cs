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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Event : AbstractModel
    {
        
        /// <summary>
        /// 事件代码，支持以下的事件代码
        /// 
        /// - FLEET_CREATED 
        /// - FLEET_STATE_DOWNLOADING 
        /// - FLEET_BINARY_DOWNLOAD_FAILED 
        /// - FLEET_CREATION_EXTRACTING_BUILD
        /// - FLEET_CREATION_VALIDATING_RUNTIME_CONFIG
        /// - FLEET_STATE_VALIDATING
        /// - FLEET_STATE_BUILDING 
        /// - FLEET_STATE_ACTIVATING
        /// - FLEET_STATE_ACTIVE
        /// - FLEET_SCALING_EVENT
        /// - FLEET_STATE_ERROR
        /// - FLEET_VALIDATION_LAUNCH_PATH_NOT_FOUND
        /// - FLEET_ACTIVATION_FAILED_NO_INSTANCES
        /// - FLEET_VPC_PEERING_SUCCEEDED
        /// - FLEET_VPC_PEERING_FAILED
        /// - FLEET_VPC_PEERING_DELETE
        /// - FLEET_INITIALIZATION_FAILED
        /// - FLEET_DELETED
        /// - FLEET_STATE_DELETING
        /// - FLEET_ACTIVATION_FAILED
        /// - GAME_SESSION_ACTIVATION_TIMEOUT
        /// </summary>
        [JsonProperty("EventCode")]
        public string EventCode{ get; set; }

        /// <summary>
        /// 事件的唯一标识 ID
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// 事件的发生时间，UTC 时间格式
        /// </summary>
        [JsonProperty("EventTime")]
        public string EventTime{ get; set; }

        /// <summary>
        /// 事件的消息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 事件相关的日志存储路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreSignedLogUrl")]
        public string PreSignedLogUrl{ get; set; }

        /// <summary>
        /// 事件对应的资源对象唯一标识 ID，例如服务器舰队 ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventCode", this.EventCode);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "PreSignedLogUrl", this.PreSignedLogUrl);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
        }
    }
}

