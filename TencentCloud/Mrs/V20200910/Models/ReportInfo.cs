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

    public class ReportInfo : AbstractModel
    {
        
        /// <summary>
        /// 医院名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Hospital")]
        public string Hospital{ get; set; }

        /// <summary>
        /// 科室名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DepartmentName")]
        public string DepartmentName{ get; set; }

        /// <summary>
        /// 申请时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillingTime")]
        public string BillingTime{ get; set; }

        /// <summary>
        /// 报告时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportTime")]
        public string ReportTime{ get; set; }

        /// <summary>
        /// 检查时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InspectTime")]
        public string InspectTime{ get; set; }

        /// <summary>
        /// 检查号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckNum")]
        public string CheckNum{ get; set; }

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
        /// 检验号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TestNum")]
        public string TestNum{ get; set; }

        /// <summary>
        /// 门诊号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutpatientNum")]
        public string OutpatientNum{ get; set; }

        /// <summary>
        /// 病理号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PathologyNum")]
        public string PathologyNum{ get; set; }

        /// <summary>
        /// 住院号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InHospitalNum")]
        public string InHospitalNum{ get; set; }

        /// <summary>
        /// 样本号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SampleNum")]
        public string SampleNum{ get; set; }

        /// <summary>
        /// 标本种类
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SampleType")]
        public string SampleType{ get; set; }

        /// <summary>
        /// 病历号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MedicalRecordNum")]
        public string MedicalRecordNum{ get; set; }

        /// <summary>
        /// 报告名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportName")]
        public string ReportName{ get; set; }

        /// <summary>
        /// 超声号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UltraNum")]
        public string UltraNum{ get; set; }

        /// <summary>
        /// 临床诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Diagnose")]
        public string Diagnose{ get; set; }

        /// <summary>
        /// 检查项目
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckItem")]
        public string CheckItem{ get; set; }

        /// <summary>
        /// 检查方法
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckMethod")]
        public string CheckMethod{ get; set; }

        /// <summary>
        /// 诊断时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiagnoseTime")]
        public string DiagnoseTime{ get; set; }

        /// <summary>
        /// 体检号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthCheckupNum")]
        public string HealthCheckupNum{ get; set; }

        /// <summary>
        /// 其它时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherTime")]
        public string OtherTime{ get; set; }

        /// <summary>
        /// 打印时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrintTime")]
        public string PrintTime{ get; set; }

        /// <summary>
        /// 未归类时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Times")]
        public Time[] Times{ get; set; }

        /// <summary>
        /// 床号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BedNo")]
        public string BedNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Hospital", this.Hospital);
            this.SetParamSimple(map, prefix + "DepartmentName", this.DepartmentName);
            this.SetParamSimple(map, prefix + "BillingTime", this.BillingTime);
            this.SetParamSimple(map, prefix + "ReportTime", this.ReportTime);
            this.SetParamSimple(map, prefix + "InspectTime", this.InspectTime);
            this.SetParamSimple(map, prefix + "CheckNum", this.CheckNum);
            this.SetParamSimple(map, prefix + "ImageNum", this.ImageNum);
            this.SetParamSimple(map, prefix + "RadiationNum", this.RadiationNum);
            this.SetParamSimple(map, prefix + "TestNum", this.TestNum);
            this.SetParamSimple(map, prefix + "OutpatientNum", this.OutpatientNum);
            this.SetParamSimple(map, prefix + "PathologyNum", this.PathologyNum);
            this.SetParamSimple(map, prefix + "InHospitalNum", this.InHospitalNum);
            this.SetParamSimple(map, prefix + "SampleNum", this.SampleNum);
            this.SetParamSimple(map, prefix + "SampleType", this.SampleType);
            this.SetParamSimple(map, prefix + "MedicalRecordNum", this.MedicalRecordNum);
            this.SetParamSimple(map, prefix + "ReportName", this.ReportName);
            this.SetParamSimple(map, prefix + "UltraNum", this.UltraNum);
            this.SetParamSimple(map, prefix + "Diagnose", this.Diagnose);
            this.SetParamSimple(map, prefix + "CheckItem", this.CheckItem);
            this.SetParamSimple(map, prefix + "CheckMethod", this.CheckMethod);
            this.SetParamSimple(map, prefix + "DiagnoseTime", this.DiagnoseTime);
            this.SetParamSimple(map, prefix + "HealthCheckupNum", this.HealthCheckupNum);
            this.SetParamSimple(map, prefix + "OtherTime", this.OtherTime);
            this.SetParamSimple(map, prefix + "PrintTime", this.PrintTime);
            this.SetParamArrayObj(map, prefix + "Times.", this.Times);
            this.SetParamSimple(map, prefix + "BedNo", this.BedNo);
        }
    }
}

