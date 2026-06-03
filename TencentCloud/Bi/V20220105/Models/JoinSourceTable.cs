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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JoinSourceTable : AbstractModel
    {
        
        /// <summary>
        /// 1:数据源原表,2:本地表,3:Excel表,4:API表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableNodeType")]
        public ulong? TableNodeType{ get; set; }

        /// <summary>
        /// 原始表节点Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableNodeId")]
        public string TableNodeId{ get; set; }

        /// <summary>
        /// 父节点id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentId")]
        public string ParentId{ get; set; }

        /// <summary>
        /// 非必填, 数据源原表没有ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// 必填,数据源原表用原始表名, 其他类型用BI的逻辑表名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 原始表需要展示的字段列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Fields")]
        public TableField[] Fields{ get; set; }

        /// <summary>
        /// 数据源id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceId")]
        public ulong? DatasourceId{ get; set; }

        /// <summary>
        /// 非必填,前端展示的数据源别名,excel建表需要
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableAlias")]
        public string TableAlias{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableNodeType", this.TableNodeType);
            this.SetParamSimple(map, prefix + "TableNodeId", this.TableNodeId);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamArrayObj(map, prefix + "Fields.", this.Fields);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "TableAlias", this.TableAlias);
        }
    }
}

