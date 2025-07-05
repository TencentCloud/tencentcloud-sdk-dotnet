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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MPSResult : AbstractModel
    {
        
        /// <summary>
        /// 智能语音识别结果。
        /// </summary>
        [JsonProperty("AiAsrResults")]
        public string[] AiAsrResults{ get; set; }

        /// <summary>
        /// 智能文字识别结果。
        /// </summary>
        [JsonProperty("AiOcrResults")]
        public string[] AiOcrResults{ get; set; }

        /// <summary>
        /// 内容质检结果。
        /// </summary>
        [JsonProperty("StreamQuaCtrlResults")]
        public string[] StreamQuaCtrlResults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AiAsrResults.", this.AiAsrResults);
            this.SetParamArraySimple(map, prefix + "AiOcrResults.", this.AiOcrResults);
            this.SetParamArraySimple(map, prefix + "StreamQuaCtrlResults.", this.StreamQuaCtrlResults);
        }
    }
}

