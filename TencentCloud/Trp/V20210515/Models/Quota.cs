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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Quota : AbstractModel
    {
        
        /// <summary>
        /// 服务开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 服务结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 配额ID
        /// </summary>
        [JsonProperty("QuotaId")]
        public ulong? QuotaId{ get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CorpId")]
        public ulong? CorpId{ get; set; }

        /// <summary>
        /// 开通服务
        /// </summary>
        [JsonProperty("Services")]
        public string[] Services{ get; set; }

        /// <summary>
        /// 商户配额
        /// </summary>
        [JsonProperty("FactoryQuota")]
        public long? FactoryQuota{ get; set; }

        /// <summary>
        /// 商品配额
        /// </summary>
        [JsonProperty("ItemQuota")]
        public long? ItemQuota{ get; set; }

        /// <summary>
        /// 溯源码配额
        /// </summary>
        [JsonProperty("TrackQuota")]
        public long? TrackQuota{ get; set; }

        /// <summary>
        /// 销售码配额
        /// </summary>
        [JsonProperty("SaleQuota")]
        public long? SaleQuota{ get; set; }

        /// <summary>
        /// 上链配额
        /// </summary>
        [JsonProperty("ChainQuota")]
        public long? ChainQuota{ get; set; }

        /// <summary>
        /// 风控配额
        /// </summary>
        [JsonProperty("RiskQuota")]
        public long? RiskQuota{ get; set; }

        /// <summary>
        /// AI文字数量
        /// </summary>
        [JsonProperty("AigcTextQuota")]
        public long? AigcTextQuota{ get; set; }

        /// <summary>
        /// AI图片数量
        /// </summary>
        [JsonProperty("AigcImageQuota")]
        public long? AigcImageQuota{ get; set; }

        /// <summary>
        /// 溯源类型
        /// </summary>
        [JsonProperty("TrackType")]
        public long? TrackType{ get; set; }

        /// <summary>
        /// 开通版本 lite:轻量版, basic:基础版, standard:标准版
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 是否开启企业认证
        /// </summary>
        [JsonProperty("ProductCertify")]
        public ulong? ProductCertify{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "QuotaId", this.QuotaId);
            this.SetParamSimple(map, prefix + "CorpId", this.CorpId);
            this.SetParamArraySimple(map, prefix + "Services.", this.Services);
            this.SetParamSimple(map, prefix + "FactoryQuota", this.FactoryQuota);
            this.SetParamSimple(map, prefix + "ItemQuota", this.ItemQuota);
            this.SetParamSimple(map, prefix + "TrackQuota", this.TrackQuota);
            this.SetParamSimple(map, prefix + "SaleQuota", this.SaleQuota);
            this.SetParamSimple(map, prefix + "ChainQuota", this.ChainQuota);
            this.SetParamSimple(map, prefix + "RiskQuota", this.RiskQuota);
            this.SetParamSimple(map, prefix + "AigcTextQuota", this.AigcTextQuota);
            this.SetParamSimple(map, prefix + "AigcImageQuota", this.AigcImageQuota);
            this.SetParamSimple(map, prefix + "TrackType", this.TrackType);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "ProductCertify", this.ProductCertify);
        }
    }
}

