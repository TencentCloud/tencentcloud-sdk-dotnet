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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目 id
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// 应用名称(可选，不为空且最长为 200字符)
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 项目网页地址(可选，最长为 256)
        /// </summary>
        [JsonProperty("URL")]
        public string URL{ get; set; }

        /// <summary>
        /// 项目仓库地址(可选，最长为 256)
        /// </summary>
        [JsonProperty("Repo")]
        public string Repo{ get; set; }

        /// <summary>
        /// 项目需要转移到的实例 id(可选)
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 项目采样率(可选)
        /// </summary>
        [JsonProperty("Rate")]
        public string Rate{ get; set; }

        /// <summary>
        /// 是否开启聚类(可选)
        /// </summary>
        [JsonProperty("EnableURLGroup")]
        public ulong? EnableURLGroup{ get; set; }

        /// <summary>
        /// 项目类型(可接受值为 "web", "mp", "android", "ios", "node", "hippy", "weex", "viola", "rn")
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 应用描述(可选，最长为 1000字符)
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 启动kafka配置
        /// </summary>
        [JsonProperty("EnableKafka")]
        public ulong? EnableKafka{ get; set; }

        /// <summary>
        /// kafka_host
        /// </summary>
        [JsonProperty("KafkaHost")]
        public string KafkaHost{ get; set; }

        /// <summary>
        /// topic
        /// </summary>
        [JsonProperty("KafkaTopic")]
        public string KafkaTopic{ get; set; }

        /// <summary>
        /// kafka_version
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }

        /// <summary>
        /// kafka_username
        /// </summary>
        [JsonProperty("SaslUserName")]
        public string SaslUserName{ get; set; }

        /// <summary>
        /// kafka_pwd
        /// </summary>
        [JsonProperty("SaslPassword")]
        public string SaslPassword{ get; set; }

        /// <summary>
        /// SaslMechanism
        /// </summary>
        [JsonProperty("SaslMechanism")]
        public string SaslMechanism{ get; set; }

        /// <summary>
        /// sink_id，日知汇算子id
        /// </summary>
        [JsonProperty("SinkId")]
        public ulong? SinkId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "URL", this.URL);
            this.SetParamSimple(map, prefix + "Repo", this.Repo);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "Rate", this.Rate);
            this.SetParamSimple(map, prefix + "EnableURLGroup", this.EnableURLGroup);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "EnableKafka", this.EnableKafka);
            this.SetParamSimple(map, prefix + "KafkaHost", this.KafkaHost);
            this.SetParamSimple(map, prefix + "KafkaTopic", this.KafkaTopic);
            this.SetParamSimple(map, prefix + "KafkaVersion", this.KafkaVersion);
            this.SetParamSimple(map, prefix + "SaslUserName", this.SaslUserName);
            this.SetParamSimple(map, prefix + "SaslPassword", this.SaslPassword);
            this.SetParamSimple(map, prefix + "SaslMechanism", this.SaslMechanism);
            this.SetParamSimple(map, prefix + "SinkId", this.SinkId);
        }
    }
}

