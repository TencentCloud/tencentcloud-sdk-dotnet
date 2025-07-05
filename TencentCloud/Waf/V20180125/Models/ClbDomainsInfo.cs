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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClbDomainsInfo : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 域名唯一ID
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// 域名所属实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 域名所属实例名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 域名所属实例类型
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// waf前是否部署有七层代理服务。 0：没有部署代理服务 1：有部署代理服务，waf将使用XFF获取客户端IP 2：有部署代理服务，waf将使用remote_addr获取客户端IP 3：有部署代理服务，waf将使用ip_headers中的自定义header获取客户端IP
        /// </summary>
        [JsonProperty("IsCdn")]
        public ulong? IsCdn{ get; set; }

        /// <summary>
        /// 负载均衡类型为clb时，对应的负载均衡器信息
        /// </summary>
        [JsonProperty("LoadBalancerSet")]
        public LoadBalancerPackageNew[] LoadBalancerSet{ get; set; }

        /// <summary>
        /// 负载均衡型WAF的流量模式，1：清洗模式，0：镜像模式
        /// </summary>
        [JsonProperty("FlowMode")]
        public ulong? FlowMode{ get; set; }

        /// <summary>
        /// 域名绑定负载均衡器状态
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// 负载均衡类型，clb或者apisix
        /// </summary>
        [JsonProperty("AlbType")]
        public string AlbType{ get; set; }

        /// <summary>
        /// IsCdn=3时，表示自定义header
        /// </summary>
        [JsonProperty("IpHeaders")]
        public string[] IpHeaders{ get; set; }

        /// <summary>
        /// cdc-clb-waf类型WAF的CDC集群信息
        /// </summary>
        [JsonProperty("CdcClusters")]
        public string CdcClusters{ get; set; }

        /// <summary>
        /// 云类型:public:公有云；private:私有云;hybrid:混合云
        /// </summary>
        [JsonProperty("CloudType")]
        public string CloudType{ get; set; }

        /// <summary>
        /// 域名备注信息
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// 域名标签
        /// </summary>
        [JsonProperty("Labels")]
        public string[] Labels{ get; set; }

        /// <summary>
        /// clbwaf接入状态，0代表“尚无流量接入”，1代表“流量接入”，2代表“CLB监听器已注销”，3代表“配置生效中”，4代表“配置下发失败中”
        /// </summary>
        [JsonProperty("AccessStatus")]
        public long? AccessStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "IsCdn", this.IsCdn);
            this.SetParamArrayObj(map, prefix + "LoadBalancerSet.", this.LoadBalancerSet);
            this.SetParamSimple(map, prefix + "FlowMode", this.FlowMode);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "AlbType", this.AlbType);
            this.SetParamArraySimple(map, prefix + "IpHeaders.", this.IpHeaders);
            this.SetParamSimple(map, prefix + "CdcClusters", this.CdcClusters);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamArraySimple(map, prefix + "Labels.", this.Labels);
            this.SetParamSimple(map, prefix + "AccessStatus", this.AccessStatus);
        }
    }
}

