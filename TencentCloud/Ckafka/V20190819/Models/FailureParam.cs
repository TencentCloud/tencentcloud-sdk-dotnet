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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FailureParam : AbstractModel
    {
        
        /// <summary>
        /// 类型，DLQ死信队列，IGNORE_ERROR保留，DROP废弃
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Ckafka类型死信队列
        /// </summary>
        [JsonProperty("KafkaParam")]
        public KafkaParam KafkaParam{ get; set; }

        /// <summary>
        /// 重试间隔
        /// </summary>
        [JsonProperty("RetryInterval")]
        public ulong? RetryInterval{ get; set; }

        /// <summary>
        /// 重试次数
        /// </summary>
        [JsonProperty("MaxRetryAttempts")]
        public ulong? MaxRetryAttempts{ get; set; }

        /// <summary>
        /// DIP Topic类型死信队列
        /// </summary>
        [JsonProperty("TopicParam")]
        public TopicParam TopicParam{ get; set; }

        /// <summary>
        /// 死信队列类型，CKAFKA，TOPIC
        /// </summary>
        [JsonProperty("DlqType")]
        public string DlqType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "KafkaParam.", this.KafkaParam);
            this.SetParamSimple(map, prefix + "RetryInterval", this.RetryInterval);
            this.SetParamSimple(map, prefix + "MaxRetryAttempts", this.MaxRetryAttempts);
            this.SetParamObj(map, prefix + "TopicParam.", this.TopicParam);
            this.SetParamSimple(map, prefix + "DlqType", this.DlqType);
        }
    }
}

