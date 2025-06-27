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

namespace TencentCloud.Vm.V20210922.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SegmentCosUrlList : AbstractModel
    {
        
        /// <summary>
        /// 全量图片片段的cos url
        /// </summary>
        [JsonProperty("ImageAllUrl")]
        public string ImageAllUrl{ get; set; }

        /// <summary>
        /// 全量音频片段的cos url
        /// </summary>
        [JsonProperty("AudioAllUrl")]
        public string AudioAllUrl{ get; set; }

        /// <summary>
        /// 违规图片片段的cos url
        /// </summary>
        [JsonProperty("ImageBlockUrl")]
        public string ImageBlockUrl{ get; set; }

        /// <summary>
        /// 违规音频片段的cos url
        /// </summary>
        [JsonProperty("AudioBlockUrl")]
        public string AudioBlockUrl{ get; set; }

        /// <summary>
        /// 全量音频识别文本的cos url
        /// </summary>
        [JsonProperty("AsrUrl")]
        public string AsrUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageAllUrl", this.ImageAllUrl);
            this.SetParamSimple(map, prefix + "AudioAllUrl", this.AudioAllUrl);
            this.SetParamSimple(map, prefix + "ImageBlockUrl", this.ImageBlockUrl);
            this.SetParamSimple(map, prefix + "AudioBlockUrl", this.AudioBlockUrl);
            this.SetParamSimple(map, prefix + "AsrUrl", this.AsrUrl);
        }
    }
}

