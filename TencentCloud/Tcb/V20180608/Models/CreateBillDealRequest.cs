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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBillDealRequest : AbstractModel
    {
        
        /// <summary>
        /// 当前下单的操作类型，可取[purchase,renew,modify]三种值，分别代表新购，续费，变配。
        /// </summary>
        [JsonProperty("DealType")]
        public string DealType{ get; set; }

        /// <summary>
        /// 购买的产品类型，可取[tcb-baas,tcb-promotion,tcb-package], 分别代表baas套餐、大促包、资源包
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }

        /// <summary>
        /// 目标下单产品/套餐Id
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 默认只下单不支付，为ture则下单并支付
        /// </summary>
        [JsonProperty("CreateAndPay")]
        public bool? CreateAndPay{ get; set; }

        /// <summary>
        /// 购买时长
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// 购买时长单位,按各产品规则可选d(天),m(月),y(年),p(一次性)
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 资源唯一标识
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 来源可选[qcloud,miniapp]，默认qcloud
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 资源别名
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 开启超限按量
        /// </summary>
        [JsonProperty("EnableExcess")]
        public bool? EnableExcess{ get; set; }

        /// <summary>
        /// 变配目标产品/套餐id
        /// </summary>
        [JsonProperty("ModifyPackageId")]
        public string ModifyPackageId{ get; set; }

        /// <summary>
        /// jsonstr附加信息
        /// </summary>
        [JsonProperty("Extension")]
        public string Extension{ get; set; }

        /// <summary>
        /// 是否自动选择代金券支付
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public bool? AutoVoucher{ get; set; }

        /// <summary>
        /// 资源类型。
        /// 代表新购环境（DealType=purchase 并且 ProductType=tcb-baas ）时需要发货哪些资源。
        /// 可取值：flexdb, cos, cdn, scf
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public string[] ResourceTypes{ get; set; }

        /// <summary>
        /// 环境标签。
        ///  代表新购环境（DealType=purchase 并且 ProductType=tcb-baas ）时需要打的标签。
        /// </summary>
        [JsonProperty("EnvTags")]
        public Tag[] EnvTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DealType", this.DealType);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "CreateAndPay", this.CreateAndPay);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "EnableExcess", this.EnableExcess);
            this.SetParamSimple(map, prefix + "ModifyPackageId", this.ModifyPackageId);
            this.SetParamSimple(map, prefix + "Extension", this.Extension);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "ResourceTypes.", this.ResourceTypes);
            this.SetParamArrayObj(map, prefix + "EnvTags.", this.EnvTags);
        }
    }
}

