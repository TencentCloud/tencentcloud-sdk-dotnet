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

    public class PreviewKafkaRechargeRequest : AbstractModel
    {
        
        /// <summary>
        /// 预览类型，1：源数据预览；2：导出结果预览。
        /// </summary>
        [JsonProperty("PreviewType")]
        public ulong? PreviewType{ get; set; }

        /// <summary>
        /// 导入Kafka类型，0：腾讯云CKafka；1：用户自建Kafka。
        /// </summary>
        [JsonProperty("KafkaType")]
        public ulong? KafkaType{ get; set; }

        /// <summary>
        /// 用户需要导入的Kafka相关topic列表，多个topic之间使用半角逗号隔开。
        /// 最多支持100个。
        /// </summary>
        [JsonProperty("UserKafkaTopics")]
        public string UserKafkaTopics{ get; set; }

        /// <summary>
        /// 导入数据位置，-2：最早；-1：最晚。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 腾讯云CKafka实例ID，当KafkaType为0时参数KafkaInstance有效且必填。
        /// - 通过 [获取实例列表信息](https://cloud.tencent.com/document/product/597/40835) 获取实例id。
        /// </summary>
        [JsonProperty("KafkaInstance")]
        public string KafkaInstance{ get; set; }

        /// <summary>
        /// 服务地址。
        /// KafkaType为1时ServerAddr必填。
        /// </summary>
        [JsonProperty("ServerAddr")]
        public string ServerAddr{ get; set; }

        /// <summary>
        /// ServerAddr是否为加密连接。
        /// KafkaType为1时有效。
        /// </summary>
        [JsonProperty("IsEncryptionAddr")]
        public bool? IsEncryptionAddr{ get; set; }

        /// <summary>
        /// 加密访问协议。
        /// KafkaType为1并且IsEncryptionAddr为true时Protocol必填。
        /// </summary>
        [JsonProperty("Protocol")]
        public KafkaProtocolInfo Protocol{ get; set; }

        /// <summary>
        /// 用户Kafka消费组。
        /// 
        /// - 消费组是 Kafka 提供的可扩展且具有容错性的消费者机制，一个消费组中存在多个消费者，组内的所有消费者共同消费订阅 Topic 中的消息。一个消费者可同时消费多个 Partition，但一个 Partition 只能被消费组内的一个消费者消费。
        /// </summary>
        [JsonProperty("ConsumerGroupName")]
        public string ConsumerGroupName{ get; set; }

        /// <summary>
        /// 日志导入规则
        /// </summary>
        [JsonProperty("LogRechargeRule")]
        public LogRechargeRuleInfo LogRechargeRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PreviewType", this.PreviewType);
            this.SetParamSimple(map, prefix + "KafkaType", this.KafkaType);
            this.SetParamSimple(map, prefix + "UserKafkaTopics", this.UserKafkaTopics);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "KafkaInstance", this.KafkaInstance);
            this.SetParamSimple(map, prefix + "ServerAddr", this.ServerAddr);
            this.SetParamSimple(map, prefix + "IsEncryptionAddr", this.IsEncryptionAddr);
            this.SetParamObj(map, prefix + "Protocol.", this.Protocol);
            this.SetParamSimple(map, prefix + "ConsumerGroupName", this.ConsumerGroupName);
            this.SetParamObj(map, prefix + "LogRechargeRule.", this.LogRechargeRule);
        }
    }
}

