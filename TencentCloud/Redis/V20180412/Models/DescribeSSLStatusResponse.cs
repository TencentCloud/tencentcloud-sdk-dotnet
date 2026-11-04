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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSSLStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>SSL 证书下载地址。</p>
        /// </summary>
        [JsonProperty("CertDownloadUrl")]
        public string CertDownloadUrl{ get; set; }

        /// <summary>
        /// <p>证书下载链接到期时间。</p>
        /// </summary>
        [JsonProperty("UrlExpiredTime")]
        public string UrlExpiredTime{ get; set; }

        /// <summary>
        /// <p>标识实例开启 SSL 功能。</p><ul><li>true：开启 。</li><li>false：关闭。</li></ul>
        /// </summary>
        [JsonProperty("SSLConfig")]
        public bool? SSLConfig{ get; set; }

        /// <summary>
        /// <p>标识实例是否支持 SSL特性。</p><ul><li>true：支持。</li><li>false：不支持。</li></ul>
        /// </summary>
        [JsonProperty("FeatureSupport")]
        public bool? FeatureSupport{ get; set; }

        /// <summary>
        /// <p>说明配置 SSL 的状态。</p><ul><li>1: 配置中。</li><li>2：配置成功。</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>地址类型</p><p>枚举值：</p><ul><li>0： 不限</li><li>1： 内网IPv4</li><li>2： 内网IPv6</li><li>3： 外网</li><li>-1： 未指定</li></ul>
        /// </summary>
        [JsonProperty("AddressType")]
        public long? AddressType{ get; set; }

        /// <summary>
        /// <p>当前加密连接地址</p>
        /// </summary>
        [JsonProperty("EncryptAddress")]
        public string EncryptAddress{ get; set; }

        /// <summary>
        /// <p>密钥来源</p><p>枚举值：</p><ul><li>0： 腾讯云提供</li><li>1： 自定义证书</li></ul>
        /// </summary>
        [JsonProperty("CertSource")]
        public ulong? CertSource{ get; set; }

        /// <summary>
        /// <p>证书有效性</p><p>枚举值：</p><ul><li>0： 有效</li><li>1： 即将过期（30天内）</li><li>2： 已过期</li><li>404： 证书已被删除</li><li>500： 查询异常</li></ul>
        /// </summary>
        [JsonProperty("CertStatus")]
        public ulong? CertStatus{ get; set; }

        /// <summary>
        /// <p>SSL 证书服务的证书 ID，CertSource=1 时必填</p>
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// <p>证书别名</p>
        /// </summary>
        [JsonProperty("CertAlias")]
        public string CertAlias{ get; set; }

        /// <summary>
        /// <p>证书到期时间</p><p>参数格式：时间格式YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("CertExpireTime")]
        public string CertExpireTime{ get; set; }

        /// <summary>
        /// <p>证书关联域名（SAN）</p><p>包括了IP</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>最低 TLS 版本</p><p>枚举值：</p><ul><li>TLSv1.0： TLSv1.0</li><li>TLSv1.1： TLSv1.1</li><li>TLSv1.2： TLSv1.2</li></ul>
        /// </summary>
        [JsonProperty("SSLMinVersion")]
        public string SSLMinVersion{ get; set; }

        /// <summary>
        /// <p>当前加密模式</p><p>枚举值：</p><ul><li>required： 强制加密</li><li>flexible： 兼容模式</li></ul>
        /// </summary>
        [JsonProperty("EncryptionMode")]
        public string EncryptionMode{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertDownloadUrl", this.CertDownloadUrl);
            this.SetParamSimple(map, prefix + "UrlExpiredTime", this.UrlExpiredTime);
            this.SetParamSimple(map, prefix + "SSLConfig", this.SSLConfig);
            this.SetParamSimple(map, prefix + "FeatureSupport", this.FeatureSupport);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamSimple(map, prefix + "EncryptAddress", this.EncryptAddress);
            this.SetParamSimple(map, prefix + "CertSource", this.CertSource);
            this.SetParamSimple(map, prefix + "CertStatus", this.CertStatus);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertAlias", this.CertAlias);
            this.SetParamSimple(map, prefix + "CertExpireTime", this.CertExpireTime);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SSLMinVersion", this.SSLMinVersion);
            this.SetParamSimple(map, prefix + "EncryptionMode", this.EncryptionMode);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

