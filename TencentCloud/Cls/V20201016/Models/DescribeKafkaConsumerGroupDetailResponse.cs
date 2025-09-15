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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeKafkaConsumerGroupDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 日志集id
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// 消费组名称
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// 消费组信息列表
        /// </summary>
        [JsonProperty("PartitionInfos")]
        public GroupPartitionInfo[] PartitionInfos{ get; set; }

        /// <summary>
        /// Empty：组内没有成员，但存在已提交的偏移量。所有消费者都离开但保留了偏移量
        /// Dead：组内没有成员，且没有已提交的偏移量。组被删除或长时间无活动
        /// Stable：组内成员正常消费，分区分配平衡。正常运行状态
        /// PreparingRebalance：组正在准备重新平衡。有新成员加入或现有成员离开
        /// CompletingRebalance：组正在准备重新平衡。有新成员加入或现有成员离开
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

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
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamArrayObj(map, prefix + "PartitionInfos.", this.PartitionInfos);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

