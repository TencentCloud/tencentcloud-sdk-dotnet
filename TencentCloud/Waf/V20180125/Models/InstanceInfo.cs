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
        /// id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("ResourceIds")]
        public string ResourceIds{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 付费模式
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 自动续费
        /// </summary>
        [JsonProperty("RenewFlag")]
        public ulong? RenewFlag{ get; set; }

        /// <summary>
        /// 弹性计费
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// 套餐版本
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ValidTime")]
        public string ValidTime{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 已用
        /// </summary>
        [JsonProperty("DomainCount")]
        public ulong? DomainCount{ get; set; }

        /// <summary>
        /// 上限
        /// </summary>
        [JsonProperty("SubDomainLimit")]
        public ulong? SubDomainLimit{ get; set; }

        /// <summary>
        /// 已用
        /// </summary>
        [JsonProperty("MainDomainCount")]
        public ulong? MainDomainCount{ get; set; }

        /// <summary>
        /// 上限
        /// </summary>
        [JsonProperty("MainDomainLimit")]
        public ulong? MainDomainLimit{ get; set; }

        /// <summary>
        /// 峰值
        /// </summary>
        [JsonProperty("MaxQPS")]
        public ulong? MaxQPS{ get; set; }

        /// <summary>
        /// qps套餐
        /// </summary>
        [JsonProperty("QPS")]
        public QPSPackageNew QPS{ get; set; }

        /// <summary>
        /// 域名套餐
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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FraudPkg")]
        public FraudPkg FraudPkg{ get; set; }

        /// <summary>
        /// Bot资源包
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BotPkg")]
        public BotPkg BotPkg{ get; set; }

        /// <summary>
        /// bot的qps详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BotQPS")]
        public BotQPS BotQPS{ get; set; }

        /// <summary>
        /// qps弹性计费上限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ElasticBilling")]
        public ulong? ElasticBilling{ get; set; }

        /// <summary>
        /// 攻击日志投递开关
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackLogPost")]
        public long? AttackLogPost{ get; set; }

        /// <summary>
        /// 带宽峰值，单位为B/s(字节每秒)
        /// 注意：此字段可能返回 null，表示取不到有效值。
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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QpsStandard")]
        public ulong? QpsStandard{ get; set; }

        /// <summary>
        /// 购买的带宽规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BandwidthStandard")]
        public ulong? BandwidthStandard{ get; set; }

        /// <summary>
        /// 实例状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 实例沙箱值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SandboxQps")]
        public ulong? SandboxQps{ get; set; }

        /// <summary>
        /// 是否api 安全试用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAPISecurityTrial")]
        public ulong? IsAPISecurityTrial{ get; set; }


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
        }
    }
}

