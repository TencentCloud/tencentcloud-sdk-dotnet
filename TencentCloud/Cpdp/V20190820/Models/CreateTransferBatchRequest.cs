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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTransferBatchRequest : AbstractModel
    {
        
        /// <summary>
        /// 商户号。
        /// 示例值：129284394
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 转账明细列表。
        /// 发起批量转账的明细列表，最多三千笔
        /// </summary>
        [JsonProperty("TransferDetails")]
        public TransferDetailRequest[] TransferDetails{ get; set; }

        /// <summary>
        /// 直连商户appId。
        /// 即商户号绑定的appid。
        /// 示例值：wxf636efh567hg4356
        /// </summary>
        [JsonProperty("MerchantAppId")]
        public string MerchantAppId{ get; set; }

        /// <summary>
        /// 商家批次单号。
        /// 商户系统内部的商家批次单号，此参数只能由数字、字母组成，商户系统内部唯一，UTF8编码，最多32个字符。
        /// 示例值：plfk2020042013
        /// </summary>
        [JsonProperty("MerchantBatchNo")]
        public string MerchantBatchNo{ get; set; }

        /// <summary>
        /// 批次名称。
        /// 批量转账的名称。
        /// 示例值：2019年1月深圳分部报销单
        /// </summary>
        [JsonProperty("BatchName")]
        public string BatchName{ get; set; }

        /// <summary>
        /// 转账说明。
        /// UTF8编码，最多32个字符。
        /// 示例值：2019年深圳分部报销单
        /// </summary>
        [JsonProperty("BatchRemark")]
        public string BatchRemark{ get; set; }

        /// <summary>
        /// 转账总金额。
        /// 转账金额，单位为分。
        /// 示例值：4000000
        /// </summary>
        [JsonProperty("TotalAmount")]
        public ulong? TotalAmount{ get; set; }

        /// <summary>
        /// 转账总笔数。
        /// 一个转账批次最多允许发起三千笔转账。
        /// 示例值：200
        /// </summary>
        [JsonProperty("TotalNum")]
        public ulong? TotalNum{ get; set; }

        /// <summary>
        /// 环境名。
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
            this.SetParamArrayObj(map, prefix + "TransferDetails.", this.TransferDetails);
            this.SetParamSimple(map, prefix + "MerchantAppId", this.MerchantAppId);
            this.SetParamSimple(map, prefix + "MerchantBatchNo", this.MerchantBatchNo);
            this.SetParamSimple(map, prefix + "BatchName", this.BatchName);
            this.SetParamSimple(map, prefix + "BatchRemark", this.BatchRemark);
            this.SetParamSimple(map, prefix + "TotalAmount", this.TotalAmount);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

