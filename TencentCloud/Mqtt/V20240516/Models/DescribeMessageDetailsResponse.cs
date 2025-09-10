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

    public class DescribeMessageDetailsResponse : AbstractModel
    {
        
        /// <summary>
        /// 消息体
        /// </summary>
        [JsonProperty("Body")]
        public string Body{ get; set; }

        /// <summary>
        /// 用户自定义属性
        /// </summary>
        [JsonProperty("UserProperties")]
        public UserProperty[] UserProperties{ get; set; }

        /// <summary>
        /// 消息存储时间，毫秒级时间戳。
        /// </summary>
        [JsonProperty("StoreTimestamp")]
        public long? StoreTimestamp{ get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonProperty("MessageId")]
        public string MessageId{ get; set; }

        /// <summary>
        /// 生产者地址
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// Topic
        /// </summary>
        [JsonProperty("Qos")]
        public string Qos{ get; set; }

        /// <summary>
        /// 源topic
        /// </summary>
        [JsonProperty("OriginTopic")]
        public string OriginTopic{ get; set; }

        /// <summary>
        /// 内容类型（MQTT5）
        /// 含义：指示消息载荷的内容类型，使用标准的 MIME 类型格式。这帮助接收方正确解析和处理消息内容。
        /// 示例：
        /// application/json：表示载荷是 JSON 格式的数据。
        /// text/plain：表示载荷是纯文本。
        /// application/octet-stream：表示载荷是二进制数据。
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// 载荷格式指示符（MQTT5）
        /// 含义：指示载荷的格式，是一个布尔值。0表示未指定格式（二进制），1表示 UTF-8 编码的字符串。
        /// 示例：
        /// 值为0：当载荷是二进制数据，如图片、音频等。
        /// 值为1：当载荷是 UTF-8 编码的文本，如 JSON 字符串、XML 等。
        /// </summary>
        [JsonProperty("PayloadFormatIndicator")]
        public long? PayloadFormatIndicator{ get; set; }

        /// <summary>
        /// 消息过期间隔（MQTT5）
        /// 含义：指定消息在被丢弃前的有效时间（秒）。如果消息在过期前未能送达，则会被 MQTT 服务器丢弃。
        /// 示例：
        /// 值为60：表示消息在发布后的 60 秒内有效，过期后未送达则被丢弃。
        /// 值为0：表示消息不过期，永久有效（直到被接收或会话结束）。
        /// </summary>
        [JsonProperty("MessageExpiryInterval")]
        public long? MessageExpiryInterval{ get; set; }

        /// <summary>
        /// 响应主题（MQTT5）
        /// 含义：指定一个主题，用于请求 - 响应模式中的响应消息。发送方可以指定接收方应该将响应发送到哪个主题。
        /// 示例：
        /// 发送方发布请求到主题devices/device1/commands，并设置ResponseTopic为devices/device1/responses。
        /// 接收方处理请求后，将响应发布到devices/device1/responses主题。
        /// </summary>
        [JsonProperty("ResponseTopic")]
        public string ResponseTopic{ get; set; }

        /// <summary>
        /// 关联数据（MQTT5）
        /// 含义：用于关联请求和响应的标识符，通常是一个字节数组。在请求 - 响应模式中，发送方设置此值，接收方在响应中包含相同的值，以便发送方识别响应对应的请求。
        /// 示例：
        /// 发送方生成一个唯一 ID（如 UUID 的字节数组）作为CorrelationData，附加到请求消息中。
        /// 接收方在响应消息中包含相同的CorrelationData，发送方通过比较此值来匹配响应和请求。
        /// </summary>
        [JsonProperty("CorrelationData")]
        public string CorrelationData{ get; set; }

        /// <summary>
        /// 订阅标识符（MQTT5）
        /// 含义：为订阅分配的唯一标识符，用于标识客户端的特定订阅。当服务器向客户端发送消息时，可以包含此标识符，帮助客户端识别消息对应的订阅。
        /// 示例：
        /// 客户端订阅主题devices/+/temperature，并设置SubscriptionIdentifier为123。
        /// 当服务器向客户端发送此主题的消息时，会在消息中包含SubscriptionIdentifier: 123，客户端可以根据此值知道消息是通过哪个订阅接收的。
        /// </summary>
        [JsonProperty("SubscriptionIdentifier")]
        public string SubscriptionIdentifier{ get; set; }

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
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamArrayObj(map, prefix + "UserProperties.", this.UserProperties);
            this.SetParamSimple(map, prefix + "StoreTimestamp", this.StoreTimestamp);
            this.SetParamSimple(map, prefix + "MessageId", this.MessageId);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "Qos", this.Qos);
            this.SetParamSimple(map, prefix + "OriginTopic", this.OriginTopic);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "PayloadFormatIndicator", this.PayloadFormatIndicator);
            this.SetParamSimple(map, prefix + "MessageExpiryInterval", this.MessageExpiryInterval);
            this.SetParamSimple(map, prefix + "ResponseTopic", this.ResponseTopic);
            this.SetParamSimple(map, prefix + "CorrelationData", this.CorrelationData);
            this.SetParamSimple(map, prefix + "SubscriptionIdentifier", this.SubscriptionIdentifier);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

