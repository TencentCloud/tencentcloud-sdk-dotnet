/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

    public class SurgeryHistory : AbstractModel
    {
        
        /// <summary>
        /// 手术名称
        /// </summary>
        [JsonProperty("SurgeryName")]
        public SurgeryAttr SurgeryName{ get; set; }

        /// <summary>
        /// 手术日期
        /// </summary>
        [JsonProperty("SurgeryDate")]
        public SurgeryAttr SurgeryDate{ get; set; }

        /// <summary>
        /// 术前诊断
        /// </summary>
        [JsonProperty("PreoperativePathology")]
        public SurgeryAttr PreoperativePathology{ get; set; }

        /// <summary>
        /// 术中诊断
        /// </summary>
        [JsonProperty("IntraoperativePathology")]
        public SurgeryAttr IntraoperativePathology{ get; set; }

        /// <summary>
        /// 术后诊断
        /// </summary>
        [JsonProperty("PostoperativePathology")]
        public SurgeryAttr PostoperativePathology{ get; set; }

        /// <summary>
        /// 出院诊断
        /// </summary>
        [JsonProperty("DischargeDiagnosis")]
        public SurgeryAttr DischargeDiagnosis{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SurgeryName.", this.SurgeryName);
            this.SetParamObj(map, prefix + "SurgeryDate.", this.SurgeryDate);
            this.SetParamObj(map, prefix + "PreoperativePathology.", this.PreoperativePathology);
            this.SetParamObj(map, prefix + "IntraoperativePathology.", this.IntraoperativePathology);
            this.SetParamObj(map, prefix + "PostoperativePathology.", this.PostoperativePathology);
            this.SetParamObj(map, prefix + "DischargeDiagnosis.", this.DischargeDiagnosis);
        }
    }
}

