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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 套餐ID。可以通过调用 [DescribeBundles](https://cloud.tencent.com/document/api/1207/47575) 接口获取。
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// 镜像ID。可以通过调用 [DescribeBlueprints](https://cloud.tencent.com/document/api/1207/47689) 接口获取。
        /// </summary>
        [JsonProperty("BlueprintId")]
        public string BlueprintId{ get; set; }

        /// <summary>
        /// 当前实例仅支持预付费模式，即包年包月相关参数设置，单位（月）。通过该参数可以指定包年包月实例的购买时长、是否设置自动续费等属性。该参数必传。
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// 实例显示名称。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 购买实例数量。包年包月实例取值范围：[1，30]。默认取值：1。指定购买实例的数量不能超过用户所能购买的剩余配额数量
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// 可用区列表。
        /// 不填此参数，表示为随机可用区。
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// 是否只预检此次请求。
        /// true：发送检查请求，不会创建实例。检查项包括是否填写了必需参数，请求格式，业务限制和库存。
        /// 如果检查不通过，则返回对应错误码；
        /// 如果检查通过，则返回RequestId.
        /// false（默认）：发送正常请求，通过检查后直接创建实例
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// 用于保证请求幂等性的字符串。该字符串由客户生成，需保证不同请求之间唯一，最大值不超过64个ASCII字符。若不指定该参数，则无法保证请求的幂等性。
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 实例登录密码信息配置。默认缺失情况下代表用户选择实例创建后设置登录密码。
        /// </summary>
        [JsonProperty("LoginConfiguration")]
        public LoginConfiguration LoginConfiguration{ get; set; }

        /// <summary>
        /// 要创建的容器配置列表。
        /// </summary>
        [JsonProperty("Containers")]
        public DockerContainerConfiguration[] Containers{ get; set; }

        /// <summary>
        /// 是否自动使用代金券。默认不使用。
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public bool? AutoVoucher{ get; set; }

        /// <summary>
        /// 防火墙模板ID。若不指定该参数，则使用默认防火墙策略。
        /// </summary>
        [JsonProperty("FirewallTemplateId")]
        public string FirewallTemplateId{ get; set; }

        /// <summary>
        /// 标签键和标签值。
        /// 如果指定多个标签，则会为指定资源同时创建并绑定该多个标签。
        /// 同一个资源上的同一个标签键只能对应一个标签值。如果您尝试添加已有标签键，则对应的标签值会更新为新值。
        /// 如果标签不存在会为您自动创建标签。
        /// 数组最多支持10个元素。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 创建实例后自动执行的命令。
        /// </summary>
        [JsonProperty("InitCommand")]
        public Command InitCommand{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BlueprintId", this.BlueprintId);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamObj(map, prefix + "LoginConfiguration.", this.LoginConfiguration);
            this.SetParamArrayObj(map, prefix + "Containers.", this.Containers);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamSimple(map, prefix + "FirewallTemplateId", this.FirewallTemplateId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "InitCommand.", this.InitCommand);
        }
    }
}

