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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitAigcVideoJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模型名称。</p><p>枚举值：</p><p>● Vidu；</p><p>● Kling：可灵；</p><p>● SA；</p><p>● VO；</p><p>● HY：混元；</p><p>● YT：优图；</p><p>示例值：Vidu</p>
        /// </summary>
        [JsonProperty("Vendor")]
        public string Vendor{ get; set; }

        /// <summary>
        /// <p>模型版本。</p><p>按照【厂商-版本号】</p><p>枚举值：</p><p>● 当ModelName为Vidu时，可选值[q2, q2-pro, q2-turbo]</p><p>● 当ModelName为Kling时，可选值[v1.6, v2.0, v2.1, v2.5 , v2.6]</p><p>● 当ModelName为SA时，可选值[SA2]</p><p>● 当ModelName为VO时，可选值[V3, V3.1, V3-Fast, V3.1-Fast]</p><p>● 当ModelName为HY时，默认选择：v1.5</p><p>● 当ModelName为YT时，默认值选择：v2.0</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>模型参数Json-Format字符串</p>
        /// </summary>
        [JsonProperty("ModelParam")]
        public string ModelParam{ get; set; }

        /// <summary>
        /// <p>正向文本提示词。不能超过2000个字符</p><p>示例值：一只小猫在草地奔跑</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>为生成结果图添加显式水印标识的开关，默认为1。<br>1：添加。<br>0：不添加。<br>其他数值：默认按1处理。<br>建议您使用显著标识来提示结果图使用了 AI 绘画技术，是 AI 生成的图片。<br>示例值：1</p>
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// <p>标识内容设置。<br>默认在生成结果图右下角添加“图片由 AI 生成”字样，您可根据自身需要替换为其他的标识图片。</p>
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Vendor", this.Vendor);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "ModelParam", this.ModelParam);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
        }
    }
}

