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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PurchaseResourcePoolPacksRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例资源池预扣包所在可用区。形如：ap-guangzhou-6。可通过[DescribeZones](https://cloud.tencent.com/document/product/213/15707)接口获取可用区列表。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例资源池预扣包的规格，仅支持半整机/整机规格。形如：SA9.96XLARGE1152（SA9半整机）。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例资源池预扣包的数量。1个数量代表1个半整机/整机资源池。取值范围：1-100。
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// 实例资源池预扣包的时长，单位：月。取值范围：1-60。
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 实例资源池类型。取值范围：
        /// <li>EXCLUSIVE：独享（默认值）</li>
        /// <li>SHARED：共享</li>
        /// 注意：第一期仅支持EXCLUSIVE类型。
        /// </summary>
        [JsonProperty("ResourcePoolPackType")]
        public string ResourcePoolPackType{ get; set; }

        /// <summary>
        /// 自动放置开关，默认开启（true）。
        /// <li>开启：在不指定实例资源池创建实例时，系统会在开启了该能力的实例资源池里寻找合适的池子创建实例。</li>
        /// <li>关闭：在不指定实例资源池创建实例时，系统不会在该池子里创建实例，只有在指定实例资源池创建实例时，指定了该池子的ID，才允许在池子内创建实例。</li>
        /// </summary>
        [JsonProperty("AutoPlacement")]
        public bool? AutoPlacement{ get; set; }

        /// <summary>
        /// 实例资源池的名称。长度限制：1-60个字符，支持中文、英文、数字、连接线"-"、下划线"_"。
        /// </summary>
        [JsonProperty("DedicatedResourcePoolPackName")]
        public string DedicatedResourcePoolPackName{ get; set; }

        /// <summary>
        /// 自动续费标识。取值范围：
        /// <li>NOTIFY_AND_AUTO_RENEW：通知过期且自动续费</li>
        /// <li>NOTIFY_AND_MANUAL_RENEW：通知过期不自动续费（默认值）</li>
        /// <li>DISABLE_NOTIFY_AND_MANUAL_RENEW：不通知过期不自动续费</li>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 试运行，用于校验请求参数是否正确。默认为false。
        /// <li>true：发送检查请求，不会创建实例资源池。检查项包括是否填写了必需参数，请求格式，业务限制等。如果检查不通过，则返回对应错误码；如果检查通过，则返回RequestId。</li>
        /// <li>false（默认值）：发送正常请求，通过检查后直接创建实例资源池。</li>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "ResourcePoolPackType", this.ResourcePoolPackType);
            this.SetParamSimple(map, prefix + "AutoPlacement", this.AutoPlacement);
            this.SetParamSimple(map, prefix + "DedicatedResourcePoolPackName", this.DedicatedResourcePoolPackName);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

