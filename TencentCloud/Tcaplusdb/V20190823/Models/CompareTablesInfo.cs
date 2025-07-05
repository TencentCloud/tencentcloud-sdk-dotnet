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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompareTablesInfo : AbstractModel
    {
        
        /// <summary>
        /// 源表格的集群id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcTableClusterId")]
        public string SrcTableClusterId{ get; set; }

        /// <summary>
        /// 源表格的表格组id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcTableGroupId")]
        public string SrcTableGroupId{ get; set; }

        /// <summary>
        /// 源表格的表名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcTableName")]
        public string SrcTableName{ get; set; }

        /// <summary>
        /// 目标表格的集群id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DstTableClusterId")]
        public string DstTableClusterId{ get; set; }

        /// <summary>
        /// 目标表格的表格组id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DstTableGroupId")]
        public string DstTableGroupId{ get; set; }

        /// <summary>
        /// 目标表格的表名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DstTableName")]
        public string DstTableName{ get; set; }

        /// <summary>
        /// 源表格的实例id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcTableInstanceId")]
        public string SrcTableInstanceId{ get; set; }

        /// <summary>
        /// 目标表格的实例id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DstTableInstanceId")]
        public string DstTableInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcTableClusterId", this.SrcTableClusterId);
            this.SetParamSimple(map, prefix + "SrcTableGroupId", this.SrcTableGroupId);
            this.SetParamSimple(map, prefix + "SrcTableName", this.SrcTableName);
            this.SetParamSimple(map, prefix + "DstTableClusterId", this.DstTableClusterId);
            this.SetParamSimple(map, prefix + "DstTableGroupId", this.DstTableGroupId);
            this.SetParamSimple(map, prefix + "DstTableName", this.DstTableName);
            this.SetParamSimple(map, prefix + "SrcTableInstanceId", this.SrcTableInstanceId);
            this.SetParamSimple(map, prefix + "DstTableInstanceId", this.DstTableInstanceId);
        }
    }
}

