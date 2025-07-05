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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadAudioInfo : AbstractModel
    {
        
        /// <summary>
        /// 文件别名（可重复）
        /// </summary>
        [JsonProperty("CustomFileName")]
        public string CustomFileName{ get; set; }

        /// <summary>
        /// 音频文件链接。(支持mp3和wav格式，文件不超过5MB)
        /// </summary>
        [JsonProperty("AudioUrl")]
        public string AudioUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomFileName", this.CustomFileName);
            this.SetParamSimple(map, prefix + "AudioUrl", this.AudioUrl);
        }
    }
}

