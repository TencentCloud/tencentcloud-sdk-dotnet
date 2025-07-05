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

    public class Kafka : AbstractModel
    {
        
        /// <summary>
        /// 1：开启
        /// 0：关闭
        /// </summary>
        [JsonProperty("EnableKafka")]
        public ulong? EnableKafka{ get; set; }

        /// <summary>
        /// host地址
        /// </summary>
        [JsonProperty("KafkaHost")]
        public string KafkaHost{ get; set; }

        /// <summary>
        /// topic
        /// </summary>
        [JsonProperty("KafkaTopic")]
        public string KafkaTopic{ get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }

        /// <summary>
        /// username
        /// </summary>
        [JsonProperty("SaslUserName")]
        public string SaslUserName{ get; set; }

        /// <summary>
        /// password
        /// </summary>
        [JsonProperty("SaslPassword")]
        public string SaslPassword{ get; set; }

        /// <summary>
        /// ssl
        /// </summary>
        [JsonProperty("SaslMechanism")]
        public string SaslMechanism{ get; set; }

        /// <summary>
        /// 默认算子id为0新增算子
        /// 一旦算子新增成功会返回正确的算子id值
        /// </summary>
        [JsonProperty("SinkId")]
        public ulong? SinkId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
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

