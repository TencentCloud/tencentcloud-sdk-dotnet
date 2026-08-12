/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Delivery : AbstractModel
    {
        
        /// <summary>
        /// <p>物流方式</p><ul><li>physical：物理投送</li><li>electonic：电子投送</li></ul>
        /// </summary>
        [JsonProperty("DeliveryMethod")]
        public string DeliveryMethod{ get; set; }

        /// <summary>
        /// <p>物流费用</p>
        /// </summary>
        [JsonProperty("DeliveryAmount")]
        public Amount DeliveryAmount{ get; set; }

        /// <summary>
        /// <p>收货地址</p>
        /// </summary>
        [JsonProperty("DeliveryAddress")]
        public Address DeliveryAddress{ get; set; }

        /// <summary>
        /// <p>收货人电话</p><p>参数格式：符合E.164标准的带“+”、地区编码和号码的格式</p>
        /// </summary>
        [JsonProperty("ConsigneePhone")]
        public string ConsigneePhone{ get; set; }

        /// <summary>
        /// <p>收货人邮箱</p>
        /// </summary>
        [JsonProperty("ConsigneeEmail")]
        public string ConsigneeEmail{ get; set; }

        /// <summary>
        /// <p>收货人姓名</p>
        /// </summary>
        [JsonProperty("ConsigneeName")]
        public string ConsigneeName{ get; set; }

        /// <summary>
        /// <p>是否加急</p>
        /// </summary>
        [JsonProperty("Expedited")]
        public bool? Expedited{ get; set; }

        /// <summary>
        /// <p>物流厂商，一般是物流的公司</p>
        /// </summary>
        [JsonProperty("DeliveryCarrier")]
        public string DeliveryCarrier{ get; set; }

        /// <summary>
        /// <p>物流追踪单号</p>
        /// </summary>
        [JsonProperty("DeliveryTracking")]
        public string DeliveryTracking{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeliveryMethod", this.DeliveryMethod);
            this.SetParamObj(map, prefix + "DeliveryAmount.", this.DeliveryAmount);
            this.SetParamObj(map, prefix + "DeliveryAddress.", this.DeliveryAddress);
            this.SetParamSimple(map, prefix + "ConsigneePhone", this.ConsigneePhone);
            this.SetParamSimple(map, prefix + "ConsigneeEmail", this.ConsigneeEmail);
            this.SetParamSimple(map, prefix + "ConsigneeName", this.ConsigneeName);
            this.SetParamSimple(map, prefix + "Expedited", this.Expedited);
            this.SetParamSimple(map, prefix + "DeliveryCarrier", this.DeliveryCarrier);
            this.SetParamSimple(map, prefix + "DeliveryTracking", this.DeliveryTracking);
        }
    }
}

