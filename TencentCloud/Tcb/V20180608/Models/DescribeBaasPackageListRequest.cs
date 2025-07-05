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

    public class DescribeBaasPackageListRequest : AbstractModel
    {
        
        /// <summary>
        /// tcb产品套餐ID，不填拉取全量package信息。
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// 环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 套餐归属方，填写后只返回对应的套餐 包含miniapp与qcloud两种 默认为miniapp
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 套餐归属环境渠道
        /// </summary>
        [JsonProperty("EnvChannel")]
        public string EnvChannel{ get; set; }

        /// <summary>
        /// 拉取套餐用途：
        /// 1）new 新购
        /// 2）modify变配
        /// 3）renew续费
        /// </summary>
        [JsonProperty("TargetAction")]
        public string TargetAction{ get; set; }

        /// <summary>
        /// 预留字段，同一商品会对应多个类型套餐，对指标有不同侧重。
        /// 计算型calculation
        /// 流量型flux
        /// 容量型capactiy
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 类型分组过滤。默认为["default"]
        /// </summary>
        [JsonProperty("PackageTypeList")]
        public string[] PackageTypeList{ get; set; }

        /// <summary>
        /// 付费渠道，与回包billTags中的计费参数相关，不填返回默认值。
        /// </summary>
        [JsonProperty("PaymentChannel")]
        public string PaymentChannel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "EnvChannel", this.EnvChannel);
            this.SetParamSimple(map, prefix + "TargetAction", this.TargetAction);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamArraySimple(map, prefix + "PackageTypeList.", this.PackageTypeList);
            this.SetParamSimple(map, prefix + "PaymentChannel", this.PaymentChannel);
        }
    }
}

