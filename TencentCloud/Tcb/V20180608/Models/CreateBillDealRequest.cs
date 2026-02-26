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
        /// 目标下单产品/套餐Id。
        /// 对于云开发环境套餐，可通过 DescribeBaasPackageList 接口获取，对应其出参的PackageName
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 默认只下单不支付，为ture则下单并支付。
        /// 如果需要下单并支付，请确保账户下有足够的余额，否则会导致下单失败。
        /// </summary>
        [JsonProperty("CreateAndPay")]
        public bool? CreateAndPay{ get; set; }

        /// <summary>
        /// 购买时长，与TimeUnit字段搭配使用。
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// 购买时长单位,按各产品规则可选d(天),m(月),y(年),p(一次性)。
        /// 对于 云开发环境的 新购和续费，目前仅支持 按月购买（即 TimeUnit=m）。
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 资源唯一标识。
        /// 在云开发环境 续费和变配 场景下必传，取值为环境ID。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 来源可选[qcloud,miniapp]，默认qcloud。
        /// miniapp表示微信云开发，主要适用于[小程序云开发](https://developers.weixin.qq.com/miniprogram/dev/wxcloudservice/wxcloud/billing/price.html)。
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 环境别名，用于新购云开发环境时，给云开发环境起别名。
        /// 仅当 新购云开发环境（DealType=purchase 并且 ProductType=tcb-baas ）时有效。
        /// 
        /// ### 格式要求
        /// - 可选字符： 小写字母(a~z)、数字、减号(-)
        /// - 不能以 减号(-) 开头或结尾
        /// - 不能有连个连续的 减号(-)
        /// - 长度不超过20位
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 环境id，当购买资源包和大促包时（ProductType取值为tcb-promotion 或 tcb-package）必传，表示资源包在哪个环境下生效。
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 开启超限按量。
        /// 开启后，当 套餐内的资源点 和 资源包 都用尽后，会自动按量计费。
        /// 详见 [计费说明](https://cloud.tencent.com/document/product/876/127357)。
        /// </summary>
        [JsonProperty("EnableExcess")]
        public bool? EnableExcess{ get; set; }

        /// <summary>
        /// 变配目标套餐id，对于云开发环境变配场景下必传。
        /// 对于云开发环境套餐，可通过 DescribeBaasPackageList 接口获取，对应其出参的PackageName
        /// </summary>
        [JsonProperty("ModifyPackageId")]
        public string ModifyPackageId{ get; set; }

        /// <summary>
        /// jsonstr附加信息
        /// </summary>
        [JsonProperty("Extension")]
        public string Extension{ get; set; }

        /// <summary>
        /// 是否自动选择代金券支付。
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

