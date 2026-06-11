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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiTryOnConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>换装模型。</p><p>枚举值：</p><ul><li>WAND-tryon-1.0-lite： 轻量档，速度优先。</li><li>WAND-tryon-1.0-flash： 均衡档，兼顾效果与时延。</li><li>WAND-tryon-1.0-pro： 高质量档，效果优先。</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>输入需要更换的衣物图片列表。支持1-4张图片。</p>
        /// </summary>
        [JsonProperty("ClothesFileInfos")]
        public SceneAigcImageTaskInputFileInfo[] ClothesFileInfos{ get; set; }

        /// <summary>
        /// <p>换装指令Prompt。</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArrayObj(map, prefix + "ClothesFileInfos.", this.ClothesFileInfos);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
        }
    }
}

