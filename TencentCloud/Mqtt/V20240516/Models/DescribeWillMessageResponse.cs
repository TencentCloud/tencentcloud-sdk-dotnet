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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWillMessageResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>保留消息Topic</p>
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// <p>消息服务质量</p>
        /// </summary>
        [JsonProperty("Qos")]
        public long? Qos{ get; set; }

        /// <summary>
        /// <p>是否保留消息</p>
        /// </summary>
        [JsonProperty("Retained")]
        public bool? Retained{ get; set; }

        /// <summary>
        /// <p>消息负载(Base64编码)</p>
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// <p>创建时间，毫秒级时间戳 。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间，毫秒级时间戳 。</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// <p>遗嘱消息延迟时间，单位秒</p>
        /// </summary>
        [JsonProperty("WillDelayInterval")]
        public long? WillDelayInterval{ get; set; }

        /// <summary>
        /// <p>响应内容类型</p>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// <p>响应主题</p>
        /// </summary>
        [JsonProperty("ResponseTopic")]
        public string ResponseTopic{ get; set; }

        /// <summary>
        /// <p>关联数据（Base64编码）</p>
        /// </summary>
        [JsonProperty("CorrelationData")]
        public string CorrelationData{ get; set; }

        /// <summary>
        /// <p>消息过期时间，单位秒</p>
        /// </summary>
        [JsonProperty("MessageExpiryInterval")]
        public long? MessageExpiryInterval{ get; set; }

        /// <summary>
        /// <p>负载格式指示器 1:UTF-8文本</p>
        /// </summary>
        [JsonProperty("PayloadFormatIndicator")]
        public long? PayloadFormatIndicator{ get; set; }

        /// <summary>
        /// <p>用户属性</p>
        /// </summary>
        [JsonProperty("UserProperties")]
        public UserProperty[] UserProperties{ get; set; }

        /// <summary>
        /// <p>遗嘱消息发布时间</p>
        /// </summary>
        [JsonProperty("PublishAfter")]
        public long? PublishAfter{ get; set; }

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
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "Qos", this.Qos);
            this.SetParamSimple(map, prefix + "Retained", this.Retained);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "WillDelayInterval", this.WillDelayInterval);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "ResponseTopic", this.ResponseTopic);
            this.SetParamSimple(map, prefix + "CorrelationData", this.CorrelationData);
            this.SetParamSimple(map, prefix + "MessageExpiryInterval", this.MessageExpiryInterval);
            this.SetParamSimple(map, prefix + "PayloadFormatIndicator", this.PayloadFormatIndicator);
            this.SetParamArrayObj(map, prefix + "UserProperties.", this.UserProperties);
            this.SetParamSimple(map, prefix + "PublishAfter", this.PublishAfter);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

