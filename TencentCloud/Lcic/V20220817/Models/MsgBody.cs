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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MsgBody : AbstractModel
    {
        
        /// <summary>
        /// TIM 消息对象类型，目前支持的消息对象包括：
        /// TIMTextElem（文本消息）
        /// TIMFaceElem（表情消息）
        /// TIMImageElem（图像消息）
        /// TIMCustomElem（自定义消息）
        /// </summary>
        [JsonProperty("MsgType")]
        public string MsgType{ get; set; }

        /// <summary>
        /// 文本消息，当MsgType 为TIMTextElem（文本消息）必选。
        /// </summary>
        [JsonProperty("TextMsgContent")]
        public TextMsgContent TextMsgContent{ get; set; }

        /// <summary>
        /// 表情消息，当MsgType 为TIMFaceElem（表情消息）必选。
        /// </summary>
        [JsonProperty("FaceMsgContent")]
        public FaceMsgContent FaceMsgContent{ get; set; }

        /// <summary>
        /// 图像消息，当MsgType为TIMImageElem（图像消息）必选。
        /// </summary>
        [JsonProperty("ImageMsgContent")]
        public ImageMsgContent ImageMsgContent{ get; set; }

        /// <summary>
        /// 自定义消息，TIMCustomElem（自定义消息）必选。
        /// </summary>
        [JsonProperty("CustomMsgContent")]
        public CustomMsgContent CustomMsgContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MsgType", this.MsgType);
            this.SetParamObj(map, prefix + "TextMsgContent.", this.TextMsgContent);
            this.SetParamObj(map, prefix + "FaceMsgContent.", this.FaceMsgContent);
            this.SetParamObj(map, prefix + "ImageMsgContent.", this.ImageMsgContent);
            this.SetParamObj(map, prefix + "CustomMsgContent.", this.CustomMsgContent);
        }
    }
}

