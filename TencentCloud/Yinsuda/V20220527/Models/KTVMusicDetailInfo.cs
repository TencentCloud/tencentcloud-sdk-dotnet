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

    public class KTVMusicDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 歌曲基础信息。
        /// </summary>
        [JsonProperty("KTVMusicBaseInfo")]
        public KTVMusicBaseInfo KTVMusicBaseInfo{ get; set; }

        /// <summary>
        /// 播放凭证。
        /// </summary>
        [JsonProperty("PlayToken")]
        public string PlayToken{ get; set; }

        /// <summary>
        /// 歌词下载链接。
        /// </summary>
        [JsonProperty("LyricsUrl")]
        public string LyricsUrl{ get; set; }

        /// <summary>
        /// 音高数据下载链接。
        /// </summary>
        [JsonProperty("MidiUrl")]
        public string MidiUrl{ get; set; }

        /// <summary>
        /// 副歌片段信息。
        /// </summary>
        [JsonProperty("ChorusClipSet")]
        public ChorusClip[] ChorusClipSet{ get; set; }

        /// <summary>
        /// 前奏间隔。
        /// </summary>
        [JsonProperty("PreludeInterval")]
        public long? PreludeInterval{ get; set; }

        /// <summary>
        /// 歌曲流派列表。
        /// </summary>
        [JsonProperty("GenreSet")]
        public string[] GenreSet{ get; set; }

        /// <summary>
        /// 节拍信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BPMInfo")]
        public KTVBPMInfo BPMInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "KTVMusicBaseInfo.", this.KTVMusicBaseInfo);
            this.SetParamSimple(map, prefix + "PlayToken", this.PlayToken);
            this.SetParamSimple(map, prefix + "LyricsUrl", this.LyricsUrl);
            this.SetParamSimple(map, prefix + "MidiUrl", this.MidiUrl);
            this.SetParamArrayObj(map, prefix + "ChorusClipSet.", this.ChorusClipSet);
            this.SetParamSimple(map, prefix + "PreludeInterval", this.PreludeInterval);
            this.SetParamArraySimple(map, prefix + "GenreSet.", this.GenreSet);
            this.SetParamObj(map, prefix + "BPMInfo.", this.BPMInfo);
        }
    }
}

