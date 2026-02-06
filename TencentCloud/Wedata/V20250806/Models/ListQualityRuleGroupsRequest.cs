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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListQualityRuleGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 分页序号，默认1
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 分页大小，默认10
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 过滤条件,每次请求的Filters的上限为10，Filter.Values的上限为5，可选过滤条件如下：
        /// 
        /// 1. RuleGroupId
        /// 描述：规则组ID。
        /// 取值：整数
        /// 
        /// 2. RuleGroupName
        /// 描述：规则组名称。
        /// 取值：字符串
        /// 
        /// 3. TableId
        /// 描述：数据源表id
        /// 取值：字符串
        /// 
        /// 4. TableName
        /// 描述：数据源表名称，支持模糊匹配。
        /// 取值：字符串
        /// 
        /// 5. TableOwnerName
        /// 描述：表负责人名称，支持模糊匹配。
        /// 取值：字符串
        /// 
        /// 
        /// 6. DatasourceType
        /// 描述：数据源类型。
        /// 取值：1 - MYSQL；2 - HIVE；3 - DLC；4 - GBASE；5 - TCHouse-P/CDW；6 - ICEBERG；7 - DORIS；8 - TCHouse-D；9 - EMR_STARROCKS；10 - TBDS_STARROCKS；11 - TCHouse-X
        /// 
        /// 7. DatasourceId
        /// 描述：数据源ID。
        /// 取值：字符串
        /// 
        /// 8. DatabaseName
        /// 描述：数据库名称。
        /// 取值：字符串
        /// 
        /// 9. SchemaName
        /// 描述：Schema名称。
        /// 取值：字符串
        /// 
        /// 10. CatalogName
        /// 描述：数据目录名称。
        /// 取值：字符串
        /// 
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 通用排序，支持的排序字段：
        /// CreateTime - 按创建时间排序
        /// UpdateTime - 按更新时间排序（默认）
        /// 排序方向：
        /// 1 - 升序（ASC）
        /// 2 - 降序（DESC）
        /// </summary>
        [JsonProperty("OrderFields")]
        public OrderField[] OrderFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "OrderFields.", this.OrderFields);
        }
    }
}

