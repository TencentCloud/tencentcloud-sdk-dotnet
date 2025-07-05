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

    public class DynamicRangeInfo : AbstractModel
    {
        
        /// <summary>
        /// 画面动态范围信息。可取值：
        /// <li>SDR：Standard Dynamic Range 标准动态范围；</li>
        /// <li>HDR：High Dynamic Range 高动态范围。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 高动态范围类型，当 Type 为 HDR 时有效。目前支持的可取值：
        /// <li>hdr10：表示 hdr10 标准；</li>
        /// <li>hlg：表示 hlg 标准。</li>
        /// </summary>
        [JsonProperty("HDRType")]
        public string HDRType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "HDRType", this.HDRType);
        }
    }
}

