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

    public class OpenBankGoodsInfo : AbstractModel
    {
        
        /// <summary>
        /// 商品标题。默认值“商品支付”。
        /// </summary>
        [JsonProperty("GoodsName")]
        public string GoodsName{ get; set; }

        /// <summary>
        /// 商品详细描述（商品列表）。
        /// </summary>
        [JsonProperty("GoodsDetail")]
        public string GoodsDetail{ get; set; }

        /// <summary>
        /// 银行附言。不可以有以下字符：<>+{}()%*&';"[]等特殊符号
        /// </summary>
        [JsonProperty("GoodsDescription")]
        public string GoodsDescription{ get; set; }

        /// <summary>
        /// 业务类型。汇付渠道必填，汇付渠道传入固定值100099。
        /// </summary>
        [JsonProperty("GoodsBizType")]
        public string GoodsBizType{ get; set; }

        /// <summary>
        /// 商品编号。
        /// </summary>
        [JsonProperty("Sku")]
        public string Sku{ get; set; }

        /// <summary>
        /// 商品单价。
        /// </summary>
        [JsonProperty("Price")]
        public string Price{ get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("Quantity")]
        public string Quantity{ get; set; }

        /// <summary>
        /// 商品图片url
        /// </summary>
        [JsonProperty("ProductImage")]
        public string ProductImage{ get; set; }

        /// <summary>
        /// 商品链接url
        /// </summary>
        [JsonProperty("ProductUrl")]
        public string ProductUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GoodsName", this.GoodsName);
            this.SetParamSimple(map, prefix + "GoodsDetail", this.GoodsDetail);
            this.SetParamSimple(map, prefix + "GoodsDescription", this.GoodsDescription);
            this.SetParamSimple(map, prefix + "GoodsBizType", this.GoodsBizType);
            this.SetParamSimple(map, prefix + "Sku", this.Sku);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "Quantity", this.Quantity);
            this.SetParamSimple(map, prefix + "ProductImage", this.ProductImage);
            this.SetParamSimple(map, prefix + "ProductUrl", this.ProductUrl);
        }
    }
}

