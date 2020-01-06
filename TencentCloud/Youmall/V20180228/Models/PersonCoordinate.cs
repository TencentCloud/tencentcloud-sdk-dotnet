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

    public class PersonCoordinate : AbstractModel
    {
        
        /// <summary>
        /// CAD图X坐标
        /// </summary>
        [JsonProperty("CADX")]
        public float? CADX{ get; set; }

        /// <summary>
        /// CAD图Y坐标
        /// </summary>
        [JsonProperty("CADY")]
        public float? CADY{ get; set; }

        /// <summary>
        /// 抓拍时间点
        /// </summary>
        [JsonProperty("CapTime")]
        public string CapTime{ get; set; }

        /// <summary>
        /// 抓拍图片
        /// </summary>
        [JsonProperty("CapPic")]
        public string CapPic{ get; set; }

        /// <summary>
        /// 卖场区域类型
        /// </summary>
        [JsonProperty("MallAreaType")]
        public long? MallAreaType{ get; set; }

        /// <summary>
        /// 坐标编号
        /// </summary>
        [JsonProperty("PosId")]
        public long? PosId{ get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [JsonProperty("ShopId")]
        public long? ShopId{ get; set; }

        /// <summary>
        /// 事件
        /// </summary>
        [JsonProperty("Event")]
        public string Event{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CADX", this.CADX);
            this.SetParamSimple(map, prefix + "CADY", this.CADY);
            this.SetParamSimple(map, prefix + "CapTime", this.CapTime);
            this.SetParamSimple(map, prefix + "CapPic", this.CapPic);
            this.SetParamSimple(map, prefix + "MallAreaType", this.MallAreaType);
            this.SetParamSimple(map, prefix + "PosId", this.PosId);
            this.SetParamSimple(map, prefix + "ShopId", this.ShopId);
            this.SetParamSimple(map, prefix + "Event", this.Event);
        }
    }
}

