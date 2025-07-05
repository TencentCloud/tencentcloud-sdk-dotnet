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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCloudMusicRequest : AbstractModel
    {
        
        /// <summary>
        /// 歌曲Id
        /// </summary>
        [JsonProperty("MusicId")]
        public string MusicId{ get; set; }

        /// <summary>
        /// 歌曲类型，可选值有：
        /// <li>MP3-128K-FTW：含有水印的试听资源；</li>
        /// <li>MP3-320K-FTD-P：320kbps歌曲热门片段；</li>
        /// <li>MP3-320K-FTD：320kbps已核验歌曲完整资源。</li>
        /// 默认为：MP3-128K-FTW
        /// </summary>
        [JsonProperty("MusicType")]
        public string MusicType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MusicId", this.MusicId);
            this.SetParamSimple(map, prefix + "MusicType", this.MusicType);
        }
    }
}

