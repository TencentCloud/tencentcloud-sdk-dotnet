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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOrganizationFinancialByProductRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询开始月份。格式：yyyy-mm，例如：2021-01
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// 限制数目。取值范围：1~50，默认值：10	
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量。取值是limit的整数倍，默认值 : 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 查询结束月份。格式：yyyy-mm，例如：2021-01,默认值为查询开始月份
        /// </summary>
        [JsonProperty("EndMonth")]
        public string EndMonth{ get; set; }

        /// <summary>
        /// 查询成员列表。 最大100个
        /// </summary>
        [JsonProperty("MemberUins")]
        public long?[] MemberUins{ get; set; }

        /// <summary>
        /// 查询产品列表。 最大100个
        /// </summary>
        [JsonProperty("ProductCodes")]
        public string[] ProductCodes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "EndMonth", this.EndMonth);
            this.SetParamArraySimple(map, prefix + "MemberUins.", this.MemberUins);
            this.SetParamArraySimple(map, prefix + "ProductCodes.", this.ProductCodes);
        }
    }
}

