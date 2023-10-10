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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductStatusInfo : AbstractModel
    {
        
        /// <summary>
        /// 防护状态，1未防护，2防护中，3试用中，4已过期
        /// </summary>
        [JsonProperty("FWUserStatus")]
        public ulong? FWUserStatus{ get; set; }

        /// <summary>
        /// 是否可以申请试用，true可以申请
        /// </summary>
        [JsonProperty("CanApplyTrial")]
        public bool? CanApplyTrial{ get; set; }

        /// <summary>
        /// 无法试用原因，可试用为空
        /// </summary>
        [JsonProperty("CanNotApplyReason")]
        public string CanNotApplyReason{ get; set; }

        /// <summary>
        /// 上次试用结束时间（不存在试用记录则为空）
        /// </summary>
        [JsonProperty("LastTrialTime")]
        public string LastTrialTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FWUserStatus", this.FWUserStatus);
            this.SetParamSimple(map, prefix + "CanApplyTrial", this.CanApplyTrial);
            this.SetParamSimple(map, prefix + "CanNotApplyReason", this.CanNotApplyReason);
            this.SetParamSimple(map, prefix + "LastTrialTime", this.LastTrialTime);
        }
    }
}

