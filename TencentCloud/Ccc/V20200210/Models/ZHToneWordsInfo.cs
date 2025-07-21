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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZHToneWordsInfo : AbstractModel
    {
        
        /// <summary>
        /// 中性词列表
        /// </summary>
        [JsonProperty("Neutral")]
        public string[] Neutral{ get; set; }

        /// <summary>
        /// 正面词列表
        /// </summary>
        [JsonProperty("Positive")]
        public string[] Positive{ get; set; }

        /// <summary>
        /// 负面词列表
        /// </summary>
        [JsonProperty("Negative")]
        public string[] Negative{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Neutral.", this.Neutral);
            this.SetParamArraySimple(map, prefix + "Positive.", this.Positive);
            this.SetParamArraySimple(map, prefix + "Negative.", this.Negative);
        }
    }
}

