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

    public class DomainInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>域名ID</p>
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>cname地址</p>
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// <p>域名所属实例类型。<br>sparta-waf：SaaS型WAF实例<br>clb-waf：负载均衡型WAF实例<br>cdc-clb-waf：CDC环境下负载均衡型WAF实例</p>
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// <p>地域。<br>&quot;多伦多&quot;: &quot;ca&quot;<br>&quot;广州&quot;: &quot;gz&quot;<br>&quot;成都&quot;: &quot;cd&quot;<br>&quot;福州&quot;: &quot;fzec&quot;<br>&quot;深圳&quot;: &quot;szx&quot;<br>&quot;印度&quot;: &quot;in&quot;<br>&quot;济南&quot;: &quot;jnec&quot;<br>&quot;重庆&quot;: &quot;cq&quot;<br>&quot;天津&quot;: &quot;tsn&quot;<br>&quot;欧洲东北&quot;: &quot;ru&quot;<br>&quot;南京&quot;: &quot;nj&quot;<br>&quot;美国硅谷&quot;: &quot;usw&quot;<br>&quot;泰国&quot;: &quot;th&quot;<br>&quot;广州Open&quot;: &quot;gzopen&quot;<br>&quot;深圳金融&quot;: &quot;szjr&quot;<br>&quot;法兰克福&quot;: &quot;de&quot;<br>&quot;日本&quot;: &quot;jp&quot;<br>&quot;弗吉尼亚&quot;: &quot;use&quot;<br>&quot;北京&quot;: &quot;bj&quot;<br>&quot;中国香港&quot;: &quot;hk&quot;<br>&quot;杭州&quot;: &quot;hzec&quot;<br>&quot;北京金融&quot;: &quot;bjjr&quot;<br>&quot;上海金融&quot;: &quot;shjr&quot;<br>&quot;台北&quot;: &quot;tpe&quot;<br>&quot;首尔&quot;: &quot;kr&quot;<br>&quot;上海&quot;: &quot;sh&quot;<br>&quot;新加坡&quot;: &quot;sg&quot;<br>&quot;清远&quot;: &quot;qy&quot;</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>实例名</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>访问日志开关状态。<br>0：关闭<br>1：开启</p>
        /// </summary>
        [JsonProperty("ClsStatus")]
        public ulong? ClsStatus{ get; set; }

        /// <summary>
        /// <p>负载均衡型WAF使用模式。<br>0：镜像模式<br>1：清洗模式</p>
        /// </summary>
        [JsonProperty("FlowMode")]
        public ulong? FlowMode{ get; set; }

        /// <summary>
        /// <p>waf开关状态。<br>0：关闭<br>1：开启</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>规则引擎防护模式。<br>0：观察模式<br>1：拦截模式</p>
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// <p>规则引擎和AI引擎防护模式联合状态。<br>1:初始状态,规则引擎拦截&amp;&amp;AI引擎未操作开关状态<br>10：规则引擎观察&amp;&amp;AI引擎关闭模式<br>11：规则引擎观察&amp;&amp;AI引擎观察模式<br>12：规则引擎观察&amp;&amp;AI引擎拦截模式<br>20：规则引擎拦截&amp;&amp;AI引擎关闭模式<br>21：规则引擎拦截&amp;&amp;AI引擎观察模式<br>22：规则引擎拦截&amp;&amp;AI引擎拦截模式</p>
        /// </summary>
        [JsonProperty("Engine")]
        public ulong? Engine{ get; set; }

        /// <summary>
        /// <p>沙箱集群回源出口IP列表</p>
        /// </summary>
        [JsonProperty("CCList")]
        public string[] CCList{ get; set; }

        /// <summary>
        /// <p>生产集群回源出口IP列表</p>
        /// </summary>
        [JsonProperty("RsList")]
        public string[] RsList{ get; set; }

        /// <summary>
        /// <p>服务端口配置</p>
        /// </summary>
        [JsonProperty("Ports")]
        public PortInfo[] Ports{ get; set; }

        /// <summary>
        /// <p>负载均衡器相关配置</p>
        /// </summary>
        [JsonProperty("LoadBalancerSet")]
        public LoadBalancerPackageNew[] LoadBalancerSet{ get; set; }

        /// <summary>
        /// <p>用户id</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>SAAS型WAF域名状态：<br>-2：配置下发失败<br>-1：配置下发中<br>0：DNS解析中<br>1：无DNS解析记录，请接入WAF<br>10：DNS解析未知，域名启用了代理<br>11：DNS解析异常，使用A记录接入WAF IP<br>200：检测源站不可达<br>220：源站不支持长连接<br>311：证书过期<br>312：证书即将过期<br>310：证书异常<br>316：备案异常<br>5：WAF回源已变更<br>负载均衡型WAF域名LB监听器状态：<br>0：操作成功<br>4：正在绑定LB<br>6：正在解绑LB<br>7：解绑LB失败<br>8：绑定LB失败<br>10：内部错误</p>
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>编辑时间</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>Ipv6开关状态。<br>0：关闭<br>1：开启</p>
        /// </summary>
        [JsonProperty("Ipv6Status")]
        public long? Ipv6Status{ get; set; }

        /// <summary>
        /// <p>BOT开关状态。<br>0：关闭<br>1：关闭<br>2：开启<br>3：开启</p>
        /// </summary>
        [JsonProperty("BotStatus")]
        public long? BotStatus{ get; set; }

        /// <summary>
        /// <p>实例版本信息。<br>101：小微敏捷版<br>102：小微超轻版<br>2：高级版<br>3：企业版<br>4：旗舰版<br>6：独享版</p>
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// <p>投递CLS状态。<br>0：关闭<br>1：开启</p>
        /// </summary>
        [JsonProperty("PostCLSStatus")]
        public long? PostCLSStatus{ get; set; }

        /// <summary>
        /// <p>投递CKafka状态。<br>0：关闭<br>1：开启</p>
        /// </summary>
        [JsonProperty("PostCKafkaStatus")]
        public long? PostCKafkaStatus{ get; set; }

        /// <summary>
        /// <p>cdc实例域名接入的集群信息,非cdc实例忽略。</p>
        /// </summary>
        [JsonProperty("CdcClusters")]
        public string CdcClusters{ get; set; }

        /// <summary>
        /// <p>api安全开关状态。<br>0：关闭<br>1：开启</p>
        /// </summary>
        [JsonProperty("ApiStatus")]
        public long? ApiStatus{ get; set; }

        /// <summary>
        /// <p>应用型负载均衡类型，默认clb。<br>clb：七层负载均衡器类型<br>apisix：apisix网关型</p>
        /// </summary>
        [JsonProperty("AlbType")]
        public string AlbType{ get; set; }

        /// <summary>
        /// <p>安全组状态。<br>0：不展示<br>1：非腾讯云源站<br>2：安全组绑定失败<br>3：安全组发生变更</p>
        /// </summary>
        [JsonProperty("SgState")]
        public long? SgState{ get; set; }

        /// <summary>
        /// <p>安全组状态的详细解释</p>
        /// </summary>
        [JsonProperty("SgDetail")]
        public string SgDetail{ get; set; }

        /// <summary>
        /// <p>域名云环境。hybrid：混合云域名<br>public：公有云域名</p>
        /// </summary>
        [JsonProperty("CloudType")]
        public string CloudType{ get; set; }

        /// <summary>
        /// <p>域名备注信息</p>
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// <p>SAASWAF源站IP列表</p>
        /// </summary>
        [JsonProperty("SrcList")]
        public string[] SrcList{ get; set; }

        /// <summary>
        /// <p>SAASWAF源站域名列表</p>
        /// </summary>
        [JsonProperty("UpstreamDomainList")]
        public string[] UpstreamDomainList{ get; set; }

        /// <summary>
        /// <p>安全组ID</p>
        /// </summary>
        [JsonProperty("SgID")]
        public string SgID{ get; set; }

        /// <summary>
        /// <p>clbwaf接入状态，0代表“尚无流量接入”，1代表“流量接入”，2代表“CLB监听器已注销”，3代表“配置生效中”，4代表“配置下发失败中”</p>
        /// </summary>
        [JsonProperty("AccessStatus")]
        public long? AccessStatus{ get; set; }

        /// <summary>
        /// <p>域名标签</p>
        /// </summary>
        [JsonProperty("Labels")]
        public string[] Labels{ get; set; }

        /// <summary>
        /// <p>saaswaf独享ip状态，0是关闭，1是开启，2是开启中</p>
        /// </summary>
        [JsonProperty("PrivateVipStatus")]
        public long? PrivateVipStatus{ get; set; }

        /// <summary>
        /// <p>代表是否是四层clbwaf域名</p>
        /// </summary>
        [JsonProperty("IsREIP")]
        public long? IsREIP{ get; set; }

        /// <summary>
        /// <p>四层关联的对象ID</p>
        /// </summary>
        [JsonProperty("REIPObjectId")]
        public string REIPObjectId{ get; set; }

        /// <summary>
        /// <p>标签结构体</p>
        /// </summary>
        [JsonProperty("TagInfos")]
        public TagInfo[] TagInfos{ get; set; }

        /// <summary>
        /// <p>大模型开关</p><p>枚举值：</p><ul><li>0： 大模型开关关闭状态</li><li>1： 大模型开关开启状态</li></ul>
        /// </summary>
        [JsonProperty("LLMStatus")]
        public long? LLMStatus{ get; set; }


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
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
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
            this.SetParamSimple(map, prefix + "PrivateVipStatus", this.PrivateVipStatus);
            this.SetParamSimple(map, prefix + "IsREIP", this.IsREIP);
            this.SetParamSimple(map, prefix + "REIPObjectId", this.REIPObjectId);
            this.SetParamArrayObj(map, prefix + "TagInfos.", this.TagInfos);
            this.SetParamSimple(map, prefix + "LLMStatus", this.LLMStatus);
        }
    }
}

