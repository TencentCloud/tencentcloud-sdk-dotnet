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

    public class AfterPayInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>用户appid</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

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
        /// <p>实例版本，后付费实例固定为 llm-sdk-waf</p>
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// <p>实例所属地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>付费模式，后付费实例为 0</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

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
        /// <p>计费项</p>
        /// </summary>
        [JsonProperty("BillingItem")]
        public string BillingItem{ get; set; }

        /// <summary>
        /// <p>自动续费标识。<br>0：关闭<br>1：开启</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public ulong? RenewFlag{ get; set; }

        /// <summary>
        /// <p>实例套餐版本</p>
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// <p>实例修改时间</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>域名数量上限</p>
        /// </summary>
        [JsonProperty("SubDomainLimit")]
        public ulong? SubDomainLimit{ get; set; }

        /// <summary>
        /// <p>主域名数量上限</p>
        /// </summary>
        [JsonProperty("MainDomainLimit")]
        public ulong? MainDomainLimit{ get; set; }

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
        /// <p>api安全是否购买</p>
        /// </summary>
        [JsonProperty("APISecurity")]
        public ulong? APISecurity{ get; set; }

        /// <summary>
        /// <p>是否api 安全试用</p>
        /// </summary>
        [JsonProperty("IsAPISecurityTrial")]
        public ulong? IsAPISecurityTrial{ get; set; }

        /// <summary>
        /// <p>实例延期释放标识</p>
        /// </summary>
        [JsonProperty("FreeDelayFlag")]
        public ulong? FreeDelayFlag{ get; set; }

        /// <summary>
        /// <p>1是基础2025版本；0不是</p>
        /// </summary>
        [JsonProperty("BasicFlag")]
        public ulong? BasicFlag{ get; set; }

        /// <summary>
        /// <p>大模型安全「后付费」资源信息，结构与内容与 DescribeInstances 的 InstanceDetail.LLMPkg 保持一致</p>
        /// </summary>
        [JsonProperty("LLMPkg")]
        public LLMPkg LLMPkg{ get; set; }

        /// <summary>
        /// <p>LLM实例当天4个计费模块token消耗量及近7天趋势（仅后付费llm-sdk-waf实例返回）</p>
        /// </summary>
        [JsonProperty("LLMTokenUsage")]
        public LLMTokenUsage LLMTokenUsage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ResourceIds", this.ResourceIds);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ValidTime", this.ValidTime);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "BillingItem", this.BillingItem);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "SubDomainLimit", this.SubDomainLimit);
            this.SetParamSimple(map, prefix + "MainDomainLimit", this.MainDomainLimit);
            this.SetParamSimple(map, prefix + "ElasticBilling", this.ElasticBilling);
            this.SetParamSimple(map, prefix + "AttackLogPost", this.AttackLogPost);
            this.SetParamSimple(map, prefix + "APISecurity", this.APISecurity);
            this.SetParamSimple(map, prefix + "IsAPISecurityTrial", this.IsAPISecurityTrial);
            this.SetParamSimple(map, prefix + "FreeDelayFlag", this.FreeDelayFlag);
            this.SetParamSimple(map, prefix + "BasicFlag", this.BasicFlag);
            this.SetParamObj(map, prefix + "LLMPkg.", this.LLMPkg);
            this.SetParamObj(map, prefix + "LLMTokenUsage.", this.LLMTokenUsage);
        }
    }
}

