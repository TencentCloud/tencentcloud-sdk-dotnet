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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PartitionsTopic : AbstractModel
    {
        
        /// <summary>
        /// 最后一次间隔内发布消息的平均byte大小。
        /// </summary>
        [JsonProperty("AverageMsgSize")]
        public string AverageMsgSize{ get; set; }

        /// <summary>
        /// 消费者数量。
        /// </summary>
        [JsonProperty("ConsumerCount")]
        public string ConsumerCount{ get; set; }

        /// <summary>
        /// 被记录下来的消息总数。
        /// </summary>
        [JsonProperty("LastConfirmedEntry")]
        public string LastConfirmedEntry{ get; set; }

        /// <summary>
        /// 最后一个ledger创建的时间。
        /// </summary>
        [JsonProperty("LastLedgerCreatedTimestamp")]
        public string LastLedgerCreatedTimestamp{ get; set; }

        /// <summary>
        /// 本地和复制的发布者每秒发布消息的速率。
        /// </summary>
        [JsonProperty("MsgRateIn")]
        public string MsgRateIn{ get; set; }

        /// <summary>
        /// 本地和复制的消费者每秒分发消息的数量之和。
        /// </summary>
        [JsonProperty("MsgRateOut")]
        public string MsgRateOut{ get; set; }

        /// <summary>
        /// 本地和复制的发布者每秒发布消息的byte。
        /// </summary>
        [JsonProperty("MsgThroughputIn")]
        public string MsgThroughputIn{ get; set; }

        /// <summary>
        /// 本地和复制的消费者每秒分发消息的byte。
        /// </summary>
        [JsonProperty("MsgThroughputOut")]
        public string MsgThroughputOut{ get; set; }

        /// <summary>
        /// 被记录下来的消息总数。
        /// </summary>
        [JsonProperty("NumberOfEntries")]
        public string NumberOfEntries{ get; set; }

        /// <summary>
        /// 子分区id。
        /// </summary>
        [JsonProperty("Partitions")]
        public long? Partitions{ get; set; }

        /// <summary>
        /// 生产者数量。
        /// </summary>
        [JsonProperty("ProducerCount")]
        public string ProducerCount{ get; set; }

        /// <summary>
        /// 以byte计算的所有消息存储总量。
        /// </summary>
        [JsonProperty("TotalSize")]
        public string TotalSize{ get; set; }

        /// <summary>
        /// topic类型描述。
        /// </summary>
        [JsonProperty("TopicType")]
        public ulong? TopicType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AverageMsgSize", this.AverageMsgSize);
            this.SetParamSimple(map, prefix + "ConsumerCount", this.ConsumerCount);
            this.SetParamSimple(map, prefix + "LastConfirmedEntry", this.LastConfirmedEntry);
            this.SetParamSimple(map, prefix + "LastLedgerCreatedTimestamp", this.LastLedgerCreatedTimestamp);
            this.SetParamSimple(map, prefix + "MsgRateIn", this.MsgRateIn);
            this.SetParamSimple(map, prefix + "MsgRateOut", this.MsgRateOut);
            this.SetParamSimple(map, prefix + "MsgThroughputIn", this.MsgThroughputIn);
            this.SetParamSimple(map, prefix + "MsgThroughputOut", this.MsgThroughputOut);
            this.SetParamSimple(map, prefix + "NumberOfEntries", this.NumberOfEntries);
            this.SetParamSimple(map, prefix + "Partitions", this.Partitions);
            this.SetParamSimple(map, prefix + "ProducerCount", this.ProducerCount);
            this.SetParamSimple(map, prefix + "TotalSize", this.TotalSize);
            this.SetParamSimple(map, prefix + "TopicType", this.TopicType);
        }
    }
}

