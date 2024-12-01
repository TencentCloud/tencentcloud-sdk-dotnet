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

    public class PathologyReport : AbstractModel
    {
        
        /// <summary>
        /// 癌症部位
        /// </summary>
        [JsonProperty("CancerPart")]
        public Part CancerPart{ get; set; }

        /// <summary>
        /// 癌症部位大小
        /// </summary>
        [JsonProperty("CancerSize")]
        public Size[] CancerSize{ get; set; }

        /// <summary>
        /// 描述文本
        /// </summary>
        [JsonProperty("DescText")]
        public string DescText{ get; set; }

        /// <summary>
        /// 组织学等级
        /// </summary>
        [JsonProperty("HistologyLevel")]
        public HistologyLevel HistologyLevel{ get; set; }

        /// <summary>
        /// 组织学类型
        /// </summary>
        [JsonProperty("HistologyType")]
        public HistologyType HistologyType{ get; set; }

        /// <summary>
        /// IHC信息
        /// </summary>
        [JsonProperty("IHC")]
        public IHCInfo[] IHC{ get; set; }

        /// <summary>
        /// 浸润深度
        /// </summary>
        [JsonProperty("InfiltrationDepth")]
        public BlockInfo InfiltrationDepth{ get; set; }

        /// <summary>
        /// 肿瘤扩散
        /// </summary>
        [JsonProperty("Invasive")]
        public Invas[] Invasive{ get; set; }

        /// <summary>
        /// 淋巴结
        /// </summary>
        [JsonProperty("LymphNodes")]
        public Lymph[] LymphNodes{ get; set; }

        /// <summary>
        /// PTNM信息
        /// </summary>
        [JsonProperty("PTNM")]
        public BlockInfo PTNM{ get; set; }

        /// <summary>
        /// 病理报告类型
        /// </summary>
        [JsonProperty("PathologicalReportType")]
        public BlockInfo PathologicalReportType{ get; set; }

        /// <summary>
        /// 报告原文
        /// </summary>
        [JsonProperty("ReportText")]
        public string ReportText{ get; set; }

        /// <summary>
        /// 标本类型
        /// </summary>
        [JsonProperty("SampleType")]
        public BlockInfo SampleType{ get; set; }

        /// <summary>
        /// 结论文本
        /// </summary>
        [JsonProperty("SummaryText")]
        public string SummaryText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CancerPart.", this.CancerPart);
            this.SetParamArrayObj(map, prefix + "CancerSize.", this.CancerSize);
            this.SetParamSimple(map, prefix + "DescText", this.DescText);
            this.SetParamObj(map, prefix + "HistologyLevel.", this.HistologyLevel);
            this.SetParamObj(map, prefix + "HistologyType.", this.HistologyType);
            this.SetParamArrayObj(map, prefix + "IHC.", this.IHC);
            this.SetParamObj(map, prefix + "InfiltrationDepth.", this.InfiltrationDepth);
            this.SetParamArrayObj(map, prefix + "Invasive.", this.Invasive);
            this.SetParamArrayObj(map, prefix + "LymphNodes.", this.LymphNodes);
            this.SetParamObj(map, prefix + "PTNM.", this.PTNM);
            this.SetParamObj(map, prefix + "PathologicalReportType.", this.PathologicalReportType);
            this.SetParamSimple(map, prefix + "ReportText", this.ReportText);
            this.SetParamObj(map, prefix + "SampleType.", this.SampleType);
            this.SetParamSimple(map, prefix + "SummaryText", this.SummaryText);
        }
    }
}

