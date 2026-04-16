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

    public class AlignmentItem : AbstractModel
    {
        
        /// <summary>
        /// 字幕对应的时间起点
        /// </summary>
        [JsonProperty("TimeBeginMs")]
        public ulong? TimeBeginMs{ get; set; }

        /// <summary>
        /// 字幕对应的时间尾点
        /// </summary>
        [JsonProperty("TimeEndMs")]
        public ulong? TimeEndMs{ get; set; }

        /// <summary>
        /// 字幕对应的文本索引起点
        /// </summary>
        [JsonProperty("TextBegin")]
        public ulong? TextBegin{ get; set; }

        /// <summary>
        /// 字幕对应的文本索引尾点
        /// </summary>
        [JsonProperty("TextEnd")]
        public ulong? TextEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeBeginMs", this.TimeBeginMs);
            this.SetParamSimple(map, prefix + "TimeEndMs", this.TimeEndMs);
            this.SetParamSimple(map, prefix + "TextBegin", this.TextBegin);
            this.SetParamSimple(map, prefix + "TextEnd", this.TextEnd);
        }
    }
}

