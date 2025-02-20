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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanLog : AbstractModel
    {
        
        /// <summary>
        /// 行ID
        /// </summary>
        [JsonProperty("LogId")]
        public long? LogId{ get; set; }

        /// <summary>
        /// 微信openid
        /// </summary>
        [JsonProperty("Openid")]
        public string Openid{ get; set; }

        /// <summary>
        /// 微信昵称
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 码
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CorpId")]
        public long? CorpId{ get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// ip地址
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 县/区
        /// </summary>
        [JsonProperty("District")]
        public string District{ get; set; }

        /// <summary>
        /// 微信 unionid
        /// </summary>
        [JsonProperty("Unionid")]
        public string Unionid{ get; set; }

        /// <summary>
        /// 首次扫码 0:否, 1:是
        /// </summary>
        [JsonProperty("First")]
        public long? First{ get; set; }

        /// <summary>
        /// 批次ID
        /// </summary>
        [JsonProperty("BatchId")]
        public string BatchId{ get; set; }

        /// <summary>
        /// 扫码类型 0:无效扫码 1: 小程序扫码 2: 商家扫码
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonProperty("MerchantName")]
        public string MerchantName{ get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 产品Logo
        /// </summary>
        [JsonProperty("ProductLogo")]
        public string ProductLogo{ get; set; }

        /// <summary>
        /// 风险状态
        /// 0: 未知, 1:通过, 2:失败/风险, 3:存疑
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 是否开启验证
        /// 0:否, 1:是
        /// </summary>
        [JsonProperty("Verify")]
        public long? Verify{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogId", this.LogId);
            this.SetParamSimple(map, prefix + "Openid", this.Openid);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "CorpId", this.CorpId);
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "District", this.District);
            this.SetParamSimple(map, prefix + "Unionid", this.Unionid);
            this.SetParamSimple(map, prefix + "First", this.First);
            this.SetParamSimple(map, prefix + "BatchId", this.BatchId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "MerchantName", this.MerchantName);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ProductLogo", this.ProductLogo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Verify", this.Verify);
        }
    }
}

