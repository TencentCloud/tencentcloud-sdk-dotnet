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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleExecResultDetail : AbstractModel
    {
        
        /// <summary>
        /// 数据源id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceId")]
        public ulong? DatasourceId{ get; set; }

        /// <summary>
        /// 数据源名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceName")]
        public string DatasourceName{ get; set; }

        /// <summary>
        /// 数据库guid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseId")]
        public string DatabaseId{ get; set; }

        /// <summary>
        /// 数据库名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 表guid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// 表名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 规则执行记录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleExecResult")]
        public RuleExecResult RuleExecResult{ get; set; }

        /// <summary>
        /// 表负责人userId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableOwnerUserId")]
        public ulong? TableOwnerUserId{ get; set; }

        /// <summary>
        /// 2.HIVE 3.DLC
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceType")]
        public ulong? DatasourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "DatasourceName", this.DatasourceName);
            this.SetParamSimple(map, prefix + "DatabaseId", this.DatabaseId);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamObj(map, prefix + "RuleExecResult.", this.RuleExecResult);
            this.SetParamSimple(map, prefix + "TableOwnerUserId", this.TableOwnerUserId);
            this.SetParamSimple(map, prefix + "DatasourceType", this.DatasourceType);
        }
    }
}

