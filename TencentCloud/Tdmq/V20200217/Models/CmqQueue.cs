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

    public class CmqQueue : AbstractModel
    {
        
        /// <summary>
        /// 消息队列ID。
        /// </summary>
        [JsonProperty("QueueId")]
        public string QueueId{ get; set; }

        /// <summary>
        /// 消息队列名字。
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// 每秒钟生产消息条数的限制，消费消息的大小是该值的1.1倍。
        /// </summary>
        [JsonProperty("Qps")]
        public ulong? Qps{ get; set; }

        /// <summary>
        /// 带宽限制。
        /// </summary>
        [JsonProperty("Bps")]
        public ulong? Bps{ get; set; }

        /// <summary>
        /// 飞行消息最大保留时间，需要小于消息保留周期。
        /// </summary>
        [JsonProperty("MaxDelaySeconds")]
        public ulong? MaxDelaySeconds{ get; set; }

        /// <summary>
        /// 最大堆积消息数。取值范围在公测期间为 1,000,000 - 10,000,000，正式上线后范围可达到 1000,000-1000,000,000。默认取值在公测期间为 10,000,000，正式上线后为 100,000,000。
        /// </summary>
        [JsonProperty("MaxMsgHeapNum")]
        public ulong? MaxMsgHeapNum{ get; set; }

        /// <summary>
        /// 消息接收长轮询等待时间。取值范围0 - 30秒，默认值0。
        /// </summary>
        [JsonProperty("PollingWaitSeconds")]
        public ulong? PollingWaitSeconds{ get; set; }

        /// <summary>
        /// 消息保留周期。取值范围60-1296000秒（1min-15天），默认值345600秒（4 天）。
        /// </summary>
        [JsonProperty("MsgRetentionSeconds")]
        public ulong? MsgRetentionSeconds{ get; set; }

        /// <summary>
        /// 消息可见性超时。取值范围1 - 43200秒（即12小时内），默认值30。
        /// </summary>
        [JsonProperty("VisibilityTimeout")]
        public ulong? VisibilityTimeout{ get; set; }

        /// <summary>
        /// 消息最大长度。取值范围1024 - 1048576 Byte（即1K - 1024K），默认值65536。
        /// </summary>
        [JsonProperty("MaxMsgSize")]
        public ulong? MaxMsgSize{ get; set; }

        /// <summary>
        /// 回溯队列的消息回溯时间最大值，取值范围0 - 43200秒，0表示不开启消息回溯。
        /// </summary>
        [JsonProperty("RewindSeconds")]
        public ulong? RewindSeconds{ get; set; }

        /// <summary>
        /// 队列的创建时间。返回 Unix 时间戳，精确到毫秒。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 最后一次修改队列属性的时间。返回 Unix 时间戳，精确到毫秒。
        /// </summary>
        [JsonProperty("LastModifyTime")]
        public ulong? LastModifyTime{ get; set; }

        /// <summary>
        /// 在队列中处于 Active 状态（不处于被消费状态）的消息总数，为近似值。
        /// </summary>
        [JsonProperty("ActiveMsgNum")]
        public ulong? ActiveMsgNum{ get; set; }

        /// <summary>
        /// 在队列中处于 Inactive 状态（正处于被消费状态）的消息总数，为近似值。
        /// </summary>
        [JsonProperty("InactiveMsgNum")]
        public ulong? InactiveMsgNum{ get; set; }

        /// <summary>
        /// 延迟消息数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DelayMsgNum")]
        public ulong? DelayMsgNum{ get; set; }

        /// <summary>
        /// 已调用 DelMsg 接口删除，但还在回溯保留时间内的消息数量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RewindMsgNum")]
        public ulong? RewindMsgNum{ get; set; }

        /// <summary>
        /// 消息最小未消费时间，单位为秒。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinMsgTime")]
        public ulong? MinMsgTime{ get; set; }

        /// <summary>
        /// 事务消息队列。true表示是事务消息，false表示不是事务消息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Transaction")]
        public bool? Transaction{ get; set; }

        /// <summary>
        /// 死信队列。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeadLetterSource")]
        public CmqDeadLetterSource[] DeadLetterSource{ get; set; }

        /// <summary>
        /// 死信队列策略。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeadLetterPolicy")]
        public CmqDeadLetterPolicy DeadLetterPolicy{ get; set; }

        /// <summary>
        /// 事务消息策略。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransactionPolicy")]
        public CmqTransactionPolicy TransactionPolicy{ get; set; }

        /// <summary>
        /// 创建者Uin。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateUin")]
        public ulong? CreateUin{ get; set; }

        /// <summary>
        /// 关联的标签。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 消息轨迹。true表示开启，false表示不开启。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Trace")]
        public bool? Trace{ get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// 命名空间名称
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// 集群状态，0:创建中，1:正常，2:销毁中，3:已删除，4: 隔离中，5:创建失败，6: 删除失败
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 最大未确认消息数量
        /// </summary>
        [JsonProperty("MaxUnackedMsgNum")]
        public long? MaxUnackedMsgNum{ get; set; }

        /// <summary>
        /// 最大消息堆积大小（字节）
        /// </summary>
        [JsonProperty("MaxMsgBacklogSize")]
        public long? MaxMsgBacklogSize{ get; set; }

        /// <summary>
        /// 队列可回溯存储空间，取值范围1024MB - 10240MB，0表示不开启
        /// </summary>
        [JsonProperty("RetentionSizeInMB")]
        public ulong? RetentionSizeInMB{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueueId", this.QueueId);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "Bps", this.Bps);
            this.SetParamSimple(map, prefix + "MaxDelaySeconds", this.MaxDelaySeconds);
            this.SetParamSimple(map, prefix + "MaxMsgHeapNum", this.MaxMsgHeapNum);
            this.SetParamSimple(map, prefix + "PollingWaitSeconds", this.PollingWaitSeconds);
            this.SetParamSimple(map, prefix + "MsgRetentionSeconds", this.MsgRetentionSeconds);
            this.SetParamSimple(map, prefix + "VisibilityTimeout", this.VisibilityTimeout);
            this.SetParamSimple(map, prefix + "MaxMsgSize", this.MaxMsgSize);
            this.SetParamSimple(map, prefix + "RewindSeconds", this.RewindSeconds);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastModifyTime", this.LastModifyTime);
            this.SetParamSimple(map, prefix + "ActiveMsgNum", this.ActiveMsgNum);
            this.SetParamSimple(map, prefix + "InactiveMsgNum", this.InactiveMsgNum);
            this.SetParamSimple(map, prefix + "DelayMsgNum", this.DelayMsgNum);
            this.SetParamSimple(map, prefix + "RewindMsgNum", this.RewindMsgNum);
            this.SetParamSimple(map, prefix + "MinMsgTime", this.MinMsgTime);
            this.SetParamSimple(map, prefix + "Transaction", this.Transaction);
            this.SetParamArrayObj(map, prefix + "DeadLetterSource.", this.DeadLetterSource);
            this.SetParamObj(map, prefix + "DeadLetterPolicy.", this.DeadLetterPolicy);
            this.SetParamObj(map, prefix + "TransactionPolicy.", this.TransactionPolicy);
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Trace", this.Trace);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MaxUnackedMsgNum", this.MaxUnackedMsgNum);
            this.SetParamSimple(map, prefix + "MaxMsgBacklogSize", this.MaxMsgBacklogSize);
            this.SetParamSimple(map, prefix + "RetentionSizeInMB", this.RetentionSizeInMB);
        }
    }
}

