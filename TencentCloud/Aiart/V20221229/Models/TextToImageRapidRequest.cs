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

    public class TextToImageRapidRequest : AbstractModel
    {
        
        /// <summary>
        /// 文本描述。
        /// 算法将根据输入的文本智能生成与之相关的图像。建议详细描述画面主体、细节、场景等，文本描述越丰富，生成效果越精美。
        /// 不能为空，推荐使用中文。最多可传256个 utf-8 字符。
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 生成图分辨率，默认1024:1024。
        /// 支持的图像宽高比例: 1:1，3:4，4:3，9:16，16:9。
        /// 支持的长边分辨率: 160，200，225，258，512，520，608，768，1024，1080，1280，1600，1620，1920，2048，2400，2560，2592，3440，3840，4096。
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 随机种子，默认随机。
        /// 0：随机种子生成。
        /// 不传：随机种子生成。
        /// 正数：固定种子生成。
        /// </summary>
        [JsonProperty("Seed")]
        public long? Seed{ get; set; }

        /// <summary>
        /// 参考图。
        /// 
        /// - Base64 和 Url 必须提供一个，如果都提供以 Url 为准。
        /// - 当传入Image参数时，Style和Resolution参数不生效，输出图分辨率将保持Image传入图分辨率。
        /// - 图片限制：单边分辨率大于128且小于2048；图片小于6M；格式支持 jpg、jpeg、png、bmp、tiff、webp。
        /// </summary>
        [JsonProperty("Image")]
        public Image Image{ get; set; }

        /// <summary>
        /// 生成的图片风格，参考值：
        /// 
        /// 1：宫崎骏风格；
        /// 2：新海诚风格；
        /// 3：去旅行风格；
        /// 4：水彩风格；
        /// 5：像素风格；
        /// 6：童话世界风格；
        /// 7：奇趣卡通风格；
        /// 8：赛博朋克风格；
        /// 9：极简风格；
        /// 10：复古风格；
        /// 11：暗黑系风格；
        /// 12：波普风风格；
        /// 13：糖果色风格；
        /// 14：胶片电影风格；
        /// 15：素描风格；
        /// 16：水墨画风格；
        /// 17：油画风格；
        /// 18：粉笔风格；
        /// 19：粘土风格；
        /// 20：毛毡风格；
        /// 21：刺绣风格；
        /// 22：彩铅风格；
        /// 23：莫奈风格；
        /// 24：毕加索风格；
        /// 25：穆夏风格；
        /// 26：古风二次元风格；
        /// 27：都市二次元风格；
        /// 28：悬疑风格；
        /// 29：校园风格；
        /// 30：都市异能风格。
        /// </summary>
        [JsonProperty("Style")]
        public string Style{ get; set; }

        /// <summary>
        /// 为生成结果图添加标识的开关，默认为1。
        /// 1：添加标识。
        /// 0：不添加标识。
        /// 其他数值：默认按1处理。
        /// 建议您使用显著标识来提示结果图使用了 AI 绘画技术，是 AI 生成的图片。
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// 标识内容设置。
        /// 默认在生成结果图右下角添加“图片由 AI 生成”字样，您可根据自身需要替换为其他的标识图片。
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }

        /// <summary>
        /// 返回图像方式（base64 或 url) ，二选一，默认为 base64。url 有效期为1小时。
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamObj(map, prefix + "Image.", this.Image);
            this.SetParamSimple(map, prefix + "Style", this.Style);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
            this.SetParamSimple(map, prefix + "RspImgType", this.RspImgType);
        }
    }
}

