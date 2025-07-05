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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDealsGoods : AbstractModel
    {
        
        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// 商品明细
        /// </summary>
        [JsonProperty("GoodsDetail")]
        public CreateDealsGoodsDetail GoodsDetail{ get; set; }

        /// <summary>
        /// 订单类型ID，用来唯一标识一个业务的一种场景（总共三种场景：新购、配置变更、续费）
        /// 高级版: 102375(新购),102376(续费),102377(变配)
        /// 企业版 : 102378(新购),102379(续费),102380(变配)
        /// 旗舰版 : 102369(新购),102370(续费),102371(变配)
        /// 域名包 : 102372(新购),102373(续费),102374(变配)
        /// 业务扩展包 : 101040(新购),101041(续费),101042(变配)
        /// 
        /// 高级版-CLB: 新购 101198  续费 101199 变配 101200
        /// 企业版-CLB 101204(新购),101205(续费),101206(变配)
        /// 旗舰版-CLB : 101201(新购),101202(续费),101203(变配)
        /// 域名包-CLB: 101207(新购),101208(续费),101209(变配)
        /// 业务扩展包-CLB: 101210(新购),101211(续费),101212(变配)
        /// </summary>
        [JsonProperty("GoodsCategoryId")]
        public long? GoodsCategoryId{ get; set; }

        /// <summary>
        /// 购买waf实例区域ID
        /// 1 表示购买大陆资源;
        /// 9表示购买非中国大陆资源
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamObj(map, prefix + "GoodsDetail.", this.GoodsDetail);
            this.SetParamSimple(map, prefix + "GoodsCategoryId", this.GoodsCategoryId);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
        }
    }
}

