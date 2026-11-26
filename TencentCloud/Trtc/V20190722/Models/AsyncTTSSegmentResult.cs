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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AsyncTTSSegmentResult : AbstractModel
    {
        
        /// <summary>
        /// <p>分段文本</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>音频下载url</p>
        /// </summary>
        [JsonProperty("AudioDownloadUrl")]
        public string AudioDownloadUrl{ get; set; }

        /// <summary>
        /// <p>音频时长</p><p>单位：ms</p>
        /// </summary>
        [JsonProperty("DurationMs")]
        public ulong? DurationMs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "AudioDownloadUrl", this.AudioDownloadUrl);
            this.SetParamSimple(map, prefix + "DurationMs", this.DurationMs);
        }
    }
}

