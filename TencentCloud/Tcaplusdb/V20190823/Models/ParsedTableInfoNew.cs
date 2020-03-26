/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParsedTableInfoNew : AbstractModel
    {
        
        /// <summary>
        /// 表格描述语言类型：`PROTO`或`TDR`
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableIdlType")]
        public string TableIdlType{ get; set; }

        /// <summary>
        /// 表格实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableInstanceId")]
        public string TableInstanceId{ get; set; }

        /// <summary>
        /// 表格名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 表格数据结构类型：`GENERIC`或`LIST`
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }

        /// <summary>
        /// 主键字段信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeyFields")]
        public string KeyFields{ get; set; }

        /// <summary>
        /// 原主键字段信息，改表校验时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldKeyFields")]
        public string OldKeyFields{ get; set; }

        /// <summary>
        /// 非主键字段信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueFields")]
        public string ValueFields{ get; set; }

        /// <summary>
        /// 原非主键字段信息，改表校验时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldValueFields")]
        public string OldValueFields{ get; set; }

        /// <summary>
        /// 所属表格组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableGroupId")]
        public string TableGroupId{ get; set; }

        /// <summary>
        /// 主键字段总大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SumKeyFieldSize")]
        public long? SumKeyFieldSize{ get; set; }

        /// <summary>
        /// 非主键字段总大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SumValueFieldSize")]
        public long? SumValueFieldSize{ get; set; }

        /// <summary>
        /// 索引键集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexKeySet")]
        public string IndexKeySet{ get; set; }

        /// <summary>
        /// 分表因子集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShardingKeySet")]
        public string ShardingKeySet{ get; set; }

        /// <summary>
        /// TDR版本号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TdrVersion")]
        public long? TdrVersion{ get; set; }

        /// <summary>
        /// 错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Error")]
        public ErrorInfo Error{ get; set; }

        /// <summary>
        /// LIST类型表格元素个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ListElementNum")]
        public long? ListElementNum{ get; set; }

        /// <summary>
        /// SORTLIST类型表格排序字段个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SortFieldNum")]
        public long? SortFieldNum{ get; set; }

        /// <summary>
        /// SORTLIST类型表格排序顺序
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SortRule")]
        public long? SortRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableIdlType", this.TableIdlType);
            this.SetParamSimple(map, prefix + "TableInstanceId", this.TableInstanceId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
            this.SetParamSimple(map, prefix + "KeyFields", this.KeyFields);
            this.SetParamSimple(map, prefix + "OldKeyFields", this.OldKeyFields);
            this.SetParamSimple(map, prefix + "ValueFields", this.ValueFields);
            this.SetParamSimple(map, prefix + "OldValueFields", this.OldValueFields);
            this.SetParamSimple(map, prefix + "TableGroupId", this.TableGroupId);
            this.SetParamSimple(map, prefix + "SumKeyFieldSize", this.SumKeyFieldSize);
            this.SetParamSimple(map, prefix + "SumValueFieldSize", this.SumValueFieldSize);
            this.SetParamSimple(map, prefix + "IndexKeySet", this.IndexKeySet);
            this.SetParamSimple(map, prefix + "ShardingKeySet", this.ShardingKeySet);
            this.SetParamSimple(map, prefix + "TdrVersion", this.TdrVersion);
            this.SetParamObj(map, prefix + "Error.", this.Error);
            this.SetParamSimple(map, prefix + "ListElementNum", this.ListElementNum);
            this.SetParamSimple(map, prefix + "SortFieldNum", this.SortFieldNum);
            this.SetParamSimple(map, prefix + "SortRule", this.SortRule);
        }
    }
}

