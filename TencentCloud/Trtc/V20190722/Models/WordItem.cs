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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WordItem : AbstractModel
    {
        
        /// <summary>
        /// <p>词对应的文本</p>
        /// </summary>
        [JsonProperty("Word")]
        public string Word{ get; set; }

        /// <summary>
        /// <p>词对应的时间起点</p>
        /// </summary>
        [JsonProperty("TimeBeginMs")]
        public ulong? TimeBeginMs{ get; set; }

        /// <summary>
        /// <p>词对应的时间尾点</p>
        /// </summary>
        [JsonProperty("TimeEndMs")]
        public ulong? TimeEndMs{ get; set; }

        /// <summary>
        /// <p>词的索引起点</p>
        /// </summary>
        [JsonProperty("WordBegin")]
        public ulong? WordBegin{ get; set; }

        /// <summary>
        /// <p>词的索引尾点</p>
        /// </summary>
        [JsonProperty("WordEnd")]
        public ulong? WordEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Word", this.Word);
            this.SetParamSimple(map, prefix + "TimeBeginMs", this.TimeBeginMs);
            this.SetParamSimple(map, prefix + "TimeEndMs", this.TimeEndMs);
            this.SetParamSimple(map, prefix + "WordBegin", this.WordBegin);
            this.SetParamSimple(map, prefix + "WordEnd", this.WordEnd);
        }
    }
}

