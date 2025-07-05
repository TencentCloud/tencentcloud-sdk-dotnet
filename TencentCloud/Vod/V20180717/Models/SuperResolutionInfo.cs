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

    public class SuperResolutionInfo : AbstractModel
    {
        
        /// <summary>
        /// 画面超分控制开关，可选值：
        /// <li>ON：开启画面超分；</li>
        /// <li>OFF：关闭画面超分。</li>
        /// 当开启画面超分时，默认2倍超分。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 画面超分类型，仅当画面超分控制开关为 ON 时有效，可选值：
        /// <li>lq：针对低清晰度有较多噪声视频的超分；</li>
        /// <li>hq：针对高清晰度视频超分。</li>
        /// 默认值：lq。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 超分倍数，可选值：2。
        /// 默认值：2。
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Size", this.Size);
        }
    }
}

