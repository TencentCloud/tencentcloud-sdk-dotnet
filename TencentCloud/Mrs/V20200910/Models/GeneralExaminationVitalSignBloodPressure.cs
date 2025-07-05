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

    public class GeneralExaminationVitalSignBloodPressure : AbstractModel
    {
        
        /// <summary>
        /// 血压
        /// </summary>
        [JsonProperty("Text")]
        public BloodPressureItem Text{ get; set; }

        /// <summary>
        /// 收缩压/舒张压
        /// </summary>
        [JsonProperty("SystolicDiastolicPressure")]
        public BloodPressureItem[] SystolicDiastolicPressure{ get; set; }

        /// <summary>
        /// 收缩压
        /// </summary>
        [JsonProperty("SystolicPressure")]
        public BloodPressureItem[] SystolicPressure{ get; set; }

        /// <summary>
        /// 舒张压
        /// </summary>
        [JsonProperty("DiastolicPressure")]
        public BloodPressureItem[] DiastolicPressure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Text.", this.Text);
            this.SetParamArrayObj(map, prefix + "SystolicDiastolicPressure.", this.SystolicDiastolicPressure);
            this.SetParamArrayObj(map, prefix + "SystolicPressure.", this.SystolicPressure);
            this.SetParamArrayObj(map, prefix + "DiastolicPressure.", this.DiastolicPressure);
        }
    }
}

