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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PersonTracePoint : AbstractModel
    {
        
        /// <summary>
        /// 卖场区域编码
        /// </summary>
        [JsonProperty("MallAreaId")]
        public ulong? MallAreaId{ get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [JsonProperty("ShopId")]
        public ulong? ShopId{ get; set; }

        /// <summary>
        /// 卖场区域类型
        /// </summary>
        [JsonProperty("MallAreaType")]
        public ulong? MallAreaType{ get; set; }

        /// <summary>
        /// 轨迹事件
        /// </summary>
        [JsonProperty("TraceEventType")]
        public ulong? TraceEventType{ get; set; }

        /// <summary>
        /// 轨迹事件发生时间点
        /// </summary>
        [JsonProperty("TraceEventTime")]
        public string TraceEventTime{ get; set; }

        /// <summary>
        /// 抓拍图片
        /// </summary>
        [JsonProperty("CapPic")]
        public string CapPic{ get; set; }

        /// <summary>
        /// 购物袋类型
        /// </summary>
        [JsonProperty("ShoppingBagType")]
        public ulong? ShoppingBagType{ get; set; }

        /// <summary>
        /// 购物袋数量
        /// </summary>
        [JsonProperty("ShoppingBagCount")]
        public ulong? ShoppingBagCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MallAreaId", this.MallAreaId);
            this.SetParamSimple(map, prefix + "ShopId", this.ShopId);
            this.SetParamSimple(map, prefix + "MallAreaType", this.MallAreaType);
            this.SetParamSimple(map, prefix + "TraceEventType", this.TraceEventType);
            this.SetParamSimple(map, prefix + "TraceEventTime", this.TraceEventTime);
            this.SetParamSimple(map, prefix + "CapPic", this.CapPic);
            this.SetParamSimple(map, prefix + "ShoppingBagType", this.ShoppingBagType);
            this.SetParamSimple(map, prefix + "ShoppingBagCount", this.ShoppingBagCount);
        }
    }
}

