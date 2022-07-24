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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VatInvoiceVerifyRequest : AbstractModel
    {
        
        /// <summary>
        /// 发票代码， 一张发票一天只能查询5次。
        /// </summary>
        [JsonProperty("InvoiceCode")]
        public string InvoiceCode{ get; set; }

        /// <summary>
        /// 发票号码（8位）
        /// </summary>
        [JsonProperty("InvoiceNo")]
        public string InvoiceNo{ get; set; }

        /// <summary>
        /// 开票日期（不支持当天发票查询，支持五年以内开具的发票），格式：“YYYY-MM-DD”，如：2019-12-20。
        /// </summary>
        [JsonProperty("InvoiceDate")]
        public string InvoiceDate{ get; set; }

        /// <summary>
        /// 根据票种传递对应值，如果报参数错误，请仔细检查每个票种对应的值
        /// 
        /// 增值税专用发票：开具金额（不含税）
        /// 
        /// 增值税普通发票、增值税电子普通发票（含通行费发票）、增值税普通发票（卷票）：校验码后6位
        /// 
        /// 区块链发票：不含税金额/校验码，例如：“285.01/856ab”
        /// 
        /// 机动车销售统一发票：不含税价
        /// 
        /// 货物运输业增值税专用发票：合计金额
        /// 
        /// 二手车销售统一发票：车价合计
        /// </summary>
        [JsonProperty("Additional")]
        public string Additional{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvoiceCode", this.InvoiceCode);
            this.SetParamSimple(map, prefix + "InvoiceNo", this.InvoiceNo);
            this.SetParamSimple(map, prefix + "InvoiceDate", this.InvoiceDate);
            this.SetParamSimple(map, prefix + "Additional", this.Additional);
        }
    }
}

