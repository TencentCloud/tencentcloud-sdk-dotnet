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

    public class DomainInfo : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 域名ID
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// cname地址
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// 域名所属实例类型。
        /// sparta-waf：SaaS型WAF实例
        /// clb-waf：负载均衡型WAF实例
        /// cdc-clb-waf：CDC环境下负载均衡型WAF实例
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// 地域。
        /// "多伦多": "ca"
        /// "广州": "gz"
        /// "成都": "cd"
        /// "福州": "fzec"
        /// "深圳": "szx"
        /// "印度": "in"
        /// "济南": "jnec"
        /// "重庆": "cq"
        /// "天津": "tsn"
        /// "欧洲东北": "ru"
        /// "南京": "nj"
        /// "美国硅谷": "usw"
        /// "泰国": "th"
        /// "广州Open": "gzopen"
        /// "深圳金融": "szjr"
        /// "法兰克福": "de"
        /// "日本": "jp"
        /// "弗吉尼亚": "use"
        /// "北京": "bj"
        /// "中国香港": "hk"
        /// "杭州": "hzec"
        /// "北京金融": "bjjr"
        /// "上海金融": "shjr"
        /// "台北": "tpe"
        /// "首尔": "kr"
        /// "上海": "sh"
        /// "新加坡": "sg"
        /// "清远": "qy"
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 实例名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 访问日志开关状态。
        /// 0：关闭
        /// 1：开启
        /// </summary>
        [JsonProperty("ClsStatus")]
        public ulong? ClsStatus{ get; set; }

        /// <summary>
        /// 负载均衡型WAF使用模式。
        /// 0：镜像模式 
        /// 1：清洗模式
        /// </summary>
        [JsonProperty("FlowMode")]
        public ulong? FlowMode{ get; set; }

        /// <summary>
        /// waf开关状态。
        /// 0：关闭 
        /// 1：开启
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 规则引擎防护模式。
        /// 0：观察模式 
        /// 1：拦截模式
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

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
        /// 沙箱集群回源出口IP列表
        /// </summary>
        [JsonProperty("CCList")]
        public string[] CCList{ get; set; }

        /// <summary>
        /// 生产集群回源出口IP列表
        /// </summary>
        [JsonProperty("RsList")]
        public string[] RsList{ get; set; }

        /// <summary>
        /// 服务端口配置
        /// </summary>
        [JsonProperty("Ports")]
        public PortInfo[] Ports{ get; set; }

        /// <summary>
        /// 负载均衡器相关配置
        /// </summary>
        [JsonProperty("LoadBalancerSet")]
        public LoadBalancerPackageNew[] LoadBalancerSet{ get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 负载均衡型WAF域名LB监听器状态。
        /// 0：操作成功 
        /// 4：正在绑定LB 
        /// 6：正在解绑LB 
        /// 7：解绑LB失败 
        /// 8：绑定LB失败 
        /// 10：内部错误
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Ipv6开关状态。
        /// 0：关闭 
        /// 1：开启
        /// </summary>
        [JsonProperty("Ipv6Status")]
        public long? Ipv6Status{ get; set; }

        /// <summary>
        /// BOT开关状态。
        /// 0：关闭 
        /// 1：关闭
        /// 2：开启
        /// 3：开启
        /// </summary>
        [JsonProperty("BotStatus")]
        public long? BotStatus{ get; set; }

        /// <summary>
        /// 实例版本信息。
        /// 101：小微敏捷版 
        /// 102：小微超轻版
        /// 2：高级版
        /// 3：企业版
        /// 4：旗舰版
        /// 6：独享版
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 投递CLS状态。
        /// 0：关闭 
        /// 1：开启
        /// </summary>
        [JsonProperty("PostCLSStatus")]
        public long? PostCLSStatus{ get; set; }

        /// <summary>
        /// 投递CKafka状态。
        /// 0：关闭 
        /// 1：开启
        /// </summary>
        [JsonProperty("PostCKafkaStatus")]
        public long? PostCKafkaStatus{ get; set; }

        /// <summary>
        /// cdc实例域名接入的集群信息,非cdc实例忽略。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CdcClusters")]
        public string CdcClusters{ get; set; }

        /// <summary>
        /// api安全开关状态。
        /// 0：关闭 
        /// 1：开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiStatus")]
        public long? ApiStatus{ get; set; }

        /// <summary>
        /// 应用型负载均衡类型，默认clb。
        /// clb：七层负载均衡器类型
        /// apisix：apisix网关型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlbType")]
        public string AlbType{ get; set; }

        /// <summary>
        /// 安全组状态。
        /// 0：不展示
        /// 1：非腾讯云源站
        /// 2：安全组绑定失败
        /// 3：安全组发生变更
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SgState")]
        public long? SgState{ get; set; }

        /// <summary>
        /// 安全组状态的详细解释
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SgDetail")]
        public string SgDetail{ get; set; }

        /// <summary>
        /// 域名云环境。hybrid：混合云域名
        /// public：公有云域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloudType")]
        public string CloudType{ get; set; }

        /// <summary>
        /// 域名备注信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// SAASWAF源站IP列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcList")]
        public string[] SrcList{ get; set; }

        /// <summary>
        /// SAASWAF源站域名列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpstreamDomainList")]
        public string[] UpstreamDomainList{ get; set; }

        /// <summary>
        /// 安全组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SgID")]
        public string SgID{ get; set; }

        /// <summary>
        /// clbwaf接入状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessStatus")]
        public long? AccessStatus{ get; set; }

        /// <summary>
        /// 域名标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Labels")]
        public string[] Labels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ClsStatus", this.ClsStatus);
            this.SetParamSimple(map, prefix + "FlowMode", this.FlowMode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamArraySimple(map, prefix + "CCList.", this.CCList);
            this.SetParamArraySimple(map, prefix + "RsList.", this.RsList);
            this.SetParamArrayObj(map, prefix + "Ports.", this.Ports);
            this.SetParamArrayObj(map, prefix + "LoadBalancerSet.", this.LoadBalancerSet);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Ipv6Status", this.Ipv6Status);
            this.SetParamSimple(map, prefix + "BotStatus", this.BotStatus);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "PostCLSStatus", this.PostCLSStatus);
            this.SetParamSimple(map, prefix + "PostCKafkaStatus", this.PostCKafkaStatus);
            this.SetParamSimple(map, prefix + "CdcClusters", this.CdcClusters);
            this.SetParamSimple(map, prefix + "ApiStatus", this.ApiStatus);
            this.SetParamSimple(map, prefix + "AlbType", this.AlbType);
            this.SetParamSimple(map, prefix + "SgState", this.SgState);
            this.SetParamSimple(map, prefix + "SgDetail", this.SgDetail);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamArraySimple(map, prefix + "SrcList.", this.SrcList);
            this.SetParamArraySimple(map, prefix + "UpstreamDomainList.", this.UpstreamDomainList);
            this.SetParamSimple(map, prefix + "SgID", this.SgID);
            this.SetParamSimple(map, prefix + "AccessStatus", this.AccessStatus);
            this.SetParamArraySimple(map, prefix + "Labels.", this.Labels);
        }
    }
}

