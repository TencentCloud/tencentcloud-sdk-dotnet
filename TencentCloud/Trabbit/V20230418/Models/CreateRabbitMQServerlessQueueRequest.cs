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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRabbitMQServerlessQueueRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// VHost参数
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// 队列名称
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// 只支持 classic
        /// </summary>
        [JsonProperty("QueueType")]
        public string QueueType{ get; set; }

        /// <summary>
        /// 持久标记,classic类型必传,quorum类型无需传入固定为true
        /// </summary>
        [JsonProperty("Durable")]
        public bool? Durable{ get; set; }

        /// <summary>
        /// 自动清除,classic类型必传,quorum类型无需传入固定为false
        /// </summary>
        [JsonProperty("AutoDelete")]
        public bool? AutoDelete{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// MessageTTL参数,classic类型专用
        /// </summary>
        [JsonProperty("MessageTTL")]
        public long? MessageTTL{ get; set; }

        /// <summary>
        /// AutoExpire参数，单位为 ms，队列在指定时间内没有被使用，将会被删除
        /// </summary>
        [JsonProperty("AutoExpire")]
        public long? AutoExpire{ get; set; }

        /// <summary>
        /// MaxLength参数。队列可以容纳的最大条数。若超出上限，将根据 overview behavior 处理
        /// </summary>
        [JsonProperty("MaxLength")]
        public long? MaxLength{ get; set; }

        /// <summary>
        /// MaxLengthBytes参数。若超出上限，将根据 overview behavior 处理。
        /// </summary>
        [JsonProperty("MaxLengthBytes")]
        public long? MaxLengthBytes{ get; set; }

        /// <summary>
        /// DeliveryLimit参数,quorum类型专用
        /// </summary>
        [JsonProperty("DeliveryLimit")]
        public long? DeliveryLimit{ get; set; }

        /// <summary>
        /// OverflowBehaviour参数,取值为drop-head, reject-publish或reject-publish-dlx
        /// </summary>
        [JsonProperty("OverflowBehaviour")]
        public string OverflowBehaviour{ get; set; }

        /// <summary>
        /// DeadLetterExchange参数。可将过期或被拒绝的消息投往指定的死信 exchange。
        /// </summary>
        [JsonProperty("DeadLetterExchange")]
        public string DeadLetterExchange{ get; set; }

        /// <summary>
        /// DeadLetterRoutingKey参数。只能包含字母、数字、"."、"-"，"@"，"_"
        /// </summary>
        [JsonProperty("DeadLetterRoutingKey")]
        public string DeadLetterRoutingKey{ get; set; }

        /// <summary>
        /// SingleActiveConsumer参数。若开启，需确保每次有且只有一个消费者从队列中消费
        /// </summary>
        [JsonProperty("SingleActiveConsumer")]
        public bool? SingleActiveConsumer{ get; set; }

        /// <summary>
        /// MaximumPriority参数,classic类型专用
        /// </summary>
        [JsonProperty("MaximumPriority")]
        public long? MaximumPriority{ get; set; }

        /// <summary>
        /// LazyMode参数,classic类型专用
        /// </summary>
        [JsonProperty("LazyMode")]
        public bool? LazyMode{ get; set; }

        /// <summary>
        /// MasterLocator参数,classic类型专用,取值为min-masters,client-local或random
        /// </summary>
        [JsonProperty("MasterLocator")]
        public string MasterLocator{ get; set; }

        /// <summary>
        /// MaxInMemoryLength参数，quorum类型专用。quorum 队列的内存中最大消息数量
        /// </summary>
        [JsonProperty("MaxInMemoryLength")]
        public long? MaxInMemoryLength{ get; set; }

        /// <summary>
        /// MaxInMemoryBytes参数，quorum类型专用。quorum 队列的内存中最大数总消息大小
        /// </summary>
        [JsonProperty("MaxInMemoryBytes")]
        public long? MaxInMemoryBytes{ get; set; }

        /// <summary>
        /// Node参数，非必填，指定创建 queue 所在节点
        /// </summary>
        [JsonProperty("Node")]
        public string Node{ get; set; }

        /// <summary>
        /// 仲裁队列死信一致性策略，at-most-once、at-least-once，默认是at-most-once
        /// </summary>
        [JsonProperty("DeadLetterStrategy")]
        public string DeadLetterStrategy{ get; set; }

        /// <summary>
        /// 仲裁队列的领导者选举策略，client-local、balanced，默认是client-local
        /// </summary>
        [JsonProperty("QueueLeaderLocator")]
        public string QueueLeaderLocator{ get; set; }

        /// <summary>
        /// 仲裁队列的初始副本组大小，默认3
        /// </summary>
        [JsonProperty("QuorumInitialGroupSize")]
        public long? QuorumInitialGroupSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "QueueType", this.QueueType);
            this.SetParamSimple(map, prefix + "Durable", this.Durable);
            this.SetParamSimple(map, prefix + "AutoDelete", this.AutoDelete);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "MessageTTL", this.MessageTTL);
            this.SetParamSimple(map, prefix + "AutoExpire", this.AutoExpire);
            this.SetParamSimple(map, prefix + "MaxLength", this.MaxLength);
            this.SetParamSimple(map, prefix + "MaxLengthBytes", this.MaxLengthBytes);
            this.SetParamSimple(map, prefix + "DeliveryLimit", this.DeliveryLimit);
            this.SetParamSimple(map, prefix + "OverflowBehaviour", this.OverflowBehaviour);
            this.SetParamSimple(map, prefix + "DeadLetterExchange", this.DeadLetterExchange);
            this.SetParamSimple(map, prefix + "DeadLetterRoutingKey", this.DeadLetterRoutingKey);
            this.SetParamSimple(map, prefix + "SingleActiveConsumer", this.SingleActiveConsumer);
            this.SetParamSimple(map, prefix + "MaximumPriority", this.MaximumPriority);
            this.SetParamSimple(map, prefix + "LazyMode", this.LazyMode);
            this.SetParamSimple(map, prefix + "MasterLocator", this.MasterLocator);
            this.SetParamSimple(map, prefix + "MaxInMemoryLength", this.MaxInMemoryLength);
            this.SetParamSimple(map, prefix + "MaxInMemoryBytes", this.MaxInMemoryBytes);
            this.SetParamSimple(map, prefix + "Node", this.Node);
            this.SetParamSimple(map, prefix + "DeadLetterStrategy", this.DeadLetterStrategy);
            this.SetParamSimple(map, prefix + "QueueLeaderLocator", this.QueueLeaderLocator);
            this.SetParamSimple(map, prefix + "QuorumInitialGroupSize", this.QuorumInitialGroupSize);
        }
    }
}

