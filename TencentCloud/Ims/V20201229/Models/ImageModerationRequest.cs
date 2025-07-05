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

namespace TencentCloud.Ims.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageModerationRequest : AbstractModel
    {
        
        /// <summary>
        /// 该字段表示使用的策略的具体编号，该字段需要先在[内容安全控制台](#https://console.cloud.tencent.com/cms/clouds/manage)中配置。
        /// 备注：不同Biztype关联不同的业务场景与识别能力策略，调用前请确认正确的Biztype。
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// 该字段表示您为待检测对象分配的数据ID，传入后可方便您对文件进行标识和管理。<br>取值：由英文字母（大小写均可）、数字及四个特殊符号（_，-，@，#）组成，**长度不超过64个字符**。
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// 该字段表示待检测图片文件内容的Base64编码，由于云API对请求包体有大小限制，图片的**Base64编码内容大小不得超过10MB**。<br/>备注：**该字段与FileUrl必须选择输入其中一个**。
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// 该字段表示待检测图片文件的访问链接，URL源图**大小不超过30MB**。<br />备注：该字段与FileContent必须选择输入其中一个。
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// **GIF检测专用**，用于表示GIF截帧频率（每隔多少张图片抽取一帧进行检测）；默认值为0，此时只会检测GIF的第一帧或不进行切分处理。<br>备注：Interval与MaxFrames参数需要组合使用。例如，Interval=3, MaxFrames=400，则代表在检测GIF时，将每间隔2帧检测一次且最多检测400帧。
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// **GIF检测专用**，用于标识最大截帧数量；默认值为1，此时只会检测输入GIF的第一帧不进行切分处理（可能会造成处理超时）。<br>备注：Interval与MaxFrames参数需要组合使用。例如，Interval=3, MaxFrames=400，则代表在检测GIF时，将每间隔2帧检测一次且最多检测400帧。
        /// </summary>
        [JsonProperty("MaxFrames")]
        public long? MaxFrames{ get; set; }

        /// <summary>
        /// 该字段表示待检测对象对应的用户相关信息，若填入则可甄别相应违规风险用户。
        /// </summary>
        [JsonProperty("User")]
        public User User{ get; set; }

        /// <summary>
        /// 该字段表示待检测对象对应的设备相关信息，若填入则可甄别相应违规风险设备。
        /// </summary>
        [JsonProperty("Device")]
        public Device Device{ get; set; }

        /// <summary>
        /// 该字段表示输入的图片审核类型，取值含：IMAGE（内容安全）、IMAGE_AIGC（AI生成识别）两种，默认值为IMAGE。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "MaxFrames", this.MaxFrames);
            this.SetParamObj(map, prefix + "User.", this.User);
            this.SetParamObj(map, prefix + "Device.", this.Device);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

