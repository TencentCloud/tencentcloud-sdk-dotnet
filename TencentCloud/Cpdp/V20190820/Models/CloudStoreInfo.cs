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

    public class CloudStoreInfo : AbstractModel
    {
        
        /// <summary>
        /// 门店ID。
        /// </summary>
        [JsonProperty("StoreId")]
        public string StoreId{ get; set; }

        /// <summary>
        /// 门店名称。
        /// </summary>
        [JsonProperty("StoreName")]
        public string StoreName{ get; set; }

        /// <summary>
        /// 门店地址。
        /// </summary>
        [JsonProperty("StoreAddress")]
        public string StoreAddress{ get; set; }

        /// <summary>
        /// 门店地区代码。
        /// </summary>
        [JsonProperty("StoreAreaCode")]
        public string StoreAreaCode{ get; set; }

        /// <summary>
        /// 设备ID。
        /// wechat_ecommerce渠道 - h5支付方式，此字段必填。
        /// </summary>
        [JsonProperty("StoreDeviceId")]
        public string StoreDeviceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StoreId", this.StoreId);
            this.SetParamSimple(map, prefix + "StoreName", this.StoreName);
            this.SetParamSimple(map, prefix + "StoreAddress", this.StoreAddress);
            this.SetParamSimple(map, prefix + "StoreAreaCode", this.StoreAreaCode);
            this.SetParamSimple(map, prefix + "StoreDeviceId", this.StoreDeviceId);
        }
    }
}

