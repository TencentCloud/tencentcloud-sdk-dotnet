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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateCertificateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 一键更新原证书ID， 查询绑定该证书的云资源然后进行证书更新
        /// </summary>
        [JsonProperty("OldCertificateId")]
        public string OldCertificateId{ get; set; }

        /// <summary>
        /// 需要部署的资源类型，参数值可选（小写）：clb、cdn、waf、live、ddos、teo、apigateway、vod、tke、tcb、tse
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public string[] ResourceTypes{ get; set; }

        /// <summary>
        /// 一键更新新证书ID，不传该则证书公钥和私钥必传
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// 需要部署的地域列表（废弃）
        /// </summary>
        [JsonProperty("Regions")]
        [System.Obsolete]
        public string[] Regions{ get; set; }

        /// <summary>
        /// 云资源需要部署的地域列表，支持地域的云资源类型必传，如：clb、tke、apigateway、waf、tcb、tse等
        /// </summary>
        [JsonProperty("ResourceTypesRegions")]
        public ResourceTypeRegions[] ResourceTypesRegions{ get; set; }

        /// <summary>
        /// 证书公钥， 若上传证书公钥， 则CertificateId不用传
        /// </summary>
        [JsonProperty("CertificatePublicKey")]
        public string CertificatePublicKey{ get; set; }

        /// <summary>
        /// 证书私钥，若上传证书公钥， 则CertificateId不用传
        /// </summary>
        [JsonProperty("CertificatePrivateKey")]
        public string CertificatePrivateKey{ get; set; }

        /// <summary>
        /// 旧证书是否忽略到期提醒  0:不忽略通知。1:忽略通知，忽略OldCertificateId到期提醒
        /// </summary>
        [JsonProperty("ExpiringNotificationSwitch")]
        public ulong? ExpiringNotificationSwitch{ get; set; }

        /// <summary>
        /// 相同的证书是否允许重复上传，若选择上传证书， 则可以配置该参数
        /// </summary>
        [JsonProperty("Repeatable")]
        public bool? Repeatable{ get; set; }

        /// <summary>
        /// 是否允许下载，若选择上传证书， 则可以配置该参数
        /// </summary>
        [JsonProperty("AllowDownload")]
        public bool? AllowDownload{ get; set; }

        /// <summary>
        /// 标签列表，若选择上传证书， 则可以配置该参数
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// 项目 ID，若选择上传证书， 则可以配置该参数
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OldCertificateId", this.OldCertificateId);
            this.SetParamArraySimple(map, prefix + "ResourceTypes.", this.ResourceTypes);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamArraySimple(map, prefix + "Regions.", this.Regions);
            this.SetParamArrayObj(map, prefix + "ResourceTypesRegions.", this.ResourceTypesRegions);
            this.SetParamSimple(map, prefix + "CertificatePublicKey", this.CertificatePublicKey);
            this.SetParamSimple(map, prefix + "CertificatePrivateKey", this.CertificatePrivateKey);
            this.SetParamSimple(map, prefix + "ExpiringNotificationSwitch", this.ExpiringNotificationSwitch);
            this.SetParamSimple(map, prefix + "Repeatable", this.Repeatable);
            this.SetParamSimple(map, prefix + "AllowDownload", this.AllowDownload);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
        }
    }
}

