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

namespace TencentCloud.Tts.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Subtitle : AbstractModel
    {
        
        /// <summary>
        /// ⽂本信息。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// ⽂本对应tts语⾳开始时间戳，单位ms。
        /// </summary>
        [JsonProperty("BeginTime")]
        public long? BeginTime{ get; set; }

        /// <summary>
        /// ⽂本对应tts语⾳结束时间戳，单位ms。
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 该文本在时间戳数组中的开始位置，从0开始。
        /// </summary>
        [JsonProperty("BeginIndex")]
        public long? BeginIndex{ get; set; }

        /// <summary>
        /// 该文本在时间戳数组中的结束位置，从0开始。
        /// </summary>
        [JsonProperty("EndIndex")]
        public long? EndIndex{ get; set; }

        /// <summary>
        /// 该字的音素。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Phoneme")]
        public string Phoneme{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "BeginIndex", this.BeginIndex);
            this.SetParamSimple(map, prefix + "EndIndex", this.EndIndex);
            this.SetParamSimple(map, prefix + "Phoneme", this.Phoneme);
        }
    }
}

