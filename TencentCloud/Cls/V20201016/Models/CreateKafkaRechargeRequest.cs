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

    public class CreateKafkaRechargeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>导入CLS目标TopicId。</p><ul><li>通过 <a href="https://cloud.tencent.com/document/product/614/56454">获取日志主题列表</a> 获取日志主题Id。</li><li>通过 <a href="https://cloud.tencent.com/document/product/614/56456">创建日志主题</a> 获取日志主题Id。</li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>Kafka导入配置名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>导入Kafka类型，0: 腾讯云CKafka，1: 用户自建Kafka</p>
        /// </summary>
        [JsonProperty("KafkaType")]
        public ulong? KafkaType{ get; set; }

        /// <summary>
        /// <p>用户需要导入的Kafka相关topic列表，多个topic之间使用半角逗号隔开</p>
        /// </summary>
        [JsonProperty("UserKafkaTopics")]
        public string UserKafkaTopics{ get; set; }

        /// <summary>
        /// <p>导入数据位置，-2:最早（默认），-1：最晚</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>日志导入规则。</p>
        /// </summary>
        [JsonProperty("LogRechargeRule")]
        public LogRechargeRuleInfo LogRechargeRule{ get; set; }

        /// <summary>
        /// <p>腾讯云CKafka实例ID，KafkaType为0时必填。</p><ul><li>通过 <a href="https://cloud.tencent.com/document/product/597/40835">获取实例列表信息</a> 获取实例id。</li></ul>
        /// </summary>
        [JsonProperty("KafkaInstance")]
        public string KafkaInstance{ get; set; }

        /// <summary>
        /// <p>服务地址，KafkaType为1时必填。</p>
        /// </summary>
        [JsonProperty("ServerAddr")]
        public string ServerAddr{ get; set; }

        /// <summary>
        /// <p>ServerAddr是否为加密连接，KafkaType为1时必填。</p>
        /// </summary>
        [JsonProperty("IsEncryptionAddr")]
        public bool? IsEncryptionAddr{ get; set; }

        /// <summary>
        /// <p>加密访问协议。<br>KafkaType为1并且IsEncryptionAddr为true时Protocol必填。</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public KafkaProtocolInfo Protocol{ get; set; }

        /// <summary>
        /// <p>用户Kafka消费组名称。</p><ul><li>消费组是 Kafka 提供的可扩展且具有容错性的消费者机制，一个消费组中存在多个消费者，组内的所有消费者共同消费订阅 Topic 中的消息。一个消费者可同时消费多个 Partition，但一个 Partition 只能被消费组内的一个消费者消费。</li></ul>
        /// </summary>
        [JsonProperty("ConsumerGroupName")]
        public string ConsumerGroupName{ get; set; }

        /// <summary>
        /// <p>网络信息参数</p>
        /// </summary>
        [JsonProperty("NetworkInfo")]
        public NetworkInfo NetworkInfo{ get; set; }

        /// <summary>
        /// <p>用户kafka拓展信息</p>
        /// </summary>
        [JsonProperty("UserKafkaMeta")]
        public UserKafkaMeta UserKafkaMeta{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "KafkaType", this.KafkaType);
            this.SetParamSimple(map, prefix + "UserKafkaTopics", this.UserKafkaTopics);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamObj(map, prefix + "LogRechargeRule.", this.LogRechargeRule);
            this.SetParamSimple(map, prefix + "KafkaInstance", this.KafkaInstance);
            this.SetParamSimple(map, prefix + "ServerAddr", this.ServerAddr);
            this.SetParamSimple(map, prefix + "IsEncryptionAddr", this.IsEncryptionAddr);
            this.SetParamObj(map, prefix + "Protocol.", this.Protocol);
            this.SetParamSimple(map, prefix + "ConsumerGroupName", this.ConsumerGroupName);
            this.SetParamObj(map, prefix + "NetworkInfo.", this.NetworkInfo);
            this.SetParamObj(map, prefix + "UserKafkaMeta.", this.UserKafkaMeta);
        }
    }
}

