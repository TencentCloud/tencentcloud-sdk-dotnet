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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoDubbingAsyncInput : AbstractModel
    {
        
        /// <summary>
        /// <p>输入视频Url</p>
        /// </summary>
        [JsonProperty("InputUrl")]
        public string InputUrl{ get; set; }

        /// <summary>
        /// <p>输入视频FileId</p>
        /// </summary>
        [JsonProperty("InputFileId")]
        public string InputFileId{ get; set; }

        /// <summary>
        /// <p>视频源语言，默认zh</p>
        /// </summary>
        [JsonProperty("SrcLanguage")]
        public string SrcLanguage{ get; set; }

        /// <summary>
        /// <p>视频目标语言，默认en</p>
        /// </summary>
        [JsonProperty("DstLanguage")]
        public string DstLanguage{ get; set; }

        /// <summary>
        /// <p>配音模型</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputUrl", this.InputUrl);
            this.SetParamSimple(map, prefix + "InputFileId", this.InputFileId);
            this.SetParamSimple(map, prefix + "SrcLanguage", this.SrcLanguage);
            this.SetParamSimple(map, prefix + "DstLanguage", this.DstLanguage);
            this.SetParamSimple(map, prefix + "Model", this.Model);
        }
    }
}

