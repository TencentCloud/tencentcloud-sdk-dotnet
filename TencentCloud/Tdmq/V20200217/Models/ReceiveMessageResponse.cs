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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }

        /// <summary>
        /// 返回订阅者的名字，用来创建 ack consumer时使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubName")]
        public string SubName{ get; set; }

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
            this.SetParamSimple(map, prefix + "MessageID", this.MessageID);
            this.SetParamSimple(map, prefix + "MessagePayload", this.MessagePayload);
            this.SetParamSimple(map, prefix + "AckTopic", this.AckTopic);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
            this.SetParamSimple(map, prefix + "SubName", this.SubName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

