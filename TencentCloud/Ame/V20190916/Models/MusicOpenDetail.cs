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

    public class MusicOpenDetail : AbstractModel
    {
        
        /// <summary>
        /// 音乐Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MusicId")]
        public string MusicId{ get; set; }

        /// <summary>
        /// 专辑名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlbumName")]
        public string AlbumName{ get; set; }

        /// <summary>
        /// 专辑图片路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlbumImageUrl")]
        public string AlbumImageUrl{ get; set; }

        /// <summary>
        /// 音乐名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MusicName")]
        public string MusicName{ get; set; }

        /// <summary>
        /// 音乐图片路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MusicImageUrl")]
        public string MusicImageUrl{ get; set; }

        /// <summary>
        /// 歌手
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Singers")]
        public string[] Singers{ get; set; }

        /// <summary>
        /// 播放时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 歌词url
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LyricUrl")]
        public string LyricUrl{ get; set; }

        /// <summary>
        /// 波形图url
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaveformUrl")]
        public string WaveformUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MusicId", this.MusicId);
            this.SetParamSimple(map, prefix + "AlbumName", this.AlbumName);
            this.SetParamSimple(map, prefix + "AlbumImageUrl", this.AlbumImageUrl);
            this.SetParamSimple(map, prefix + "MusicName", this.MusicName);
            this.SetParamSimple(map, prefix + "MusicImageUrl", this.MusicImageUrl);
            this.SetParamArraySimple(map, prefix + "Singers.", this.Singers);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "LyricUrl", this.LyricUrl);
            this.SetParamSimple(map, prefix + "WaveformUrl", this.WaveformUrl);
        }
    }
}

