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

    public class SendBatchMessagesRequest : AbstractModel
    {
        
        /// <summary>
        /// 消息要发送的topic的名字, 这里尽量需要使用topic的全路径，即：tenant/namespace/topic。如果不指定，默认使用的是：public/default
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// 需要发送消息的内容
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// String 类型的 token，可以不填，系统会自动获取
        /// </summary>
        [JsonProperty("StringToken")]
        public string StringToken{ get; set; }

        /// <summary>
        /// producer 的名字，要求全局是唯一的，如果不设置，系统会自动生成
        /// </summary>
        [JsonProperty("ProducerName")]
        public string ProducerName{ get; set; }

        /// <summary>
        /// 单位：s。消息发送的超时时间。默认值为：30s
        /// </summary>
        [JsonProperty("SendTimeout")]
        public long? SendTimeout{ get; set; }

        /// <summary>
        /// 内存中允许缓存的生产消息的最大数量，默认值：1000条
        /// </summary>
        [JsonProperty("MaxPendingMessages")]
        public long? MaxPendingMessages{ get; set; }

        /// <summary>
        /// 每一个batch中消息的最大数量，默认值：1000条/batch
        /// </summary>
        [JsonProperty("BatchingMaxMessages")]
        public long? BatchingMaxMessages{ get; set; }

        /// <summary>
        /// 每一个batch最大等待的时间，超过这个时间，不管是否达到指定的batch中消息的数量和大小，都会将该batch发送出去，默认：10ms
        /// </summary>
        [JsonProperty("BatchingMaxPublishDelay")]
        public long? BatchingMaxPublishDelay{ get; set; }

        /// <summary>
        /// 每一个batch中最大允许的消息的大小，默认：128KB
        /// </summary>
        [JsonProperty("BatchingMaxBytes")]
        public long? BatchingMaxBytes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "StringToken", this.StringToken);
            this.SetParamSimple(map, prefix + "ProducerName", this.ProducerName);
            this.SetParamSimple(map, prefix + "SendTimeout", this.SendTimeout);
            this.SetParamSimple(map, prefix + "MaxPendingMessages", this.MaxPendingMessages);
            this.SetParamSimple(map, prefix + "BatchingMaxMessages", this.BatchingMaxMessages);
            this.SetParamSimple(map, prefix + "BatchingMaxPublishDelay", this.BatchingMaxPublishDelay);
            this.SetParamSimple(map, prefix + "BatchingMaxBytes", this.BatchingMaxBytes);
        }
    }
}

