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

    public class CharacterSceneConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>模型。</p><p>枚举值：</p><ul><li>character_scene_standard： 标准。</li><li>character_scene_mini： 轻量。</li><li>character_scene_fast： 快速。</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>提示词模式。</p><p>枚举值：</p><ul><li>Standard： 标准模式，自行填写提示词。</li><li>Dynamic： 动态模式，由大模型根据参考素材产生提示词。</li></ul><p>默认值：Standard</p>
        /// </summary>
        [JsonProperty("PromptMode")]
        public string PromptMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "PromptMode", this.PromptMode);
        }
    }
}

