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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Denoising : AbstractModel
    {
        
        /// <summary>
        /// 去噪方式，可选项：
        /// templ：时域降噪；
        /// spatial：空域降噪,
        /// fast-spatial：快速空域降噪。
        /// 注意：可选择组合方式：
        /// 1.type:"templ,spatial" ;
        /// 2.type:"templ,fast-spatial"。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 时域去噪强度，可选值：0.0-1.0 。小于0.0的默认为0.0，大于1.0的默认为1.0。
        /// </summary>
        [JsonProperty("TemplStrength")]
        public float? TemplStrength{ get; set; }

        /// <summary>
        /// 空域去噪强度，可选值：0.0-1.0 。小于0.0的默认为0.0，大于1.0的默认为1.0。
        /// </summary>
        [JsonProperty("SpatialStrength")]
        public float? SpatialStrength{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TemplStrength", this.TemplStrength);
            this.SetParamSimple(map, prefix + "SpatialStrength", this.SpatialStrength);
        }
    }
}

