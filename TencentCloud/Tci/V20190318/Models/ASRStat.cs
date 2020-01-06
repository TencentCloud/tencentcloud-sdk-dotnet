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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ASRStat : AbstractModel
    {
        
        /// <summary>
        /// 当前音频的平均语速
        /// </summary>
        [JsonProperty("AvgSpeed")]
        public float? AvgSpeed{ get; set; }

        /// <summary>
        /// Vad的平均音量
        /// </summary>
        [JsonProperty("AvgVolume")]
        public float? AvgVolume{ get; set; }

        /// <summary>
        /// Vad的最大音量
        /// </summary>
        [JsonProperty("MaxVolume")]
        public float? MaxVolume{ get; set; }

        /// <summary>
        /// Vad的最小音量
        /// </summary>
        [JsonProperty("MinVolume")]
        public float? MinVolume{ get; set; }

        /// <summary>
        /// 当前音频的非发音时长
        /// </summary>
        [JsonProperty("MuteDuration")]
        public long? MuteDuration{ get; set; }

        /// <summary>
        /// 当前音频的发音时长
        /// </summary>
        [JsonProperty("SoundDuration")]
        public long? SoundDuration{ get; set; }

        /// <summary>
        /// 当前音频的总时长
        /// </summary>
        [JsonProperty("TotalDuration")]
        public long? TotalDuration{ get; set; }

        /// <summary>
        /// 当前音频的句子总数
        /// </summary>
        [JsonProperty("VadNum")]
        public long? VadNum{ get; set; }

        /// <summary>
        /// 当前音频的单词总数
        /// </summary>
        [JsonProperty("WordNum")]
        public long? WordNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AvgSpeed", this.AvgSpeed);
            this.SetParamSimple(map, prefix + "AvgVolume", this.AvgVolume);
            this.SetParamSimple(map, prefix + "MaxVolume", this.MaxVolume);
            this.SetParamSimple(map, prefix + "MinVolume", this.MinVolume);
            this.SetParamSimple(map, prefix + "MuteDuration", this.MuteDuration);
            this.SetParamSimple(map, prefix + "SoundDuration", this.SoundDuration);
            this.SetParamSimple(map, prefix + "TotalDuration", this.TotalDuration);
            this.SetParamSimple(map, prefix + "VadNum", this.VadNum);
            this.SetParamSimple(map, prefix + "WordNum", this.WordNum);
        }
    }
}

