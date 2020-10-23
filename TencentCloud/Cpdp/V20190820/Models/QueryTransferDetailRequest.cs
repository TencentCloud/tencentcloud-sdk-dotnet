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

    public class QueryTransferDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 商户号。
        /// 示例值：129284394
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 商家批次单号。
        /// 商户系统内部的商家批次单号，此参数只能由数字、字母组成，商户系统内部唯一，UTF8编码，最多32个字符。
        /// 示例值：plfk2020042013
        /// </summary>
        [JsonProperty("MerchantBatchNo")]
        public string MerchantBatchNo{ get; set; }

        /// <summary>
        /// 商家明细单号。
        /// 商户系统内部的商家明细单号
        /// 示例值：plfk2020042013
        /// </summary>
        [JsonProperty("MerchantDetailNo")]
        public string MerchantDetailNo{ get; set; }

        /// <summary>
        /// 微信批次单号。
        /// 微信商家转账系统返回的唯一标识。
        /// 商家单号（包含批次号和明细单号）和微信单号（包含批次号和明细单号）二者必填其一。
        /// 示例值：1030000071100999991182020050700019480001
        /// </summary>
        [JsonProperty("BatchId")]
        public string BatchId{ get; set; }

        /// <summary>
        /// 微信明细单号。
        /// 微信区分明细单返回的唯一标识。
        /// 示例值：1030000071100999991182020050700019480001
        /// </summary>
        [JsonProperty("DetailId")]
        public string DetailId{ get; set; }

        /// <summary>
        /// 环境名:
        /// release: 现网环境
        /// sandbox: 沙箱环境
        /// development: 开发环境
        /// 缺省: release
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "MerchantBatchNo", this.MerchantBatchNo);
            this.SetParamSimple(map, prefix + "MerchantDetailNo", this.MerchantDetailNo);
            this.SetParamSimple(map, prefix + "BatchId", this.BatchId);
            this.SetParamSimple(map, prefix + "DetailId", this.DetailId);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

