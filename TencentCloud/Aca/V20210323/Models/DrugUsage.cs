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

namespace TencentCloud.Aca.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DrugUsage : AbstractModel
    {
        
        /// <summary>
        /// 药品ID
        /// </summary>
        [JsonProperty("DrugId")]
        public string DrugId{ get; set; }

        /// <summary>
        /// 药品名称
        /// </summary>
        [JsonProperty("DrugName")]
        public string DrugName{ get; set; }

        /// <summary>
        /// 日服药频次
        /// </summary>
        [JsonProperty("TimePerDay")]
        public string TimePerDay{ get; set; }

        /// <summary>
        /// 给药途径
        /// </summary>
        [JsonProperty("Usage")]
        public string Usage{ get; set; }

        /// <summary>
        /// 处方ID，药品不同分组是传不同的处方ID
        /// </summary>
        [JsonProperty("PrescriptionId")]
        public string PrescriptionId{ get; set; }

        /// <summary>
        /// 每次剂量
        /// </summary>
        [JsonProperty("DosagePerTime")]
        public string DosagePerTime{ get; set; }

        /// <summary>
        /// 每次剂量单位
        /// </summary>
        [JsonProperty("DosagePerTimeUnit")]
        public string DosagePerTimeUnit{ get; set; }

        /// <summary>
        /// 单次服药时间
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 给药周期
        /// </summary>
        [JsonProperty("Cycle")]
        public string Cycle{ get; set; }

        /// <summary>
        /// 单日剂量
        /// </summary>
        [JsonProperty("DosagePerDay")]
        public string DosagePerDay{ get; set; }

        /// <summary>
        /// 疗程
        /// </summary>
        [JsonProperty("Course")]
        public string Course{ get; set; }

        /// <summary>
        /// 给药速度
        /// </summary>
        [JsonProperty("Speed")]
        public string Speed{ get; set; }

        /// <summary>
        /// 处方生效时间戳，住院医嘱必须传(caseType =1)
        /// </summary>
        [JsonProperty("BeginTime")]
        public long? BeginTime{ get; set; }

        /// <summary>
        /// 处方失效时间戳，住院医嘱必须传(caseType =1)
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 开具数量
        /// </summary>
        [JsonProperty("Package")]
        public string Package{ get; set; }

        /// <summary>
        /// 开具数量单位
        /// </summary>
        [JsonProperty("PackageUnit")]
        public string PackageUnit{ get; set; }

        /// <summary>
        /// 相同标志液体间进行配伍禁忌审核，不同标志间液体不进行配伍禁忌审核
        /// </summary>
        [JsonProperty("GroupInj")]
        public string GroupInj{ get; set; }

        /// <summary>
        /// 处方金额
        /// </summary>
        [JsonProperty("PrescriptionCharge")]
        public string PrescriptionCharge{ get; set; }

        /// <summary>
        /// 用药天数
        /// </summary>
        [JsonProperty("MedicationDays")]
        public string MedicationDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DrugId", this.DrugId);
            this.SetParamSimple(map, prefix + "DrugName", this.DrugName);
            this.SetParamSimple(map, prefix + "TimePerDay", this.TimePerDay);
            this.SetParamSimple(map, prefix + "Usage", this.Usage);
            this.SetParamSimple(map, prefix + "PrescriptionId", this.PrescriptionId);
            this.SetParamSimple(map, prefix + "DosagePerTime", this.DosagePerTime);
            this.SetParamSimple(map, prefix + "DosagePerTimeUnit", this.DosagePerTimeUnit);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Cycle", this.Cycle);
            this.SetParamSimple(map, prefix + "DosagePerDay", this.DosagePerDay);
            this.SetParamSimple(map, prefix + "Course", this.Course);
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Package", this.Package);
            this.SetParamSimple(map, prefix + "PackageUnit", this.PackageUnit);
            this.SetParamSimple(map, prefix + "GroupInj", this.GroupInj);
            this.SetParamSimple(map, prefix + "PrescriptionCharge", this.PrescriptionCharge);
            this.SetParamSimple(map, prefix + "MedicationDays", this.MedicationDays);
        }
    }
}

