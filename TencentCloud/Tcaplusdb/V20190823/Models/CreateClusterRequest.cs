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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群数据描述语言类型，统一填<code>MIX</code></p><p>枚举值：</p><ul><li>MIX： 同时支持<code>PROTO</code>，<code>TDR</code>表</li></ul>
        /// </summary>
        [JsonProperty("IdlType")]
        public string IdlType{ get; set; }

        /// <summary>
        /// <p>集群名称，可使用中文或英文字符，最大长度32个字符</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>集群所绑定的私有网络实例ID，形如：vpc-f49l6u0z</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>集群所绑定的子网实例ID，形如：subnet-pxir56ns</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>集群访问密码，必须是a-zA-Z0-9的字符,且必须包含数字和大小写字母</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>集群标签列表</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public TagInfoUnit[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>集群是否开启IPv6功能</p>
        /// </summary>
        [JsonProperty("Ipv6Enable")]
        public long? Ipv6Enable{ get; set; }

        /// <summary>
        /// <p>独占集群占用的svr机器</p>
        /// </summary>
        [JsonProperty("ServerList")]
        public MachineInfo[] ServerList{ get; set; }

        /// <summary>
        /// <p>独占集群占用的proxy机器</p>
        /// </summary>
        [JsonProperty("ProxyList")]
        public MachineInfo[] ProxyList{ get; set; }

        /// <summary>
        /// <p>集群类型1共享2独占</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public long? ClusterType{ get; set; }

        /// <summary>
        /// <p>密码认证类型，0 静态认证， 1 签名认证</p>
        /// </summary>
        [JsonProperty("AuthType")]
        public long? AuthType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdlType", this.IdlType);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "Ipv6Enable", this.Ipv6Enable);
            this.SetParamArrayObj(map, prefix + "ServerList.", this.ServerList);
            this.SetParamArrayObj(map, prefix + "ProxyList.", this.ProxyList);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
        }
    }
}

