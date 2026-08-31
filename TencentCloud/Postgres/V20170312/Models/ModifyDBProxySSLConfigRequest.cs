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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBProxySSLConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，指定要修改 SSL 配置的数据库代理所属的目标实例
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// 代理组 ID，指定要修改 SSL 配置的代理组
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// 代理地址 ID，指定要修改 SSL 配置的代理连接地址
        /// </summary>
        [JsonProperty("ProxyAddressId")]
        public string ProxyAddressId{ get; set; }

        /// <summary>
        /// SSL 开关。true：开启 SSL；false：关闭 SSL
        /// </summary>
        [JsonProperty("SSLEnabled")]
        public bool? SSLEnabled{ get; set; }

        /// <summary>
        /// 连接地址。SSLEnabled 为 true 时必填，需与代理地址的 Vip 保持一致，用于 SSL 证书校验
        /// </summary>
        [JsonProperty("ConnectAddress")]
        public string ConnectAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamSimple(map, prefix + "ProxyAddressId", this.ProxyAddressId);
            this.SetParamSimple(map, prefix + "SSLEnabled", this.SSLEnabled);
            this.SetParamSimple(map, prefix + "ConnectAddress", this.ConnectAddress);
        }
    }
}

