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

    public class Pathology : AbstractModel
    {
        
        /// <summary>
        /// 病理类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PathologicalType")]
        public string PathologicalType{ get; set; }

        /// <summary>
        /// 侵润深度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InfiltrationDepth")]
        public string InfiltrationDepth{ get; set; }

        /// <summary>
        /// PTNM分期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PTNM")]
        public string PTNM{ get; set; }

        /// <summary>
        /// 远处转移
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DistanceMetastasis")]
        public string DistanceMetastasis{ get; set; }

        /// <summary>
        /// 影像诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SummaryText")]
        public string SummaryText{ get; set; }

        /// <summary>
        /// 影像所见
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DescText")]
        public string DescText{ get; set; }

        /// <summary>
        /// 组织学类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HistologyType")]
        public string HistologyType{ get; set; }

        /// <summary>
        /// 组织学等级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HistologyLevel")]
        public string HistologyLevel{ get; set; }

        /// <summary>
        /// 标本类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SampleType")]
        public string SampleType{ get; set; }

        /// <summary>
        /// 标本部位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SamplePart")]
        public string SamplePart{ get; set; }

        /// <summary>
        /// 标本大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SampleSize")]
        public string SampleSize{ get; set; }

        /// <summary>
        /// 肿瘤扩散
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvasiveList")]
        public Invasive[] InvasiveList{ get; set; }

        /// <summary>
        /// 肿瘤转移
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetastasisList")]
        public Metastasis[] MetastasisList{ get; set; }

        /// <summary>
        /// 免疫组化信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IHCList")]
        public IHC[] IHCList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PathologicalType", this.PathologicalType);
            this.SetParamSimple(map, prefix + "InfiltrationDepth", this.InfiltrationDepth);
            this.SetParamSimple(map, prefix + "PTNM", this.PTNM);
            this.SetParamSimple(map, prefix + "DistanceMetastasis", this.DistanceMetastasis);
            this.SetParamSimple(map, prefix + "SummaryText", this.SummaryText);
            this.SetParamSimple(map, prefix + "DescText", this.DescText);
            this.SetParamSimple(map, prefix + "HistologyType", this.HistologyType);
            this.SetParamSimple(map, prefix + "HistologyLevel", this.HistologyLevel);
            this.SetParamSimple(map, prefix + "SampleType", this.SampleType);
            this.SetParamSimple(map, prefix + "SamplePart", this.SamplePart);
            this.SetParamSimple(map, prefix + "SampleSize", this.SampleSize);
            this.SetParamArrayObj(map, prefix + "InvasiveList.", this.InvasiveList);
            this.SetParamArrayObj(map, prefix + "MetastasisList.", this.MetastasisList);
            this.SetParamArrayObj(map, prefix + "IHCList.", this.IHCList);
        }
    }
}

