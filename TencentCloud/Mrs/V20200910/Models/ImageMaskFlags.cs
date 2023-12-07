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

    public class ImageMaskFlags : AbstractModel
    {
        
        /// <summary>
        /// 是否对医院信息进行脱敏
        /// </summary>
        [JsonProperty("HospitalFlag")]
        public bool? HospitalFlag{ get; set; }

        /// <summary>
        /// 是否对医生信息进行脱敏
        /// </summary>
        [JsonProperty("DoctorFlag")]
        public bool? DoctorFlag{ get; set; }

        /// <summary>
        /// 是否对患者信息进行脱敏
        /// </summary>
        [JsonProperty("PatientFlag")]
        public bool? PatientFlag{ get; set; }

        /// <summary>
        /// 是否对二维码信息进行脱敏
        /// </summary>
        [JsonProperty("BarFlag")]
        public bool? BarFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HospitalFlag", this.HospitalFlag);
            this.SetParamSimple(map, prefix + "DoctorFlag", this.DoctorFlag);
            this.SetParamSimple(map, prefix + "PatientFlag", this.PatientFlag);
            this.SetParamSimple(map, prefix + "BarFlag", this.BarFlag);
        }
    }
}

