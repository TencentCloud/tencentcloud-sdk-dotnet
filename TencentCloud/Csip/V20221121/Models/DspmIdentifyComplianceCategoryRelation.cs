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

    public class DspmIdentifyComplianceCategoryRelation : AbstractModel
    {
        
        /// <summary>
        /// <p>分类ID</p>
        /// </summary>
        [JsonProperty("CategoryId")]
        public ulong? CategoryId{ get; set; }

        /// <summary>
        /// <p>分类名称</p>
        /// </summary>
        [JsonProperty("CategoryName")]
        public string CategoryName{ get; set; }

        /// <summary>
        /// <p>父分类ID</p>
        /// </summary>
        [JsonProperty("CategoryParentId")]
        public string CategoryParentId{ get; set; }

        /// <summary>
        /// <p>是否叶子节点</p>
        /// </summary>
        [JsonProperty("IsLeaf")]
        public bool? IsLeaf{ get; set; }

        /// <summary>
        /// <p>分类类型</p><p>枚举值：</p><ul><li>0： 内置</li><li>1： 自定义</li></ul>
        /// </summary>
        [JsonProperty("CategoryType")]
        public ulong? CategoryType{ get; set; }

        /// <summary>
        /// <p>分类层级</p><p>单位：层</p>
        /// </summary>
        [JsonProperty("CategoryGrade")]
        public ulong? CategoryGrade{ get; set; }

        /// <summary>
        /// <p>无</p>
        /// </summary>
        [JsonProperty("RuleRelations")]
        public DspmIdentifyComplianceRuleRelation[] RuleRelations{ get; set; }

        /// <summary>
        /// <p>无</p>
        /// </summary>
        [JsonProperty("Children")]
        public DspmIdentifyComplianceCategoryRelation[] Children{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "CategoryName", this.CategoryName);
            this.SetParamSimple(map, prefix + "CategoryParentId", this.CategoryParentId);
            this.SetParamSimple(map, prefix + "IsLeaf", this.IsLeaf);
            this.SetParamSimple(map, prefix + "CategoryType", this.CategoryType);
            this.SetParamSimple(map, prefix + "CategoryGrade", this.CategoryGrade);
            this.SetParamArrayObj(map, prefix + "RuleRelations.", this.RuleRelations);
            this.SetParamArrayObj(map, prefix + "Children.", this.Children);
        }
    }
}

