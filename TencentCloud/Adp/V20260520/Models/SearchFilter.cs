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

    public class SearchFilter : AbstractModel
    {
        
        /// <summary>
        /// <p>检索过滤类型<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>SEARCH_FILTER_TYPE_UNKNOWN</td><td>0</td><td></td></tr><tr><td>SEARCH_FILTER_TYPE_CUSTOMER_LABEL_VALUE</td><td>1</td><td>用户自定义标签值</td></tr><tr><td>SEARCH_FILTER_TYPE_CUSTOMER_LABEL_VALUE_ID</td><td>2</td><td>用户自定义标签值ID</td></tr><tr><td>SEARCH_FILTER_TYPE_DOC_ID</td><td>3</td><td>指定文档 ID 检索</td></tr><tr><td>SEARCH_FILTER_TYPE_DOC_CATEGORY_ID</td><td>4</td><td>指定文档分类 ID 检索</td></tr><tr><td>SEARCH_FILTER_TYPE_DB_TABLE_ID</td><td>5</td><td>指定数据库表 ID 检索</td></tr><tr><td>SEARCH_FILTER_TYPE_KB_SCHEMA_ID</td><td>6</td><td>指定知识库 schema ID</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("FilterType")]
        public long? FilterType{ get; set; }

        /// <summary>
        /// <p>过滤值列表，根据SearchFilterType取值1：传自定义标签值；2：传自定义标签值ID；3：传文档ID；4：传分类ID</p>
        /// </summary>
        [JsonProperty("FilterValueList")]
        public string[] FilterValueList{ get; set; }

        /// <summary>
        /// <p>用户自定义标签 ID</p>
        /// </summary>
        [JsonProperty("LabelId")]
        public string LabelId{ get; set; }

        /// <summary>
        /// <p>逻辑运算符：AND 或 OR<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>LOGIC_OPR_NOOP</td><td>0</td><td></td></tr><tr><td>LOGIC_OPR_AND</td><td>1</td><td></td></tr><tr><td>LOGIC_OPR_OR</td><td>2</td><td></td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("LogicOp")]
        public long? LogicOp{ get; set; }

        /// <summary>
        /// <p>嵌套检索过滤</p>
        /// </summary>
        [JsonProperty("SearchFilterList")]
        public SearchFilter[] SearchFilterList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamArraySimple(map, prefix + "FilterValueList.", this.FilterValueList);
            this.SetParamSimple(map, prefix + "LabelId", this.LabelId);
            this.SetParamSimple(map, prefix + "LogicOp", this.LogicOp);
            this.SetParamArrayObj(map, prefix + "SearchFilterList.", this.SearchFilterList);
        }
    }
}

