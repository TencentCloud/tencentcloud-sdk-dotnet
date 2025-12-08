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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Topic : AbstractModel
    {
        
        /// <summary>
        /// 最后一次间隔内发布消息的平均byte大小。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AverageMsgSize")]
        public string AverageMsgSize{ get; set; }

        /// <summary>
        /// 消费者数量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsumerCount")]
        public string ConsumerCount{ get; set; }

        /// <summary>
        /// 被记录下来的消息总数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastConfirmedEntry")]
        public string LastConfirmedEntry{ get; set; }

        /// <summary>
        /// 最后一个ledger创建的时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastLedgerCreatedTimestamp")]
        public string LastLedgerCreatedTimestamp{ get; set; }

        /// <summary>
        /// 本地和复制的发布者每秒发布消息的速率。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgRateIn")]
        public string MsgRateIn{ get; set; }

        /// <summary>
        /// 本地和复制的消费者每秒分发消息的数量之和。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgRateOut")]
        public string MsgRateOut{ get; set; }

        /// <summary>
        /// 本地和复制的发布者每秒发布消息的byte。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgThroughputIn")]
        public string MsgThroughputIn{ get; set; }

        /// <summary>
        /// 本地和复制的消费者每秒分发消息的byte。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgThroughputOut")]
        public string MsgThroughputOut{ get; set; }

        /// <summary>
        /// 被记录下来的消息总数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumberOfEntries")]
        public string NumberOfEntries{ get; set; }

        /// <summary>
        /// 分区数<=0：topic下无子分区。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Partitions")]
        public long? Partitions{ get; set; }

        /// <summary>
        /// 生产者数量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProducerCount")]
        public string ProducerCount{ get; set; }

        /// <summary>
        /// 以byte计算的所有消息存储总量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalSize")]
        public string TotalSize{ get; set; }

        /// <summary>
        /// 分区topic里面的子分区。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubTopicSets")]
        public PartitionsTopic[] SubTopicSets{ get; set; }

        /// <summary>
        /// topic类型描述：
        /// 0：普通消息；
        /// 1：全局顺序消息；
        /// 2：局部顺序消息；
        /// 3：重试队列；
        /// 4：死信队列；
        /// 5：事务消息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicType")]
        public ulong? TopicType{ get; set; }

        /// <summary>
        /// 环境（命名空间）名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 主题名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 说明，128个字符以内。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 创建时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最近修改时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 生产者上限。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProducerLimit")]
        public string ProducerLimit{ get; set; }

        /// <summary>
        /// 消费者上限。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsumerLimit")]
        public string ConsumerLimit{ get; set; }

        /// <summary>
        /// 0: 非持久非分区
        /// 1: 非持久分区
        /// 2: 持久非分区
        /// 3: 持久分区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PulsarTopicType")]
        public long? PulsarTopicType{ get; set; }

        /// <summary>
        /// 未消费消息过期时间，单位：秒
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgTTL")]
        public ulong? MsgTTL{ get; set; }

        /// <summary>
        /// 集群 ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 用户自定义的租户别名，如果没有，会复用专业集群 ID
        /// </summary>
        [JsonProperty("Tenant")]
        public string Tenant{ get; set; }

        /// <summary>
        /// 是否开启异常消费者隔离
        /// </summary>
        [JsonProperty("IsolateConsumerEnable")]
        public bool? IsolateConsumerEnable{ get; set; }

        /// <summary>
        /// 消费者 Ack 超时时间，单位：秒
        /// </summary>
        [JsonProperty("AckTimeOut")]
        public long? AckTimeOut{ get; set; }

        /// <summary>
        /// Pulsar主题消息类型0: 混合消息1:普通消息2:延迟消息
        /// </summary>
        [JsonProperty("PulsarTopicMessageType")]
        public long? PulsarTopicMessageType{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "SubTopicSets.", this.SubTopicSets);
            this.SetParamSimple(map, prefix + "TopicType", this.TopicType);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ProducerLimit", this.ProducerLimit);
            this.SetParamSimple(map, prefix + "ConsumerLimit", this.ConsumerLimit);
            this.SetParamSimple(map, prefix + "PulsarTopicType", this.PulsarTopicType);
            this.SetParamSimple(map, prefix + "MsgTTL", this.MsgTTL);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Tenant", this.Tenant);
            this.SetParamSimple(map, prefix + "IsolateConsumerEnable", this.IsolateConsumerEnable);
            this.SetParamSimple(map, prefix + "AckTimeOut", this.AckTimeOut);
            this.SetParamSimple(map, prefix + "PulsarTopicMessageType", this.PulsarTopicMessageType);
        }
    }
}

