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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDomainBatchRequest : AbstractModel
    {
        
        /// <summary>
        /// 模板ID。详情请查看：[获取模板列表](https://cloud.tencent.com/document/product/242/48940)
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 购买域名的年限，可选值：[1-10]
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 批量购买的域名,最多为4000个
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 付费模式 0手动在线付费，1使用余额付费，2使用特惠包
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 自动续费开关。有两个可选值：
        /// 0 表示关闭，不自动续费（默认值）
        /// 1 表示开启，将自动续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 使用的特惠包ID，PayMode为2时必填
        /// </summary>
        [JsonProperty("PackageResourceId")]
        public string PackageResourceId{ get; set; }

        /// <summary>
        /// 是否开启更新锁：0=默认不开启，1=开启
        /// </summary>
        [JsonProperty("UpdateProhibition")]
        public long? UpdateProhibition{ get; set; }

        /// <summary>
        /// 是否开启转移锁：0=默认不开启，1=开启
        /// </summary>
        [JsonProperty("TransferProhibition")]
        public long? TransferProhibition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "PackageResourceId", this.PackageResourceId);
            this.SetParamSimple(map, prefix + "UpdateProhibition", this.UpdateProhibition);
            this.SetParamSimple(map, prefix + "TransferProhibition", this.TransferProhibition);
        }
    }
}

