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

    public class PathologyV2 : AbstractModel
    {
        
        /// <summary>
        /// 报告类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PathologicalReportType")]
        public Report PathologicalReportType{ get; set; }

        /// <summary>
        /// 描述段落
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Desc")]
        public DescInfo Desc{ get; set; }

        /// <summary>
        /// 诊断结论
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Summary")]
        public SummaryInfo Summary{ get; set; }

        /// <summary>
        /// 报告全文
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportText")]
        public string ReportText{ get; set; }

        /// <summary>
        /// 淋巴结总计转移信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LymphTotal")]
        public LymphTotal[] LymphTotal{ get; set; }

        /// <summary>
        /// 单淋巴结转移信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LymphNodes")]
        public LymphNode[] LymphNodes{ get; set; }

        /// <summary>
        /// ihc信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ihc")]
        public IHCV2[] Ihc{ get; set; }

        /// <summary>
        /// 临床诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Clinical")]
        public BaseInfo Clinical{ get; set; }

        /// <summary>
        /// 是否癌前病变
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Precancer")]
        public HistologyClass Precancer{ get; set; }

        /// <summary>
        /// 是否恶性肿瘤
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Malignant")]
        public HistologyClass Malignant{ get; set; }

        /// <summary>
        /// 是否良性肿瘤
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Benigntumor")]
        public HistologyClass Benigntumor{ get; set; }

        /// <summary>
        /// 送检材料
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SampleType")]
        public BaseInfo SampleType{ get; set; }

        /// <summary>
        /// 淋巴结大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LymphSize")]
        public Size[] LymphSize{ get; set; }

        /// <summary>
        /// 分子病理
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Molecular")]
        public Molecular[] Molecular{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "PathologicalReportType.", this.PathologicalReportType);
            this.SetParamObj(map, prefix + "Desc.", this.Desc);
            this.SetParamObj(map, prefix + "Summary.", this.Summary);
            this.SetParamSimple(map, prefix + "ReportText", this.ReportText);
            this.SetParamArrayObj(map, prefix + "LymphTotal.", this.LymphTotal);
            this.SetParamArrayObj(map, prefix + "LymphNodes.", this.LymphNodes);
            this.SetParamArrayObj(map, prefix + "Ihc.", this.Ihc);
            this.SetParamObj(map, prefix + "Clinical.", this.Clinical);
            this.SetParamObj(map, prefix + "Precancer.", this.Precancer);
            this.SetParamObj(map, prefix + "Malignant.", this.Malignant);
            this.SetParamObj(map, prefix + "Benigntumor.", this.Benigntumor);
            this.SetParamObj(map, prefix + "SampleType.", this.SampleType);
            this.SetParamArrayObj(map, prefix + "LymphSize.", this.LymphSize);
            this.SetParamArrayObj(map, prefix + "Molecular.", this.Molecular);
        }
    }
}

