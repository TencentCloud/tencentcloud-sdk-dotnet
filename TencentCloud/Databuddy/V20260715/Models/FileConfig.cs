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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>高级运行参数，变量替换用，map-json String,String</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Params")]
        public string Params{ get; set; }

        /// <summary>
        /// <p>执行资源 ID。来源：ListComputeResources 接口返回的 ResourceId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>默认 catalog</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultCatalog")]
        public string DefaultCatalog{ get; set; }

        /// <summary>
        /// <p>默认 schema</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultSchema")]
        public string DefaultSchema{ get; set; }

        /// <summary>
        /// <p>高级配置，JSON 字符串</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdvanceConfig")]
        public string AdvanceConfig{ get; set; }

        /// <summary>
        /// <p>扩展参数，JSON 字符串</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraParams")]
        public string ExtraParams{ get; set; }

        /// <summary>
        /// <p>Notebook 交互控件定义，JSON 字符串</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Widgets")]
        public string Widgets{ get; set; }

        /// <summary>
        /// <p>各单元格输出配置。仅 Get 出参返回，入参忽略</p>
        /// </summary>
        [JsonProperty("OutputConf")]
        public FileOutputConf[] OutputConf{ get; set; }

        /// <summary>
        /// <p>SQL脚本语法标记</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlSyntax")]
        public string SqlSyntax{ get; set; }

        /// <summary>
        /// <p>平台集群id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Params", this.Params);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "DefaultCatalog", this.DefaultCatalog);
            this.SetParamSimple(map, prefix + "DefaultSchema", this.DefaultSchema);
            this.SetParamSimple(map, prefix + "AdvanceConfig", this.AdvanceConfig);
            this.SetParamSimple(map, prefix + "ExtraParams", this.ExtraParams);
            this.SetParamSimple(map, prefix + "Widgets", this.Widgets);
            this.SetParamArrayObj(map, prefix + "OutputConf.", this.OutputConf);
            this.SetParamSimple(map, prefix + "SqlSyntax", this.SqlSyntax);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
        }
    }
}

