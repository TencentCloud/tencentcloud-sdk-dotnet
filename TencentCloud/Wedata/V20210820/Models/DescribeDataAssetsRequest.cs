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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDataAssetsRequest : AbstractModel
    {
        
        /// <summary>
        /// 请求来源，WEB 前端；CLIENT 客户端
        /// </summary>
        [JsonProperty("RequestFromSource")]
        public string RequestFromSource{ get; set; }

        /// <summary>
        /// 过滤字段名称
        /// Name 取值如下
        ///       keyword 搜索关键字
        ///       bizCatalogIds 表示目录分类取值
        ///       DataAssetType 数据资产类型枚举取值：ALL-全部类型、TABLE-数据表
        ///       DatasourceType 数据源类型
        ///       datasourceIds 数据源ID列表
        ///       DatabaseName 数据库名称
        ///       InCharge 负责人
        ///       ProjectId 项目ID
        ///       Label 标签
        ///       ProjectId 数据资产归属的项目ID
        ///       AssetLevel 等级 取值：ALL-全部，40-核心，30-重要，20-一般，10-临时
        ///       OwnerMe 我负责的
        ///       PermissionMe 我有权限的
        ///       MyFavorite 我收藏的
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序字段列表
        /// 取值：
        ///      Name： Table-按表名，LikeCount-按热度
        ///      Direction： ASC, DESC
        /// </summary>
        [JsonProperty("OrderFields")]
        public OrderField[] OrderFields{ get; set; }

        /// <summary>
        /// 页码，配合pageSize使用
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每页数目，配合pageNumber使用
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RequestFromSource", this.RequestFromSource);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "OrderFields.", this.OrderFields);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

