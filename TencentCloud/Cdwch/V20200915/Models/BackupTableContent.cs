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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupTableContent : AbstractModel
    {
        
        /// <summary>
        /// 数据库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// 表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// 表总字节数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalBytes")]
        public long? TotalBytes{ get; set; }

        /// <summary>
        /// 虚拟cluster
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VCluster")]
        public string VCluster{ get; set; }

        /// <summary>
        /// 表ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ips")]
        public string Ips{ get; set; }

        /// <summary>
        /// zk路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZooPath")]
        public string ZooPath{ get; set; }

        /// <summary>
        /// cvm的ip地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Rip")]
        public string Rip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "TotalBytes", this.TotalBytes);
            this.SetParamSimple(map, prefix + "VCluster", this.VCluster);
            this.SetParamSimple(map, prefix + "Ips", this.Ips);
            this.SetParamSimple(map, prefix + "ZooPath", this.ZooPath);
            this.SetParamSimple(map, prefix + "Rip", this.Rip);
        }
    }
}

