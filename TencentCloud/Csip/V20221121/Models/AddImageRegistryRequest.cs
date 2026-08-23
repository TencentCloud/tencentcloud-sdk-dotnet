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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddImageRegistryRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>镜像仓库名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>镜像仓库账号</p>
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// <p>镜像仓库密码</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>镜像仓库url</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>镜像仓库类型</p><p>枚举值：</p><ul><li>tcr： tcr类型仓库</li><li>ccr： ccr类型仓库</li><li>harbor： harbor类型仓库</li><li>jfrog： jfrog类型仓库</li><li>quay： quay类型仓库</li><li>aws： aws类型仓库</li><li>azure： azure类型仓库</li></ul>
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// <p>网络类型</p><p>枚举值：</p><ul><li>public： 公网</li><li>空： 内网，默认值</li></ul>
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// <p>api版本</p>
        /// </summary>
        [JsonProperty("RegistryVersion")]
        public string RegistryVersion{ get; set; }

        /// <summary>
        /// <p>镜像仓库所在region</p>
        /// </summary>
        [JsonProperty("RegistryRegion")]
        public string RegistryRegion{ get; set; }

        /// <summary>
        /// <p>访问限速值</p>
        /// </summary>
        [JsonProperty("SpeedLimit")]
        public ulong? SpeedLimit{ get; set; }

        /// <summary>
        /// <p>是否忽略证书</p><p>枚举值：</p><ul><li>0： 验证证书</li><li>1： 忽略证书</li></ul>
        /// </summary>
        [JsonProperty("Insecure")]
        public ulong? Insecure{ get; set; }

        /// <summary>
        /// <p>是否立即同步</p>
        /// </summary>
        [JsonProperty("NeedScan")]
        public bool? NeedScan{ get; set; }

        /// <summary>
        /// <p>同步模式，0-全量同步</p>
        /// </summary>
        [JsonProperty("SyncMode")]
        public ulong? SyncMode{ get; set; }

        /// <summary>
        /// <p>镜像仓库实例id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>扫描使用的链接配置</p>
        /// </summary>
        [JsonProperty("ConnectivityDetectConfig")]
        public ConnectivityDetectConfig[] ConnectivityDetectConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "RegistryType", this.RegistryType);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "RegistryVersion", this.RegistryVersion);
            this.SetParamSimple(map, prefix + "RegistryRegion", this.RegistryRegion);
            this.SetParamSimple(map, prefix + "SpeedLimit", this.SpeedLimit);
            this.SetParamSimple(map, prefix + "Insecure", this.Insecure);
            this.SetParamSimple(map, prefix + "NeedScan", this.NeedScan);
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "ConnectivityDetectConfig.", this.ConnectivityDetectConfig);
        }
    }
}

