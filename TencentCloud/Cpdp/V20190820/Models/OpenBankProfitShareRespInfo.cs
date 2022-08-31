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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpenBankProfitShareRespInfo : AbstractModel
    {
        
        /// <summary>
        /// 接收方企业ID
        /// </summary>
        [JsonProperty("RecvId")]
        public string RecvId{ get; set; }

        /// <summary>
        /// 分润金额（分）
        /// </summary>
        [JsonProperty("ProfitShareFee")]
        public long? ProfitShareFee{ get; set; }

        /// <summary>
        /// 实际分账金额
        /// </summary>
        [JsonProperty("RealProfitShareFee")]
        public long? RealProfitShareFee{ get; set; }

        /// <summary>
        /// 分账状态
        /// </summary>
        [JsonProperty("ProfitShareStatus")]
        public string ProfitShareStatus{ get; set; }

        /// <summary>
        /// 分账完成时间
        /// </summary>
        [JsonProperty("ProfitFinishTime")]
        public string ProfitFinishTime{ get; set; }

        /// <summary>
        /// 分账类型
        /// </summary>
        [JsonProperty("ProfitShareType")]
        public long? ProfitShareType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecvId", this.RecvId);
            this.SetParamSimple(map, prefix + "ProfitShareFee", this.ProfitShareFee);
            this.SetParamSimple(map, prefix + "RealProfitShareFee", this.RealProfitShareFee);
            this.SetParamSimple(map, prefix + "ProfitShareStatus", this.ProfitShareStatus);
            this.SetParamSimple(map, prefix + "ProfitFinishTime", this.ProfitFinishTime);
            this.SetParamSimple(map, prefix + "ProfitShareType", this.ProfitShareType);
        }
    }
}

