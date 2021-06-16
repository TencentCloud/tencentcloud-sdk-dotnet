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

    public class TakeMusicOffShelves : AbstractModel
    {
        
        /// <summary>
        /// 资源方对应音乐Id
        /// </summary>
        [JsonProperty("MusicIds")]
        public string MusicIds{ get; set; }

        /// <summary>
        /// 当曲目临时下架时：已订购客户无影响，无需消息通知。当曲目封杀下架后，推送消息至已订购老客户，枚举值，判断是否上/下架
        /// 在售状态，0在售，1临时下架，2永久下架
        /// </summary>
        [JsonProperty("SaleStatus")]
        public string SaleStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MusicIds", this.MusicIds);
            this.SetParamSimple(map, prefix + "SaleStatus", this.SaleStatus);
        }
    }
}

