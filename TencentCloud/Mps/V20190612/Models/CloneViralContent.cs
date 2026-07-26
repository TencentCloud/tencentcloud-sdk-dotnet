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

    public class CloneViralContent : AbstractModel
    {
        
        /// <summary>
        /// <p>自定义提示词，对生成视频的要求</p>
        /// </summary>
        [JsonProperty("UserPrompt")]
        public string UserPrompt{ get; set; }

        /// <summary>
        /// <p>生成视频的目标语言，默认不指定，支持zh / en / ja / ko / es / pt / instrumental（纯音乐无口播）</p>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>目标市场，默认不指定。可选north_america / europe / china / japan / korea / sea / brazil</p>
        /// </summary>
        [JsonProperty("Market")]
        public string Market{ get; set; }

        /// <summary>
        /// <p>裂变程度。exact/low/medium/high，默认exact 1:1复刻</p>
        /// </summary>
        [JsonProperty("FissionLevel")]
        public string FissionLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserPrompt", this.UserPrompt);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "Market", this.Market);
            this.SetParamSimple(map, prefix + "FissionLevel", this.FissionLevel);
        }
    }
}

