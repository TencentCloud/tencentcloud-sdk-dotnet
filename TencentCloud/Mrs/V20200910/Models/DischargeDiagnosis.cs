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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DischargeDiagnosis : AbstractModel
    {
        
        /// <summary>
        /// 表格位置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableIndex")]
        public long? TableIndex{ get; set; }

        /// <summary>
        /// 出院诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutDiagnosis")]
        public BlockInfo OutDiagnosis{ get; set; }

        /// <summary>
        /// 疾病编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiseaseCode")]
        public BlockInfo DiseaseCode{ get; set; }

        /// <summary>
        /// 入院情况
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InStatus")]
        public BlockInfo InStatus{ get; set; }

        /// <summary>
        /// 出院情况
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutStatus")]
        public BlockInfo OutStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableIndex", this.TableIndex);
            this.SetParamObj(map, prefix + "OutDiagnosis.", this.OutDiagnosis);
            this.SetParamObj(map, prefix + "DiseaseCode.", this.DiseaseCode);
            this.SetParamObj(map, prefix + "InStatus.", this.InStatus);
            this.SetParamObj(map, prefix + "OutStatus.", this.OutStatus);
        }
    }
}

