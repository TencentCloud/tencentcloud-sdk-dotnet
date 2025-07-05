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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntegrationNodeDetail : AbstractModel
    {
        
        /// <summary>
        /// 集成节点名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 集成节点类型
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 节点数据源类型
        /// </summary>
        [JsonProperty("DataSourceType")]
        public string DataSourceType{ get; set; }

        /// <summary>
        /// 节点描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 数据源id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// 节点配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Config")]
        public RecordField[] Config{ get; set; }

        /// <summary>
        /// 节点扩展配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtConfig")]
        public RecordField[] ExtConfig{ get; set; }

        /// <summary>
        /// 节点schema
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Schema")]
        public IntegrationNodeSchema[] Schema{ get; set; }

        /// <summary>
        /// 节点映射
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeMapping")]
        public IntegrationNodeMapping NodeMapping{ get; set; }

        /// <summary>
        /// owner uin
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "DataSourceType", this.DataSourceType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamArrayObj(map, prefix + "Config.", this.Config);
            this.SetParamArrayObj(map, prefix + "ExtConfig.", this.ExtConfig);
            this.SetParamArrayObj(map, prefix + "Schema.", this.Schema);
            this.SetParamObj(map, prefix + "NodeMapping.", this.NodeMapping);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
        }
    }
}

