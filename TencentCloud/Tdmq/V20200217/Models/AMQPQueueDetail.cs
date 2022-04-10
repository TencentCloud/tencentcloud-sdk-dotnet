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

    public class AMQPQueueDetail : AbstractModel
    {
        
        /// <summary>
        /// Queue名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 被绑定数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DestBindedNum")]
        public ulong? DestBindedNum{ get; set; }

        /// <summary>
        /// 创建时间，以毫秒为单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 创建时间，以毫秒为单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// 在线消费者数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OnlineConsumerNum")]
        public ulong? OnlineConsumerNum{ get; set; }

        /// <summary>
        /// 每秒钟的事务数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tps")]
        public ulong? Tps{ get; set; }

        /// <summary>
        /// 消息堆积数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccumulativeMsgNum")]
        public ulong? AccumulativeMsgNum{ get; set; }

        /// <summary>
        /// 是否自动删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoDelete")]
        public bool? AutoDelete{ get; set; }

        /// <summary>
        /// 死信交换机
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeadLetterExchange")]
        public string DeadLetterExchange{ get; set; }

        /// <summary>
        /// 死信交换机路由键
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeadLetterRoutingKey")]
        public string DeadLetterRoutingKey{ get; set; }

        /// <summary>
        /// Queue对应的Topic名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "DestBindedNum", this.DestBindedNum);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "OnlineConsumerNum", this.OnlineConsumerNum);
            this.SetParamSimple(map, prefix + "Tps", this.Tps);
            this.SetParamSimple(map, prefix + "AccumulativeMsgNum", this.AccumulativeMsgNum);
            this.SetParamSimple(map, prefix + "AutoDelete", this.AutoDelete);
            this.SetParamSimple(map, prefix + "DeadLetterExchange", this.DeadLetterExchange);
            this.SetParamSimple(map, prefix + "DeadLetterRoutingKey", this.DeadLetterRoutingKey);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
        }
    }
}

