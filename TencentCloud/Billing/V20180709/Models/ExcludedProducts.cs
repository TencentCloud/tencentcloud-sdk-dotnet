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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExcludedProducts : AbstractModel
    {
        
        /// <summary>
        /// 不适用商品名称
        /// </summary>
        [JsonProperty("GoodsName")]
        public string GoodsName{ get; set; }

        /// <summary>
        /// postPay后付费/prePay预付费/riPay预留实例/空字符串或者"*"表示全部模式。
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GoodsName", this.GoodsName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
        }
    }
}

