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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MachineLicenseDetail : AbstractModel
    {
        
        /// <summary>
        /// 主机quuid
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 计费模式, 0 按量计费 , 1 预付费
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 授权类型
        /// </summary>
        [JsonProperty("LicenseType")]
        public ulong? LicenseType{ get; set; }

        /// <summary>
        /// 订单类型,0 默认计费订单 1 试用订单, 2 赠送 3 体验
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// 废弃字段,
        /// </summary>
        [JsonProperty("InquireKey")]
        public string InquireKey{ get; set; }

        /// <summary>
        /// 自动续费标识 0 默认不自动付费, 1 自动付费 2 手动设置不续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 到期时间,按量付费该值为空
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// 购买时间
        /// </summary>
        [JsonProperty("BuyTime")]
        public string BuyTime{ get; set; }

        /// <summary>
        /// 授权数量
        /// </summary>
        [JsonProperty("LicenseCnt")]
        public ulong? LicenseCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "InquireKey", this.InquireKey);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "BuyTime", this.BuyTime);
            this.SetParamSimple(map, prefix + "LicenseCnt", this.LicenseCnt);
        }
    }
}

