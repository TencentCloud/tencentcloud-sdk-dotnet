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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigratePrivateIpAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// ECM 地域，形如ap-xian-ecm。
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }

        /// <summary>
        /// 当前内网IP绑定的弹性网卡实例ID，例如：eni-11112222。
        /// </summary>
        [JsonProperty("SourceNetworkInterfaceId")]
        public string SourceNetworkInterfaceId{ get; set; }

        /// <summary>
        /// 待迁移的目的弹性网卡实例ID。
        /// </summary>
        [JsonProperty("DestinationNetworkInterfaceId")]
        public string DestinationNetworkInterfaceId{ get; set; }

        /// <summary>
        /// 迁移的内网IP地址，例如：10.0.0.6。
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public string PrivateIpAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
            this.SetParamSimple(map, prefix + "SourceNetworkInterfaceId", this.SourceNetworkInterfaceId);
            this.SetParamSimple(map, prefix + "DestinationNetworkInterfaceId", this.DestinationNetworkInterfaceId);
            this.SetParamSimple(map, prefix + "PrivateIpAddress", this.PrivateIpAddress);
        }
    }
}

