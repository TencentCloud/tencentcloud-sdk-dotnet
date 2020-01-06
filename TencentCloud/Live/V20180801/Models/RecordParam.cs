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

    public class RecordParam : AbstractModel
    {
        
        /// <summary>
        /// 录制间隔。
        /// 单位秒，默认值1800。
        /// 取值范围:300-7200。
        /// 此参数对 HLS 无效，当录制 HLS 时从推流到断流生成一个文件。
        /// </summary>
        [JsonProperty("RecordInterval")]
        public long? RecordInterval{ get; set; }

        /// <summary>
        /// 录制存储时长。
        /// 单位秒，取值范围： 0-93312000。
        /// 0表示永久存储。
        /// </summary>
        [JsonProperty("StorageTime")]
        public long? StorageTime{ get; set; }

        /// <summary>
        /// 是否开启当前格式录制，0 否 1是。默认值0。
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordInterval", this.RecordInterval);
            this.SetParamSimple(map, prefix + "StorageTime", this.StorageTime);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
        }
    }
}

