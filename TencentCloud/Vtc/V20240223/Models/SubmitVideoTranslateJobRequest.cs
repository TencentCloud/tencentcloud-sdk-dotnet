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

namespace TencentCloud.Vtc.V20240223.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitVideoTranslateJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 视频地址URL。
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// 源语言：zh, en
        /// </summary>
        [JsonProperty("SrcLang")]
        public string SrcLang{ get; set; }

        /// <summary>
        /// 目标语言：zh, en
        /// </summary>
        [JsonProperty("DstLang")]
        public string DstLang{ get; set; }

        /// <summary>
        /// 当音频 URL 不为空时，默认以音频驱动视频任务口型
        /// </summary>
        [JsonProperty("AudioUrl")]
        public string AudioUrl{ get; set; }

        /// <summary>
        /// 是否需要确认翻译结果0：不需要，1：需要
        /// </summary>
        [JsonProperty("Confirm")]
        public long? Confirm{ get; set; }

        /// <summary>
        /// 是否开启口型驱动，0：不开启，1：开启。默认开启。
        /// </summary>
        [JsonProperty("LipSync")]
        public long? LipSync{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "SrcLang", this.SrcLang);
            this.SetParamSimple(map, prefix + "DstLang", this.DstLang);
            this.SetParamSimple(map, prefix + "AudioUrl", this.AudioUrl);
            this.SetParamSimple(map, prefix + "Confirm", this.Confirm);
            this.SetParamSimple(map, prefix + "LipSync", this.LipSync);
        }
    }
}

