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

namespace TencentCloud.Yinsuda.V20220527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KTVMusicBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>歌曲Id。</p>
        /// </summary>
        [JsonProperty("MusicId")]
        public string MusicId{ get; set; }

        /// <summary>
        /// <p>歌曲名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>歌手名称。</p>
        /// </summary>
        [JsonProperty("SingerSet")]
        public string[] SingerSet{ get; set; }

        /// <summary>
        /// <p>播放时长。</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// <p>歌手图片链接。</p>
        /// </summary>
        [JsonProperty("SingerImageUrl")]
        public string SingerImageUrl{ get; set; }

        /// <summary>
        /// <p>专辑信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlbumInfo")]
        public MusicAlbumInfo AlbumInfo{ get; set; }

        /// <summary>
        /// <p>权益列表，取值有：</p><li>Play：可播；</li><li>Sing：可唱。</li>
        /// </summary>
        [JsonProperty("RightSet")]
        public string[] RightSet{ get; set; }

        /// <summary>
        /// <p>推荐类型，取值有：</p><li>Featured：精选；</li><li>Other：其他。</li>
        /// </summary>
        [JsonProperty("RecommendType")]
        public string RecommendType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MusicId", this.MusicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "SingerSet.", this.SingerSet);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "SingerImageUrl", this.SingerImageUrl);
            this.SetParamObj(map, prefix + "AlbumInfo.", this.AlbumInfo);
            this.SetParamArraySimple(map, prefix + "RightSet.", this.RightSet);
            this.SetParamSimple(map, prefix + "RecommendType", this.RecommendType);
        }
    }
}

