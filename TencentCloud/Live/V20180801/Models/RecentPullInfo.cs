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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecentPullInfo : AbstractModel
    {
        
        /// <summary>
        /// 当前正在拉的文件地址。
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// 当前正在拉的文件偏移，单位：秒。
        /// </summary>
        [JsonProperty("OffsetTime")]
        public ulong? OffsetTime{ get; set; }

        /// <summary>
        /// 最新上报偏移信息时间。UTC格式。
        /// 如：2020-07-23T03:20:39Z。
        /// 注意：与北京时间相差八小时。
        /// </summary>
        [JsonProperty("ReportTime")]
        public string ReportTime{ get; set; }

        /// <summary>
        /// 已经轮播的次数。
        /// </summary>
        [JsonProperty("LoopedTimes")]
        public long? LoopedTimes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "OffsetTime", this.OffsetTime);
            this.SetParamSimple(map, prefix + "ReportTime", this.ReportTime);
            this.SetParamSimple(map, prefix + "LoopedTimes", this.LoopedTimes);
        }
    }
}

