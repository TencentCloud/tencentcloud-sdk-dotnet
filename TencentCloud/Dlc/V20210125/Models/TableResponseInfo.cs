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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TableResponseInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据表基本信息。
        /// </summary>
        [JsonProperty("TableBaseInfo")]
        public TableBaseInfo TableBaseInfo{ get; set; }

        /// <summary>
        /// 数据表列信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Columns")]
        public Column[] Columns{ get; set; }

        /// <summary>
        /// 数据表分块信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Partitions")]
        public Partition[] Partitions{ get; set; }

        /// <summary>
        /// 数据存储路径。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 数据表属性信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Properties")]
        public Property[] Properties{ get; set; }

        /// <summary>
        /// 数据表更新时间, 单位: ms。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// 数据表创建时间,单位: ms。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 数据格式。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputFormat")]
        public string InputFormat{ get; set; }

        /// <summary>
        /// 数据表存储大小（单位：Byte）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageSize")]
        public long? StorageSize{ get; set; }

        /// <summary>
        /// 数据表行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordCount")]
        public long? RecordCount{ get; set; }

        /// <summary>
        /// xxxx
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MapMaterializedViewName")]
        public string MapMaterializedViewName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TableBaseInfo.", this.TableBaseInfo);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamArrayObj(map, prefix + "Partitions.", this.Partitions);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "InputFormat", this.InputFormat);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamSimple(map, prefix + "RecordCount", this.RecordCount);
            this.SetParamSimple(map, prefix + "MapMaterializedViewName", this.MapMaterializedViewName);
        }
    }
}

