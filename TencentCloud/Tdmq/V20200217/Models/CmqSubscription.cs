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

    public class CmqSubscription : AbstractModel
    {
        
        /// <summary>
        /// 订阅名字，在单个地域同一账号的同一主题下唯一。订阅名称是一个不超过64个字符的字符串，必须以字母为首字符，剩余部分可以包含字母、数字和横划线(-)。
        /// </summary>
        [JsonProperty("SubscriptionName")]
        public string SubscriptionName{ get; set; }

        /// <summary>
        /// 订阅 ID。订阅 ID 在拉取监控数据时会用到。
        /// </summary>
        [JsonProperty("SubscriptionId")]
        public string SubscriptionId{ get; set; }

        /// <summary>
        /// 订阅拥有者的 APPID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicOwner")]
        public ulong? TopicOwner{ get; set; }

        /// <summary>
        /// 该订阅待投递的消息数。
        /// </summary>
        [JsonProperty("MsgCount")]
        public ulong? MsgCount{ get; set; }

        /// <summary>
        /// 最后一次修改订阅属性的时间。返回 Unix 时间戳，精确到毫秒。
        /// </summary>
        [JsonProperty("LastModifyTime")]
        public ulong? LastModifyTime{ get; set; }

        /// <summary>
        /// 订阅的创建时间。返回 Unix 时间戳，精确到毫秒。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 表示订阅接收消息的过滤策略。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BindingKey")]
        public string[] BindingKey{ get; set; }

        /// <summary>
        /// 接收通知的 endpoint，根据协议 protocol 区分：对于 HTTP，endpoint 必须以http://开头，host 可以是域名或 IP；对于 queue，则填 queueName。
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// 描述用户创建订阅时选择的过滤策略：
        /// filterType = 1表示用户使用 filterTag 标签过滤
        /// filterType = 2表示用户使用 bindingKey 过滤。
        /// </summary>
        [JsonProperty("FilterTags")]
        public string[] FilterTags{ get; set; }

        /// <summary>
        /// 订阅的协议，目前支持两种协议：HTTP、queue。使用 HTTP 协议，用户需自己搭建接受消息的 Web Server。使用 queue，消息会自动推送到 CMQ queue，用户可以并发地拉取消息。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 向 endpoint 推送消息出现错误时，CMQ 推送服务器的重试策略。取值有：
        /// （1）BACKOFF_RETRY，退避重试。每隔一定时间重试一次，重试够一定次数后，就把该消息丢弃，继续推送下一条消息；
        /// （2）EXPONENTIAL_DECAY_RETRY，指数衰退重试。每次重试的间隔是指数递增的，例如开始 1s，后面是 2s，4s，8s...由于 Topic 消息的周期是一天，所以最多重试一天就把消息丢弃。默认值是 EXPONENTIAL_DECAY_RETRY。
        /// </summary>
        [JsonProperty("NotifyStrategy")]
        public string NotifyStrategy{ get; set; }

        /// <summary>
        /// 推送内容的格式。取值：（1）JSON；（2）SIMPLIFIED，即 raw 格式。如果 protocol 是 queue，则取值必须为 SIMPLIFIED。如果 protocol 是 HTTP，两个值均可以，默认值是 JSON。
        /// </summary>
        [JsonProperty("NotifyContentFormat")]
        public string NotifyContentFormat{ get; set; }

        /// <summary>
        /// 订阅所属的主题名称
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubscriptionName", this.SubscriptionName);
            this.SetParamSimple(map, prefix + "SubscriptionId", this.SubscriptionId);
            this.SetParamSimple(map, prefix + "TopicOwner", this.TopicOwner);
            this.SetParamSimple(map, prefix + "MsgCount", this.MsgCount);
            this.SetParamSimple(map, prefix + "LastModifyTime", this.LastModifyTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArraySimple(map, prefix + "BindingKey.", this.BindingKey);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamArraySimple(map, prefix + "FilterTags.", this.FilterTags);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "NotifyStrategy", this.NotifyStrategy);
            this.SetParamSimple(map, prefix + "NotifyContentFormat", this.NotifyContentFormat);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
        }
    }
}

