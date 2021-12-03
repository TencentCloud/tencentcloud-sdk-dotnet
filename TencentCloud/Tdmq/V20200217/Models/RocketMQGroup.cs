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

    public class RocketMQGroup : AbstractModel
    {
        
        /// <summary>
        /// 消费组名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 在线消费者数量
        /// </summary>
        [JsonProperty("ConsumerNum")]
        public ulong? ConsumerNum{ get; set; }

        /// <summary>
        /// 消费TPS
        /// </summary>
        [JsonProperty("TPS")]
        public ulong? TPS{ get; set; }

        /// <summary>
        /// 总堆积数量
        /// </summary>
        [JsonProperty("TotalAccumulative")]
        public long? TotalAccumulative{ get; set; }

        /// <summary>
        /// 0表示集群消费模式，1表示广播消费模式，-1表示未知
        /// </summary>
        [JsonProperty("ConsumptionMode")]
        public long? ConsumptionMode{ get; set; }

        /// <summary>
        /// 是否允许消费
        /// </summary>
        [JsonProperty("ReadEnabled")]
        public bool? ReadEnabled{ get; set; }

        /// <summary>
        /// 重试队列分区数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryPartitionNum")]
        public ulong? RetryPartitionNum{ get; set; }

        /// <summary>
        /// 创建时间，以毫秒为单位
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 修改时间，以毫秒为单位
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// 客户端协议
        /// </summary>
        [JsonProperty("ClientProtocol")]
        public string ClientProtocol{ get; set; }

        /// <summary>
        /// 说明信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 消费者类型，枚举值ACTIVELY, PASSIVELY
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsumerType")]
        public string ConsumerType{ get; set; }

        /// <summary>
        /// 是否开启广播消费
        /// </summary>
        [JsonProperty("BroadcastEnabled")]
        public bool? BroadcastEnabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ConsumerNum", this.ConsumerNum);
            this.SetParamSimple(map, prefix + "TPS", this.TPS);
            this.SetParamSimple(map, prefix + "TotalAccumulative", this.TotalAccumulative);
            this.SetParamSimple(map, prefix + "ConsumptionMode", this.ConsumptionMode);
            this.SetParamSimple(map, prefix + "ReadEnabled", this.ReadEnabled);
            this.SetParamSimple(map, prefix + "RetryPartitionNum", this.RetryPartitionNum);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ClientProtocol", this.ClientProtocol);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ConsumerType", this.ConsumerType);
            this.SetParamSimple(map, prefix + "BroadcastEnabled", this.BroadcastEnabled);
        }
    }
}

