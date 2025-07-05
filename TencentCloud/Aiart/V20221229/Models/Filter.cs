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

namespace TencentCloud.Aiart.V20221229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Filter : AbstractModel
    {
        
        /// <summary>
        /// 过滤不满足分辨率下限的训练图像，默认开启过滤
        /// 开启后将过滤横边<512或竖边<720的图片，横、竖边上限均为2000，不支持调整
        /// 
        /// 1：开启过滤
        /// 0：关闭过滤
        /// </summary>
        [JsonProperty("Resolution")]
        public long? Resolution{ get; set; }

        /// <summary>
        /// 过滤脸部区域过小的训练图像，默认开启过滤
        /// 
        /// 1：开启过滤
        /// 0：关闭过滤
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 过滤脸部存在明显遮挡、偏转角度过大等质量较差的训练图像，默认开启过滤
        /// 
        /// 1：开启过滤
        /// 0：关闭过滤
        /// </summary>
        [JsonProperty("Occlusion")]
        public long? Occlusion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Occlusion", this.Occlusion);
        }
    }
}

