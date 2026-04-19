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

    public class SubmitDrawPortraitJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>写真模型 ID。</p>
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// <p>写真风格模板。<br>请在<a href="https://cloud.tencent.com/document/product/1668/105740"> AI 写真风格列表</a> 中选择期望的风格，传入风格编号。</p>
        /// </summary>
        [JsonProperty("StyleId")]
        public string StyleId{ get; set; }

        /// <summary>
        /// <p>本次生成的图片数量，取值范围[1,4]</p>
        /// </summary>
        [JsonProperty("ImageNum")]
        public long? ImageNum{ get; set; }

        /// <summary>
        /// <p>为生成结果图添加标识的开关，默认为1。<br>1：添加标识。<br> 0：不添加标识。<br>其他数值：默认按1处理。<br>建议您使用显著标识来提示结果图是 AI 生成的图片。</p>
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// <p>标识内容设置。<br>默认在生成结果图右下角添加“图片由 AI 生成”字样，您可根据自身需要替换为其他的标识图片。<br>示例值：{&quot;LogoUrl&quot;: &quot;https://cos.ap-guangzhou.myqcloud.com/logo.jpg&quot;, &quot;LogoRect&quot;: {&quot;X&quot;: 10, &quot;Y&quot;: 10, &quot;Width&quot;: 20, &quot;Height&quot;: 20}}</p>
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }

        /// <summary>
        /// <p>清晰度，单位为 px。<br>支持以下选项：<br>sd：基础版，分辨率512:640<br>hd：高清畅享版，分辨率1024:1280<br>hdpro：高清优享版，分辨率1024:1280（推荐）<br>uhd：超清版，分辨率2048:2560<br>不填默认为sd。</p>
        /// </summary>
        [JsonProperty("Definition")]
        public string Definition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "StyleId", this.StyleId);
            this.SetParamSimple(map, prefix + "ImageNum", this.ImageNum);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
        }
    }
}

