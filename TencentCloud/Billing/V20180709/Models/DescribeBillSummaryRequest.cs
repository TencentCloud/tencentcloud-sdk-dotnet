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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillSummaryRequest : AbstractModel
    {
        
        /// <summary>
        /// 账单月份，格式为2023-04
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// 账单维度类型，枚举值如下：business、project、region、payMode、tag
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// 标签键，GroupType=tag获取标签维度账单时传
        /// </summary>
        [JsonProperty("TagKey")]
        public string[] TagKey{ get; set; }

        /// <summary>
        /// 操作者UIN：操作者账号 ID（预付费资源下单或后付费操作开通资源账号的 ID 或者角色 ID ）
        /// </summary>
        [JsonProperty("OperateUin")]
        public string OperateUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamArraySimple(map, prefix + "TagKey.", this.TagKey);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
        }
    }
}

