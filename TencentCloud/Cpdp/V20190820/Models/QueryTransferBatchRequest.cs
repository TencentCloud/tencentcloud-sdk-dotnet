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

    public class QueryTransferBatchRequest : AbstractModel
    {
        
        /// <summary>
        /// 商户号。
        /// 示例值：129284394
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 微信明细单号。
        /// 微信区分明细单返回的唯一标识。
        /// 示例值：1030000071100999991182020050700019480101
        /// </summary>
        [JsonProperty("NeedQueryDetail")]
        public bool? NeedQueryDetail{ get; set; }

        /// <summary>
        /// 商家批次单号。
        /// 商户系统内部的商家批次单号，此参数只能由数字、字母组成，商户系统内部唯一，UTF8编码，最多32个字符。
        /// 示例值：plfk2020042013
        /// </summary>
        [JsonProperty("MerchantBatchNo")]
        public string MerchantBatchNo{ get; set; }

        /// <summary>
        /// 是否查询账单明细。
        /// true-是；
        /// false-否，默认否。
        /// 商户可选择是否查询指定状态的转账明细单，当转账批次单状态为“FINISHED”（已完成）时，才会返回满足条件的转账明细单。
        /// 示例值：true
        /// </summary>
        [JsonProperty("BatchId")]
        public string BatchId{ get; set; }

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
        /// 请求资源起始位置。
        /// 从0开始，默认值为0。
        /// 示例值：20
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 最大资源条数。
        /// 该次请求可返回的最大资源（转账明细单）条数，最小20条，最大100条，不传则默认20条。不足20条按实际条数返回
        /// 示例值：20
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 明细状态。
        /// ALL：全部，需要同时查询转账成功喝失败的明细单；
        /// SUCCESS：转账成功，只查询成功的明细单；
        /// FAIL：转账失败，只查询转账失败的明细单。
        /// 示例值：FAIL
        /// </summary>
        [JsonProperty("DetailStatus")]
        public string DetailStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "NeedQueryDetail", this.NeedQueryDetail);
            this.SetParamSimple(map, prefix + "MerchantBatchNo", this.MerchantBatchNo);
            this.SetParamSimple(map, prefix + "BatchId", this.BatchId);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "DetailStatus", this.DetailStatus);
        }
    }
}

