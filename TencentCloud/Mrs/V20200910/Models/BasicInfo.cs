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

    public class BasicInfo : AbstractModel
    {
        
        /// <summary>
        /// 医院名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HospitalName")]
        public string HospitalName{ get; set; }

        /// <summary>
        /// 科室名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DepartmentName")]
        public string DepartmentName{ get; set; }

        /// <summary>
        /// 报告名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportName")]
        public string ReportName{ get; set; }

        /// <summary>
        /// 报告时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportTime")]
        public string ReportTime{ get; set; }

        /// <summary>
        /// 门诊号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutpatientNum")]
        public string OutpatientNum{ get; set; }

        /// <summary>
        /// 住院号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InHospitalNum")]
        public string InHospitalNum{ get; set; }

        /// <summary>
        /// 检查号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InspectionNum")]
        public string InspectionNum{ get; set; }

        /// <summary>
        /// 影像号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageNum")]
        public string ImageNum{ get; set; }

        /// <summary>
        /// 放射号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RadiationNum")]
        public string RadiationNum{ get; set; }

        /// <summary>
        /// 病理号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PathologyNum")]
        public string PathologyNum{ get; set; }

        /// <summary>
        /// 床位号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BedNum")]
        public string BedNum{ get; set; }

        /// <summary>
        /// 入院时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InHospitalTime")]
        public string InHospitalTime{ get; set; }

        /// <summary>
        /// 出院时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutHospitalTime")]
        public string OutHospitalTime{ get; set; }

        /// <summary>
        /// 住院治疗时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CureDuration")]
        public string CureDuration{ get; set; }

        /// <summary>
        /// 住院次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HospitalizationTimes")]
        public string HospitalizationTimes{ get; set; }

        /// <summary>
        /// 送检检查时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InspectionTime")]
        public string InspectionTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HospitalName", this.HospitalName);
            this.SetParamSimple(map, prefix + "DepartmentName", this.DepartmentName);
            this.SetParamSimple(map, prefix + "ReportName", this.ReportName);
            this.SetParamSimple(map, prefix + "ReportTime", this.ReportTime);
            this.SetParamSimple(map, prefix + "OutpatientNum", this.OutpatientNum);
            this.SetParamSimple(map, prefix + "InHospitalNum", this.InHospitalNum);
            this.SetParamSimple(map, prefix + "InspectionNum", this.InspectionNum);
            this.SetParamSimple(map, prefix + "ImageNum", this.ImageNum);
            this.SetParamSimple(map, prefix + "RadiationNum", this.RadiationNum);
            this.SetParamSimple(map, prefix + "PathologyNum", this.PathologyNum);
            this.SetParamSimple(map, prefix + "BedNum", this.BedNum);
            this.SetParamSimple(map, prefix + "InHospitalTime", this.InHospitalTime);
            this.SetParamSimple(map, prefix + "OutHospitalTime", this.OutHospitalTime);
            this.SetParamSimple(map, prefix + "CureDuration", this.CureDuration);
            this.SetParamSimple(map, prefix + "HospitalizationTimes", this.HospitalizationTimes);
            this.SetParamSimple(map, prefix + "InspectionTime", this.InspectionTime);
        }
    }
}

