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

namespace TencentCloud.Smpn.V20190822.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MRLResponse : AbstractModel
    {
        
        /// <summary>
        /// 骚扰电话恶意标记等级
        /// </summary>
        [JsonProperty("DisturbLevel")]
        public long? DisturbLevel{ get; set; }

        /// <summary>
        /// 房产中介恶意标记等级
        /// </summary>
        [JsonProperty("HouseAgentLevel")]
        public long? HouseAgentLevel{ get; set; }

        /// <summary>
        /// 保险理财恶意标记等级
        /// </summary>
        [JsonProperty("InsuranceLevel")]
        public long? InsuranceLevel{ get; set; }

        /// <summary>
        /// 广告推销恶意标记等级
        /// </summary>
        [JsonProperty("SalesLevel")]
        public long? SalesLevel{ get; set; }

        /// <summary>
        /// 诈骗电话恶意标记等级
        /// </summary>
        [JsonProperty("CheatLevel")]
        public long? CheatLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisturbLevel", this.DisturbLevel);
            this.SetParamSimple(map, prefix + "HouseAgentLevel", this.HouseAgentLevel);
            this.SetParamSimple(map, prefix + "InsuranceLevel", this.InsuranceLevel);
            this.SetParamSimple(map, prefix + "SalesLevel", this.SalesLevel);
            this.SetParamSimple(map, prefix + "CheatLevel", this.CheatLevel);
        }
    }
}

