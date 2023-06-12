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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Origin : AbstractModel
    {
        
        /// <summary>
        /// 主源站列表
        /// <font color=red>修改源站时，需要同时填充对应的 OriginType</font>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Origins")]
        public string[] Origins{ get; set; }

        /// <summary>
        /// 主源站类型
        /// <font color=red>当源站列表 Origins 不为空时必填</font>
        /// 入参支持以下几种类型：
        /// domain：域名类型
        /// domainv6：域名解析V6类型
        /// cos：对象存储源站
        /// third_party: 第三方存储源站
        /// igtm: IGTM多活源
        /// ip：IP 列表作为源站
        /// ipv6：源站列表为一个单独的 IPv6 地址
        /// ip_ipv6：源站列表为多个 IPv4 地址和IPv6 地址
        /// ip_domain: 支持IP和域名形式源站混填（白名单功能）
        /// ip_domainv6：源站列表为多个 IPv4 地址以及域名解析v6地址
        /// ipv6_domain: 源站列表为多个 IPv6 地址以及域名
        /// ipv6_domainv6：源站列表为多个 IPv6 地址以及域名解析v6地址
        /// domain_domainv6：源站列表为多个域名解析v4 地址以及域名解析v6地址
        /// ip_ipv6_domain：源站列表为多个 IPv4 地址IPv6 地址以及域名
        /// ip_ipv6_domainv6：源站列表为多个 IPv4 地址IPv6 地址以及域名解析v6地址
        /// ip_domain_domainv6：源站列表为多个 IPv4 地址域名解析v4 地址以及域名解析v6地址
        /// ipv6_domain_domainv6：源站列表为多个 域名解析v4 地址IPv6 地址以及域名解析v6地址
        /// ip_ipv6_domain_domainv6：源站列表为多个 IPv4 地址IPv6 地址 域名解析v4 地址以及域名解析v6地址
        /// 出参增加以下几种类型：
        /// image：数据万象源站
        /// ftp：历史 FTP 托管源源站，现已不维护
        /// 修改 Origins 时需要同时填充对应的 OriginType
        /// IPv6 功能目前尚未全量，需要先申请试用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// 回主源站时 Host 头部
        /// <font color=red>当源站类型为cos或者第三方存储加速时,ServerName字段必填</font>
        /// 不填充则默认为加速域名
        /// 若接入的是泛域名，则回源 Host 默认为访问时的子域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// OriginType 为对象存储（COS）时，可以指定是否允许访问私有 bucket
        /// 注意：需要先授权 CDN 访问该私有 Bucket 的权限后，才可开启此配置。取值范围: on/off
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosPrivateAccess")]
        public string CosPrivateAccess{ get; set; }

        /// <summary>
        /// 回源协议配置
        /// http：强制 http 回源
        /// follow：协议跟随回源
        /// https：强制 https 回源，https 回源时仅支持源站 443 端口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginPullProtocol")]
        public string OriginPullProtocol{ get; set; }

        /// <summary>
        /// 备源站列表
        /// <font color=red>修改备源站时，需要同时填充对应的 BackupOriginType</font>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupOrigins")]
        public string[] BackupOrigins{ get; set; }

        /// <summary>
        /// 备源站类型
        /// <font color=red>备源站列表BackupOrigins 不为空时必填</font>
        /// 支持以下类型：
        /// domain：域名类型
        /// ip：IP 列表作为源站
        /// 以下备源源站类型尚未全量支持，需要申请试用：
        /// ipv6_domain: 源站列表为多个 IPv6 地址以及域名
        /// ip_ipv6：源站列表为多个 IPv4 地址和IPv6 地址
        /// ipv6_domain: 源站列表为多个 IPv6 地址以及域名
        /// ip_ipv6_domain：源站列表为多个 IPv4 地址IPv6 地址以及域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupOriginType")]
        public string BackupOriginType{ get; set; }

        /// <summary>
        /// 回备源站时 Host 头部，不填充则默认为主源站的 ServerName
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupServerName")]
        public string BackupServerName{ get; set; }

        /// <summary>
        /// 回源路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasePath")]
        public string BasePath{ get; set; }

        /// <summary>
        /// 回源路径重写规则配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PathRules")]
        public PathRule[] PathRules{ get; set; }

        /// <summary>
        /// 分路径回源配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PathBasedOrigin")]
        public PathBasedOriginRule[] PathBasedOrigin{ get; set; }

        /// <summary>
        /// HTTPS回源SNI配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sni")]
        public OriginSni Sni{ get; set; }

        /// <summary>
        /// HTTPS回源高级配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdvanceHttps")]
        public AdvanceHttps AdvanceHttps{ get; set; }

        /// <summary>
        /// 对象存储回源厂商
        /// <font color=red>当源站类型为第三方存储源站(third_party)时必填</font>
        /// 可选值包括以下:
        /// aws_s3: AWS S3
        /// ali_oss: 阿里云 OSS
        /// hw_obs: 华为 OBS
        /// qiniu_kodo: 七牛云 kodo
        /// others: 其它厂商对象存储,仅支持兼容以AWS签名算法的对象存储，如腾讯云金融专区COS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginCompany")]
        public string OriginCompany{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Origins.", this.Origins);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "CosPrivateAccess", this.CosPrivateAccess);
            this.SetParamSimple(map, prefix + "OriginPullProtocol", this.OriginPullProtocol);
            this.SetParamArraySimple(map, prefix + "BackupOrigins.", this.BackupOrigins);
            this.SetParamSimple(map, prefix + "BackupOriginType", this.BackupOriginType);
            this.SetParamSimple(map, prefix + "BackupServerName", this.BackupServerName);
            this.SetParamSimple(map, prefix + "BasePath", this.BasePath);
            this.SetParamArrayObj(map, prefix + "PathRules.", this.PathRules);
            this.SetParamArrayObj(map, prefix + "PathBasedOrigin.", this.PathBasedOrigin);
            this.SetParamObj(map, prefix + "Sni.", this.Sni);
            this.SetParamObj(map, prefix + "AdvanceHttps.", this.AdvanceHttps);
            this.SetParamSimple(map, prefix + "OriginCompany", this.OriginCompany);
        }
    }
}

