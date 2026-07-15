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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TalkSTTTRTC : AbstractModel
    {
        
        /// <summary>
        /// <p>识别语言，只支持 <code>zh</code>、<code>16k_zh_large</code></p>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>VAD 静默检测时间，单位 ms，范围 240–2000</p>
        /// </summary>
        [JsonProperty("VADSilenceTime")]
        public long? VADSilenceTime{ get; set; }

        /// <summary>
        /// <p>远场人声抑制等级，范围 0–5</p>
        /// </summary>
        [JsonProperty("VADLevel")]
        public long? VADLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "VADSilenceTime", this.VADSilenceTime);
            this.SetParamSimple(map, prefix + "VADLevel", this.VADLevel);
        }
    }
}

