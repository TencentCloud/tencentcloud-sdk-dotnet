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

    public class SubmitTextToImageJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>文本描述。<br>算法将根据输入的文本智能生成与之相关的图像。<br>不能为空，推荐使用中文。最多可传8192个 utf-8 字符。</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>参考图，最多三张图。  - Base64 或 Url 。 - 单张图片限制：图片base64后大小小于6M ；格式支持 jpg、jpeg、png、bmp、tiff、webp。</p>
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// <p>生成图分辨率<br>格式：&quot;${宽}:${高}&quot;，说明：分辨率的设置和输入是否有参考图（image_urls/images参数）有关：<br>一、文生图（无参考图）<br>默认分辨率：1024:1024；<br>尺寸约束：宽、高均在 [512, 2048] 像素范围内，宽高乘积 ≤ 1024:1024 像素。<br>二、图生图（有参考图）<br>尺寸约束：宽、高均在 [512, 2048] 像素范围内，宽高乘积 ≤ 1024:1024 像素。</p><p>传入尺寸时（输出自适应，不严格遵循传入尺寸）：<br>输入图分辨率分桶与传入尺寸分桶一致时：按输入图长宽比，缩放至接近 1024:1024 面积输出；<br>输入图分辨率分桶与传入尺寸分桶不一致时：从 尺寸列表 中选取最接近传入尺寸的尺寸输出<br>尺寸列表：2048:512、1984:512、1920:512、1856:512、1792:512、<br>1728:512、1664:512、1600:512、1536:512、1472:576、<br>1408:640、1344:704、1280:768、1216:832、1152:896、<br>1088:960、1024:1024、960:1088、896:1152、832:1216、<br>768:1280、704:1344、640:1408、576:1472、512:1536、<br>512:1600、512:1664、512:1728、512:1792、512:1856、<br>512:1920、512:1984、512:2048、768:1024、720:1280、<br>1024:768、1280:720<br>不传入尺寸时：将传入默认值1024:1024。</p>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>随机种子，默认随机。<br>不传：随机种子生成。<br>正数：固定种子生成。<br>扩写开启时固定种子不生效，将保持随机。</p>
        /// </summary>
        [JsonProperty("Seed")]
        public long? Seed{ get; set; }

        /// <summary>
        /// <p>为生成结果图添加显式水印标识的开关，默认为1。<br>1：添加。<br>0：不添加。<br>其他数值：默认按1处理。<br>建议您使用显著标识来提示结果图使用了 AI 绘画技术，是 AI 生成的图片。</p>
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// <p>标识内容设置。<br>默认在生成结果图右下角添加“图片由 AI 生成”字样，您可根据自身需要替换为其他的标识图片。</p>
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }

        /// <summary>
        /// <p>是否开启prompt改写，为空时默认开启，改写预计会增加20s左右耗时。<br>0：关闭改写<br>1：开启改写<br>建议默认开启，如果关闭改写，需要调用方自己接改写，否则对生图效果有较大影响，改写方法可以参考：<a href="https://github.com/Tencent-Hunyuan/HunyuanImage-3.0/tree/main/PE">改写</a><br>示例值：1</p>
        /// </summary>
        [JsonProperty("Revise")]
        public long? Revise{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
            this.SetParamSimple(map, prefix + "Revise", this.Revise);
        }
    }
}

