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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DoHealthCheckOnMigratingTopicResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否通过	
        /// </summary>
        [JsonProperty("Passed")]
        public bool? Passed{ get; set; }

        /// <summary>
        /// 健康检查返回的错误信息
        /// NotChecked 未执行检查， 
        /// Unknown 未知错误, 
        /// TopicNotImported 主题未导入,
        /// TopicNotExistsInSourceCluster 主题在源集群中不存在, 
        /// TopicNotExistsInTargetCluster 主题在目标集群中不存在, 
        /// ConsumerConnectedOnTarget 目标集群上存在消费者连接, 
        /// SourceTopicHasNewMessagesIn5Minutes 源集群主题前5分钟内有新消息写入, 
        /// TargetTopicHasNewMessagesIn5Minutes 目标集群主题前5分钟内有新消息写入, 
        /// SourceTopicHasNoMessagesIn5Minutes 源集群前5分钟内没有新消息写入, 
        /// TargetTopicHasNoMessagesIn5Minutes 源集群前5分钟内没有新消息写入, 
        /// ConsumerGroupCountNotMatch 订阅组数量不一致, 
        /// SourceTopicHasUnconsumedMessages 源集群主题存在未消费消息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 健康检查返回的错误信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReasonList")]
        public string[] ReasonList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Passed", this.Passed);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamArraySimple(map, prefix + "ReasonList.", this.ReasonList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

