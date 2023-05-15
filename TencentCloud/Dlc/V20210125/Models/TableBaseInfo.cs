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

    public class TableBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// 该数据表所属数据库名字
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 数据表名字
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 该数据表所属数据源名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }

        /// <summary>
        /// 该数据表备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableComment")]
        public string TableComment{ get; set; }

        /// <summary>
        /// 具体类型，表or视图
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 数据格式类型，hive，iceberg等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableFormat")]
        public string TableFormat{ get; set; }

        /// <summary>
        /// 建表用户昵称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserAlias")]
        public string UserAlias{ get; set; }

        /// <summary>
        /// 建表用户ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserSubUin")]
        public string UserSubUin{ get; set; }

        /// <summary>
        /// 数据治理配置项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GovernPolicy")]
        public DataGovernPolicy GovernPolicy{ get; set; }

        /// <summary>
        /// 库数据治理是否关闭，关闭：true，开启：false
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbGovernPolicyIsDisable")]
        public string DbGovernPolicyIsDisable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
            this.SetParamSimple(map, prefix + "TableComment", this.TableComment);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TableFormat", this.TableFormat);
            this.SetParamSimple(map, prefix + "UserAlias", this.UserAlias);
            this.SetParamSimple(map, prefix + "UserSubUin", this.UserSubUin);
            this.SetParamObj(map, prefix + "GovernPolicy.", this.GovernPolicy);
            this.SetParamSimple(map, prefix + "DbGovernPolicyIsDisable", this.DbGovernPolicyIsDisable);
        }
    }
}

