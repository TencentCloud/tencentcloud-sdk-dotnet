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

    public class OtherInfo : AbstractModel
    {
        
        /// <summary>
        /// 麻醉方法
        /// </summary>
        [JsonProperty("Anesthesia")]
        public SurgeryAttr Anesthesia{ get; set; }

        /// <summary>
        /// 术中出血
        /// </summary>
        [JsonProperty("BloodLoss")]
        public SurgeryAttr BloodLoss{ get; set; }

        /// <summary>
        /// 输血
        /// </summary>
        [JsonProperty("BloodTransfusion")]
        public SurgeryAttr BloodTransfusion{ get; set; }

        /// <summary>
        /// 手术用时
        /// </summary>
        [JsonProperty("Duration")]
        public SurgeryAttr Duration{ get; set; }

        /// <summary>
        /// 手术开始时间
        /// </summary>
        [JsonProperty("EndTime")]
        public SurgeryAttr EndTime{ get; set; }

        /// <summary>
        /// 手术结束时间
        /// </summary>
        [JsonProperty("StartTime")]
        public SurgeryAttr StartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Anesthesia.", this.Anesthesia);
            this.SetParamObj(map, prefix + "BloodLoss.", this.BloodLoss);
            this.SetParamObj(map, prefix + "BloodTransfusion.", this.BloodTransfusion);
            this.SetParamObj(map, prefix + "Duration.", this.Duration);
            this.SetParamObj(map, prefix + "EndTime.", this.EndTime);
            this.SetParamObj(map, prefix + "StartTime.", this.StartTime);
        }
    }
}

