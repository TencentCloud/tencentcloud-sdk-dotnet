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
        /// name
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
        }
    }
}

