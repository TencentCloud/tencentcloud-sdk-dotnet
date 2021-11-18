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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEnterpriseSecurityGroupRuleResponse : AbstractModel
    {
        
        /// <summary>
        /// 分页查询时，显示的当前页的页码。
        /// </summary>
        [JsonProperty("PageNo")]
        public string PageNo{ get; set; }

        /// <summary>
        /// 分页查询时，显示的每页数据的最大条数。
        /// </summary>
        [JsonProperty("PageSize")]
        public string PageSize{ get; set; }

        /// <summary>
        /// 访问控制策略列表
        /// </summary>
        [JsonProperty("Rules")]
        public SecurityGroupRule[] Rules{ get; set; }

        /// <summary>
        /// 访问控制策略的总数量。
        /// </summary>
        [JsonProperty("TotalCount")]
        public string TotalCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

