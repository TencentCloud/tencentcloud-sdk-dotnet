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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccessWhiteListRulesResponse : AbstractModel
    {
        
        /// <summary>
        /// 记录总数
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 访问白名单规则列表
        /// </summary>
        [JsonProperty("AccessWhiteListRuleSet")]
        public AccessWhiteListRule[] AccessWhiteListRuleSet{ get; set; }

        /// <summary>
        /// 是否放开全部来源IP，如果为true，TotalCount为0，AccessWhiteListRuleSet为空
        /// </summary>
        [JsonProperty("AllowAny")]
        public bool? AllowAny{ get; set; }

        /// <summary>
        /// 是否开启自动添加来源IP, 如果为true, 在开启访问白名单的情况下将自动添加来源IP
        /// </summary>
        [JsonProperty("AllowAuto")]
        public bool? AllowAuto{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "AccessWhiteListRuleSet.", this.AccessWhiteListRuleSet);
            this.SetParamSimple(map, prefix + "AllowAny", this.AllowAny);
            this.SetParamSimple(map, prefix + "AllowAuto", this.AllowAuto);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

