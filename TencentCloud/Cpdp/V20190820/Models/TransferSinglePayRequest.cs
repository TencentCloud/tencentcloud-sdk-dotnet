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

    public class TransferSinglePayRequest : AbstractModel
    {
        
        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 微信申请商户号的appid或者商户号绑定的appid
        /// 支付宝、平安填入MerchantId
        /// </summary>
        [JsonProperty("MerchantAppId")]
        public string MerchantAppId{ get; set; }

        /// <summary>
        /// 1、 微信企业付款 
        /// 2、 支付宝转账 
        /// 3、 平安银企直联代发转账
        /// </summary>
        [JsonProperty("TransferType")]
        public long? TransferType{ get; set; }

        /// <summary>
        /// 订单流水号，唯一，不能包含特殊字符，长度最大限制64位，推荐使用字母，数字组合，"_","-"组合
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 转账金额，单位分
        /// </summary>
        [JsonProperty("TransferAmount")]
        public long? TransferAmount{ get; set; }

        /// <summary>
        /// 收款方标识。
        /// 微信为open_id；
        /// 支付宝为会员alipay_user_id;
        /// 平安为收款方银行账号
        /// </summary>
        [JsonProperty("PayeeId")]
        public string PayeeId{ get; set; }

        /// <summary>
        /// 收款方姓名。支付宝可选；微信，平安模式下必传
        /// </summary>
        [JsonProperty("PayeeName")]
        public string PayeeName{ get; set; }

        /// <summary>
        /// 收款方附加信息，平安接入使用。需要以JSON格式提供以下字段：
        /// PayeeBankName：收款人开户行名称
        ///  CcyCode：货币类型（RMB-人民币）
        ///  UnionFlag：行内跨行标志（1：行内转账，0：跨行转账）。
        /// </summary>
        [JsonProperty("PayeeExtends")]
        public string PayeeExtends{ get; set; }

        /// <summary>
        /// 请求预留字段，原样透传返回
        /// </summary>
        [JsonProperty("ReqReserved")]
        public string ReqReserved{ get; set; }

        /// <summary>
        /// 业务备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 转账结果回调通知URL。若不填，则不进行回调。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填sandbox。
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "MerchantAppId", this.MerchantAppId);
            this.SetParamSimple(map, prefix + "TransferType", this.TransferType);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "TransferAmount", this.TransferAmount);
            this.SetParamSimple(map, prefix + "PayeeId", this.PayeeId);
            this.SetParamSimple(map, prefix + "PayeeName", this.PayeeName);
            this.SetParamSimple(map, prefix + "PayeeExtends", this.PayeeExtends);
            this.SetParamSimple(map, prefix + "ReqReserved", this.ReqReserved);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

