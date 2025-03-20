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

    public class ReceiveMessageResponse : AbstractModel
    {
        
        /// <summary>
        /// 用作标识消息的唯一主键
        /// </summary>
        [JsonProperty("MessageID")]
        public string MessageID{ get; set; }

        /// <summary>
        /// 接收消息的内容
        /// </summary>
        [JsonProperty("MessagePayload")]
        public string MessagePayload{ get; set; }

        /// <summary>
        /// 提供给 Ack 接口，用来Ack哪一个topic中的消息
        /// </summary>
        [JsonProperty("AckTopic")]
        public string AckTopic{ get; set; }

        /// <summary>
        /// 返回的错误信息，如果为空，说明没有错误
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }

        /// <summary>
        /// 返回订阅者的名字，用来创建 ack consumer时使用
        /// </summary>
        [JsonProperty("SubName")]
        public string SubName{ get; set; }

        /// <summary>
        /// BatchReceivePolicy 一次性返回的多条消息的 MessageID，用 ‘###’ 来区分不同的 MessageID
        /// </summary>
        [JsonProperty("MessageIDList")]
        public string MessageIDList{ get; set; }

        /// <summary>
        /// BatchReceivePolicy 一次性返回的多条消息的消息内容，用 ‘###’ 来区分不同的消息内容
        /// </summary>
        [JsonProperty("MessagesPayload")]
        public string MessagesPayload{ get; set; }

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
            this.SetParamSimple(map, prefix + "MessageID", this.MessageID);
            this.SetParamSimple(map, prefix + "MessagePayload", this.MessagePayload);
            this.SetParamSimple(map, prefix + "AckTopic", this.AckTopic);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
            this.SetParamSimple(map, prefix + "SubName", this.SubName);
            this.SetParamSimple(map, prefix + "MessageIDList", this.MessageIDList);
            this.SetParamSimple(map, prefix + "MessagesPayload", this.MessagesPayload);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

