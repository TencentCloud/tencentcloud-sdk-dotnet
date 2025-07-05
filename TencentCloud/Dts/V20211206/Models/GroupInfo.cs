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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 消费者组账号
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// 消费者组名称
        /// </summary>
        [JsonProperty("ConsumerGroupName")]
        public string ConsumerGroupName{ get; set; }

        /// <summary>
        /// 消费者组备注
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 消费组偏移量。该字段是为了兼容以前单Partition的情况，取值为最后一个分区的偏移量。各分区的偏移量详见StateOfPartition字段
        /// </summary>
        [JsonProperty("ConsumerGroupOffset")]
        public long? ConsumerGroupOffset{ get; set; }

        /// <summary>
        /// 消费组未消费的数据量。该字段是为了兼容以前单Partition的情况，取值为最后一个分区未消费的数据量。各分区未消费数据量详见StateOfPartition字段
        /// </summary>
        [JsonProperty("ConsumerGroupLag")]
        public long? ConsumerGroupLag{ get; set; }

        /// <summary>
        /// 消费延迟(单位为秒)
        /// </summary>
        [JsonProperty("Latency")]
        public long? Latency{ get; set; }

        /// <summary>
        /// 各分区的消费状态
        /// </summary>
        [JsonProperty("StateOfPartition")]
        public MonitorInfo[] StateOfPartition{ get; set; }

        /// <summary>
        /// 消费者组创建时间，格式为YYYY-MM-DD hh:mm:ss
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 消费者组修改时间，格式为YYYY-MM-DD hh:mm:ss
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// 消费者组状态，包括Dead、Empty、Stable等，只有Dead和Empty两种状态可以执行reset操作
        /// </summary>
        [JsonProperty("ConsumerGroupState")]
        public string ConsumerGroupState{ get; set; }

        /// <summary>
        /// 每个消费者正在消费的分区
        /// </summary>
        [JsonProperty("PartitionAssignment")]
        public PartitionAssignment[] PartitionAssignment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "ConsumerGroupName", this.ConsumerGroupName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ConsumerGroupOffset", this.ConsumerGroupOffset);
            this.SetParamSimple(map, prefix + "ConsumerGroupLag", this.ConsumerGroupLag);
            this.SetParamSimple(map, prefix + "Latency", this.Latency);
            this.SetParamArrayObj(map, prefix + "StateOfPartition.", this.StateOfPartition);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "ConsumerGroupState", this.ConsumerGroupState);
            this.SetParamArrayObj(map, prefix + "PartitionAssignment.", this.PartitionAssignment);
        }
    }
}

