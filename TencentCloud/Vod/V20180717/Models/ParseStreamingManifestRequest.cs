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

    public class ParseStreamingManifestRequest : AbstractModel
    {
        
        /// <summary>
        /// 待解析的索引文件内容。
        /// </summary>
        [JsonProperty("MediaManifestContent")]
        public string MediaManifestContent{ get; set; }

        /// <summary>
        /// 视频索引文件格式。默认 m3u8 格式。
        /// <li>m3u8</li>
        /// <li>mpd</li>
        /// </summary>
        [JsonProperty("ManifestType")]
        public string ManifestType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MediaManifestContent", this.MediaManifestContent);
            this.SetParamSimple(map, prefix + "ManifestType", this.ManifestType);
        }
    }
}

