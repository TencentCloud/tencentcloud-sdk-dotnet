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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyConsoleNetworkRequest : AbstractModel
    {
        
        /// <summary>
        /// 云原生API网关实例ID。
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 网络类型：
        /// - Open 公网
        /// - Internal 内网（暂不支持）
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// 开启Konga网络，不填时默认为Open
        /// - Open，开启
        /// - Close，关闭
        /// </summary>
        [JsonProperty("Operate")]
        public string Operate{ get; set; }

        /// <summary>
        /// 访问控制策略
        /// </summary>
        [JsonProperty("AccessControl")]
        public NetworkAccessControl AccessControl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "Operate", this.Operate);
            this.SetParamObj(map, prefix + "AccessControl.", this.AccessControl);
        }
    }
}

