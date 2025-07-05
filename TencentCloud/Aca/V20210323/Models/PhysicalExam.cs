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

namespace TencentCloud.Aca.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PhysicalExam : AbstractModel
    {
        
        /// <summary>
        /// 脉搏，单位：次/分
        /// </summary>
        [JsonProperty("Pulse")]
        public string Pulse{ get; set; }

        /// <summary>
        /// 呼吸，单位：次/分
        /// </summary>
        [JsonProperty("Breathe")]
        public string Breathe{ get; set; }

        /// <summary>
        /// 体重，单位KG
        /// </summary>
        [JsonProperty("Weight")]
        public string Weight{ get; set; }

        /// <summary>
        /// 体温，单位：℃ 
        /// </summary>
        [JsonProperty("BodyTemperature")]
        public string BodyTemperature{ get; set; }

        /// <summary>
        /// 舒张压， 单位：mmHg
        /// </summary>
        [JsonProperty("DiastolicPressure")]
        public string DiastolicPressure{ get; set; }

        /// <summary>
        /// 收缩压， 单位：mmHg
        /// </summary>
        [JsonProperty("SystolicPressure")]
        public string SystolicPressure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Pulse", this.Pulse);
            this.SetParamSimple(map, prefix + "Breathe", this.Breathe);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "BodyTemperature", this.BodyTemperature);
            this.SetParamSimple(map, prefix + "DiastolicPressure", this.DiastolicPressure);
            this.SetParamSimple(map, prefix + "SystolicPressure", this.SystolicPressure);
        }
    }
}

