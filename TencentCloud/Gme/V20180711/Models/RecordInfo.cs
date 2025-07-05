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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户ID（当混流模式时，取值为0）。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 录制文件名。
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 录制开始时间（unix时间戳如：1234567868）。
        /// </summary>
        [JsonProperty("RecordBeginTime")]
        public ulong? RecordBeginTime{ get; set; }

        /// <summary>
        /// 录制状态：2代表正在录制  10代表等待转码  11代表正在转码  12正在上传  13代表上传完成  14代表通知用户完成。
        /// </summary>
        [JsonProperty("RecordStatus")]
        public ulong? RecordStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "RecordBeginTime", this.RecordBeginTime);
            this.SetParamSimple(map, prefix + "RecordStatus", this.RecordStatus);
        }
    }
}

