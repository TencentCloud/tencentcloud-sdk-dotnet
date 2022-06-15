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

namespace TencentCloud.Cii.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StructureResultObject : AbstractModel
    {
        
        /// <summary>
        /// 0表示正常返回；1代表结果未生成；2代表任务执行失败
        /// </summary>
        [JsonProperty("Code")]
        public ulong? Code{ get; set; }

        /// <summary>
        /// 报告类型:HealthReport(体检报告); BUltraReport(B超报告);MedCheckReport(检查报告);LaboratoryReport(检验报告); PathologyReport(病理报告);AdmissionReport(入院记录);DischargeReport(出院记录); DischargeSummary(出院小结);DiagnosisReport(诊断证明); MedicalRecordFront(病案首页);OperationReport(手术记录);OutpatientMedicalRecord(门诊病历)
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 结构化结果
        /// </summary>
        [JsonProperty("StructureResult")]
        public string StructureResult{ get; set; }

        /// <summary>
        /// 子任务ID
        /// </summary>
        [JsonProperty("SubTaskId")]
        public string SubTaskId{ get; set; }

        /// <summary>
        /// 任务文件列表
        /// </summary>
        [JsonProperty("TaskFiles")]
        public string[] TaskFiles{ get; set; }

        /// <summary>
        /// 结构化字段结果数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultFields")]
        public OcrRecognise[] ResultFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "StructureResult", this.StructureResult);
            this.SetParamSimple(map, prefix + "SubTaskId", this.SubTaskId);
            this.SetParamArraySimple(map, prefix + "TaskFiles.", this.TaskFiles);
            this.SetParamArrayObj(map, prefix + "ResultFields.", this.ResultFields);
        }
    }
}

