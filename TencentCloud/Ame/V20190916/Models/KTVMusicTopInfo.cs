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

    public class KTVMusicTopInfo : AbstractModel
    {
        
        /// <summary>
        /// 歌曲Id
        /// </summary>
        [JsonProperty("MusicId")]
        public string MusicId{ get; set; }

        /// <summary>
        /// 歌曲名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 歌手名称列表
        /// </summary>
        [JsonProperty("SingerInfoSet")]
        public KTVSingerBaseInfo[] SingerInfoSet{ get; set; }

        /// <summary>
        /// 歌词名称列表
        /// </summary>
        [JsonProperty("LyricistSet")]
        public string[] LyricistSet{ get; set; }

        /// <summary>
        /// 作曲列表
        /// </summary>
        [JsonProperty("ComposerSet")]
        public string[] ComposerSet{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("TagSet")]
        public string[] TagSet{ get; set; }

        /// <summary>
        /// 播放时长
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MusicId", this.MusicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "SingerInfoSet.", this.SingerInfoSet);
            this.SetParamArraySimple(map, prefix + "LyricistSet.", this.LyricistSet);
            this.SetParamArraySimple(map, prefix + "ComposerSet.", this.ComposerSet);
            this.SetParamArraySimple(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
        }
    }
}

