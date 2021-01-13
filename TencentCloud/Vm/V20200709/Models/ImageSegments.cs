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

namespace TencentCloud.Vm.V20200709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageSegments : AbstractModel
    {
        
        /// <summary>
        /// 截帧时间。
        /// 点播文件：该值为相对于视频偏移时间，单位为秒，例如：0，5，10
        /// 直播流：该值为时间戳，例如：1594650717
        /// </summary>
        [JsonProperty("OffsetTime")]
        public string OffsetTime{ get; set; }

        /// <summary>
        /// 画面截帧结果详情
        /// </summary>
        [JsonProperty("Result")]
        public ImageResult Result{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OffsetTime", this.OffsetTime);
            this.SetParamObj(map, prefix + "Result.", this.Result);
        }
    }
}

