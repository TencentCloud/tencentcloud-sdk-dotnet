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

namespace TencentCloud.Smpn.V20190822.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MHMResponse : AbstractModel
    {
        
        /// <summary>
        /// 标记类型
        ///  0: 无标记
        ///  50:骚扰电话
        ///  51:房产中介
        ///  52:保险理财
        ///  53:广告推销
        ///  54:诈骗电话
        ///  55:快递电话
        ///  56:出租车专车
        /// </summary>
        [JsonProperty("TagType")]
        public long? TagType{ get; set; }

        /// <summary>
        /// 标记次数
        /// </summary>
        [JsonProperty("TagCount")]
        public long? TagCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TagType", this.TagType);
            this.SetParamSimple(map, prefix + "TagCount", this.TagCount);
        }
    }
}

