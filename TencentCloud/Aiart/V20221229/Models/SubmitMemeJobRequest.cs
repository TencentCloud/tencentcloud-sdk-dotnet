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

    public class SubmitMemeJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>表情模板。<br>请在 <a href="https://cloud.tencent.com/document/product/1668/115327">表情动图模板列表</a>  中选择期望的模板，传入 Pose 名称。</p>
        /// </summary>
        [JsonProperty("Pose")]
        public string Pose{ get; set; }

        /// <summary>
        /// <p>人像参考图 Base64 数据。<br>Base64 和 Url 必须提供一个，如果都提供以 Url 为准。<br>图片限制：单边分辨率小于5000px，转成 Base64 字符串后小于 6MB，格式支持 jpg、jpeg、png、bmp、tiff、webp。</p>
        /// </summary>
        [JsonProperty("InputImage")]
        public string InputImage{ get; set; }

        /// <summary>
        /// <p>人像参考图 Url。<br>Base64 和 Url 必须提供一个，如果都提供以 Url 为准。<br>图片限制：单边分辨率小于5000px，转成 Base64 字符串后小于 6MB，格式支持 jpg、jpeg、png、bmp、tiff、webp。</p>
        /// </summary>
        [JsonProperty("InputUrl")]
        public string InputUrl{ get; set; }

        /// <summary>
        /// <p>生成分辨率，单位为 px。<br>真人类型支持256、512，默认为256，<br>卡通类型仅支持512。</p>
        /// </summary>
        [JsonProperty("Resolution")]
        public long? Resolution{ get; set; }

        /// <summary>
        /// <p>自定义文案。<br>仅对真人类型的 Pose 生效，将在生成的表情动图中显示指定的文字。如果传入的字符串长度大于10，只截取前10个显示。<br>如果不传，默认使用自带的文案。<br>如果 text = &quot;&quot; 空字符串，代表不在表情动图中添加文案。</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>头发遮罩开关。<br>true：裁剪过长的头发。<br>false：不裁剪过长的头发。<br>仅对卡通类型的 Pose 生效，默认为 false。</p>
        /// </summary>
        [JsonProperty("Haircut")]
        public bool? Haircut{ get; set; }

        /// <summary>
        /// <p>为生成结果图添加标识的开关，默认为1。<br>1：添加标识。<br>0：不添加标识。<br>其他数值：默认按1处理。<br>建议您使用显著标识来提示结果图是 AI 生成的图片。</p>
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// <p>标识内容设置。<br>默认在生成结果图右下角添加“图片由 AI 生成”字样，您可根据自身需要替换为其他的标识图片。<br>示例值：{&quot;LogoUrl&quot;: &quot;https://cos.ap-guangzhou.myqcloud.com/logo.jpg&quot;, &quot;LogoRect&quot;: {&quot;X&quot;: 10, &quot;Y&quot;: 10, &quot;Width&quot;: 20, &quot;Height&quot;: 20}}</p>
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Pose", this.Pose);
            this.SetParamSimple(map, prefix + "InputImage", this.InputImage);
            this.SetParamSimple(map, prefix + "InputUrl", this.InputUrl);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Haircut", this.Haircut);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
        }
    }
}

