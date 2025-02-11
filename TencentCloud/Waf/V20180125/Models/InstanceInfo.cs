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

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例唯一ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例对应资源ID，计费使用
        /// </summary>
        [JsonProperty("ResourceIds")]
        public string ResourceIds{ get; set; }

        /// <summary>
        /// 实例所属地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 付费模式
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 自动续费标识。
        /// 0：关闭
        /// 1：开启
        /// </summary>
        [JsonProperty("RenewFlag")]
        public ulong? RenewFlag{ get; set; }

        /// <summary>
        /// 弹性计费开关。
        /// 0：关闭
        /// 1：开启
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// 实例套餐版本。
        /// 101：小微版
        /// 102：超轻版
        /// 2：高级版
        /// 3：企业版
        /// 4：旗舰版
        /// 6：独享版
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 实例过期时间
        /// </summary>
        [JsonProperty("ValidTime")]
        public string ValidTime{ get; set; }

        /// <summary>
        /// 实例开始时间
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 已配置域名个数
        /// </summary>
        [JsonProperty("DomainCount")]
        public ulong? DomainCount{ get; set; }

        /// <summary>
        /// 域名数量上限
        /// </summary>
        [JsonProperty("SubDomainLimit")]
        public ulong? SubDomainLimit{ get; set; }

        /// <summary>
        /// 已配置主域名个数
        /// </summary>
        [JsonProperty("MainDomainCount")]
        public ulong? MainDomainCount{ get; set; }

        /// <summary>
        /// 主域名数量上限
        /// </summary>
        [JsonProperty("MainDomainLimit")]
        public ulong? MainDomainLimit{ get; set; }

        /// <summary>
        /// 实例30天内QPS峰值
        /// </summary>
        [JsonProperty("MaxQPS")]
        public ulong? MaxQPS{ get; set; }

        /// <summary>
        /// qps扩展包信息
        /// </summary>
        [JsonProperty("QPS")]
        public QPSPackageNew QPS{ get; set; }

        /// <summary>
        /// 域名扩展包信息
        /// </summary>
        [JsonProperty("DomainPkg")]
        public DomainPackageNew DomainPkg{ get; set; }

        /// <summary>
        /// 用户appid
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// clb或saas
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// 业务安全包
        /// </summary>
        [JsonProperty("FraudPkg")]
        public FraudPkg FraudPkg{ get; set; }

        /// <summary>
        /// Bot资源包
        /// </summary>
        [JsonProperty("BotPkg")]
        public BotPkg BotPkg{ get; set; }

        /// <summary>
        /// bot的qps详情
        /// </summary>
        [JsonProperty("BotQPS")]
        public BotQPS BotQPS{ get; set; }

        /// <summary>
        /// qps弹性计费上限
        /// </summary>
        [JsonProperty("ElasticBilling")]
        public ulong? ElasticBilling{ get; set; }

        /// <summary>
        /// 攻击日志投递开关
        /// </summary>
        [JsonProperty("AttackLogPost")]
        public long? AttackLogPost{ get; set; }

        /// <summary>
        /// 带宽峰值，单位为B/s(字节每秒)
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public ulong? MaxBandwidth{ get; set; }

        /// <summary>
        /// api安全是否购买
        /// </summary>
        [JsonProperty("APISecurity")]
        public ulong? APISecurity{ get; set; }

        /// <summary>
        /// 购买的qps规格
        /// </summary>
        [JsonProperty("QpsStandard")]
        public ulong? QpsStandard{ get; set; }

        /// <summary>
        /// 购买的带宽规格
        /// </summary>
        [JsonProperty("BandwidthStandard")]
        public ulong? BandwidthStandard{ get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 实例沙箱qps值
        /// </summary>
        [JsonProperty("SandboxQps")]
        public ulong? SandboxQps{ get; set; }

        /// <summary>
        /// 是否api 安全试用
        /// </summary>
        [JsonProperty("IsAPISecurityTrial")]
        public ulong? IsAPISecurityTrial{ get; set; }

        /// <summary>
        /// 重保包
        /// </summary>
        [JsonProperty("MajorEventsPkg")]
        public MajorEventsPkg MajorEventsPkg{ get; set; }

        /// <summary>
        /// 混合云子节点包
        /// </summary>
        [JsonProperty("HybridPkg")]
        public HybridPkg HybridPkg{ get; set; }

        /// <summary>
        /// API安全资源包
        /// </summary>
        [JsonProperty("ApiPkg")]
        public ApiPkg ApiPkg{ get; set; }

        /// <summary>
        /// 小程序安全加速包
        /// </summary>
        [JsonProperty("MiniPkg")]
        public MiniPkg MiniPkg{ get; set; }

        /// <summary>
        /// 小程序qps规格
        /// </summary>
        [JsonProperty("MiniQpsStandard")]
        public ulong? MiniQpsStandard{ get; set; }

        /// <summary>
        /// 小程序qps峰值
        /// </summary>
        [JsonProperty("MiniMaxQPS")]
        public ulong? MiniMaxQPS{ get; set; }

        /// <summary>
        /// 最近一次超量时间
        /// </summary>
        [JsonProperty("LastQpsExceedTime")]
        public string LastQpsExceedTime{ get; set; }

        /// <summary>
        /// 小程序安全接入ID数量扩张包
        /// </summary>
        [JsonProperty("MiniExtendPkg")]
        public MiniExtendPkg MiniExtendPkg{ get; set; }

        /// <summary>
        /// 计费项
        /// </summary>
        [JsonProperty("BillingItem")]
        public string BillingItem{ get; set; }

        /// <summary>
        /// 实例延期释放标识
        /// </summary>
        [JsonProperty("FreeDelayFlag")]
        public ulong? FreeDelayFlag{ get; set; }

        /// <summary>
        /// 最近3天最大qps
        /// </summary>
        [JsonProperty("Last3MaxQPS")]
        public ulong? Last3MaxQPS{ get; set; }

        /// <summary>
        /// 最近3天最大带宽
        /// </summary>
        [JsonProperty("Last3MaxBandwidth")]
        public ulong? Last3MaxBandwidth{ get; set; }


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
        }
    }
}

