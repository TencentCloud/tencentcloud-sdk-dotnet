/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// 歌曲Id。
        /// </summary>
        [JsonProperty("MusicId")]
        public string MusicId{ get; set; }

        /// <summary>
        /// 歌曲名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 歌手名称。
        /// </summary>
        [JsonProperty("SingerSet")]
        public string[] SingerSet{ get; set; }

        /// <summary>
        /// 播放时长。
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 歌手图片链接。
        /// </summary>
        [JsonProperty("SingerImageUrl")]
        public string SingerImageUrl{ get; set; }

        /// <summary>
        /// 专辑信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlbumInfo")]
        public MusicAlbumInfo AlbumInfo{ get; set; }

        /// <summary>
        /// 权益列表，取值有：
        /// <li>Play：可播；</li>
        /// <li>Sing：可唱。</li>
        /// </summary>
        [JsonProperty("RightSet")]
        public string[] RightSet{ get; set; }


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
        }
    }
}

