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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReferVideoInfo : AbstractModel
    {
        
        /// <summary>
        /// 视频地址
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// 视频类型
        /// feature为特征参考视频
        /// base为待编辑视频
        /// </summary>
        [JsonProperty("ReferType")]
        public string ReferType{ get; set; }

        /// <summary>
        /// 否保留视频原声，yes为保留，no为不保留；
        /// 当前参数对特征参考视频（feature）也生效。
        /// </summary>
        [JsonProperty("KeepOriginalSound")]
        public string KeepOriginalSound{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "ReferType", this.ReferType);
            this.SetParamSimple(map, prefix + "KeepOriginalSound", this.KeepOriginalSound);
        }
    }
}

