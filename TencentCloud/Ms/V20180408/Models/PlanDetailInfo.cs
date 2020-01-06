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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PlanDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 默认策略，1为默认，0为非默认
        /// </summary>
        [JsonProperty("IsDefault")]
        public ulong? IsDefault{ get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("PlanId")]
        public ulong? PlanId{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// 策略信息
        /// </summary>
        [JsonProperty("PlanInfo")]
        public PlanInfo PlanInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamObj(map, prefix + "PlanInfo.", this.PlanInfo);
        }
    }
}

