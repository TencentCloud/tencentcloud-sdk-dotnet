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

    public class AiDramaInput : AbstractModel
    {
        
        /// <summary>
        /// <p>ai漫剧剧本</p><p>参数格式：无</p><p>入参限制：无</p>
        /// </summary>
        [JsonProperty("Script")]
        public string Script{ get; set; }

        /// <summary>
        /// <p>ai漫剧风格</p><p>枚举值：</p><ul><li>chinese_ink_wash： 国风水墨</li><li>fantasy_cyberpunk： 奇幻赛博朋克</li><li>japanese_anime_2d： 日漫二次元</li></ul><p>默认值：chinese_ink_wash</p><p>枚举值：</p><ul><li>realistic_live_action： 真人写实</li><li>chinese_ink_wash： 国风水墨</li><li>fantasy_cyberpunk： 奇幻赛博朋克</li><li>japanese_anime_2d： 日漫二次元</li></ul><p>默认值：chinese_ink_wash</p>
        /// </summary>
        [JsonProperty("Style")]
        public string Style{ get; set; }

        /// <summary>
        /// <p>宽高比</p><p>枚举值：</p><ul><li>16:9： 16:9</li><li>9:16： 9:16</li></ul><p>默认值：16:9</p>
        /// </summary>
        [JsonProperty("Ratio")]
        public string Ratio{ get; set; }

        /// <summary>
        /// <p>输出视频分辨率</p><p>枚举值：</p><ul><li>720p： 720p</li><li>1080p： 1080p</li></ul><p>默认值：720p</p>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Script", this.Script);
            this.SetParamSimple(map, prefix + "Style", this.Style);
            this.SetParamSimple(map, prefix + "Ratio", this.Ratio);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
        }
    }
}

