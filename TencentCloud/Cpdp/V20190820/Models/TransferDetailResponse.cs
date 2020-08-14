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

    public class TransferDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 商家明细单号。
        /// 商户系统内部的商家明细单号
        /// 示例值：plfk2020042013
        /// </summary>
        [JsonProperty("MerchantDetailNo")]
        public string MerchantDetailNo{ get; set; }

        /// <summary>
        /// 微信明细单号。
        /// 微信区分明细单返回的唯一标识。
        /// 示例值：1030000071100999991182020050700019480001
        /// </summary>
        [JsonProperty("DetailId")]
        public string DetailId{ get; set; }

        /// <summary>
        /// 明细状态。
        /// PROCESSING：转账中，正在处理，结果未明；
        /// SUCCESS：转账成功；
        /// FAIL：转账失败，需要确认失败原因以后，再决定是否重新发起地该笔明细的转账。
        /// 示例值：SUCCESS
        /// </summary>
        [JsonProperty("DetailStatus")]
        public string DetailStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantDetailNo", this.MerchantDetailNo);
            this.SetParamSimple(map, prefix + "DetailId", this.DetailId);
            this.SetParamSimple(map, prefix + "DetailStatus", this.DetailStatus);
        }
    }
}

