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

    public class Dict : AbstractModel
    {
        
        /// <summary>
        /// 给药频次编码
        /// </summary>
        [JsonProperty("FreqCode")]
        public string FreqCode{ get; set; }

        /// <summary>
        /// 给药频次名称
        /// </summary>
        [JsonProperty("FreqName")]
        public string FreqName{ get; set; }

        /// <summary>
        /// 是否禁用 0-启用 1-禁用
        /// </summary>
        [JsonProperty("Disable")]
        public long? Disable{ get; set; }

        /// <summary>
        /// 给药途径编码
        /// </summary>
        [JsonProperty("UsageCode")]
        public string UsageCode{ get; set; }

        /// <summary>
        /// 给药途径名称
        /// </summary>
        [JsonProperty("UsageName")]
        public string UsageName{ get; set; }

        /// <summary>
        /// 科室ID
        /// </summary>
        [JsonProperty("DeptId")]
        public string DeptId{ get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [JsonProperty("DeptName")]
        public string DeptName{ get; set; }

        /// <summary>
        /// 科室区域类型 0:门诊  1:住院  2:门诊+住院
        /// </summary>
        [JsonProperty("Scope")]
        public long? Scope{ get; set; }

        /// <summary>
        /// 门诊开关
        /// </summary>
        [JsonProperty("OutpatientOn")]
        public bool? OutpatientOn{ get; set; }

        /// <summary>
        /// 住院
        /// </summary>
        [JsonProperty("InHospitalOn")]
        public bool? InHospitalOn{ get; set; }

        /// <summary>
        /// 诊断编码
        /// </summary>
        [JsonProperty("DiagCode")]
        public string DiagCode{ get; set; }

        /// <summary>
        /// 诊断名称
        /// </summary>
        [JsonProperty("DiagName")]
        public string DiagName{ get; set; }

        /// <summary>
        /// ICD代码
        /// </summary>
        [JsonProperty("IcdCode")]
        public string IcdCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FreqCode", this.FreqCode);
            this.SetParamSimple(map, prefix + "FreqName", this.FreqName);
            this.SetParamSimple(map, prefix + "Disable", this.Disable);
            this.SetParamSimple(map, prefix + "UsageCode", this.UsageCode);
            this.SetParamSimple(map, prefix + "UsageName", this.UsageName);
            this.SetParamSimple(map, prefix + "DeptId", this.DeptId);
            this.SetParamSimple(map, prefix + "DeptName", this.DeptName);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "OutpatientOn", this.OutpatientOn);
            this.SetParamSimple(map, prefix + "InHospitalOn", this.InHospitalOn);
            this.SetParamSimple(map, prefix + "DiagCode", this.DiagCode);
            this.SetParamSimple(map, prefix + "DiagName", this.DiagName);
            this.SetParamSimple(map, prefix + "IcdCode", this.IcdCode);
        }
    }
}

