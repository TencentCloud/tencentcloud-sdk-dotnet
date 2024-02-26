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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrderFlowPackageRequest : AbstractModel
    {
        
        /// <summary>
        /// 流量包规格类型。可取值如下：
        /// DEVICE_1_FLOW_20G、DEVICE_2_FLOW_50G、
        /// DEVICE_3_FLOW_100G、
        /// DEVICE_5_FLOW_500G，分别代表20G、50G、100G、500G档位的流量包。
        /// 档位也影响流量包可绑定的设备数量上限：
        /// 20G：最多绑定1个设备
        /// 50G：最多绑定2个设备
        /// 100G：最多绑定3个设备
        /// 500G：最多绑定5个设备
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// 流量包绑定的设备ID列表。捆绑设备个数上限取决于包的规格档位：
        /// 20G：最多绑定1个设备
        /// 50G：最多绑定2个设备
        /// 100G：最多绑定3个设备
        /// 500G：最多绑定5个设备
        /// </summary>
        [JsonProperty("DeviceList")]
        public string[] DeviceList{ get; set; }

        /// <summary>
        /// 是否自动续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public bool? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 区域标识，0：国内，1：国外
        /// </summary>
        [JsonProperty("PackageRegion")]
        public long? PackageRegion{ get; set; }

        /// <summary>
        /// 是否自动选择代金券，默认false。
        /// 有多张券时的选择策略：按照可支付订单全部金额的券，先到期的券，可抵扣金额最大的券，余额最小的券，现金券 这个优先级进行扣券，且最多只抵扣一张券。
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public bool? AutoVoucher{ get; set; }

        /// <summary>
        /// 指定代金券ID。自动选择代金券时此参数无效。目前只允许传入一张代金券。
        /// 注：若指定的代金券不符合订单抵扣条件，则正常支付，不扣券
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamArraySimple(map, prefix + "DeviceList.", this.DeviceList);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "PackageRegion", this.PackageRegion);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
        }
    }
}

