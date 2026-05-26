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

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>实例唯一ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>实例对应资源ID，计费使用</p>
        /// </summary>
        [JsonProperty("ResourceIds")]
        public string ResourceIds{ get; set; }

        /// <summary>
        /// <p>实例所属地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>付费模式</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// <p>自动续费标识。<br>0：关闭<br>1：开启</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public ulong? RenewFlag{ get; set; }

        /// <summary>
        /// <p>弹性计费开关。<br>0：关闭<br>1：开启</p>
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// <p>实例套餐版本。<br>101：小微版<br>102：超轻版<br>2：高级版<br>3：企业版<br>4：旗舰版<br>6：独享版</p>
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// <p>实例过期时间</p>
        /// </summary>
        [JsonProperty("ValidTime")]
        public string ValidTime{ get; set; }

        /// <summary>
        /// <p>实例开始时间</p>
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// <p>已配置域名个数</p>
        /// </summary>
        [JsonProperty("DomainCount")]
        public ulong? DomainCount{ get; set; }

        /// <summary>
        /// <p>域名数量上限</p>
        /// </summary>
        [JsonProperty("SubDomainLimit")]
        public ulong? SubDomainLimit{ get; set; }

        /// <summary>
        /// <p>已配置主域名个数</p>
        /// </summary>
        [JsonProperty("MainDomainCount")]
        public ulong? MainDomainCount{ get; set; }

        /// <summary>
        /// <p>主域名数量上限</p>
        /// </summary>
        [JsonProperty("MainDomainLimit")]
        public ulong? MainDomainLimit{ get; set; }

        /// <summary>
        /// <p>实例30天内QPS峰值</p>
        /// </summary>
        [JsonProperty("MaxQPS")]
        public ulong? MaxQPS{ get; set; }

        /// <summary>
        /// <p>qps扩展包信息</p>
        /// </summary>
        [JsonProperty("QPS")]
        public QPSPackageNew QPS{ get; set; }

        /// <summary>
        /// <p>域名扩展包信息</p>
        /// </summary>
        [JsonProperty("DomainPkg")]
        public DomainPackageNew DomainPkg{ get; set; }

        /// <summary>
        /// <p>用户appid</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>clb或saas</p>
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// <p>业务安全包</p>
        /// </summary>
        [JsonProperty("FraudPkg")]
        public FraudPkg FraudPkg{ get; set; }

        /// <summary>
        /// <p>Bot资源包</p>
        /// </summary>
        [JsonProperty("BotPkg")]
        public BotPkg BotPkg{ get; set; }

        /// <summary>
        /// <p>bot的qps详情</p>
        /// </summary>
        [JsonProperty("BotQPS")]
        public BotQPS BotQPS{ get; set; }

        /// <summary>
        /// <p>qps弹性计费上限</p>
        /// </summary>
        [JsonProperty("ElasticBilling")]
        public ulong? ElasticBilling{ get; set; }

        /// <summary>
        /// <p>攻击日志投递开关</p>
        /// </summary>
        [JsonProperty("AttackLogPost")]
        public long? AttackLogPost{ get; set; }

        /// <summary>
        /// <p>带宽峰值，单位为B/s(字节每秒)</p>
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public ulong? MaxBandwidth{ get; set; }

        /// <summary>
        /// <p>api安全是否购买</p>
        /// </summary>
        [JsonProperty("APISecurity")]
        public ulong? APISecurity{ get; set; }

        /// <summary>
        /// <p>购买的qps规格</p>
        /// </summary>
        [JsonProperty("QpsStandard")]
        public ulong? QpsStandard{ get; set; }

        /// <summary>
        /// <p>购买的带宽规格</p>
        /// </summary>
        [JsonProperty("BandwidthStandard")]
        public ulong? BandwidthStandard{ get; set; }

        /// <summary>
        /// <p>实例状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>实例沙箱qps值</p>
        /// </summary>
        [JsonProperty("SandboxQps")]
        public ulong? SandboxQps{ get; set; }

        /// <summary>
        /// <p>是否api 安全试用</p>
        /// </summary>
        [JsonProperty("IsAPISecurityTrial")]
        public ulong? IsAPISecurityTrial{ get; set; }

        /// <summary>
        /// <p>重保包</p>
        /// </summary>
        [JsonProperty("MajorEventsPkg")]
        public MajorEventsPkg MajorEventsPkg{ get; set; }

        /// <summary>
        /// <p>混合云子节点包</p>
        /// </summary>
        [JsonProperty("HybridPkg")]
        public HybridPkg HybridPkg{ get; set; }

        /// <summary>
        /// <p>API安全资源包</p>
        /// </summary>
        [JsonProperty("ApiPkg")]
        public ApiPkg ApiPkg{ get; set; }

        /// <summary>
        /// <p>小程序安全加速包</p>
        /// </summary>
        [JsonProperty("MiniPkg")]
        public MiniPkg MiniPkg{ get; set; }

        /// <summary>
        /// <p>小程序qps规格</p>
        /// </summary>
        [JsonProperty("MiniQpsStandard")]
        public ulong? MiniQpsStandard{ get; set; }

        /// <summary>
        /// <p>小程序qps峰值</p>
        /// </summary>
        [JsonProperty("MiniMaxQPS")]
        public ulong? MiniMaxQPS{ get; set; }

        /// <summary>
        /// <p>最近一次超量时间</p>
        /// </summary>
        [JsonProperty("LastQpsExceedTime")]
        public string LastQpsExceedTime{ get; set; }

        /// <summary>
        /// <p>小程序安全接入ID数量扩张包</p>
        /// </summary>
        [JsonProperty("MiniExtendPkg")]
        public MiniExtendPkg MiniExtendPkg{ get; set; }

        /// <summary>
        /// <p>计费项</p>
        /// </summary>
        [JsonProperty("BillingItem")]
        public string BillingItem{ get; set; }

        /// <summary>
        /// <p>实例延期释放标识</p>
        /// </summary>
        [JsonProperty("FreeDelayFlag")]
        public ulong? FreeDelayFlag{ get; set; }

        /// <summary>
        /// <p>最近3天最大qps</p>
        /// </summary>
        [JsonProperty("Last3MaxQPS")]
        public ulong? Last3MaxQPS{ get; set; }

        /// <summary>
        /// <p>最近3天最大带宽</p>
        /// </summary>
        [JsonProperty("Last3MaxBandwidth")]
        public ulong? Last3MaxBandwidth{ get; set; }

        /// <summary>
        /// <p>重保增强包</p>
        /// </summary>
        [JsonProperty("MajorEventsProPkg")]
        public MajorEventsProPkg MajorEventsProPkg{ get; set; }

        /// <summary>
        /// <p>1是基础2025版本；0不是</p>
        /// </summary>
        [JsonProperty("BasicFlag")]
        public ulong? BasicFlag{ get; set; }

        /// <summary>
        /// <p>实例的网络配置</p>
        /// </summary>
        [JsonProperty("NetworkConfig")]
        public NetworkConfig NetworkConfig{ get; set; }

        /// <summary>
        /// <p>RCE设备安全信息包</p>
        /// </summary>
        [JsonProperty("RCEPkg")]
        public RCEPkg RCEPkg{ get; set; }

        /// <summary>
        /// <p>超量策略。0：超量沙箱<br>1：超量限流</p>
        /// </summary>
        [JsonProperty("ExceedPolicy")]
        public long? ExceedPolicy{ get; set; }

        /// <summary>
        /// <p>大模型安全信息包</p>
        /// </summary>
        [JsonProperty("LLMPkg")]
        public LLMPkg LLMPkg{ get; set; }

        /// <summary>
        /// <p>弹性资源Id</p>
        /// </summary>
        [JsonProperty("ElasticResourceId")]
        public string ElasticResourceId{ get; set; }

        /// <summary>
        /// <p>预付费大模型安全信息包</p>
        /// </summary>
        [JsonProperty("LLMMonPkg")]
        public LLMMonPkg LLMMonPkg{ get; set; }

        /// <summary>
        /// <p>地域id</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// <p>BOT安全护航信息</p>
        /// </summary>
        [JsonProperty("BotSecurityPkg")]
        public BotSecurityPkg BotSecurityPkg{ get; set; }

        /// <summary>
        /// <p>BOT安全监测资源信息</p>
        /// </summary>
        [JsonProperty("BotMonitorPkg")]
        public BotMonitorPkg BotMonitorPkg{ get; set; }

        /// <summary>
        /// <p>独享ip资源信息</p>
        /// </summary>
        [JsonProperty("DedicatedIPPkg")]
        public DedicatedIPPkg DedicatedIPPkg{ get; set; }

        /// <summary>
        /// <p>已经配置独享ip的数量</p>
        /// </summary>
        [JsonProperty("DedicatedIPCount")]
        public long? DedicatedIPCount{ get; set; }

        /// <summary>
        /// <p>标签结构体</p>
        /// </summary>
        [JsonProperty("TagInfos")]
        public TagInfo[] TagInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ResourceIds", this.ResourceIds);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "ValidTime", this.ValidTime);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "DomainCount", this.DomainCount);
            this.SetParamSimple(map, prefix + "SubDomainLimit", this.SubDomainLimit);
            this.SetParamSimple(map, prefix + "MainDomainCount", this.MainDomainCount);
            this.SetParamSimple(map, prefix + "MainDomainLimit", this.MainDomainLimit);
            this.SetParamSimple(map, prefix + "MaxQPS", this.MaxQPS);
            this.SetParamObj(map, prefix + "QPS.", this.QPS);
            this.SetParamObj(map, prefix + "DomainPkg.", this.DomainPkg);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamObj(map, prefix + "FraudPkg.", this.FraudPkg);
            this.SetParamObj(map, prefix + "BotPkg.", this.BotPkg);
            this.SetParamObj(map, prefix + "BotQPS.", this.BotQPS);
            this.SetParamSimple(map, prefix + "ElasticBilling", this.ElasticBilling);
            this.SetParamSimple(map, prefix + "AttackLogPost", this.AttackLogPost);
            this.SetParamSimple(map, prefix + "MaxBandwidth", this.MaxBandwidth);
            this.SetParamSimple(map, prefix + "APISecurity", this.APISecurity);
            this.SetParamSimple(map, prefix + "QpsStandard", this.QpsStandard);
            this.SetParamSimple(map, prefix + "BandwidthStandard", this.BandwidthStandard);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SandboxQps", this.SandboxQps);
            this.SetParamSimple(map, prefix + "IsAPISecurityTrial", this.IsAPISecurityTrial);
            this.SetParamObj(map, prefix + "MajorEventsPkg.", this.MajorEventsPkg);
            this.SetParamObj(map, prefix + "HybridPkg.", this.HybridPkg);
            this.SetParamObj(map, prefix + "ApiPkg.", this.ApiPkg);
            this.SetParamObj(map, prefix + "MiniPkg.", this.MiniPkg);
            this.SetParamSimple(map, prefix + "MiniQpsStandard", this.MiniQpsStandard);
            this.SetParamSimple(map, prefix + "MiniMaxQPS", this.MiniMaxQPS);
            this.SetParamSimple(map, prefix + "LastQpsExceedTime", this.LastQpsExceedTime);
            this.SetParamObj(map, prefix + "MiniExtendPkg.", this.MiniExtendPkg);
            this.SetParamSimple(map, prefix + "BillingItem", this.BillingItem);
            this.SetParamSimple(map, prefix + "FreeDelayFlag", this.FreeDelayFlag);
            this.SetParamSimple(map, prefix + "Last3MaxQPS", this.Last3MaxQPS);
            this.SetParamSimple(map, prefix + "Last3MaxBandwidth", this.Last3MaxBandwidth);
            this.SetParamObj(map, prefix + "MajorEventsProPkg.", this.MajorEventsProPkg);
            this.SetParamSimple(map, prefix + "BasicFlag", this.BasicFlag);
            this.SetParamObj(map, prefix + "NetworkConfig.", this.NetworkConfig);
            this.SetParamObj(map, prefix + "RCEPkg.", this.RCEPkg);
            this.SetParamSimple(map, prefix + "ExceedPolicy", this.ExceedPolicy);
            this.SetParamObj(map, prefix + "LLMPkg.", this.LLMPkg);
            this.SetParamSimple(map, prefix + "ElasticResourceId", this.ElasticResourceId);
            this.SetParamObj(map, prefix + "LLMMonPkg.", this.LLMMonPkg);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamObj(map, prefix + "BotSecurityPkg.", this.BotSecurityPkg);
            this.SetParamObj(map, prefix + "BotMonitorPkg.", this.BotMonitorPkg);
            this.SetParamObj(map, prefix + "DedicatedIPPkg.", this.DedicatedIPPkg);
            this.SetParamSimple(map, prefix + "DedicatedIPCount", this.DedicatedIPCount);
            this.SetParamArrayObj(map, prefix + "TagInfos.", this.TagInfos);
        }
    }
}

