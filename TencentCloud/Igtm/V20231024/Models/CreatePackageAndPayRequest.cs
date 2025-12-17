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

namespace TencentCloud.Igtm.V20231024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePackageAndPayRequest : AbstractModel
    {
        
        /// <summary>
        /// 下单类型：CREATE 新购；RENEW 续费；MODIFY 变配
        /// </summary>
        [JsonProperty("DealType")]
        public string DealType{ get; set; }

        /// <summary>
        /// 套餐类型：STANDARD 标准版；ULTIMATE 旗舰版；TASK 任务探测
        /// </summary>
        [JsonProperty("GoodsType")]
        public string GoodsType{ get; set; }

        /// <summary>
        /// 商品数量：STANDARD和ULTIMATE固定为1，TASK为任务探测数量。取值范围：1～10000
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// 自动续费：1 开启自动续费；2 关闭自动续费
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// 资源ID，续费和变配的时候需要传
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 套餐时长，以月为单位，创建和续费的时候需要传。取值范围：1～120
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// 升级的套餐类型，暂时只支持传ULTIMATE，不支持降配
        /// </summary>
        [JsonProperty("NewPackageType")]
        public string NewPackageType{ get; set; }

        /// <summary>
        /// 是否自动选择代金券，1 是；0否，默认为0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public ulong? AutoVoucher{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DealType", this.DealType);
            this.SetParamSimple(map, prefix + "GoodsType", this.GoodsType);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "NewPackageType", this.NewPackageType);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
        }
    }
}

