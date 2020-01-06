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

    public class QueryOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 聚鑫分配的支付主 MidasAppId
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 用户Id，长度不小于5位， 仅支持字母和数字的组合
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// type=by_order根据订单号 查订单；
        /// type=by_user根据用户id 查订单 。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 聚鑫分配的安全ID
        /// </summary>
        [JsonProperty("MidasSecretId")]
        public string MidasSecretId{ get; set; }

        /// <summary>
        /// 按照聚鑫安全密钥计算的签名
        /// </summary>
        [JsonProperty("MidasSignature")]
        public string MidasSignature{ get; set; }

        /// <summary>
        /// 每页返回的记录数。根据用户 号码查询订单列表时需要传。 用于分页展示。Type=by_order时必填
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 记录数偏移量，默认从0开 始。根据用户号码查询订单列 表时需要传。用于分页展示。Type=by_order时必填
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 查询开始时间，Unix时间戳。Type=by_order时必填
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询结束时间，Unix时间戳。Type=by_order时必填
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 业务订单号，OutTradeNo与 TransactionId不能同时为 空，都传优先使用 OutTradeNo
        /// </summary>
        [JsonProperty("OutTradeNo")]
        public string OutTradeNo{ get; set; }

        /// <summary>
        /// 聚鑫订单号，OutTradeNo与 TransactionId不能同时为 空，都传优先使用 OutTradeNo
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "MidasSecretId", this.MidasSecretId);
            this.SetParamSimple(map, prefix + "MidasSignature", this.MidasSignature);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "OutTradeNo", this.OutTradeNo);
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
        }
    }
}

