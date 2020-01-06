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

    public class WholeTextItem : AbstractModel
    {
        
        /// <summary>
        /// 当前句子的信息
        /// </summary>
        [JsonProperty("TextItem")]
        public TextItem TextItem{ get; set; }

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
        /// 当前句子的语速
        /// </summary>
        [JsonProperty("Speed")]
        public float? Speed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TextItem.", this.TextItem);
            this.SetParamSimple(map, prefix + "AvgVolume", this.AvgVolume);
            this.SetParamSimple(map, prefix + "MaxVolume", this.MaxVolume);
            this.SetParamSimple(map, prefix + "MinVolume", this.MinVolume);
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
        }
    }
}

