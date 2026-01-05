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

    public class ListQualityRuleTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// 工作空间ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 当前页，默认1
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 每页记录数，默认10
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 通用排序，
        /// 支持的排序字段：
        /// CitationCount - 按引用数量排序
        /// UpdateTime - 按更新时间排序
        /// 排序方向：
        /// 1 - 升序（ASC）
        /// 2 - 降序（DESC）
        /// </summary>
        [JsonProperty("OrderFields")]
        public OrderField[] OrderFields{ get; set; }

        /// <summary>
        /// 通用过滤条件
        /// 1. Id
        /// 描述：模板ID。
        /// 取值：模板的唯一标识
        /// 
        /// 2. Keyword
        /// 描述：关键字搜索，支持模板名称模糊搜索。
        /// 取值：字符串
        /// 
        /// 3. Type
        /// 描述：模板类型。
        /// 取值：1 - 系统模板；2 - 自定义模板；支持多个值（OR关系）
        /// 
        /// 4. QualityDim
        /// 描述：质量检测维度。
        /// 取值：1 - 准确性；2 - 唯一性；3 - 完整性；4 - 一致性；5 - 及时性；6 - 有效性；支持多个值（OR关系）
        /// 
        /// 5. SourceObjectType
        /// 描述：规则适用的源数据对象类型。
        /// 取值：1 - 常量；2 - 离线表级；3 - 离线字段级；4 - 库级；支持多个值（OR关系）
        /// 
        /// 6. SourceEngineTypes
        /// 描述：模板适用的源数据引擎类型。
        /// 取值：1 - MySQL；2 - Hive；4 - Spark；8 - Livy；16 - DLC；32 - Gbase；64 - TCHouse-P；128 - Doris；256 - TCHouse-D；512 - EMR_StarRocks；1024 - TCHouse-X；支持多个值（OR关系）
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArrayObj(map, prefix + "OrderFields.", this.OrderFields);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

