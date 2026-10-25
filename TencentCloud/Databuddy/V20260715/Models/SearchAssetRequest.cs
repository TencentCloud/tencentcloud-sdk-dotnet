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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchAssetRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>工作空间ID</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>最大结果条数，默认30，可选30～50</p>
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

        /// <summary>
        /// <p>关键字</p>
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// <p>资产类型列表，类型参见ListEntityTypeMetas的返回</p>
        /// </summary>
        [JsonProperty("AssetTypes")]
        public string[] AssetTypes{ get; set; }

        /// <summary>
        /// <p>分页token信息，取上一页返回NextPageToken</p>
        /// </summary>
        [JsonProperty("PageToken")]
        public string PageToken{ get; set; }

        /// <summary>
        /// <p>按资产负责人检索</p><ul><li>my 我负责的(包含my时其他uin不生效)</li><li>uin 指定用户uin</li></ul>
        /// </summary>
        [JsonProperty("Owner")]
        public string[] Owner{ get; set; }

        /// <summary>
        /// <p>标签IDs，可通过 ListTags 获取</p>
        /// </summary>
        [JsonProperty("TagIds")]
        public long?[] TagIds{ get; set; }

        /// <summary>
        /// <p>标签值IDs，可通过 ListTags 获取</p>
        /// </summary>
        [JsonProperty("TagValueIds")]
        public long?[] TagValueIds{ get; set; }

        /// <summary>
        /// <p>更新时间，13位时间戳</p>
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// <p>数据目录列表</p>
        /// </summary>
        [JsonProperty("CatalogNames")]
        public string[] CatalogNames{ get; set; }

        /// <summary>
        /// <p>工作空间路径筛选(非catalog类资产)</p>
        /// </summary>
        [JsonProperty("WorkspacePaths")]
        public string[] WorkspacePaths{ get; set; }

        /// <summary>
        /// <p>是否开启混合搜索</p>
        /// </summary>
        [JsonProperty("EnableHybridSearch")]
        public bool? EnableHybridSearch{ get; set; }

        /// <summary>
        /// <p>字段标签ID列表（可选）。使用场景：根据字段上打的标签检索资产（表），返回包含该字段标签的资产。与 TagIds 的区别：TagIds 是表级标签过滤，FieldTagIds 是字段级标签过滤。规格要求：int64 数组，最多支持 20 个标签 ID 同时过滤。可通过 ListTags 获取</p>
        /// </summary>
        [JsonProperty("FieldTagIds")]
        public long?[] FieldTagIds{ get; set; }

        /// <summary>
        /// <p>排序，为空时默认按相关度倒排序</p><p>Name:<br>PopularityQuantity 热度</p><p>Direction:<br>Desc 降序<br>Asc 升序</p>
        /// </summary>
        [JsonProperty("OrderBys")]
        public OrderBy[] OrderBys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamArraySimple(map, prefix + "AssetTypes.", this.AssetTypes);
            this.SetParamSimple(map, prefix + "PageToken", this.PageToken);
            this.SetParamArraySimple(map, prefix + "Owner.", this.Owner);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
            this.SetParamArraySimple(map, prefix + "TagValueIds.", this.TagValueIds);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamArraySimple(map, prefix + "CatalogNames.", this.CatalogNames);
            this.SetParamArraySimple(map, prefix + "WorkspacePaths.", this.WorkspacePaths);
            this.SetParamSimple(map, prefix + "EnableHybridSearch", this.EnableHybridSearch);
            this.SetParamArraySimple(map, prefix + "FieldTagIds.", this.FieldTagIds);
            this.SetParamArrayObj(map, prefix + "OrderBys.", this.OrderBys);
        }
    }
}

