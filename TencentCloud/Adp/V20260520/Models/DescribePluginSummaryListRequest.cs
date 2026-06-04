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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePluginSummaryListRequest : AbstractModel
    {
        
        /// <summary>
        /// 空间ID，查询空间内的插件列表时使用
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// 过滤条件列表 支持：PluginKind、CategoryKey、PluginSource、PluginId、PluginClass、BillingType
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }

        /// <summary>
        /// true-筛选收藏的插件，false不过滤
        /// </summary>
        [JsonProperty("IsFavoriteOnly")]
        public bool? IsFavoriteOnly{ get; set; }

        /// <summary>
        /// module
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 所有模块 |
        /// | 1 | agent模式模块 |
        /// | 2 | 工作流模块 |
        /// | 3 | 企业员工助理模块 |
        /// </summary>
        [JsonProperty("Module")]
        public long? Module{ get; set; }

        /// <summary>
        /// 页码 从0开始
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 查询内容 模糊匹配：插件名称/插件描述/工具名称/工具描述
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 排序类型，仅搜索场景有效
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 未指定，使用默认行为 |
        /// | 1 | 按相关性排序 |
        /// | 2 | 按更新时间排序 |
        /// </summary>
        [JsonProperty("SortType")]
        public long? SortType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamArrayObj(map, prefix + "FilterList.", this.FilterList);
            this.SetParamSimple(map, prefix + "IsFavoriteOnly", this.IsFavoriteOnly);
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
        }
    }
}

