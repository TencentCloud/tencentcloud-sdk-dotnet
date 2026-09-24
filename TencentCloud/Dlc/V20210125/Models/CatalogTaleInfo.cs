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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CatalogTaleInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>表名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>字段信息</p>
        /// </summary>
        [JsonProperty("Columns")]
        public ColumnInfo[] Columns{ get; set; }

        /// <summary>
        /// <p>属性值</p>
        /// </summary>
        [JsonProperty("Properties")]
        public KVPair[] Properties{ get; set; }

        /// <summary>
        /// <p>分区</p>
        /// </summary>
        [JsonProperty("Partitioning")]
        public Partitioning[] Partitioning{ get; set; }

        /// <summary>
        /// <p>索引</p>
        /// </summary>
        [JsonProperty("Indexes")]
        public IndexInfo[] Indexes{ get; set; }

        /// <summary>
        /// <p>编辑者/审计信息</p>
        /// </summary>
        [JsonProperty("Audit")]
        public Audit Audit{ get; set; }

        /// <summary>
        /// <p>数据目录名称</p>
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// <p>数据库名称</p>
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// <p>表格式</p>
        /// </summary>
        [JsonProperty("TableFormat")]
        public string TableFormat{ get; set; }

        /// <summary>
        /// <p>表格式类型</p><p>枚举值：</p><ul><li>v2： TcIceberg v2版本</li></ul>
        /// </summary>
        [JsonProperty("FormatType")]
        public string FormatType{ get; set; }

        /// <summary>
        /// <p>表类型</p><p>枚举值：</p><ul><li>Managed： 内部表</li></ul>
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }

        /// <summary>
        /// <p>场景类型</p><p>枚举值：</p><ul><li>REALTIME： 实时类型</li></ul>
        /// </summary>
        [JsonProperty("TableMode")]
        public string TableMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
            this.SetParamArrayObj(map, prefix + "Partitioning.", this.Partitioning);
            this.SetParamArrayObj(map, prefix + "Indexes.", this.Indexes);
            this.SetParamObj(map, prefix + "Audit.", this.Audit);
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "TableFormat", this.TableFormat);
            this.SetParamSimple(map, prefix + "FormatType", this.FormatType);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
            this.SetParamSimple(map, prefix + "TableMode", this.TableMode);
        }
    }
}

