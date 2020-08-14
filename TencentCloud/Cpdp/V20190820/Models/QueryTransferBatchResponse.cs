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

    public class QueryTransferBatchResponse : AbstractModel
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
        /// 直连商户appId。
        /// 商户号绑定的appid。
        /// 示例值：wxf636efh567hg4356
        /// </summary>
        [JsonProperty("MerchantAppId")]
        public string MerchantAppId{ get; set; }

        /// <summary>
        /// 批次状态。
        /// ACCEPTED:已受理，批次已受理成功，若发起批量转账的30分钟后，转账批次单仍处于该状态，可能原因是商户账户余额不足等。商户可查询账户资金流水，若该笔转账批次单的扣款已经发生，则表示批次已经进入转账中，请再次查单确认；
        /// PROCESSING:转账中，已开始处理批次内的转账明细单；
        /// FINISHED:已完成，批次内的所有转账明细单都已处理完成；
        /// CLOSED:已关闭，可查询具体的批次关闭原因确认；
        /// 示例值：ACCEPTED
        /// </summary>
        [JsonProperty("BatchStatus")]
        public string BatchStatus{ get; set; }

        /// <summary>
        /// 批次关闭原因。
        /// 如果批次单状态为“CLOSED”（已关闭），则有关闭原因；
        /// MERCHANT_REVOCATION：商户主动撤销；
        /// OVERDUE_CLOSE：系统超时关闭。
        /// 示例值：OVERDUE_CLOSE
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloseReason")]
        public string CloseReason{ get; set; }

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
        /// 批次受理成功时返回，遵循rfc3339标准格式。格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示北京时间2015年05月20日13点29分35秒。
        /// 示例值：2015-05-20T13:29:35.120+08:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 批次最近一次更新时间，遵循rfc3339标准格式。格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示北京时间2015年05月20日13点29分35秒。
        /// 示例值：2015-05-20T13:29:35.120+08:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 转账成功金额。
        /// 转账成功的金额，单位为分，可能随时变化。
        /// 示例值：4000000
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessAmount")]
        public ulong? SuccessAmount{ get; set; }

        /// <summary>
        /// 转账成功的笔数。
        /// 可能随时变化。
        /// 示例值：200
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessNum")]
        public ulong? SuccessNum{ get; set; }

        /// <summary>
        /// 转账失败金额。
        /// 转账失败的金额，单位为分，可能随时变化。
        /// 示例值：4000000
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailAmount")]
        public ulong? FailAmount{ get; set; }

        /// <summary>
        /// 转账失败笔数。
        /// 可能随时变化。
        /// 示例值：200
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailNum")]
        public ulong? FailNum{ get; set; }

        /// <summary>
        /// 转账明细列表。
        /// 返回明细详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransferDetails")]
        public TransferDetailResponse[] TransferDetails{ get; set; }

        /// <summary>
        /// 批次类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BatchType")]
        public string BatchType{ get; set; }

        /// <summary>
        /// 批次名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BatchName")]
        public string BatchName{ get; set; }

        /// <summary>
        /// 批次标注。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BatchRemark")]
        public string BatchRemark{ get; set; }

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
            this.SetParamSimple(map, prefix + "MerchantAppId", this.MerchantAppId);
            this.SetParamSimple(map, prefix + "BatchStatus", this.BatchStatus);
            this.SetParamSimple(map, prefix + "CloseReason", this.CloseReason);
            this.SetParamSimple(map, prefix + "TotalAmount", this.TotalAmount);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "SuccessAmount", this.SuccessAmount);
            this.SetParamSimple(map, prefix + "SuccessNum", this.SuccessNum);
            this.SetParamSimple(map, prefix + "FailAmount", this.FailAmount);
            this.SetParamSimple(map, prefix + "FailNum", this.FailNum);
            this.SetParamArrayObj(map, prefix + "TransferDetails.", this.TransferDetails);
            this.SetParamSimple(map, prefix + "BatchType", this.BatchType);
            this.SetParamSimple(map, prefix + "BatchName", this.BatchName);
            this.SetParamSimple(map, prefix + "BatchRemark", this.BatchRemark);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

