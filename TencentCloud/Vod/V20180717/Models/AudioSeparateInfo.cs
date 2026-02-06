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

    public class AudioSeparateInfo : AbstractModel
    {
        
        /// <summary>
        /// 音频分离控制开关，可选值：
        /// <li>ON：开启音频分离；</li>
        /// <li>OFF：关闭音频分离。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 场景类型，可选值：
        /// <li>normal：人声背景声场景</li>
        /// <li>music：演唱伴奏场景</li>
        /// 默认值：normal。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 输出音轨，可选值：
        /// <li>vocal：输出人声</li>
        /// <li>background：应用场景为normal时输出背景声，应用场景为music时输出伴奏</li>
        /// 默认值：vocal。
        /// </summary>
        [JsonProperty("Track")]
        public string Track{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Track", this.Track);
        }
    }
}

