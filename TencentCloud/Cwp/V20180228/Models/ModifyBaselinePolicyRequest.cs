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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBaselinePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("Data")]
        public BaselinePolicy Data{ get; set; }

        /// <summary>
        /// <li>RuleName - String - 是否必填：否 - 规则名称</li>
        /// <li>CategoryId - int64 - 是否必填：否 自定义筛选为-1 - 规则分类</li>
        /// <li>RuleType - int - 是否必填：否 0:系统 1:自定义 - 规则类型</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 是否按照过滤的全选
        /// </summary>
        [JsonProperty("SelectAll")]
        public long? SelectAll{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Data.", this.Data);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "SelectAll", this.SelectAll);
        }
    }
}

