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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiagnoseResult : AbstractModel
    {
        
        /// <summary>
        /// 断流信息
        /// </summary>
        [JsonProperty("StreamBrokenResults")]
        public string[] StreamBrokenResults{ get; set; }

        /// <summary>
        /// 低帧率信息
        /// </summary>
        [JsonProperty("LowFrameRateResults")]
        public string[] LowFrameRateResults{ get; set; }

        /// <summary>
        /// 流格式诊断信息
        /// </summary>
        [JsonProperty("StreamFormatResults")]
        public string[] StreamFormatResults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "StreamBrokenResults.", this.StreamBrokenResults);
            this.SetParamArraySimple(map, prefix + "LowFrameRateResults.", this.LowFrameRateResults);
            this.SetParamArraySimple(map, prefix + "StreamFormatResults.", this.StreamFormatResults);
        }
    }
}

