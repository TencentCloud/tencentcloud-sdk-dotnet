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

namespace TencentCloud.Fmu.V20191213.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BeautyParam : AbstractModel
    {
        
        /// <summary>
        /// 美白程度，取值范围[0,100]。0不美白，100代表最高程度。默认值30。
        /// </summary>
        [JsonProperty("WhitenLevel")]
        public ulong? WhitenLevel{ get; set; }

        /// <summary>
        /// 磨皮程度，取值范围[0,100]。0不磨皮，100代表最高程度。默认值30。
        /// </summary>
        [JsonProperty("SmoothingLevel")]
        public ulong? SmoothingLevel{ get; set; }

        /// <summary>
        /// 大眼程度，取值范围[0,100]。0不大眼，100代表最高程度。默认值70。
        /// </summary>
        [JsonProperty("EyeEnlargeLevel")]
        public ulong? EyeEnlargeLevel{ get; set; }

        /// <summary>
        /// 瘦脸程度，取值范围[0,100]。0不瘦脸，100代表最高程度。默认值70。
        /// </summary>
        [JsonProperty("FaceShrinkLevel")]
        public ulong? FaceShrinkLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WhitenLevel", this.WhitenLevel);
            this.SetParamSimple(map, prefix + "SmoothingLevel", this.SmoothingLevel);
            this.SetParamSimple(map, prefix + "EyeEnlargeLevel", this.EyeEnlargeLevel);
            this.SetParamSimple(map, prefix + "FaceShrinkLevel", this.FaceShrinkLevel);
        }
    }
}

