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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LivenessRecognitionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>身份证号。</p>
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// <p>姓名。</p><ul><li>中文请使用UTF-8编码。</li></ul>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>活体检测类型。</p><ul><li>取值：LIP/ACTION/SILENT。</li><li>LIP为数字模式，ACTION为动作模式，SILENT为静默模式，三种模式选择一种传入。</li></ul>
        /// </summary>
        [JsonProperty("LivenessType")]
        public string LivenessType{ get; set; }

        /// <summary>
        /// <p>用于活体检测的视频，视频的BASE64值；<br>BASE64编码后的大小不超过8M，支持mp4、avi、flv格式。</p>
        /// </summary>
        [JsonProperty("VideoBase64")]
        public string VideoBase64{ get; set; }

        /// <summary>
        /// <p>用于活体检测的视频Url 地址。</p><ul><li>视频下载后经Base64编码不超过 8M，视频下载耗时不超过4S，支持mp4、avi、flv格式。</li><li>视频的 VideoUrl、VideoBase64 必须提供一个，如果都提供，只使用 VideoBase64。</li><li>建议视频存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议视频存储于腾讯云。</li><li>非腾讯云存储的 Url 速度和稳定性可能受一定影响。</li></ul>
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// <p>验证数据。</p><ul><li>数字活体模式传参：传数字验证码，验证码需先调用<a href="https://cloud.tencent.com/document/product/1007/31821">获取数字验证码接口</a>得到；</li><li>动作活体模式传参：传动作顺序，动作顺序需先调用<a href="https://cloud.tencent.com/document/product/1007/31822">获取动作顺序接口</a>得到；</li><li>静默活体模式传参：空。</li></ul>
        /// </summary>
        [JsonProperty("ValidateData")]
        public string ValidateData{ get; set; }

        /// <summary>
        /// <p>额外配置，传入JSON字符串。</p><ul><li>格式如下：<br>{<br>&quot;BestFrameNum&quot;: 2  //需要返回多张最佳截图，取值范围2-10<br>}</li></ul>
        /// </summary>
        [JsonProperty("Optional")]
        public string Optional{ get; set; }

        /// <summary>
        /// <p>敏感数据加密信息。</p><ul><li>对传入信息（姓名、身份证号）有加密需求的用户可使用此参数，详情请点击左侧链接。</li></ul>
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "LivenessType", this.LivenessType);
            this.SetParamSimple(map, prefix + "VideoBase64", this.VideoBase64);
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "ValidateData", this.ValidateData);
            this.SetParamSimple(map, prefix + "Optional", this.Optional);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
        }
    }
}

