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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSocCheckResultListRspRsp : AbstractModel
    {
        
        /// <summary>
        /// 具体检查项详情
        /// </summary>
        [JsonProperty("List")]
        public SocCheckResult[] List{ get; set; }

        /// <summary>
        /// 检查结果总数
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// 低危个数
        /// </summary>
        [JsonProperty("LowTotal")]
        public long? LowTotal{ get; set; }

        /// <summary>
        /// 中危个数
        /// </summary>
        [JsonProperty("MiddleTotal")]
        public long? MiddleTotal{ get; set; }

        /// <summary>
        /// 高危个数
        /// </summary>
        [JsonProperty("HighTotal")]
        public long? HighTotal{ get; set; }

        /// <summary>
        /// 正常个数
        /// </summary>
        [JsonProperty("NormalTotal")]
        public long? NormalTotal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "List.", this.List);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "LowTotal", this.LowTotal);
            this.SetParamSimple(map, prefix + "MiddleTotal", this.MiddleTotal);
            this.SetParamSimple(map, prefix + "HighTotal", this.HighTotal);
            this.SetParamSimple(map, prefix + "NormalTotal", this.NormalTotal);
        }
    }
}

