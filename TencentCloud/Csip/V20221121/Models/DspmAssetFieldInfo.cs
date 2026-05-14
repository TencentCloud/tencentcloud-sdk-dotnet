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

    public class DspmAssetFieldInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>资产实例id</p>
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// <p>数据库名称</p>
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// <p>schema名</p>
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// <p>表名</p>
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// <p>字段名</p>
        /// </summary>
        [JsonProperty("FieldName")]
        public string FieldName{ get; set; }

        /// <summary>
        /// <p>数据项id集合</p>
        /// </summary>
        [JsonProperty("RuleIds")]
        public ulong?[] RuleIds{ get; set; }

        /// <summary>
        /// <p>数据项名称集合</p>
        /// </summary>
        [JsonProperty("RuleNames")]
        public string[] RuleNames{ get; set; }

        /// <summary>
        /// <p>分类id集合</p>
        /// </summary>
        [JsonProperty("CategoryIds")]
        public ulong?[] CategoryIds{ get; set; }

        /// <summary>
        /// <p>分类名称集合</p>
        /// </summary>
        [JsonProperty("CategoryNames")]
        public string[] CategoryNames{ get; set; }

        /// <summary>
        /// <p>分类详情</p>
        /// </summary>
        [JsonProperty("CategoryDetails")]
        public DspmIdentifyCategoryDetail[] CategoryDetails{ get; set; }

        /// <summary>
        /// <p>字段注释</p>
        /// </summary>
        [JsonProperty("FieldComment")]
        public string FieldComment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "FieldName", this.FieldName);
            this.SetParamArraySimple(map, prefix + "RuleIds.", this.RuleIds);
            this.SetParamArraySimple(map, prefix + "RuleNames.", this.RuleNames);
            this.SetParamArraySimple(map, prefix + "CategoryIds.", this.CategoryIds);
            this.SetParamArraySimple(map, prefix + "CategoryNames.", this.CategoryNames);
            this.SetParamArrayObj(map, prefix + "CategoryDetails.", this.CategoryDetails);
            this.SetParamSimple(map, prefix + "FieldComment", this.FieldComment);
        }
    }
}

