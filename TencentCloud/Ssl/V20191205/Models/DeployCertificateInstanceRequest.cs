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

    public class DeployCertificateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 待部署的证书ID
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// 证书部署的实例列表，不同云资源类型如下
        /// - clb：若监听器开启了SNI，则需要指定到域名LoadBalancerId|ListenerId|Domain，例：["lb-bid2fs4g|lbl-a8af11gs|tencent.com"]，若监听器未开启SNI或者为四层监听器，则指定到监听器，例：["lb-bid2fs4g|lbl-1c6rp5eo"]
        /// - cdn：Domain|计费开关，例：["cdn2.tencent.com|off", "cdn.tencent.com|on"]
        /// - ddos：InsId|Domain|VirtualPort，例：["bgpip-000001ms|tencent.com|443"]
        /// - live：Domain，例：["live1.tencent.com", "live2.tencent.com"]
        /// - vod：Domain， 例：["vod1.tencent.com", "vod2.tencent.com"]
        /// - waf：Domain， 例：["waf1.tencent.com", "waf2.tencent.com"]
        /// - apigateway：ServiceId|Domain， 例：["service-8sk7cqmd|apigw1.tencent.com", "service-8sk7cqmd|apigw2.ninghhuang.online"]
        /// - teo：Domain， 例：["edgeone1.tencent.com", "edgeone2.tencent.com"]
        /// - tke：ClusterId|NameSpace|SecretName， 例：["cls-42sa0ae0|default|test-tencent"]
        /// - cos：Region|Bucket|Domain， 例：["ap-hongkong|ssl-server-1251810746|tencent.com"]
        /// - lighthouse：Region|InstanceId|Domain， 例：["ap-shanghai|lhins-nh7lql34|tencent.com"]
        /// - tse：GatewayId|CertificateId， 例：["gateway-s1da9151|fa61bc05-cc54-4eea-c932-24de52577372"]
        /// - tcb：Type|Region|EnvId|Domain， 例：["AccessService|ap-shanghai|ceshi-4s5h0ymg11c839c7|tencent.com"]
        /// </summary>
        [JsonProperty("InstanceIdList")]
        public string[] InstanceIdList{ get; set; }

        /// <summary>
        /// 证书部署云资源支持的云资源类型， 不传则默认部署clb：
        /// - clb
        /// - cdn
        /// - ddos
        /// - live
        /// - vod
        /// - waf
        /// - apigateway
        /// - teo
        /// - tke
        /// - cos
        /// - lighthouse
        /// - tse
        /// - tcb
        /// <dx-alert infotype="explain" title="">当云资源类型传入clb、waf、apigateway、cos、lighthouse、tke、tse、tcb 时，公共参数Region必传。</dx-alert>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 部署云资源状态：
        /// 云直播：
        /// -1：域名未关联证书。
        /// 1： 域名https已开启。
        /// 0： 域名https已关闭。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 是否查询缓存，1：是； 0：否， 默认为查询缓存，默认缓存半小时
        /// </summary>
        [JsonProperty("IsCache")]
        public ulong? IsCache{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamArraySimple(map, prefix + "InstanceIdList.", this.InstanceIdList);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsCache", this.IsCache);
        }
    }
}

