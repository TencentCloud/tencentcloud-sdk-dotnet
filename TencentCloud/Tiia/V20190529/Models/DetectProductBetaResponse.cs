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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectProductBetaResponse : AbstractModel
    {
        
        /// <summary>
        /// 检测到的图片中的商品位置和品类预测。 
        /// 当图片中存在多个商品时，输出多组坐标，按照__显著性__排序（综合考虑面积、是否在中心、检测算法置信度）。 
        /// 最多可以输出__3组__检测结果。
        /// </summary>
        [JsonProperty("RegionDetected")]
        public RegionDetected[] RegionDetected{ get; set; }

        /// <summary>
        /// 图像识别出的商品的详细信息。 
        /// 当图像中检测到多个物品时，会对显著性最高的进行识别。
        /// </summary>
        [JsonProperty("ProductInfo")]
        public ProductInfo ProductInfo{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "RegionDetected.", this.RegionDetected);
            this.SetParamObj(map, prefix + "ProductInfo.", this.ProductInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

