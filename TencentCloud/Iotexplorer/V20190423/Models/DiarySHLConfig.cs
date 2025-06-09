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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiarySHLConfig : AbstractModel
    {
        
        /// <summary>
        /// 每个视频偏移时长，单位秒
        /// </summary>
        [JsonProperty("StartOffset")]
        public ulong? StartOffset{ get; set; }

        /// <summary>
        /// 视频浓缩倍数，支持1,2,4之间
        /// </summary>
        [JsonProperty("PlaySpeed")]
        public ulong? PlaySpeed{ get; set; }

        /// <summary>
        /// 单个视频最小提取时长，单位秒
        /// </summary>
        [JsonProperty("MiniExtract")]
        public ulong? MiniExtract{ get; set; }

        /// <summary>
        /// 每天最终输出视频时长，单位秒
        /// 注：免费版固定10s
        /// </summary>
        [JsonProperty("OutDuration")]
        public ulong? OutDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartOffset", this.StartOffset);
            this.SetParamSimple(map, prefix + "PlaySpeed", this.PlaySpeed);
            this.SetParamSimple(map, prefix + "MiniExtract", this.MiniExtract);
            this.SetParamSimple(map, prefix + "OutDuration", this.OutDuration);
        }
    }
}

