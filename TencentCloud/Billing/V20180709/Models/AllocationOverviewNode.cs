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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AllocationOverviewNode : AbstractModel
    {
        
        /// <summary>
        /// 分账单元ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 分账单元名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 分账单元唯一标识
        /// </summary>
        [JsonProperty("TreeNodeUniqKey")]
        public string TreeNodeUniqKey{ get; set; }

        /// <summary>
        /// 分账单元包含规则标志
        /// 0 - 不存在规则
        /// 1 - 同时存在归集规则和公摊规则
        /// 2 - 仅存在归集规则
        /// 3 - 仅存在公摊规则
        /// </summary>
        [JsonProperty("Symbol")]
        public ulong? Symbol{ get; set; }

        /// <summary>
        /// 子单元月概览详情
        /// </summary>
        [JsonProperty("Children")]
        public AllocationOverviewNode[] Children{ get; set; }

        /// <summary>
        /// 分账账单月概览金额明细
        /// </summary>
        [JsonProperty("Detail")]
        public AllocationMonthOverviewDetail Detail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TreeNodeUniqKey", this.TreeNodeUniqKey);
            this.SetParamSimple(map, prefix + "Symbol", this.Symbol);
            this.SetParamArrayObj(map, prefix + "Children.", this.Children);
            this.SetParamObj(map, prefix + "Detail.", this.Detail);
        }
    }
}

