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

    public class MusicDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 资源方音乐Id
        /// </summary>
        [JsonProperty("MusicId")]
        public string MusicId{ get; set; }

        /// <summary>
        /// 资源方识别信息
        /// </summary>
        [JsonProperty("AmeId")]
        public string AmeId{ get; set; }

        /// <summary>
        /// 分类标签
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [JsonProperty("HitWords")]
        public string[] HitWords{ get; set; }

        /// <summary>
        /// 节奏信息
        /// </summary>
        [JsonProperty("Bpm")]
        public long? Bpm{ get; set; }

        /// <summary>
        /// 商业化权益
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MusicId", this.MusicId);
            this.SetParamSimple(map, prefix + "AmeId", this.AmeId);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "HitWords.", this.HitWords);
            this.SetParamSimple(map, prefix + "Bpm", this.Bpm);
            this.SetParamSimple(map, prefix + "Score", this.Score);
        }
    }
}

