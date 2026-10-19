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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ControlDeviceStreamData : AbstractModel
    {
        
        /// <summary>
        /// <p>flv 流地址</p>
        /// </summary>
        [JsonProperty("Flv")]
        public string Flv{ get; set; }

        /// <summary>
        /// <p>hls 流地址</p>
        /// </summary>
        [JsonProperty("Hls")]
        public string Hls{ get; set; }

        /// <summary>
        /// <p>rtmp 流地址</p>
        /// </summary>
        [JsonProperty("Rtmp")]
        public string Rtmp{ get; set; }

        /// <summary>
        /// <p>fmp4地址</p>
        /// </summary>
        [JsonProperty("FMp4")]
        public string FMp4{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Flv", this.Flv);
            this.SetParamSimple(map, prefix + "Hls", this.Hls);
            this.SetParamSimple(map, prefix + "Rtmp", this.Rtmp);
            this.SetParamSimple(map, prefix + "FMp4", this.FMp4);
        }
    }
}

