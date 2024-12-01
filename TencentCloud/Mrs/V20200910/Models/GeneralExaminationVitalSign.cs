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

    public class GeneralExaminationVitalSign : AbstractModel
    {
        
        /// <summary>
        /// 生命体征总体描述
        /// </summary>
        [JsonProperty("Text")]
        public ValueUnitItem Text{ get; set; }

        /// <summary>
        /// 体温
        /// </summary>
        [JsonProperty("BodyTemperature")]
        public ValueUnitItem BodyTemperature{ get; set; }

        /// <summary>
        /// 脉率
        /// </summary>
        [JsonProperty("Pulse")]
        public ValueUnitItem Pulse{ get; set; }

        /// <summary>
        /// 心率
        /// </summary>
        [JsonProperty("HeartRate")]
        public ValueUnitItem HeartRate{ get; set; }

        /// <summary>
        /// 呼吸频率
        /// </summary>
        [JsonProperty("BreathingRate")]
        public ValueUnitItem BreathingRate{ get; set; }

        /// <summary>
        /// 身高
        /// </summary>
        [JsonProperty("BodyHeight")]
        public ValueUnitItem BodyHeight{ get; set; }

        /// <summary>
        /// 体重
        /// </summary>
        [JsonProperty("BodyWeight")]
        public ValueUnitItem BodyWeight{ get; set; }

        /// <summary>
        /// 体质指数
        /// </summary>
        [JsonProperty("BodyMassIndex")]
        public ValueUnitItem BodyMassIndex{ get; set; }

        /// <summary>
        /// 腰围
        /// </summary>
        [JsonProperty("Waistline")]
        public ValueUnitItem Waistline{ get; set; }

        /// <summary>
        /// 血压
        /// </summary>
        [JsonProperty("BloodPressure")]
        public GeneralExaminationVitalSignBloodPressure BloodPressure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Text.", this.Text);
            this.SetParamObj(map, prefix + "BodyTemperature.", this.BodyTemperature);
            this.SetParamObj(map, prefix + "Pulse.", this.Pulse);
            this.SetParamObj(map, prefix + "HeartRate.", this.HeartRate);
            this.SetParamObj(map, prefix + "BreathingRate.", this.BreathingRate);
            this.SetParamObj(map, prefix + "BodyHeight.", this.BodyHeight);
            this.SetParamObj(map, prefix + "BodyWeight.", this.BodyWeight);
            this.SetParamObj(map, prefix + "BodyMassIndex.", this.BodyMassIndex);
            this.SetParamObj(map, prefix + "Waistline.", this.Waistline);
            this.SetParamObj(map, prefix + "BloodPressure.", this.BloodPressure);
        }
    }
}

