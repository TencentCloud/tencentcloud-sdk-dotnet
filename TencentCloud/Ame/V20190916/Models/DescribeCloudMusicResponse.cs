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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCloudMusicResponse : AbstractModel
    {
        
        /// <summary>
        /// 歌曲Id
        /// </summary>
        [JsonProperty("MusicId")]
        public string MusicId{ get; set; }

        /// <summary>
        /// 歌曲名称
        /// </summary>
        [JsonProperty("MusicName")]
        public string MusicName{ get; set; }

        /// <summary>
        /// 歌曲时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 歌曲链接
        /// </summary>
        [JsonProperty("MusicUrl")]
        public string MusicUrl{ get; set; }

        /// <summary>
        /// 歌曲图片
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MusicImageUrl")]
        public string MusicImageUrl{ get; set; }

        /// <summary>
        /// 歌手列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Singers")]
        public string[] Singers{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MusicId", this.MusicId);
            this.SetParamSimple(map, prefix + "MusicName", this.MusicName);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "MusicUrl", this.MusicUrl);
            this.SetParamSimple(map, prefix + "MusicImageUrl", this.MusicImageUrl);
            this.SetParamArraySimple(map, prefix + "Singers.", this.Singers);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

