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

    public class MerchantManagementList : AbstractModel
    {
        
        /// <summary>
        /// 企业名称。
        /// </summary>
        [JsonProperty("TaxpayerName")]
        public string TaxpayerName{ get; set; }

        /// <summary>
        /// 纳税人识别号(税号)	。
        /// </summary>
        [JsonProperty("TaxpayerNum")]
        public string TaxpayerNum{ get; set; }

        /// <summary>
        /// 请求流水号。
        /// </summary>
        [JsonProperty("SerialNo")]
        public string SerialNo{ get; set; }

        /// <summary>
        /// 开票系统ID
        /// </summary>
        [JsonProperty("InvoicePlatformId")]
        public long? InvoicePlatformId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaxpayerName", this.TaxpayerName);
            this.SetParamSimple(map, prefix + "TaxpayerNum", this.TaxpayerNum);
            this.SetParamSimple(map, prefix + "SerialNo", this.SerialNo);
            this.SetParamSimple(map, prefix + "InvoicePlatformId", this.InvoicePlatformId);
        }
    }
}

