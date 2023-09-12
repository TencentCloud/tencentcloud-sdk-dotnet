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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTopicResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 主题名称
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// 主题类型
        /// UNSPECIFIED:未指定,
        /// NORMAL:普通消息,
        /// FIFO:顺序消息,
        /// DELAY:延时消息,
        /// TRANSACTION:事务消息
        /// </summary>
        [JsonProperty("TopicType")]
        public string TopicType{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 创建时间，秒为单位
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// 最后写入时间，秒为单位
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public long? LastUpdateTime{ get; set; }

        /// <summary>
        /// 订阅数量
        /// </summary>
        [JsonProperty("SubscriptionCount")]
        public long? SubscriptionCount{ get; set; }

        /// <summary>
        /// 订阅关系列表
        /// </summary>
        [JsonProperty("SubscriptionData")]
        public SubscriptionData[] SubscriptionData{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

