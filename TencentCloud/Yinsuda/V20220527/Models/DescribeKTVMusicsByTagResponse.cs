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

namespace TencentCloud.Yinsuda.V20220527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeKTVMusicsByTagResponse : AbstractModel
    {
        
        /// <summary>
        /// 歌曲信息列表。
        /// </summary>
        [JsonProperty("KTVMusicInfoSet")]
        public KTVMusicBaseInfo[] KTVMusicInfoSet{ get; set; }

        /// <summary>
        /// 滚动标记，用于设置下次请求的 ScrollToken 参数。
        /// </summary>
        [JsonProperty("ScrollToken")]
        public string ScrollToken{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "KTVMusicInfoSet.", this.KTVMusicInfoSet);
            this.SetParamSimple(map, prefix + "ScrollToken", this.ScrollToken);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

