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

    public class HDRInfo : AbstractModel
    {
        
        /// <summary>
        /// 高动态范围类型控制开关，可选值：
        /// <li>ON：开启高动态范围类型转换；</li>
        /// <li>OFF：关闭高动态范围类型转换。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 高动态范围类型，可选值：
        /// <li>hdr10：表示 hdr10 标准；</li>
        /// <li>hlg：表示 hlg 标准。</li>
        /// 
        /// 注意：
        /// <li> 仅当高动态范围类型控制开关为 ON 时有效；</li>
        /// <li>当画质重生目标参数中指定视频输出参数的视频流编码格式 Codec 为 libx265 时有效。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

