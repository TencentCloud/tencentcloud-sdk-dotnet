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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBaselineItemRiskListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>基线策略 ID 列表。</p>
        /// </summary>
        [JsonProperty("PolicyID")]
        public ulong?[] PolicyID{ get; set; }

        /// <summary>
        /// <p>基线系统父分类 ID。</p>
        /// </summary>
        [JsonProperty("ParentCategoryID")]
        public ulong? ParentCategoryID{ get; set; }

        /// <summary>
        /// <p>基线检测项 ID。</p>
        /// </summary>
        [JsonProperty("ItemID")]
        public ulong? ItemID{ get; set; }

        /// <summary>
        /// <p>检测资产类型列表，元素取值为 HOST 或 CLUSTER。</p>
        /// </summary>
        [JsonProperty("CheckAssetType")]
        public string[] CheckAssetType{ get; set; }

        /// <summary>
        /// <p>基线子分类 ID。</p>
        /// </summary>
        [JsonProperty("CategoryID")]
        public ulong? CategoryID{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>通用过滤条件。支持的 Name：ResultStatus（通过状态，Values: PASS/NOT_PASS）、AssetName（资产名称/ID，模糊搜索）、IP（IP地址，模糊搜索）、Tag（资产标签，模糊搜索）。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// <p>分页查询每页数量，最大值 100；超过时服务端将自动回退为默认值 10。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>分页查询起始偏移量，从 0 开始。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>排序方向，取值 asc（升序）或 desc（降序），默认 desc。</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>排序字段名，由具体接口定义可选字段。</p>
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "PolicyID.", this.PolicyID);
            this.SetParamSimple(map, prefix + "ParentCategoryID", this.ParentCategoryID);
            this.SetParamSimple(map, prefix + "ItemID", this.ItemID);
            this.SetParamArraySimple(map, prefix + "CheckAssetType.", this.CheckAssetType);
            this.SetParamSimple(map, prefix + "CategoryID", this.CategoryID);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

