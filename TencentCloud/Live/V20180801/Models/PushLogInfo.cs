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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PushLogInfo : AbstractModel
    {
        
        /// <summary>
        /// 日志名称。
        /// </summary>
        [JsonProperty("LogName")]
        public string LogName{ get; set; }

        /// <summary>
        /// 日志下载地址。
        /// </summary>
        [JsonProperty("LogUrl")]
        public string LogUrl{ get; set; }

        /// <summary>
        /// 日志时间。UTC 格式，例如：2018-11-29T19:00:00Z。
        /// 注意：
        /// 1. 北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("LogTime")]
        public string LogTime{ get; set; }

        /// <summary>
        /// 文件大小，单位字节。
        /// </summary>
        [JsonProperty("FileSize")]
        public long? FileSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogName", this.LogName);
            this.SetParamSimple(map, prefix + "LogUrl", this.LogUrl);
            this.SetParamSimple(map, prefix + "LogTime", this.LogTime);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
        }
    }
}

