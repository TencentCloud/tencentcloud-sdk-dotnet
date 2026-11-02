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

    public class CloneViralReference : AbstractModel
    {
        
        /// <summary>
        /// <p>服饰套装参考图，多套按视频中的分段换装</p>
        /// </summary>
        [JsonProperty("Outfits")]
        public string[] Outfits{ get; set; }

        /// <summary>
        /// <p>背景/场景参考图</p>
        /// </summary>
        [JsonProperty("Backgrounds")]
        public string[] Backgrounds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Outfits.", this.Outfits);
            this.SetParamArraySimple(map, prefix + "Backgrounds.", this.Backgrounds);
        }
    }
}

