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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateImageConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>生图模型</p><p>枚举值：</p><ul><li>WAND-create-1.0-lite： 轻量生图模型</li><li>WAND-create-1.0-flash： 质量-速度平衡生图模型</li><li>WAND-create-1.0-pro： 高质量生图模型</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>生图指令</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>输出图片的分辨率</p><p>枚举值：</p><ul><li>1K： 短边分辨率 1080</li><li>2K： 短边分辨率 1440</li><li>4K： 短边分辨率 2160</li></ul><p>默认值：1K</p>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>输出图片的宽高比</p><p>枚举值：</p><ul><li>1:1： 宽高比 1:1</li><li>2:3： 宽高比 2:3</li><li>3:2： 宽高比 3:2</li><li>3:4： 宽高比 3:4</li><li>4:3： 宽高比 4:3</li><li>9:16： 宽高比 9:16</li><li>16:9： 宽高比 16:9</li></ul><p>默认值：1:1</p>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
        }
    }
}

