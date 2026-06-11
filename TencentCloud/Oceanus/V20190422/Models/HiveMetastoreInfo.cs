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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HiveMetastoreInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>hms serialId</p>
        /// </summary>
        [JsonProperty("HiveMetastoreSerialId")]
        public string HiveMetastoreSerialId{ get; set; }

        /// <summary>
        /// <p>集群SerialId</p>
        /// </summary>
        [JsonProperty("ClusterGroupSerialId")]
        public string ClusterGroupSerialId{ get; set; }

        /// <summary>
        /// <p>状态枚举</p><p>枚举值：</p><ul><li>3： 运行中</li><li>1： 初始化中</li><li>2： 部署中</li><li>-2： 已删除</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>使用核数</p><p>单位：cu</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>使用内存资源</p><p>单位：GB</p>
        /// </summary>
        [JsonProperty("MemGB")]
        public long? MemGB{ get; set; }

        /// <summary>
        /// <p>副本数</p>
        /// </summary>
        [JsonProperty("Replica")]
        public long? Replica{ get; set; }

        /// <summary>
        /// <p>hms 访问uri</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HiveUri")]
        public string HiveUri{ get; set; }

        /// <summary>
        /// <p>命名空间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HiveNamespace")]
        public string HiveNamespace{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Warehouse地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HiveMetastoreWarehouseDir")]
        public string HiveMetastoreWarehouseDir{ get; set; }

        /// <summary>
        /// <p>高级参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Config")]
        public Property[] Config{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HiveMetastoreSerialId", this.HiveMetastoreSerialId);
            this.SetParamSimple(map, prefix + "ClusterGroupSerialId", this.ClusterGroupSerialId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "MemGB", this.MemGB);
            this.SetParamSimple(map, prefix + "Replica", this.Replica);
            this.SetParamSimple(map, prefix + "HiveUri", this.HiveUri);
            this.SetParamSimple(map, prefix + "HiveNamespace", this.HiveNamespace);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "HiveMetastoreWarehouseDir", this.HiveMetastoreWarehouseDir);
            this.SetParamArrayObj(map, prefix + "Config.", this.Config);
        }
    }
}

