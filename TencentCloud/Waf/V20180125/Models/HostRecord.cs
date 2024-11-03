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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostRecord : AbstractModel
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
        /// 主域名，入参时为空
        /// </summary>
        [JsonProperty("MainDomain")]
        public string MainDomain{ get; set; }

        /// <summary>
        /// 规则引擎防护模式。
        /// 0：观察模式
        /// 1：拦截模式
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// waf和负载均衡器的绑定关系。
        /// 0：未绑定
        /// 1：已绑定
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// clbwaf域名监听器状态。
        /// 0：操作成功
        /// 4：正在绑定LB
        /// 6：正在解绑LB 
        /// 7：解绑LB失败 
        /// 8：绑定LB失败 
        /// 10：内部错误
        /// </summary>
        [JsonProperty("State")]
        public ulong? State{ get; set; }

        /// <summary>
        /// 规则引擎和AI引擎防护模式联合状态。
        /// 1:初始状态,规则引擎拦截&&AI引擎未操作开关状态
        /// 10：规则引擎观察&&AI引擎关闭模式 
        /// 11：规则引擎观察&&AI引擎观察模式 
        /// 12：规则引擎观察&&AI引擎拦截模式 
        /// 20：规则引擎拦截&&AI引擎关闭模式 
        /// 21：规则引擎拦截&&AI引擎观察模式 
        /// 22：规则引擎拦截&&AI引擎拦截模式
        /// </summary>
        [JsonProperty("Engine")]
        public ulong? Engine{ get; set; }

        /// <summary>
        /// waf前是否部署有七层代理服务。 0：没有部署代理服务 1：有部署代理服务，waf将使用XFF获取客户端IP 2：有部署代理服务，waf将使用remote_addr获取客户端IP 3：有部署代理服务，waf将使用ip_headers中的自定义header获取客户端IP
        /// </summary>
        [JsonProperty("IsCdn")]
        public ulong? IsCdn{ get; set; }

        /// <summary>
        /// 绑定的负载均衡器信息列表
        /// </summary>
        [JsonProperty("LoadBalancerSet")]
        public LoadBalancer[] LoadBalancerSet{ get; set; }

        /// <summary>
        /// 域名绑定的LB的地域，以逗号分割多个地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 域名所属实例类型。负载均衡型WAF为"clb-waf"
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// 负载均衡型WAF域名的流量模式。
        /// 1：清洗模式
        /// 0：镜像模式
        /// </summary>
        [JsonProperty("FlowMode")]
        public ulong? FlowMode{ get; set; }

        /// <summary>
        /// 是否开启访问日志。
        /// 1：开启
        /// 0：关闭
        /// </summary>
        [JsonProperty("ClsStatus")]
        public ulong? ClsStatus{ get; set; }

        /// <summary>
        /// 防护等级，可选值100,200,300
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 域名需要下发到的cdc集群列表。仅CDC场景下填充
        /// </summary>
        [JsonProperty("CdcClusters")]
        public string[] CdcClusters{ get; set; }

        /// <summary>
        /// 应用型负载均衡类型，默认clb。 
        /// clb：七层负载均衡器类型 
        /// apisix：apisix网关型
        /// tsegw：云原生API网关
        /// scf：云函数
        /// </summary>
        [JsonProperty("AlbType")]
        public string AlbType{ get; set; }

        /// <summary>
        /// IsCdn=3时，需要填此参数，表示自定义header
        /// </summary>
        [JsonProperty("IpHeaders")]
        public string[] IpHeaders{ get; set; }

        /// <summary>
        /// 规则引擎类型。
        /// 1: menshen
        /// 2: tiga
        /// </summary>
        [JsonProperty("EngineType")]
        public long? EngineType{ get; set; }

        /// <summary>
        /// 云类型。
        /// public:公有云
        /// private:私有云
        /// hybrid:混合云
        /// </summary>
        [JsonProperty("CloudType")]
        public string CloudType{ get; set; }

        /// <summary>
        /// 域名备注信息
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "MainDomain", this.MainDomain);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "IsCdn", this.IsCdn);
            this.SetParamArrayObj(map, prefix + "LoadBalancerSet.", this.LoadBalancerSet);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "FlowMode", this.FlowMode);
            this.SetParamSimple(map, prefix + "ClsStatus", this.ClsStatus);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamArraySimple(map, prefix + "CdcClusters.", this.CdcClusters);
            this.SetParamSimple(map, prefix + "AlbType", this.AlbType);
            this.SetParamArraySimple(map, prefix + "IpHeaders.", this.IpHeaders);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "Note", this.Note);
        }
    }
}

