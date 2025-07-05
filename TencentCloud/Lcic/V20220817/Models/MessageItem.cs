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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MessageItem : AbstractModel
    {
        
        /// <summary>
        /// 消息类型。0表示文本消息，1表示图片消息
        /// </summary>
        [JsonProperty("MessageType")]
        public long? MessageType{ get; set; }

        /// <summary>
        /// 文本消息内容。message type为0时有效。
        /// </summary>
        [JsonProperty("TextMessage")]
        public string TextMessage{ get; set; }

        /// <summary>
        /// 图片消息URL。 message type为1时有效。
        /// </summary>
        [JsonProperty("ImageMessage")]
        public string ImageMessage{ get; set; }

        /// <summary>
        /// 自定义消息内容。message type为2时有效。
        /// </summary>
        [JsonProperty("CustomMessage")]
        public CustomMsgContent CustomMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MessageType", this.MessageType);
            this.SetParamSimple(map, prefix + "TextMessage", this.TextMessage);
            this.SetParamSimple(map, prefix + "ImageMessage", this.ImageMessage);
            this.SetParamObj(map, prefix + "CustomMessage.", this.CustomMessage);
        }
    }
}

