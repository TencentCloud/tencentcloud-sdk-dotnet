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

namespace TencentCloud.Cmq.V20190304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueueSet : AbstractModel
    {
        
        /// <summary>
        /// QueueId
        /// </summary>
        [JsonProperty("QueueId")]
        public string QueueId{ get; set; }

        /// <summary>
        /// QueueName
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// Qps
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Qps")]
        public ulong? Qps{ get; set; }

        /// <summary>
        /// Bps
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Bps")]
        public ulong? Bps{ get; set; }

        /// <summary>
        /// MaxDelaySeconds
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxDelaySeconds")]
        public ulong? MaxDelaySeconds{ get; set; }

        /// <summary>
        /// MaxMsgHeapNum
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxMsgHeapNum")]
        public ulong? MaxMsgHeapNum{ get; set; }

        /// <summary>
        /// PollingWaitSeconds
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PollingWaitSeconds")]
        public ulong? PollingWaitSeconds{ get; set; }

        /// <summary>
        /// MsgRetentionSeconds
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgRetentionSeconds")]
        public ulong? MsgRetentionSeconds{ get; set; }

        /// <summary>
        /// VisibilityTimeout
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VisibilityTimeout")]
        public ulong? VisibilityTimeout{ get; set; }

        /// <summary>
        /// MaxMsgSize
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxMsgSize")]
        public ulong? MaxMsgSize{ get; set; }

        /// <summary>
        /// RewindSeconds
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RewindSeconds")]
        public ulong? RewindSeconds{ get; set; }

        /// <summary>
        /// CreateTime
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// LastModifyTime
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastModifyTime")]
        public ulong? LastModifyTime{ get; set; }

        /// <summary>
        /// ActiveMsgNum
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActiveMsgNum")]
        public ulong? ActiveMsgNum{ get; set; }

        /// <summary>
        /// InactiveMsgNum
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InactiveMsgNum")]
        public ulong? InactiveMsgNum{ get; set; }

        /// <summary>
        /// DelayMsgNum
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DelayMsgNum")]
        public ulong? DelayMsgNum{ get; set; }

        /// <summary>
        /// RewindMsgNum
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RewindMsgNum")]
        public ulong? RewindMsgNum{ get; set; }

        /// <summary>
        /// MinMsgTime
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinMsgTime")]
        public ulong? MinMsgTime{ get; set; }

        /// <summary>
        /// Transaction
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Transaction")]
        public bool? Transaction{ get; set; }

        /// <summary>
        /// DeadLetterSource
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeadLetterSource")]
        public DeadLetterSource[] DeadLetterSource{ get; set; }

        /// <summary>
        /// DeadLetterPolicy
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeadLetterPolicy")]
        public DeadLetterPolicy DeadLetterPolicy{ get; set; }

        /// <summary>
        /// TransactionPolicy
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransactionPolicy")]
        public TransactionPolicy TransactionPolicy{ get; set; }

        /// <summary>
        /// 创建者uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateUin")]
        public ulong? CreateUin{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 消息轨迹表示，true表示开启，false表示不开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Trace")]
        public bool? Trace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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
        }
    }
}

