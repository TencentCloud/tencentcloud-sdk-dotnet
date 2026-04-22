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

    public class CreateImageModerationAsyncTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>接收审核信息回调地址，审核过程中产生的所有结果发送至此地址。</p>
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// <p>该字段表示策略的具体编号，用于接口调度，在内容安全控制台中可配置。若不传入Biztype参数（留空），则代表采用默认的识别策略；传入则会在审核时根据业务场景采取不同的审核策略。<br>备注：Biztype仅为数字、字母与下划线的组合，长度为3-32个字符；不同Biztype关联不同的业务场景与识别能力策略，调用前请确认正确的Biztype。</p>
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// <p>该字段表示您为待检测对象分配的数据ID，传入后可方便您对文件进行标识和管理。<br>取值：由英文字母（大小写均可）、数字及四个特殊符号（_，-，@，#）组成，<strong>长度不超过64个字符</strong>。</p>
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// <p>该字段表示待检测图片文件内容的Base64编码，图片<strong>大小不超过10MB</strong>，建议<strong>分辨率不低于256x256</strong>，否则可能会影响识别效果。<br>备注： <strong>该字段与FileUrl必须选择输入其中一个</strong>。</p>
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// <p>该字段表示待检测图片文件的访问链接，图片支持PNG、JPG、JPEG、BMP、GIF、WEBP格式，<strong>大小不超过100MB</strong>，建议<strong>分辨率不低于256x256</strong>；图片下载时间限制为3秒，超过则会返回下载超时；由于网络安全策略，<strong>送审带重定向的链接，可能引起下载失败</strong>，请尽量避免，比如Http返回302状态码的链接，可能导致接口返回ResourceUnavailable.ImageDownloadError。<br>备注：<strong>该字段与FileContent必须选择输入其中一个</strong>。</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// <p><strong>GIF/长图检测专用</strong>，用于表示GIF截帧频率（每隔多少张图片抽取一帧进行检测），长图则按照长边：短边取整计算要切割的总图数；默认值为0，此时只会检测GIF的第一帧或对长图不进行切分处理。<br>备注：Interval与MaxFrames参数需要组合使用。例如，Interval=3, MaxFrames=400，则代表在检测GIF/长图时，将每间隔2帧检测一次且最多检测400帧。</p>
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// <p><strong>GIF/长图检测专用</strong>，用于标识最大截帧数量；默认值为1，此时只会检测输入GIF的第一帧或对长图不进行切分处理（可能会造成处理超时）。<br>备注：Interval与MaxFrames参数需要组合使用。例如，Interval=3, MaxFrames=400，则代表在检测GIF/长图时，将每间隔2帧检测一次且最多检测400帧。</p>
        /// </summary>
        [JsonProperty("MaxFrames")]
        public long? MaxFrames{ get; set; }

        /// <summary>
        /// <p>该字段表示待检测对象对应的用户相关信息，若填入则可甄别相应违规风险用户。</p>
        /// </summary>
        [JsonProperty("User")]
        public User User{ get; set; }

        /// <summary>
        /// <p>该字段表示待检测对象对应的设备相关信息，若填入则可甄别相应违规风险设备。</p>
        /// </summary>
        [JsonProperty("Device")]
        public Device Device{ get; set; }

        /// <summary>
        /// <p>服务类型，可为空，默认为 IMAGE。</p><p>枚举值：</p><ul><li>IMAGE： 一般图片异步检测</li><li>IMAGE_LLM： 大模型图片异步检测</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>该字段表示待审核的图片资源链接，最多支持传入4张图片</p>
        /// </summary>
        [JsonProperty("FileUrlList")]
        public string[] FileUrlList{ get; set; }

        /// <summary>
        /// <p>待审核的文本内容，需为UTF-8编码并以Base64格式传入，字数限制5000字内。</p>
        /// </summary>
        [JsonProperty("TextContent")]
        public string TextContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "MaxFrames", this.MaxFrames);
            this.SetParamObj(map, prefix + "User.", this.User);
            this.SetParamObj(map, prefix + "Device.", this.Device);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "FileUrlList.", this.FileUrlList);
            this.SetParamSimple(map, prefix + "TextContent", this.TextContent);
        }
    }
}

