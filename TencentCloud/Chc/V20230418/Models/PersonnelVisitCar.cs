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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PersonnelVisitCar : AbstractModel
    {
        
        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("CarNumber")]
        public string CarNumber{ get; set; }

        /// <summary>
        /// 驾驶人姓名
        /// </summary>
        [JsonProperty("DriverName")]
        public string DriverName{ get; set; }

        /// <summary>
        /// 驾驶人身份证号
        /// </summary>
        [JsonProperty("DriverNumber")]
        public string DriverNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CarNumber", this.CarNumber);
            this.SetParamSimple(map, prefix + "DriverName", this.DriverName);
            this.SetParamSimple(map, prefix + "DriverNumber", this.DriverNumber);
        }
    }
}

