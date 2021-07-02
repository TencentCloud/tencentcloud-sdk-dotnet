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

    public class CaseHistory : AbstractModel
    {
        
        /// <summary>
        /// 诊治信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Treatment")]
        public Treatment Treatment{ get; set; }

        /// <summary>
        /// 健康史信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthHistory")]
        public HealthHistory HealthHistory{ get; set; }

        /// <summary>
        /// 病例时间轴
        /// </summary>
        [JsonProperty("CaseHistoryList")]
        public Case[] CaseHistoryList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Treatment.", this.Treatment);
            this.SetParamObj(map, prefix + "HealthHistory.", this.HealthHistory);
            this.SetParamArrayObj(map, prefix + "CaseHistoryList.", this.CaseHistoryList);
        }
    }
}

