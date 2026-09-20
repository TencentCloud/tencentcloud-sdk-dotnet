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

    public class KafkaRechargeInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Kafka数据订阅配置的ID。</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>日志主题ID</p>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>Kafka导入任务名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>导入Kafka类型，0: 腾讯云CKafka，1: 用户自建Kafka</p>
        /// </summary>
        [JsonProperty("KafkaType")]
        public ulong? KafkaType{ get; set; }

        /// <summary>
        /// <p>腾讯云CKafka实例ID，KafkaType为0时必填</p>
        /// </summary>
        [JsonProperty("KafkaInstance")]
        public string KafkaInstance{ get; set; }

        /// <summary>
        /// <p>服务地址</p>
        /// </summary>
        [JsonProperty("ServerAddr")]
        public string ServerAddr{ get; set; }

        /// <summary>
        /// <p>ServerAddr是否为加密连接</p>
        /// </summary>
        [JsonProperty("IsEncryptionAddr")]
        public bool? IsEncryptionAddr{ get; set; }

        /// <summary>
        /// <p>加密访问协议，IsEncryptionAddr参数为true时必填</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public KafkaProtocolInfo Protocol{ get; set; }

        /// <summary>
        /// <p>用户需要导入的Kafka相关topic列表，多个topic之间使用半角逗号隔开</p>
        /// </summary>
        [JsonProperty("UserKafkaTopics")]
        public string UserKafkaTopics{ get; set; }

        /// <summary>
        /// <p>用户Kafka消费组名称</p>
        /// </summary>
        [JsonProperty("ConsumerGroupName")]
        public string ConsumerGroupName{ get; set; }

        /// <summary>
        /// <p>状态 ，1：运行中；2：暂停。</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>导入数据位置，-2:最早（默认），-1：最晚</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>创建时间。格式<code>YYYY-MM-DD HH:MM:SS</code></p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间。格式<code>YYYY-MM-DD HH:MM:SS</code></p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>日志导入规则</p>
        /// </summary>
        [JsonProperty("LogRechargeRule")]
        public LogRechargeRuleInfo LogRechargeRule{ get; set; }

        /// <summary>
        /// <p>私有网络信息</p>
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
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "KafkaType", this.KafkaType);
            this.SetParamSimple(map, prefix + "KafkaInstance", this.KafkaInstance);
            this.SetParamSimple(map, prefix + "ServerAddr", this.ServerAddr);
            this.SetParamSimple(map, prefix + "IsEncryptionAddr", this.IsEncryptionAddr);
            this.SetParamObj(map, prefix + "Protocol.", this.Protocol);
            this.SetParamSimple(map, prefix + "UserKafkaTopics", this.UserKafkaTopics);
            this.SetParamSimple(map, prefix + "ConsumerGroupName", this.ConsumerGroupName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "LogRechargeRule.", this.LogRechargeRule);
            this.SetParamObj(map, prefix + "NetworkInfo.", this.NetworkInfo);
            this.SetParamObj(map, prefix + "UserKafkaMeta.", this.UserKafkaMeta);
        }
    }
}

