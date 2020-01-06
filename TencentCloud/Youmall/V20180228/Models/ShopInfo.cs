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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ShopInfo : AbstractModel
    {
        
        /// <summary>
        /// 公司ID
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("ShopId")]
        public ulong? ShopId{ get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonProperty("ShopName")]
        public string ShopName{ get; set; }

        /// <summary>
        /// 客户门店编码
        /// </summary>
        [JsonProperty("ShopCode")]
        public string ShopCode{ get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "ShopId", this.ShopId);
            this.SetParamSimple(map, prefix + "ShopName", this.ShopName);
            this.SetParamSimple(map, prefix + "ShopCode", this.ShopCode);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
        }
    }
}

