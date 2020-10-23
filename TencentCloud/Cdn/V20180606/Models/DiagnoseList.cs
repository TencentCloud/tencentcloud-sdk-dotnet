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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiagnoseList : AbstractModel
    {
        
        /// <summary>
        /// 诊断任务标签。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiagnoseTag")]
        public string DiagnoseTag{ get; set; }

        /// <summary>
        /// 报告ID，用于获取详细诊断报告。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportId")]
        public string ReportId{ get; set; }

        /// <summary>
        /// 客户端信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientInfo")]
        public ClientInfo[] ClientInfo{ get; set; }

        /// <summary>
        /// 最终诊断结果。
        /// -1：已提交
        /// 0  ：检测中
        /// 1  ：检测正常
        /// 2  ： 检测异常
        /// 3  ： 诊断页面异常关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinalDiagnose")]
        public long? FinalDiagnose{ get; set; }

        /// <summary>
        /// 诊断任务创建时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiagnoseTag", this.DiagnoseTag);
            this.SetParamSimple(map, prefix + "ReportId", this.ReportId);
            this.SetParamArrayObj(map, prefix + "ClientInfo.", this.ClientInfo);
            this.SetParamSimple(map, prefix + "FinalDiagnose", this.FinalDiagnose);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

