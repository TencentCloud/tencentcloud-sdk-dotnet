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

    public class Warehouse : AbstractModel
    {
        
        /// <summary>
        /// <p>状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>location</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// <p>catalogtype</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CatalogType")]
        public string CatalogType{ get; set; }

        /// <summary>
        /// <p>uri</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uri")]
        public string Uri{ get; set; }

        /// <summary>
        /// <p>warehouse url</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WarehouseUrl")]
        public string WarehouseUrl{ get; set; }

        /// <summary>
        /// <p>认证方式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Authentication")]
        public string Authentication{ get; set; }

        /// <summary>
        /// <p>资源</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceRefs")]
        public ResourceRefLatest[] ResourceRefs{ get; set; }

        /// <summary>
        /// <p>hive warehouse uri</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HiveUri")]
        public string HiveUri{ get; set; }

        /// <summary>
        /// <p>高级参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Properties")]
        public Property[] Properties{ get; set; }

        /// <summary>
        /// <p>hive cata 类型</p>
        /// </summary>
        [JsonProperty("HiveCatalogType")]
        public ulong? HiveCatalogType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "CatalogType", this.CatalogType);
            this.SetParamSimple(map, prefix + "Uri", this.Uri);
            this.SetParamSimple(map, prefix + "WarehouseUrl", this.WarehouseUrl);
            this.SetParamSimple(map, prefix + "Authentication", this.Authentication);
            this.SetParamArrayObj(map, prefix + "ResourceRefs.", this.ResourceRefs);
            this.SetParamSimple(map, prefix + "HiveUri", this.HiveUri);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
            this.SetParamSimple(map, prefix + "HiveCatalogType", this.HiveCatalogType);
        }
    }
}

