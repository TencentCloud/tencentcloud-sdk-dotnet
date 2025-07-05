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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReceiveMessageRequest : AbstractModel
    {
        
        /// <summary>
        /// 接收消息的topic的名字, 这里尽量需要使用topic的全路径，如果不指定，即：tenant/namespace/topic。默认使用的是：public/default
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// 订阅者的名字
        /// </summary>
        [JsonProperty("SubscriptionName")]
        public string SubscriptionName{ get; set; }

        /// <summary>
        /// 默认值为1000，consumer接收的消息会首先存储到receiverQueueSize这个队列中，用作调优接收消息的速率
        /// </summary>
        [JsonProperty("ReceiverQueueSize")]
        public long? ReceiverQueueSize{ get; set; }

        /// <summary>
        /// 默认值为：Earliest。用作判定consumer初始接收消息的位置，可选参数为：Earliest, Latest
        /// </summary>
        [JsonProperty("SubInitialPosition")]
        public string SubInitialPosition{ get; set; }

        /// <summary>
        /// 用于设置BatchReceivePolicy，指在一次batch中最多接收多少条消息，默认是 0。即不开启BatchReceivePolicy
        /// </summary>
        [JsonProperty("MaxNumMessages")]
        public long? MaxNumMessages{ get; set; }

        /// <summary>
        /// 用于设置BatchReceivePolicy，指在一次batch中最多接收的消息体有多大，单位是 bytes。默认是 0，即不开启BatchReceivePolicy
        /// </summary>
        [JsonProperty("MaxNumBytes")]
        public long? MaxNumBytes{ get; set; }

        /// <summary>
        /// 用于设置BatchReceivePolicy，指在一次batch消息的接收z中最多等待的超时时间，单位是毫秒。默认是 0，即不开启BatchReceivePolicy
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "SubscriptionName", this.SubscriptionName);
            this.SetParamSimple(map, prefix + "ReceiverQueueSize", this.ReceiverQueueSize);
            this.SetParamSimple(map, prefix + "SubInitialPosition", this.SubInitialPosition);
            this.SetParamSimple(map, prefix + "MaxNumMessages", this.MaxNumMessages);
            this.SetParamSimple(map, prefix + "MaxNumBytes", this.MaxNumBytes);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
        }
    }
}

