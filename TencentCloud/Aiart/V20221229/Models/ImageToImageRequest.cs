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

namespace TencentCloud.Aiart.V20221229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageToImageRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>输入图 Base64 数据。<br>算法将根据输入的图片，结合文本描述智能生成与之相关的图像。<br>Base64 和 Url 必须提供一个，如果都提供以 Url 为准。<br>图片限制：单边分辨率小于5000px且大于50px，转成 Base64 字符串后小于 8MB，格式支持 jpg、jpeg、png、bmp、tiff、webp。</p>
        /// </summary>
        [JsonProperty("InputImage")]
        public string InputImage{ get; set; }

        /// <summary>
        /// <p>输入图 Url。<br>算法将根据输入的图片，结合文本描述智能生成与之相关的图像。<br>Base64 和 Url 必须提供一个，如果都提供以 Url 为准。<br>图片限制：单边分辨率小于5000px且大于50px，转成 Base64 字符串后小于 8MB，格式支持 jpg、jpeg、png、bmp、tiff、webp。</p>
        /// </summary>
        [JsonProperty("InputUrl")]
        public string InputUrl{ get; set; }

        /// <summary>
        /// <p>文本描述。<br>用于在输入图的基础上引导生成图效果，增加生成结果中出现描述内容的可能。<br>推荐使用中文。最多支持256个 utf-8 字符。</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>反向文本描述。<br>用于一定程度上从反面引导模型生成的走向，减少生成结果中出现描述内容的可能，但不能完全杜绝。<br>推荐使用中文。最多可传256个 utf-8 字符。</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// <p>绘画风格。<br>请在  <a href="https://cloud.tencent.com/document/product/1668/86250">图像风格化风格列表</a> 中选择期望的风格，传入风格编号。<br>推荐使用且只使用一种风格。不传默认使用201（日系动漫风格）。</p>
        /// </summary>
        [JsonProperty("Styles")]
        public string[] Styles{ get; set; }

        /// <summary>
        /// <p>生成图结果的配置，包括输出图片分辨率和尺寸等。<br>支持生成以下分辨率的图片：origin（与输入图分辨率一致，长边最高为2000，超出将做等比例缩小）、768:768（1:1）、768:1024（3:4）、1024:768（4:3）。<br>不传默认使用origin。<br>单位为 px。</p>
        /// </summary>
        [JsonProperty("ResultConfig")]
        public ResultConfig ResultConfig{ get; set; }

        /// <summary>
        /// <p>为生成结果图添加标识的开关，默认为1。<br>1：添加标识。<br>0：不添加标识。<br>其他数值：默认按1处理。<br>建议您使用显著标识来提示结果图使用了 AI 绘画技术，是 AI 生成的图片。</p>
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// <p>标识内容设置。<br>默认在生成结果图右下角添加“图片由 AI 生成”字样，您可根据自身需要替换为其他的标识图片。</p>
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }

        /// <summary>
        /// <p>生成自由度。<br>Strength 值越小，生成图和原图越接近，取值范围(0, 1]，不传使用模型内置的默认值。<br>推荐的取值范围为0.6 - 0.8。</p>
        /// </summary>
        [JsonProperty("Strength")]
        public float? Strength{ get; set; }

        /// <summary>
        /// <p>返回图像方式（base64 或 url) ，二选一，默认为 base64。url 有效期为1小时。</p>
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }

        /// <summary>
        /// <p>画质增强开关，默认关闭。<br>1：开启<br>0：关闭<br>开启后将增强图像的画质清晰度，生成耗时有所增加。</p>
        /// </summary>
        [JsonProperty("EnhanceImage")]
        public long? EnhanceImage{ get; set; }

        /// <summary>
        /// <p>细节优化的面部数量上限，支持0 ~ 6，默认为0。<br>若上传大于0的值，将以此为上限对每张图片中面积占比较小的面部进行细节修复，生成耗时根据实际优化的面部个数有所增加。</p>
        /// </summary>
        [JsonProperty("RestoreFace")]
        public long? RestoreFace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputImage", this.InputImage);
            this.SetParamSimple(map, prefix + "InputUrl", this.InputUrl);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamArraySimple(map, prefix + "Styles.", this.Styles);
            this.SetParamObj(map, prefix + "ResultConfig.", this.ResultConfig);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
            this.SetParamSimple(map, prefix + "Strength", this.Strength);
            this.SetParamSimple(map, prefix + "RspImgType", this.RspImgType);
            this.SetParamSimple(map, prefix + "EnhanceImage", this.EnhanceImage);
            this.SetParamSimple(map, prefix + "RestoreFace", this.RestoreFace);
        }
    }
}

