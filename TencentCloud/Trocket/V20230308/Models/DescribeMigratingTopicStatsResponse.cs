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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMigratingTopicStatsResponse : AbstractModel
    {
        
        /// <summary>
        /// 源集群的消费者数量
        /// </summary>
        [JsonProperty("SourceClusterConsumerCount")]
        public long? SourceClusterConsumerCount{ get; set; }

        /// <summary>
        /// 目标集群的消费者数量
        /// </summary>
        [JsonProperty("TargetClusterConsumerCount")]
        public long? TargetClusterConsumerCount{ get; set; }

        /// <summary>
        /// 源集群消费组列表
        /// </summary>
        [JsonProperty("SourceClusterConsumerGroups")]
        public string[] SourceClusterConsumerGroups{ get; set; }

        /// <summary>
        /// 目标集群消费组列表
        /// </summary>
        [JsonProperty("TargetClusterConsumerGroups")]
        public string[] TargetClusterConsumerGroups{ get; set; }

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
            this.SetParamSimple(map, prefix + "SourceClusterConsumerCount", this.SourceClusterConsumerCount);
            this.SetParamSimple(map, prefix + "TargetClusterConsumerCount", this.TargetClusterConsumerCount);
            this.SetParamArraySimple(map, prefix + "SourceClusterConsumerGroups.", this.SourceClusterConsumerGroups);
            this.SetParamArraySimple(map, prefix + "TargetClusterConsumerGroups.", this.TargetClusterConsumerGroups);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

