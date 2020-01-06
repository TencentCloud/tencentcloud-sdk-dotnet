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

    public class DescribeCameraPersonResponse : AbstractModel
    {
        
        /// <summary>
        /// 集团id
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonProperty("ShopId")]
        public long? ShopId{ get; set; }

        /// <summary>
        /// 摄像机id
        /// </summary>
        [JsonProperty("CameraId")]
        public long? CameraId{ get; set; }

        /// <summary>
        /// pos机id
        /// </summary>
        [JsonProperty("PosId")]
        public string PosId{ get; set; }

        /// <summary>
        /// 抓取的顾客信息
        /// </summary>
        [JsonProperty("Infos")]
        public CameraPersonInfo[] Infos{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "ShopId", this.ShopId);
            this.SetParamSimple(map, prefix + "CameraId", this.CameraId);
            this.SetParamSimple(map, prefix + "PosId", this.PosId);
            this.SetParamArrayObj(map, prefix + "Infos.", this.Infos);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

