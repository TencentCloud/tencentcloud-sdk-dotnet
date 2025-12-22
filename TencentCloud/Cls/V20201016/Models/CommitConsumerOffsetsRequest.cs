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

    public class CommitConsumerOffsetsRequest : AbstractModel
    {
        
        /// <summary>
        /// 消费组标识
        /// </summary>
        [JsonProperty("ConsumerGroup")]
        public string ConsumerGroup{ get; set; }

        /// <summary>
        /// 消费机器名称
        /// </summary>
        [JsonProperty("Consumer")]
        public string Consumer{ get; set; }

        /// <summary>
        /// 日志集id
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// topic分区点位信息
        /// </summary>
        [JsonProperty("TopicPartitionOffsetsInfo")]
        public TopicPartitionOffsetInfo[] TopicPartitionOffsetsInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsumerGroup", this.ConsumerGroup);
            this.SetParamSimple(map, prefix + "Consumer", this.Consumer);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamArrayObj(map, prefix + "TopicPartitionOffsetsInfo.", this.TopicPartitionOffsetsInfo);
        }
    }
}

