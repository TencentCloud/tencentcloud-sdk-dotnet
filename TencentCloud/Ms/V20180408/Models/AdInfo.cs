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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdInfo : AbstractModel
    {
        
        /// <summary>
        /// 插播广告列表
        /// </summary>
        [JsonProperty("Spots")]
        public PluginInfo[] Spots{ get; set; }

        /// <summary>
        /// 精品推荐广告列表
        /// </summary>
        [JsonProperty("BoutiqueRecommands")]
        public PluginInfo[] BoutiqueRecommands{ get; set; }

        /// <summary>
        /// 悬浮窗广告列表
        /// </summary>
        [JsonProperty("FloatWindowses")]
        public PluginInfo[] FloatWindowses{ get; set; }

        /// <summary>
        /// banner广告列表
        /// </summary>
        [JsonProperty("Banners")]
        public PluginInfo[] Banners{ get; set; }

        /// <summary>
        /// 积分墙广告列表
        /// </summary>
        [JsonProperty("IntegralWalls")]
        public PluginInfo[] IntegralWalls{ get; set; }

        /// <summary>
        /// 通知栏广告列表
        /// </summary>
        [JsonProperty("NotifyBars")]
        public PluginInfo[] NotifyBars{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Spots.", this.Spots);
            this.SetParamArrayObj(map, prefix + "BoutiqueRecommands.", this.BoutiqueRecommands);
            this.SetParamArrayObj(map, prefix + "FloatWindowses.", this.FloatWindowses);
            this.SetParamArrayObj(map, prefix + "Banners.", this.Banners);
            this.SetParamArrayObj(map, prefix + "IntegralWalls.", this.IntegralWalls);
            this.SetParamArrayObj(map, prefix + "NotifyBars.", this.NotifyBars);
        }
    }
}

