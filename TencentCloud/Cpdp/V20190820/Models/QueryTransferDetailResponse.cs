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

    public class QueryTransferDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 商户号。
        /// 示例值：19300009329
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
        /// 微信批次单号。
        /// 微信商家转账系统返回的唯一标识。
        /// 示例值：1030000071100999991182020050700019480001
        /// </summary>
        [JsonProperty("BatchId")]
        public string BatchId{ get; set; }

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
        /// 转账金额。
        /// 单位为分。
        /// 示例值：200
        /// </summary>
        [JsonProperty("TransferAmount")]
        public ulong? TransferAmount{ get; set; }

        /// <summary>
        /// 失败原因。
        /// 如果转账失败则有失败原因
        /// ACCOUNT_FROZEN：账户冻结
        /// REAL_NAME_CHECK_FAIL：用户未实名
        /// NAME_NOT_CORRECT：用户姓名校验失败
        /// OPENID_INVALID：Openid校验失败
        /// TRANSFER_QUOTA_EXCEED：超过用户单笔收款额度
        /// DAY_RECEIVED_QUOTA_EXCEED：超过用户单日收款额度
        /// MONTH_RECEIVED_QUOTA_EXCEED：超过用户单月收款额度
        /// DAY_RECEIVED_COUNT_EXCEED：超过用户单日收款次数
        /// PRODUCT_AUTH_CHECK_FAIL：产品权限校验失败
        /// OVERDUE_CLOSE：转账关闭
        /// ID_CARD_NOT_CORRECT：用户身份证校验失败
        /// ACCOUNT_NOT_EXIST：用户账户不存在
        /// TRANSFER_RISK：转账存在风险
        /// 示例值：ACCOUNT_FROZEN
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// 转账发起时间。
        /// 遵循rfc3339标准格式。格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示北京时间2015年05月20日13点29分35秒。
        /// 示例值：2015-05-20T13:29:35.120+08:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InitiateTime")]
        public string InitiateTime{ get; set; }

        /// <summary>
        /// 转账更新时间。
        /// 遵循rfc3339标准格式。格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示北京时间2015年05月20日13点29分35秒。
        /// 示例值：2015-05-20T13:29:35.120+08:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 用户名。
        /// 示例值：张三
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 转账备注。
        /// 单条转账备注（微信用户会收到该备注）。UTF8编码，最多32字符。
        /// 示例值：2020年4月报销
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransferRemark")]
        public string TransferRemark{ get; set; }

        /// <summary>
        /// 商家绑定公众号APPID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MerchantAppId")]
        public string MerchantAppId{ get; set; }

        /// <summary>
        /// 用户openId。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "MerchantBatchNo", this.MerchantBatchNo);
            this.SetParamSimple(map, prefix + "BatchId", this.BatchId);
            this.SetParamSimple(map, prefix + "MerchantDetailNo", this.MerchantDetailNo);
            this.SetParamSimple(map, prefix + "DetailId", this.DetailId);
            this.SetParamSimple(map, prefix + "DetailStatus", this.DetailStatus);
            this.SetParamSimple(map, prefix + "TransferAmount", this.TransferAmount);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "InitiateTime", this.InitiateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "TransferRemark", this.TransferRemark);
            this.SetParamSimple(map, prefix + "MerchantAppId", this.MerchantAppId);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

