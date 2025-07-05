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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisassociateAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// ECM 地域
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }

        /// <summary>
        /// 标识 EIP 的唯一 ID。EIP 唯一 ID 形如：eip-11112222。
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// 表示解绑 EIP 之后是否分配普通公网 IP。取值范围：
        /// TRUE：表示解绑 EIP 之后分配普通公网 IP。
        /// FALSE：表示解绑 EIP 之后不分配普通公网 IP。
        /// 默认取值：FALSE。
        /// 
        /// 只有满足以下条件时才能指定该参数：
        /// 只有在解绑主网卡的主内网 IP 上的 EIP 时才能指定该参数。
        /// 解绑 EIP 后重新分配普通公网 IP 操作一个账号每天最多操作 10 次；详情可通过 DescribeAddressQuota 接口获取。
        /// </summary>
        [JsonProperty("ReallocateNormalPublicIp")]
        public bool? ReallocateNormalPublicIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
            this.SetParamSimple(map, prefix + "AddressId", this.AddressId);
            this.SetParamSimple(map, prefix + "ReallocateNormalPublicIp", this.ReallocateNormalPublicIp);
        }
    }
}

