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

    public class DescribeCatalogTableNamesPageRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>catalog名称</p>
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// <p>Schema名称</p>
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// <p>每页大小</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>页数</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>是否基于快照</p>
        /// </summary>
        [JsonProperty("SnapshotBased")]
        public bool? SnapshotBased{ get; set; }

        /// <summary>
        /// <p>快照id</p>
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// <p>table匹配规则</p>
        /// </summary>
        [JsonProperty("TableNamePattern")]
        public string TableNamePattern{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "SnapshotBased", this.SnapshotBased);
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "TableNamePattern", this.TableNamePattern);
        }
    }
}

