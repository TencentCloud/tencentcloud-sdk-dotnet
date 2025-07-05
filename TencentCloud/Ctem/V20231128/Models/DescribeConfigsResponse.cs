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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeConfigsResponse : AbstractModel
    {
        
        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// 数组
        /// </summary>
        [JsonProperty("List")]
        public DisplayConfig[] List{ get; set; }

        /// <summary>
        /// 全部路径数量
        /// </summary>
        [JsonProperty("AllConfigNum")]
        public long? AllConfigNum{ get; set; }

        /// <summary>
        /// 高风险路径数量
        /// </summary>
        [JsonProperty("HighRiskConfigNum")]
        public long? HighRiskConfigNum{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "List.", this.List);
            this.SetParamSimple(map, prefix + "AllConfigNum", this.AllConfigNum);
            this.SetParamSimple(map, prefix + "HighRiskConfigNum", this.HighRiskConfigNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

