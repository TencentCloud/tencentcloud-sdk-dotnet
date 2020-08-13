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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Package : AbstractModel
    {
        
        /// <summary>
        /// 订单id
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 曲库包名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 授权地区-global: 全球  CN: 中国
        /// </summary>
        [JsonProperty("AuthorizedArea")]
        public string AuthorizedArea{ get; set; }

        /// <summary>
        /// 授权次数
        /// </summary>
        [JsonProperty("AuthorizedLimit")]
        public long? AuthorizedLimit{ get; set; }

        /// <summary>
        /// 套餐有效期，单位:天
        /// </summary>
        [JsonProperty("TermOfValidity")]
        public long? TermOfValidity{ get; set; }

        /// <summary>
        /// 0:不可商业化；1:可商业化
        /// </summary>
        [JsonProperty("Commercial")]
        public long? Commercial{ get; set; }

        /// <summary>
        /// 套餐价格，单位：元
        /// </summary>
        [JsonProperty("PackagePrice")]
        public float? PackagePrice{ get; set; }

        /// <summary>
        /// 生效开始时间,格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("EffectTime")]
        public string EffectTime{ get; set; }

        /// <summary>
        /// 生效结束时间,格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 剩余授权次数
        /// </summary>
        [JsonProperty("UsedCount")]
        public long? UsedCount{ get; set; }

        /// <summary>
        /// 曲库包用途信息
        /// </summary>
        [JsonProperty("UseRanges")]
        public UseRange[] UseRanges{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AuthorizedArea", this.AuthorizedArea);
            this.SetParamSimple(map, prefix + "AuthorizedLimit", this.AuthorizedLimit);
            this.SetParamSimple(map, prefix + "TermOfValidity", this.TermOfValidity);
            this.SetParamSimple(map, prefix + "Commercial", this.Commercial);
            this.SetParamSimple(map, prefix + "PackagePrice", this.PackagePrice);
            this.SetParamSimple(map, prefix + "EffectTime", this.EffectTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "UsedCount", this.UsedCount);
            this.SetParamArrayObj(map, prefix + "UseRanges.", this.UseRanges);
        }
    }
}

