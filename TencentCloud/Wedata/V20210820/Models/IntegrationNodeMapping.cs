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

    public class IntegrationNodeMapping : AbstractModel
    {
        
        /// <summary>
        /// 源节点id
        /// </summary>
        [JsonProperty("SourceId")]
        public string SourceId{ get; set; }

        /// <summary>
        /// 目标节点id
        /// </summary>
        [JsonProperty("SinkId")]
        public string SinkId{ get; set; }

        /// <summary>
        /// 源节点schema
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceSchema")]
        public IntegrationNodeSchema[] SourceSchema{ get; set; }

        /// <summary>
        /// 节点schema映射
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchemaMappings")]
        public IntegrationNodeSchemaMapping[] SchemaMappings{ get; set; }

        /// <summary>
        /// 节点映射扩展信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtConfig")]
        public RecordField[] ExtConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "SinkId", this.SinkId);
            this.SetParamArrayObj(map, prefix + "SourceSchema.", this.SourceSchema);
            this.SetParamArrayObj(map, prefix + "SchemaMappings.", this.SchemaMappings);
            this.SetParamArrayObj(map, prefix + "ExtConfig.", this.ExtConfig);
        }
    }
}

