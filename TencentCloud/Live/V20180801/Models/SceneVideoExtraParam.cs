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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SceneVideoExtraParam : AbstractModel
    {
        
        /// <summary>
        /// <p>指定输出分辨率。选项:720P, 1080P, 2K, 4K。</p>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>指定输出视频的宽高比，示例：16:9。</p>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// <p>错峰模型，仅支持的模型可使用。</p>
        /// </summary>
        [JsonProperty("OffPeak")]
        public bool? OffPeak{ get; set; }

        /// <summary>
        /// <p>自动添加水印，默认左上角添加 &quot;AI生成&quot; 标识。</p>
        /// </summary>
        [JsonProperty("LogoAdd")]
        public bool? LogoAdd{ get; set; }

        /// <summary>
        /// <p>使用音画同出。</p>
        /// </summary>
        [JsonProperty("EnableAudio")]
        public bool? EnableAudio{ get; set; }

        /// <summary>
        /// <p>生成背景音乐。</p>
        /// </summary>
        [JsonProperty("EnableBgm")]
        public bool? EnableBgm{ get; set; }

        /// <summary>
        /// <p>对输入的Prompt进行优化。</p>
        /// </summary>
        [JsonProperty("EnablePromptEnhance")]
        public bool? EnablePromptEnhance{ get; set; }

        /// <summary>
        /// <p>回调URL。</p>
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "OffPeak", this.OffPeak);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamSimple(map, prefix + "EnableAudio", this.EnableAudio);
            this.SetParamSimple(map, prefix + "EnableBgm", this.EnableBgm);
            this.SetParamSimple(map, prefix + "EnablePromptEnhance", this.EnablePromptEnhance);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
        }
    }
}

