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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTopicResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>主题名称</p>
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// <p>主题类型<br>UNSPECIFIED:未指定,<br>NORMAL:普通消息,<br>FIFO:顺序消息,<br>DELAY:延时消息,<br>TRANSACTION:事务消息</p>
        /// </summary>
        [JsonProperty("TopicType")]
        public string TopicType{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>创建时间，<strong>Unix时间戳（毫秒）</strong></p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// <p>最后写入时间，<strong>Unix时间戳（毫秒）</strong></p>
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public long? LastUpdateTime{ get; set; }

        /// <summary>
        /// <p>订阅数量</p>
        /// </summary>
        [JsonProperty("SubscriptionCount")]
        public long? SubscriptionCount{ get; set; }

        /// <summary>
        /// <p>订阅关系列表</p>
        /// </summary>
        [JsonProperty("SubscriptionData")]
        public SubscriptionData[] SubscriptionData{ get; set; }

        /// <summary>
        /// <p>消息保留时长，单位：小时</p>
        /// </summary>
        [JsonProperty("MsgTTL")]
        public long? MsgTTL{ get; set; }

        /// <summary>
        /// <p>是否自动删除</p><p>仅适用于轻量主题</p>
        /// </summary>
        [JsonProperty("AutoExpireDelete")]
        public bool? AutoExpireDelete{ get; set; }

        /// <summary>
        /// <p>自动过期时间</p><p>单位：分钟</p><p>仅适用于轻量主题</p>
        /// </summary>
        [JsonProperty("AutoExpireTime")]
        public long? AutoExpireTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "TopicType", this.TopicType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "SubscriptionCount", this.SubscriptionCount);
            this.SetParamArrayObj(map, prefix + "SubscriptionData.", this.SubscriptionData);
            this.SetParamSimple(map, prefix + "MsgTTL", this.MsgTTL);
            this.SetParamSimple(map, prefix + "AutoExpireDelete", this.AutoExpireDelete);
            this.SetParamSimple(map, prefix + "AutoExpireTime", this.AutoExpireTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

