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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaJoiningInfo : AbstractModel
    {
        
        /// <summary>
        /// 输出目标信息，拼接只采用FileName和Format，用于指定目标文件名和格式。
        /// 其中Format只支持mp4.
        /// </summary>
        [JsonProperty("TargetInfo")]
        public MediaTargetInfo TargetInfo{ get; set; }

        /// <summary>
        /// 拼接模式：
        /// Fast：快速；
        /// Normal：正常；
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TargetInfo.", this.TargetInfo);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
        }
    }
}

