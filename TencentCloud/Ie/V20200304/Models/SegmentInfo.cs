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

    public class SegmentInfo : AbstractModel
    {
        
        /// <summary>
        /// 每个切片平均时长，默认10s。
        /// </summary>
        [JsonProperty("FragmentTime")]
        public long? FragmentTime{ get; set; }

        /// <summary>
        /// 切片类型，可选项：hls，不填时默认hls。
        /// </summary>
        [JsonProperty("SegmentType")]
        public string SegmentType{ get; set; }

        /// <summary>
        /// 切片文件名字。注意：
        /// 1.不填切片文件名时，默认按照按照如下格式命名：m3u8文件名{order}。
        /// 2.若填了切片文件名字，则会按照如下格式命名：用户指定文件名{order}。
        /// </summary>
        [JsonProperty("FragmentName")]
        public string FragmentName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FragmentTime", this.FragmentTime);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
            this.SetParamSimple(map, prefix + "FragmentName", this.FragmentName);
        }
    }
}

