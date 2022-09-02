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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductInstance : AbstractModel
    {
        
        /// <summary>
        /// 预付费商品实例类型，取值有：
        /// <li>StarterPackage：点播新手包。</li>
        /// <li>MiniProgramPlugin：点播小程序插件。</li>
        /// <li>ResourcePackage：点播资源包。</li>
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }

        /// <summary>
        /// 资源包实例起始日期。使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F)。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 资源包实例过期日期。使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F)。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 资源包实例ID。对应每个资源包，系统会分配相应的资源。续费或者升级资源包时，需要带上这个资源ID。
        /// </summary>
        [JsonProperty("ProductInstanceId")]
        public string ProductInstanceId{ get; set; }

        /// <summary>
        /// 系统最近一次扣除资源包的日期。使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F)。
        /// </summary>
        [JsonProperty("LastConsumeDate")]
        public string LastConsumeDate{ get; set; }

        /// <summary>
        /// 资源包绑定 License 状态，取值有：
        /// <li>0：未绑定。</li>
        /// <li>1：已绑定。</li>
        /// </summary>
        [JsonProperty("BindStatus")]
        public long? BindStatus{ get; set; }

        /// <summary>
        /// 预付费资源包实例中包含的资源包列表。
        /// </summary>
        [JsonProperty("ProductInstanceResourceSet")]
        public ProductInstanceRecource[] ProductInstanceResourceSet{ get; set; }

        /// <summary>
        /// 资源包实例的状态，取值有：
        /// <li>Effective：生效，可用于计费抵扣。</li>
        /// <li>Isolated：隔离，不可用于计费抵扣。</li>
        /// </summary>
        [JsonProperty("ProductInstanceStatus")]
        public string ProductInstanceStatus{ get; set; }

        /// <summary>
        /// 资源包实例的可退还状态，取值有：
        /// <li>FullRefund：可全额退款。</li>
        /// <li>Denied：不可退款。</li>
        /// </summary>
        [JsonProperty("RefundStatus")]
        public string RefundStatus{ get; set; }

        /// <summary>
        /// 自动续费状态，取值有：
        /// <li>Never：不自动续费。</li>
        /// <li>Expire：到期自动续费。</li>
        /// <li>ExpireOrUseOut：到期或用完自动续费。</li>
        /// <li>NotSupport：不支持。</li>
        /// </summary>
        [JsonProperty("RenewStatus")]
        public string RenewStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ProductInstanceId", this.ProductInstanceId);
            this.SetParamSimple(map, prefix + "LastConsumeDate", this.LastConsumeDate);
            this.SetParamSimple(map, prefix + "BindStatus", this.BindStatus);
            this.SetParamArrayObj(map, prefix + "ProductInstanceResourceSet.", this.ProductInstanceResourceSet);
            this.SetParamSimple(map, prefix + "ProductInstanceStatus", this.ProductInstanceStatus);
            this.SetParamSimple(map, prefix + "RefundStatus", this.RefundStatus);
            this.SetParamSimple(map, prefix + "RenewStatus", this.RenewStatus);
        }
    }
}

