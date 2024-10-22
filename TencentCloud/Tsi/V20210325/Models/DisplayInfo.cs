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

namespace TencentCloud.Tsi.V20210325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisplayInfo : AbstractModel
    {
        
        /// <summary>
        /// 句子 ID
        /// </summary>
        [JsonProperty("SeId")]
        public string SeId{ get; set; }

        /// <summary>
        /// 句子版本号
        /// </summary>
        [JsonProperty("SeVer")]
        public ulong? SeVer{ get; set; }

        /// <summary>
        /// 识别结果
        /// </summary>
        [JsonProperty("SourceText")]
        public string SourceText{ get; set; }

        /// <summary>
        ///  翻译结果
        /// </summary>
        [JsonProperty("TargetText")]
        public string TargetText{ get; set; }

        /// <summary>
        /// 句子开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 句子结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        ///  当前句子是否已结束
        /// </summary>
        [JsonProperty("IsEnd")]
        public bool? IsEnd{ get; set; }

        /// <summary>
        /// base64编码的wav/mp3音频数据
        /// </summary>
        [JsonProperty("Audio")]
        public string Audio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SeId", this.SeId);
            this.SetParamSimple(map, prefix + "SeVer", this.SeVer);
            this.SetParamSimple(map, prefix + "SourceText", this.SourceText);
            this.SetParamSimple(map, prefix + "TargetText", this.TargetText);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "IsEnd", this.IsEnd);
            this.SetParamSimple(map, prefix + "Audio", this.Audio);
        }
    }
}

