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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveStreamAiQualityControlResultInfo : AbstractModel
    {
        
        /// <summary>
        /// 内容质检结果列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QualityControlResults")]
        [System.Obsolete]
        public QualityControlResult[] QualityControlResults{ get; set; }

        /// <summary>
        /// 格式诊断结果列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiagnoseResults")]
        [System.Obsolete]
        public DiagnoseResult[] DiagnoseResults{ get; set; }

        /// <summary>
        /// 内容质检结果列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QualityControlResultSet")]
        public QualityControlResult[] QualityControlResultSet{ get; set; }

        /// <summary>
        /// 格式诊断结果列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiagnoseResultSet")]
        public DiagnoseResult[] DiagnoseResultSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "QualityControlResults.", this.QualityControlResults);
            this.SetParamArrayObj(map, prefix + "DiagnoseResults.", this.DiagnoseResults);
            this.SetParamArrayObj(map, prefix + "QualityControlResultSet.", this.QualityControlResultSet);
            this.SetParamArrayObj(map, prefix + "DiagnoseResultSet.", this.DiagnoseResultSet);
        }
    }
}

