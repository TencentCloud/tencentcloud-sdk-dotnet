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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLiveCallbackTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 模板名称，非空的字符串。
        /// 长度上限：255字节。
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 描述信息。
        /// 长度上限：1024字节。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 开播回调URL，
        /// 相关协议文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        [JsonProperty("StreamBeginNotifyUrl")]
        public string StreamBeginNotifyUrl{ get; set; }

        /// <summary>
        /// 断流回调URL，
        /// 相关协议文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        [JsonProperty("StreamEndNotifyUrl")]
        public string StreamEndNotifyUrl{ get; set; }

        /// <summary>
        /// 录制回调URL，
        /// 相关协议文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        [JsonProperty("RecordNotifyUrl")]
        public string RecordNotifyUrl{ get; set; }

        /// <summary>
        /// 截图回调URL，
        /// 相关协议文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        [JsonProperty("SnapshotNotifyUrl")]
        public string SnapshotNotifyUrl{ get; set; }

        /// <summary>
        /// 鉴黄回调URL，
        /// 相关协议文档：[事件消息通知](/document/product/267/32741)。
        /// </summary>
        [JsonProperty("PornCensorshipNotifyUrl")]
        public string PornCensorshipNotifyUrl{ get; set; }

        /// <summary>
        /// 回调key，回调URL公用，鉴权回调说明详见回调格式文档
        /// </summary>
        [JsonProperty("CallbackKey")]
        public string CallbackKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "StreamBeginNotifyUrl", this.StreamBeginNotifyUrl);
            this.SetParamSimple(map, prefix + "StreamEndNotifyUrl", this.StreamEndNotifyUrl);
            this.SetParamSimple(map, prefix + "RecordNotifyUrl", this.RecordNotifyUrl);
            this.SetParamSimple(map, prefix + "SnapshotNotifyUrl", this.SnapshotNotifyUrl);
            this.SetParamSimple(map, prefix + "PornCensorshipNotifyUrl", this.PornCensorshipNotifyUrl);
            this.SetParamSimple(map, prefix + "CallbackKey", this.CallbackKey);
        }
    }
}

