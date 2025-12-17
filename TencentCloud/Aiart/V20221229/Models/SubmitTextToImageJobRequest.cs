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
        /// 文本描述。 
        /// 算法将根据输入的文本智能生成与之相关的图像。 
        /// 不能为空，推荐使用中文。最多可传1024个 utf-8 字符。
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 生成图分辨率，默认1024:1024：
        ///  - 宽高维度均在 [512, 2048] 像素范围内;
        ///  - 宽高乘积（即图像面积）不超过 1024×1024 像素;
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 随机种子，默认随机。
        /// 不传：随机种子生成。
        /// 正数：固定种子生成。
        /// 扩写开启时固定种子不生效，将保持随机。
        /// </summary>
        [JsonProperty("Seed")]
        public long? Seed{ get; set; }

        /// <summary>
        /// 为生成结果图添加显式水印标识的开关，默认为1。  
        /// 1：添加。  
        /// 0：不添加。  
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
        /// 是否开启prompt改写，为空时默认开启，改写预计会增加20s左右耗时。
        /// 0：关闭改写
        /// 1：开启改写
        /// 建议默认开启，如果关闭改写，需要调用方自己接改写，否则对生图效果有较大影响，改写方法可以参考：[改写](https://github.com/Tencent-Hunyuan/HunyuanImage-3.0/tree/main/PE)
        /// 示例值：1
        /// </summary>
        [JsonProperty("Revise")]
        public long? Revise{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
            this.SetParamSimple(map, prefix + "Revise", this.Revise);
        }
    }
}

