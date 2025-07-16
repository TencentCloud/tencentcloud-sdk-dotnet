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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DrmInfo : AbstractModel
    {
        
        /// <summary>
        /// 加密类型：
        /// 
        /// - simpleaes
        /// 只能用于HLS，切片格式支持ts和mp4
        /// 只能使用切片模式，不能使用singlefile模式
        /// 
        /// - fairplay：
        /// 只能用于HLS，切片格式只能是mp4
        /// 可以使用切片模式或singlefile模式
        /// 
        /// - widevine：
        /// 可以用于HLS和DASH，切片格式只能是mp4
        /// 输出HLS：可以使用切片模式或singlefile模式
        /// 输出DASH：只能singlefile模式
        /// 
        /// - playready：
        /// 可以用于HLS和DASH，切片格式只能是mp4
        /// 输出HLS：可以使用切片模式或singlefile模式
        /// 输出DASH：只能singlefile模式
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// SimpleAes 加密信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SimpleAesDrm")]
        public SimpleAesDrm SimpleAesDrm{ get; set; }

        /// <summary>
        /// FairPlay，WideVine，PlayReady 加密信息。
        /// </summary>
        [JsonProperty("SpekeDrm")]
        public SpekeDrm SpekeDrm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "SimpleAesDrm.", this.SimpleAesDrm);
            this.SetParamObj(map, prefix + "SpekeDrm.", this.SpekeDrm);
        }
    }
}

