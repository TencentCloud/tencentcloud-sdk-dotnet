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

    public class DescribeCameraPersonRequest : AbstractModel
    {
        
        /// <summary>
        /// 优mall集团id，通过"指定身份标识获取客户门店列表"接口获取
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// 优mall店铺id，通过"指定身份标识获取客户门店列表"接口获取
        /// </summary>
        [JsonProperty("ShopId")]
        public long? ShopId{ get; set; }

        /// <summary>
        /// 摄像头id
        /// </summary>
        [JsonProperty("CameraId")]
        public long? CameraId{ get; set; }

        /// <summary>
        /// 拉取开始时间戳，单位秒
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 拉取结束时间戳，单位秒，不超过StartTime+10秒，超过默认为StartTime+10
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// pos机id
        /// </summary>
        [JsonProperty("PosId")]
        public string PosId{ get; set; }

        /// <summary>
        /// 拉取图片数，默认为1，最大为3
        /// </summary>
        [JsonProperty("Num")]
        public long? Num{ get; set; }

        /// <summary>
        /// 是否需要base64的图片，0-不需要，1-需要，默认0
        /// </summary>
        [JsonProperty("IsNeedPic")]
        public long? IsNeedPic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "ShopId", this.ShopId);
            this.SetParamSimple(map, prefix + "CameraId", this.CameraId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "PosId", this.PosId);
            this.SetParamSimple(map, prefix + "Num", this.Num);
            this.SetParamSimple(map, prefix + "IsNeedPic", this.IsNeedPic);
        }
    }
}

