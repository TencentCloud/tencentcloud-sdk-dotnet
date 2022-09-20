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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WafGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 托管规则组列表。
        /// </summary>
        [JsonProperty("WafGroupDetails")]
        public WafGroupDetail[] WafGroupDetails{ get; set; }

        /// <summary>
        /// 规则组等级，取值有：
        /// <li> loose：宽松；</li>
        /// <li> normal：正常；</li>
        /// <li> strict：严格；</li>
        /// <li> stricter：超严格。</li>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 保留字段。
        /// </summary>
        [JsonProperty("Act")]
        public string Act{ get; set; }

        /// <summary>
        /// 模式，取值有：
        /// <li> block：阻断；</li>
        /// <li> observe：观察。</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 开关，取值有：
        /// <li> on：开启；</li>
        /// <li> off：关闭。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "WafGroupDetails.", this.WafGroupDetails);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Act", this.Act);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
        }
    }
}

