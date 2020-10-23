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

    public class TransferDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 商家明细单号。
        /// 商户系统内部区分转账批次单下不同转账明细单的唯一标识，要求此参数只能由数字、大小写字母组成。
        /// 示例值：x23zy545Bd5436
        /// </summary>
        [JsonProperty("MerchantDetailNo")]
        public string MerchantDetailNo{ get; set; }

        /// <summary>
        /// 转账金额。
        /// 转账金额单位为分。
        /// 示例值：200000
        /// </summary>
        [JsonProperty("TransferAmount")]
        public ulong? TransferAmount{ get; set; }

        /// <summary>
        /// 转账备注。
        /// 单条转账备注（微信用户会收到该备注）。UTF8编码，最多32字符。
        /// 示例值：2020年4月报销
        /// </summary>
        [JsonProperty("TransferRemark")]
        public string TransferRemark{ get; set; }

        /// <summary>
        /// 用户在直连商户下的唯一标识。
        /// 示例值：o-MYE42l80oelYMDE34nYD456Xoy
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 收款用户姓名。
        /// 收款方姓名。
        /// 示例值：张三
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantDetailNo", this.MerchantDetailNo);
            this.SetParamSimple(map, prefix + "TransferAmount", this.TransferAmount);
            this.SetParamSimple(map, prefix + "TransferRemark", this.TransferRemark);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
        }
    }
}

