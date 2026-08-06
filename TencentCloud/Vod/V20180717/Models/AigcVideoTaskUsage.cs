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

    public class AigcVideoTaskUsage : AbstractModel
    {
        
        /// <summary>
        /// <p>输入 Token 数目。</p>
        /// </summary>
        [JsonProperty("InputTokens")]
        public long? InputTokens{ get; set; }

        /// <summary>
        /// <p>思考产生的 Token 数目。</p>
        /// </summary>
        [JsonProperty("ThoughtTokens")]
        public long? ThoughtTokens{ get; set; }

        /// <summary>
        /// <p>输入图片数目。</p>
        /// </summary>
        [JsonProperty("InputImageCount")]
        public long? InputImageCount{ get; set; }

        /// <summary>
        /// <p>输入视频的时长。</p><p>单位：秒。</p>
        /// </summary>
        [JsonProperty("InputSeconds")]
        public long? InputSeconds{ get; set; }

        /// <summary>
        /// <p>输出视频时长。</p><p>单位：秒。</p>
        /// </summary>
        [JsonProperty("OutputSeconds")]
        public long? OutputSeconds{ get; set; }

        /// <summary>
        /// <p>输入输出总时长。</p><p>默认值：秒。</p>
        /// </summary>
        [JsonProperty("TotalSeconds")]
        public long? TotalSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputTokens", this.InputTokens);
            this.SetParamSimple(map, prefix + "ThoughtTokens", this.ThoughtTokens);
            this.SetParamSimple(map, prefix + "InputImageCount", this.InputImageCount);
            this.SetParamSimple(map, prefix + "InputSeconds", this.InputSeconds);
            this.SetParamSimple(map, prefix + "OutputSeconds", this.OutputSeconds);
            this.SetParamSimple(map, prefix + "TotalSeconds", this.TotalSeconds);
        }
    }
}

