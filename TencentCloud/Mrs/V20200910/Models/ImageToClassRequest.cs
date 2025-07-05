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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageToClassRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片列表，允许传入多张图片，支持传入图片的base64编码，暂不支持图片url
        /// </summary>
        [JsonProperty("ImageInfoList")]
        public ImageInfo[] ImageInfoList{ get; set; }

        /// <summary>
        /// 图片处理参数
        /// </summary>
        [JsonProperty("HandleParam")]
        public HandleParam HandleParam{ get; set; }

        /// <summary>
        /// 不填，默认为0
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 后付费的用户类型，新客户传1，老客户可不传或传 0。2022 年 12 月 15 新增了计费项，在此时间之前已经通过商务指定优惠价格的大客户，请不传这个字段或传 0，如果传 1 会导致以前获得的折扣价格失效。在 2022 年 12 月 15 日之后，通过商务指定优惠价格的大客户请传 1。
        /// </summary>
        [JsonProperty("UserType")]
        public ulong? UserType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ImageInfoList.", this.ImageInfoList);
            this.SetParamObj(map, prefix + "HandleParam.", this.HandleParam);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
        }
    }
}

